// These adapters model EXTERNAL Unity/resource/codec boundaries only.
// ConfigMgr, ConfigRead, BaseConfig and the 41 original row classes are compiled from their actual sources.
using System.Collections;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public static class BoundaryTrace
{
    public static readonly List<object> Events=new();
    public static readonly List<GameFramework.BaseConfig> Parsed=new();
    public static GameFramework.Resources.ResourcesInfo Provider;
    public static Func<bool> Ready=()=>false;
    public static TaskCompletionSource<YooAsset.AssetOperationHandle> Pending;
    public static bool DelayAsync;
    public static JsonSerializerOptions JsonOptions=new(){IncludeFields=true,PropertyNameCaseInsensitive=false};
    public static void Event(string kind,string name=null,object details=null)=>Events.Add(new{kind,name,ready=Ready(),details});
    public static void Track(object value)
    {
        if(value==null)return;
        if(value is GameFramework.BaseConfig config){Parsed.Add(config);return;}
        if(value is string)return;
        if(value is IEnumerable list){foreach(var item in list)Track(item);return;}
        foreach(var field in value.GetType().GetFields(BindingFlags.Public|BindingFlags.Instance))
            if(!field.FieldType.IsPrimitive && field.FieldType!=typeof(string))Track(field.GetValue(value));
    }
    public static void Clear(){Events.Clear();Parsed.Clear();Pending=null;DelayAsync=false;}
}

namespace Il2CppDummyDll
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple=true)] public class TokenAttribute:Attribute{public string Token;}
    [AttributeUsage(AttributeTargets.All)] public class FieldOffsetAttribute:Attribute{public string Offset;}
    [AttributeUsage(AttributeTargets.All)] public class AddressAttribute:Attribute{public string RVA,Offset,VA,Slot;}
}
namespace Beebyte.Obfuscator{[AttributeUsage(AttributeTargets.All)] public class SkipAttribute:Attribute{}}
namespace MemoryPack
{
    public enum GenerateType{Object}
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Struct)]public class MemoryPackableAttribute:Attribute{public MemoryPackableAttribute(GenerateType type){}}
    [AttributeUsage(AttributeTargets.All)]public class MemoryPackIgnoreAttribute:Attribute{}
    public interface IMemoryPackable<T>{}
    public interface IMemoryPackFormatterRegister{}
    public struct MemoryPackWriter{}
    public struct MemoryPackReader{}
    public abstract class MemoryPackFormatter<T>{public abstract void Serialize(ref MemoryPackWriter writer,ref T value);public abstract void Deserialize(ref MemoryPackReader reader,ref T value);}
    public static class MemoryPackSerializer{public static T Deserialize<T>(byte[] bytes)=>throw new NotSupportedException("MemoryPack boundary is intentionally not implemented by this UnityJson harness");}
}
namespace MemoryPack.Internal{[AttributeUsage(AttributeTargets.All)] public class PreserveAttribute:Attribute{}}
namespace UnityEngine
{
    public class Object{public string name;public static implicit operator bool(Object obj)=>obj is not null;}
    public class TextAsset:Object
    {
        private readonly byte[] raw;
        public TextAsset(string text){raw=Encoding.UTF8.GetBytes(text);}
        public TextAsset(byte[] data){raw=(byte[])data.Clone();}
        public string text=>Encoding.UTF8.GetString(raw).TrimStart('\uFEFF');
        public byte[] bytes=>(byte[])raw.Clone();
    }
    public static class JsonUtility
    {
        public static T FromJson<T>(string json)=>(T)FromJson(json,typeof(T));
        public static object FromJson(string json,Type type)
        {
            BoundaryTrace.Event("json-parse",type.FullName,new{length=json?.Length});
            object result=JsonSerializer.Deserialize(json,type,BoundaryTrace.JsonOptions);
            BoundaryTrace.Track(result);return result;
        }
    }
    public static class Debug{public static void Log(object x)=>BoundaryTrace.Event("log",x?.ToString());public static void LogError(object x)=>BoundaryTrace.Event("log-error",x?.ToString());public static void LogWarning(object x)=>BoundaryTrace.Event("log-warning",x?.ToString());}
    public static class Application{public static string platform="Harness";}
}
namespace YooAsset
{
    public class AssetOperationHandle
    {
        public UnityEngine.Object AssetObject;
        public UnityEngine.Object mainObject=>AssetObject;
        public bool IsDone=true;
        public bool IsValid=>true;
        public Task Task=>System.Threading.Tasks.Task.CompletedTask;
        public event Action<AssetOperationHandle> Completed;
        public void Release()=>BoundaryTrace.Event("handle-release",AssetObject?.name);
        public T GetAssetObject<T>()where T:UnityEngine.Object=>AssetObject as T;
    }
    public class AllAssetsOperationHandle
    {
        public UnityEngine.Object[] AllAssetObjects=Array.Empty<UnityEngine.Object>();
        public bool IsDone=true;
        public void Release()=>BoundaryTrace.Event("all-handle-release");
    }
}
namespace GameFramework.Resources
{
    public class ResourcesInfo
    {
        public readonly Dictionary<string,UnityEngine.TextAsset> Assets=new(StringComparer.Ordinal);
        public readonly HashSet<string> NullAssets=new(StringComparer.Ordinal);
        public string ThrowOnName;
        public T LoadAsset<T>(UnityEngine.Object owner,string name)where T:UnityEngine.Object
        {
            BoundaryTrace.Event("legacy-load",name,new{genericType=typeof(T).Name,ownerIsNull=owner==null});
            return Resolve<T>(name);
        }
        public T Resolve<T>(string name)where T:UnityEngine.Object
        {
            if(name==ThrowOnName)throw new InvalidOperationException("injected resource failure: "+name);
            if(NullAssets.Contains(name))return null;
            return Assets.TryGetValue(name,out var value)?value as T:null;
        }
    }
}
namespace GameFramework
{
    public static class AppSetting
    {
        public static bool UseNewRes,IsUseMemoryPack;
        public const string ConfigBundleDir="Data/Config/";
        public const string NewConfigBundleDir="Data/MemoryBins/";
    }
    public static class CLog
    {
        public static void Log(string message,params object[] args)=>BoundaryTrace.Event("log",message);
        public static void LogError(string message,params object[] args)=>BoundaryTrace.Event("log-error",message);
        public static void LogWarning(string message,params object[] args)=>BoundaryTrace.Event("log-warning",message);
        public static void Error(string message,params object[] args)=>BoundaryTrace.Event("log-error",message);
        public static void Error(params object[] args)=>BoundaryTrace.Event("log-error",string.Join(" ",args));
    }
    public static class NewResLoadHelper
    {
        public static YooAsset.AssetOperationHandle LoadAssetSync<T>(string name)where T:UnityEngine.Object
        {BoundaryTrace.Event("new-load-sync",name);return new(){AssetObject=BoundaryTrace.Provider.Resolve<T>(name)};}
        public static Task<YooAsset.AssetOperationHandle> LoadAssetAsync<T>(string name)where T:UnityEngine.Object
        {
            BoundaryTrace.Event("new-load-async",name);
            if(BoundaryTrace.DelayAsync){BoundaryTrace.Pending=new(TaskCreationOptions.RunContinuationsAsynchronously);return BoundaryTrace.Pending.Task;}
            return Task.FromResult(LoadAssetSync<T>(name));
        }
        public static YooAsset.AssetOperationHandle LoadAsset<T>(string name,Action<YooAsset.AssetOperationHandle> callback=null,params object[] args)where T:UnityEngine.Object
        {var handle=LoadAssetSync<T>(name);callback?.Invoke(handle);return handle;}
    }
}
