using System;
using System.Collections.Generic;
using UnityEngine;
internal static class Rig {
    internal static readonly List<string> Trace=new List<string>();
    internal static string ThrowSetter;
    internal static void Reset(){Trace.Clear();ThrowSetter=null;GameObject.Tagged=null;GameFramework.GameFrameEntry.Resource=new GameFramework.Resources.ResourcesModule();GameFramework.NewResLoadHelper.Callback=null;GameFramework.NewResLoadHelper.Path=null;GameFramework.AppSetting.UseNewRes=GameFramework.AppSetting.IsPortrait=GameFramework.AppSetting.isHeightCtrWidthFixedWidth=false;}
    internal static void Write(string item){Trace.Add(item);if(ThrowSetter==item)throw new InvalidOperationException(item);}
}
namespace UnityEngine {
    public class Object {
        public string name;public bool Destroyed;
        public static bool operator ==(Object a,Object b)=>ReferenceEquals(a,b)||((ReferenceEquals(a,null)||a.Destroyed)&&(ReferenceEquals(b,null)||b.Destroyed));
        public static bool operator !=(Object a,Object b)=>!(a==b);public override bool Equals(object o)=>ReferenceEquals(this,o);public override int GetHashCode()=>base.GetHashCode();
        public static void DontDestroyOnLoad(Object obj)=>Rig.Trace.Add("persist:"+(obj?.name??"null"));
    }
    public class Component:Object {public GameObject gameObject;public Transform transform=>gameObject.transform;}
    public class Camera:Component{}
    public class Canvas:Component{}
    public class GameObject:Object {
        public static GameObject Tagged;public Transform transform;
        readonly Dictionary<Type,Component> components=new Dictionary<Type,Component>();
        public GameObject(string value,bool rect=false){name=value;transform=rect?new RectTransform():new Transform();transform.gameObject=this;components[transform.GetType()]=transform;}
        public T Add<T>()where T:Component,new(){var value=new T{gameObject=this};components[typeof(T)]=value;return value;}
        public T GetComponent<T>()where T:class {Rig.Trace.Add("get:"+name+":"+typeof(T).Name);return components.TryGetValue(typeof(T),out var value)?value as T:null;}
        public static GameObject FindGameObjectWithTag(string tag){Rig.Trace.Add("find-tag:"+tag);return Tagged;}
    }
    public class Transform:Component {
        public Transform parent;public int FindCalls;
        public readonly Dictionary<string,Transform> Children=new Dictionary<string,Transform>();
        Vector3 scale;
        public Vector3 localScale {get=>scale;set{Rig.Write("scale");scale=value;}}
        public Transform Find(string path){FindCalls++;Rig.Trace.Add("find-child:"+path);return Children.TryGetValue(path,out var result)?result:null;}
        public void SetParent(Transform value){Rig.Write("parent");parent=value;}
    }
    public class RectTransform:Transform {
        public Vector2 sizeDelta;
        Vector2 min,max,offMin,offMax;
        public Vector2 anchorMin {get=>min;set{Rig.Write("anchor-min");min=value;}}
        public Vector2 anchorMax {get=>max;set{Rig.Write("anchor-max");max=value;}}
        public Vector2 offsetMin {get=>offMin;set{Rig.Write("offset-min");offMin=value;}}
        public Vector2 offsetMax {get=>offMax;set{Rig.Write("offset-max");offMax=value;}}
    }
    public struct Vector2 {public float x,y;public Vector2(float a,float b){x=a;y=b;}public static Vector2 zero=>new Vector2(0,0);public static Vector2 one=>new Vector2(1,1);}
    public struct Vector3 {public float x,y,z;public Vector3(float a,float b,float c){x=a;y=b;z=c;}public static Vector3 one=>new Vector3(1,1,1);}
    public sealed class WaitForEndOfFrame{}
    public sealed class WaitForSeconds {public float Seconds;public WaitForSeconds(float value){Seconds=value;}}
    public static class Debug {public static void LogError(object value)=>Rig.Trace.Add("error:"+value);}
}
namespace UnityEngine.UI {public class CanvasScaler:UnityEngine.Component {public float matchWidthOrHeight;}}
namespace YooAsset {
    public interface IResCallBackInfo {GameObject Instantiate(string name,bool value);}
    public class AssetOperationHandle:IResCallBackInfo {public GameObject Root;public GameObject Instantiate(string name,bool value){Rig.Trace.Add("instantiate:"+name+":"+value);return Root;}}
}
namespace GameFramework {
    public class BaseUI{}
    public enum EUIAnim {None}
    public static class CLog {public static void ReleaseLog(params object[] values)=>Rig.Trace.Add("release-log:"+values[0]);public static void Error(params object[] values)=>Rig.Trace.Add("node-error:"+values[0]);}
    public static class AppSetting {public static bool UseNewRes,IsPortrait,isHeightCtrWidthFixedWidth;}
    public static class GameFrameEntry {public static Resources.ResourcesModule Resource;public static T GetModule<T>()where T:class=>Resource as T;}
    public static class NewResLoadHelper {public static string Path;public static Action<YooAsset.AssetOperationHandle> Callback;public static YooAsset.AssetOperationHandle LoadPrefabOri(string path,Action<YooAsset.AssetOperationHandle> callback,params object[] args){Path=path;Callback=callback;Rig.Trace.Add("new-load:"+path);return null;}}
}
namespace GameFramework.Resources {
    public class ResourcesInfo:YooAsset.IResCallBackInfo {public GameObject Root;public bool Throw;public GameObject Instantiate(string name,bool value){Rig.Trace.Add("instantiate:"+name+":"+value);if(Throw)throw new InvalidOperationException("instantiate");return Root;}}
    public class ResLoader{}
    public class ResourcesModule:GameFramework.GameFrameModule {
        public delegate void LoadAssetCompleteHandler(ResourcesInfo info);
        public string Path;public object[] Args;public LoadAssetCompleteHandler Callback;
        public ResLoader LoadPrefab(string path,LoadAssetCompleteHandler callback,object[] args){Rig.Trace.Add("old-load:"+path);Path=path;Args=args;Callback=callback;return null;}
        internal override void Update(float dt,float real)=>Rig.Trace.Add("resource-update:"+dt+":"+real);
        internal override void Initialize(params object[] args){}internal override void Start(){}internal override void Shutdown(){}
    }
}
