using System;
using System.Collections.Generic;
using System.Reflection;
using GameFramework;
using GameFramework.Resources;
namespace GameFramework {
    public enum LogTAG {AssetBundlesDetailed=0x1000000}
    public static class CLog {internal static bool _00AEDzn_00B4E;internal static readonly List<string> Calls=new List<string>();public static void Log(LogTAG tag,params object[] args){Calls.Add(((int)tag)+":"+args[0]);}}
}
internal static class Program {
    static int scenarios,checks,failures;
    static void Check(bool value,string reason){checks++;if(!value)throw new Exception(reason);}
    static void Scenario(string name,Action action){scenarios++;CLog._00AEDzn_00B4E=false;CLog.Calls.Clear();try{action();Console.WriteLine("PASS "+name);}catch(Exception e){failures++;Console.WriteLine("FAIL "+name+": "+e.Message);}}
    static int Main(){
        Scenario("full service record preserves all original manifest and local capabilities",()=>{
            var value=new BundleAssetInfo("firstpack.unity3d","C:/original/local","https://original.invalid/resource",27,true,"cafe","seed",false);
            Check(value.BundleName=="firstpack.unity3d","real bundle name");Check(value.LocalPath=="C:/original/local","real local path");Check(value.RemoteURL=="https://original.invalid/resource","original URL");Check(value.Version==27&&value.IsEncrypAB,"version/encryption");Check(value.ObfuscatorName=="cafe"&&value.Ai_00BFZ_00ABx()=="seed","obfuscation/seed");Check(!value.h_00A1Y_0097_00A1_0093,"explicit non-app capability");
        });
        Scenario("short local record preserves name and path and original empty remote",()=>{
            var value=new BundleAssetInfo("ui/uiroot.prefab.unity3d","Assets/gameres/bundleres/ui/UIRoot.prefab");
            Check(value.BundleName=="ui/uiroot.prefab.unity3d"&&value.LocalPath=="Assets/gameres/bundleres/ui/UIRoot.prefab","local record identity");Check(value.RemoteURL==string.Empty&&value.RemoteURL!=null,"original empty remote");Check(value.Version==0&&!value.IsEncrypAB&&value.h_00A1Y_0097_00A1_0093,"short constructor defaults");Check(value.ObfuscatorName==null&&value.Ai_00BFZ_00ABx()==null,"short optional values remain null");
        });
        Scenario("missing local path does not fabricate an empty bundle name",()=>{
            var value=new BundleAssetInfo("firstpack.unity3d",string.Empty);Check(value.BundleName=="firstpack.unity3d"&&value.LocalPath==string.Empty,"name and availability collapsed");Check(value.h_00A1Y_0097_00A1_0093,"original in-app default");
        });
        Scenario("full constructor preserves null case and signed version without normalization",()=>{
            var value=new BundleAssetInfo(null,null,null,int.MinValue,false,null,null);Check(value.BundleName==null&&value.LocalPath==null&&value.RemoteURL==null,"null normalized");Check(value.Version==int.MinValue&&!value.IsEncrypAB&&value.h_00A1Y_0097_00A1_0093,"signed/default values altered");
            value=new BundleAssetInfo("MiXeD.Prefab.Unity3d","","",int.MaxValue,false,"","");Check(value.BundleName=="MiXeD.Prefab.Unity3d"&&value.Version==int.MaxValue,"unexpected canonicalization/clamp");
        });
        Scenario("original private property bridges update their actual scalar fields",()=>{
            var value=new BundleAssetInfo("bundle","local");var values=new Dictionary<string,object>{{"BundleName","changed"},{"ObfuscatorName","hash"},{"LocalPath","new-local"},{"RemoteURL","new-url"},{"Version",-5}};
            foreach(var pair in values){var property=typeof(BundleAssetInfo).GetProperty(pair.Key);property.GetSetMethod(true).Invoke(value,new[]{pair.Value});Check(Equals(property.GetValue(value),pair.Value),"setter bridge "+pair.Key);}
            Check(value.BundleName=="changed"&&value.LocalPath=="new-local"&&value.RemoteURL=="new-url"&&value.Version==-5&&value.ObfuscatorName=="hash","setter field overlap");
        });
        Scenario("detailed constructor log retains original gate tag and formatted field order",()=>{
            _=new BundleAssetInfo("a","b","c",4,true,"e","f",false);Check(CLog.Calls.Count==0,"log gate ignored");CLog._00AEDzn_00B4E=true;_=new BundleAssetInfo("a","b","c",4,true,"e","f",false);Check(CLog.Calls.Count==1,"original detailed log missing");Check(CLog.Calls[0]=="16777216:CreateBundleAssetInfo:BundleName=[a] LocalPath=[b] RemoteURL=[c] Version=[4]  IsEncrypAB=[True] obfuscatorName[e] randomSeed[f] isInApp[False]","original log format/tag order");
        });
        Console.WriteLine($"RESULT scenarios={scenarios} checks={checks} failures={failures}");return failures==0?0:1;
    }
}
