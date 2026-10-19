using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
internal static class Rig {
    internal static readonly List<string> Trace=new List<string>();
    internal static readonly List<GameObject> Created=new List<GameObject>();
    internal static int Instances;
    internal static bool ThrowRootCreation,ThrowInstantiation,ThrowCamera;
    internal static Action<string> Boundary;
    internal static void Log(string text){Trace.Add(text);Boundary?.Invoke(text);}
    internal static void Reset(){Trace.Clear();Created.Clear();Instances=0;ThrowRootCreation=ThrowInstantiation=ThrowCamera=false;Boundary=null;AssetsModule.AssetsManager.Instance=new AssetsModule.AssetsManager();DataModule.DataManager.Instance=new DataModule.DataManager();CameraModule.CameraManager.Instance=new CameraModule.CameraManager();}
}
namespace UnityEngine {
    public class Object {
        string ownName;public bool Destroyed;
        public virtual string name {get=>ownName;set=>ownName=value;}
        public static implicit operator bool(Object value)=>!ReferenceEquals(value,null)&&!value.Destroyed;
        public static GameObject Instantiate(GameObject original,Transform parent){Rig.Log("instantiate");if(Rig.ThrowInstantiation)throw new InvalidOperationException("instantiate");Rig.Instances++;var clone=new GameObject(original.name+"(Clone)",original.HasPanel,original.HasCanvas){activeSelf=original.activeSelf};clone.transform.parent=parent;if(clone.Canvas!=null)clone.Canvas.InitialSorting=original.Canvas.InitialSorting;return clone;}
    }
    public class Component:Object {
        public GameObject gameObject;
        public Transform transform=>gameObject.transform;
        public override string name {get=>gameObject.name;set {Rig.Log("panel.name");gameObject.name=value;}}
        public bool TryGetComponent<T>(out T value)where T:class {value=gameObject.GetComponent<T>();return value!=null;}
    }
    public class MonoBehaviour:Component{}
    public class Transform:Component {public Transform parent;}
    public enum RenderMode {ScreenSpaceOverlay=0,ScreenSpaceCamera=1,WorldSpace=2}
    public class Camera:Object{}
    public class Canvas:Component {
        public int InitialSorting=1000;RenderMode mode;Camera camera;
        public RenderMode renderMode {get=>mode;set{Rig.Log("canvas.renderMode");mode=value;}}
        public Camera worldCamera {get=>camera;set{Rig.Log("canvas.worldCamera");camera=value;}}
        public int sortingOrder {get=>InitialSorting;set{Rig.Log("canvas.sortingOrder");InitialSorting=value;}}
    }
    public class GameObject:Object {
        public Transform transform;public bool activeSelf=true;public bool HasPanel,HasCanvas;public UIFramework.UIPanel Panel;public Canvas Canvas;
        public GameObject(string value):this(value,false,false){}
        public GameObject(string value,bool panel,bool canvas){if(value=="UIPanelsRoot"&&Rig.ThrowRootCreation)throw new InvalidOperationException("root");name=value;HasPanel=panel;HasCanvas=canvas;transform=new Transform{gameObject=this};if(panel)Panel=new UIFramework.UIPanel{gameObject=this};if(canvas)Canvas=new Canvas{gameObject=this};Rig.Created.Add(this);}
        public T GetComponent<T>()where T:class {if(typeof(T)==typeof(UIFramework.UIPanel))return Panel as T;if(typeof(T)==typeof(Canvas))return Canvas as T;return null;}
        public void SetActive(bool value){Rig.Log("active:"+value);activeSelf=value;}
    }
    public static class Debug {public static void LogError(object value)=>Rig.Log("error:"+value);}
}
namespace ToolModule {public class ManagerBase<T>:UnityEngine.MonoBehaviour {public virtual Task Init()=>Task.CompletedTask;}}
namespace AssetsModule {
    public sealed class Request {public string Path;public TaskCompletionSource<GameObject> Source=new TaskCompletionSource<GameObject>();}
    public class AssetsManager {
        public static AssetsManager Instance;public readonly List<Request> Requests=new List<Request>();
        public Task<T> LoadAssetAsync<T>(string path)where T:UnityEngine.Object {Rig.Log("typed-load:"+path+":"+typeof(T).Name);var request=new Request{Path=path};Requests.Add(request);return Convert<T>(request.Source.Task);}
        static async Task<T> Convert<T>(Task<GameObject> task)where T:UnityEngine.Object =>(T)(UnityEngine.Object)await task;
    }
}
namespace DataModule {
    public class PanelConfig {public string panelName;public int layer;}
    public class GlobalInfo {public List<PanelConfig> panelConfigs=new List<PanelConfig>();}
    public class DataManager {public static DataManager Instance;public GlobalInfo ActualGlobal=new GlobalInfo();public GlobalInfo GlobalInfo {get{Rig.Log("data.GlobalInfo");return ActualGlobal;}}}
}
namespace CameraModule {
    public class CameraManager {public static CameraManager Instance;public Camera ActualCamera=new Camera{name="original-camera"};public Camera UICamera {get{Rig.Log("camera.UICamera");if(Rig.ThrowCamera)throw new InvalidOperationException("camera");return ActualCamera;}}}
}
