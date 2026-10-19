using System.Collections;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.Json;
using GameFramework;
using GameFramework.Resources;
using ljzs_lt;
using UnityEngine;

public record Expected(string type,string shape,string field,string path,string sha256,int? count,string key);

public static class Program
{
    static List<object> checks=new();
    static List<object> boundaries=new();
    static List<Expected> expected;
    static int fieldsCompared,rowsCompared,identitiesCompared;
    static string mode;
    static void Check(bool condition,string name,object details=null)
    {
        checks.Add(new{name,passed=condition,details});
        if(!condition)throw new InvalidOperationException("check failed: "+name);
    }
    static int Counter()=> (int)typeof(ConfigRead).GetField("n_00B9XZd_009C",BindingFlags.NonPublic|BindingFlags.Static).GetValue(null);
    static void SetCounter(int n)=>typeof(ConfigRead).GetField("n_00B9XZd_009C",BindingFlags.NonPublic|BindingFlags.Static).SetValue(null,n);
    static ResourcesInfo Provider()
    {
        var provider=new ResourcesInfo();
        foreach(var e in expected)
        {
            byte[] raw=File.ReadAllBytes(e.path);
            Check(Convert.ToHexStringLower(SHA256.HashData(raw))==e.sha256,"payload-sha:"+e.type);
            provider.Assets[e.type]=new TextAsset(raw){name=e.type};
        }
        BoundaryTrace.Provider=provider;
        ConfigRead.configRes=provider;
        ConfigRead.isUseNewRes=false;
        AppSetting.UseNewRes=false;
        return provider;
    }
    static object InvokeGeneric(string name,Type type,params object[] args)
    {
        var method=typeof(ConfigRead).GetMethods(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Static).Single(m=>m.Name==name && m.IsGenericMethodDefinition && m.GetParameters().Length==args.Length);
        try{return method.MakeGenericMethod(type).Invoke(null,args);}
        catch(TargetInvocationException e){throw e.InnerException;}
    }
    static void Compare(JsonElement expectedValue,object value,string label)
    {
        fieldsCompared++;
        switch(expectedValue.ValueKind)
        {
            case JsonValueKind.Number:
                double number=Convert.ToDouble(value);
                double wanted=expectedValue.GetDouble();
                if(Math.Abs(number-wanted)>Math.Max(1,Math.Abs(wanted))*1e-6)throw new Exception(label+" numeric mismatch");
                break;
            case JsonValueKind.Array:
                var arr=(IList)value;
                if(arr.Count!=expectedValue.GetArrayLength())throw new Exception(label+" array count mismatch");
                int i=0;foreach(var item in expectedValue.EnumerateArray())Compare(item,arr[i++],label+"[]");
                break;
            case JsonValueKind.String:if((string)value!=expectedValue.GetString())throw new Exception(label+" string mismatch");break;
            case JsonValueKind.Null:if(value!=null)throw new Exception(label+" null mismatch");break;
            default:throw new Exception(label+" unsupported expected kind "+expectedValue.ValueKind);
        }
    }
    static void CompareRow(JsonElement json,object row,string label)
    {
        foreach(var prop in json.EnumerateObject())
        {
            var field=row.GetType().GetField(prop.Name,BindingFlags.Public|BindingFlags.Instance);
            if(field==null)throw new Exception(label+" field missing: "+prop.Name);
            Compare(prop.Value,field.GetValue(row),label+"."+prop.Name);
        }
        if(!BoundaryTrace.Parsed.Any(p=>ReferenceEquals(p,row)))throw new Exception(label+" identity detached from parser output");
        identitiesCompared++;
    }
    static void VerifyLoaded(ConfigMgr mgr)
    {
        foreach(var e in expected)
        {
            var json=JsonDocument.Parse(File.ReadAllText(e.path).TrimStart('\uFEFF')).RootElement;
            object data=typeof(ConfigMgr).GetField(e.field).GetValue(mgr);
            if(e.shape=="Datas-table")
            {
                IDictionary dict=(IDictionary)data;
                Check(dict.Count==e.count,"table-count:"+e.type,new{actual=dict.Count,wanted=e.count});
                foreach(var row in json.GetProperty("Datas").EnumerateArray())
                {
                    int id=row.GetProperty(e.key).GetInt32();
                    if(!dict.Contains(id))throw new Exception(e.type+" boxed Int32 primary key missing "+id);
                    CompareRow(row,dict[id],e.type+"["+id+"]");rowsCompared++;
                }
            }
            else
            {
                Check(data!=null,"object-present:"+e.type);
                CompareRow(json,data,e.type);
            }
        }
        Check(rowsCompared==927,"all-real-table-rows",rowsCompared);
        Check(identitiesCompared==930,"all-parser-object-identities",identitiesCompared);
        Check(mgr.dicPoolConfigByPoolId.Count==9,"pool-group-count");
        int grouped=0;
        foreach(var pair in mgr.dicPoolConfigByPoolId)
        {
            foreach(var row in pair.Value)
            {
                Check(row.pool_id==pair.Key && ReferenceEquals(row,mgr.dicPoolConfig[row.id]),"pool-row-identity:"+row.id);
                grouped++;
            }
        }
        Check(grouped==51,"pool-all-51-references");
    }
    static void FullLoad()
    {
        BoundaryTrace.Clear();var provider=Provider();
        Check(ConfigRead.configAssetbundle=="Data/Config","original-cctor-config-bundle-default");
        var mgr=ConfigMgr.Instance;
        Check(mgr!=null,"singleton-created");
        Check(ReferenceEquals(mgr,ConfigMgr.Instance),"singleton-identity");
        BoundaryTrace.Ready=()=>mgr.IsInitialize;
        mgr.SetConfigABRes(provider);
        Check(ReferenceEquals(ConfigRead.configRes,provider),"SetConfigABRes-original-identity");
        Check(!mgr.IsInitialize,"ready-initial-false");
        Exception failure=null;
        try{mgr.Initialize();}catch(Exception e){failure=e;}
        if(mode=="stub-getters")
        {
            Check(failure is ArgumentNullException,"current-getter-null-key-blocks-original-data",failure?.ToString());
            Check(!mgr.IsInitialize,"ready-not-faked-after-getter-failure");
            Check(mgr.dicGoalReward.Count==0,"failed-first-table-remains-empty");
            Check(Counter()==0,"failed-parser-did-not-increment-read-count");
            boundaries.Add(new{scenario="candidate-current-row-getters",exception=failure.GetType().Name,readCount=Counter(),ready=mgr.IsInitialize,events=BoundaryTrace.Events.ToArray()});
            return;
        }
        if(failure!=null)throw failure;
        Check(mgr.IsInitialize,"ready-after-read-and-custom-group");
        Check(ConfigRead.IsUserJsonUtility && !AppSetting.IsUseMemoryPack,"initialize-json-flags");
        Check(Counter()==38,"table-read-completion-count-excludes-three-objects",Counter());
        var eventJson=JsonSerializer.SerializeToElement(BoundaryTrace.Events);
        var loads=eventJson.EnumerateArray().Where(e=>e.GetProperty("kind").GetString()=="legacy-load").ToArray();
        Check(loads.Length==41,"all-41-real-resource-reads",loads.Length);
        Check(loads.All(e=>!e.GetProperty("ready").GetBoolean()),"all-resource-reads-before-ready");
        Check(loads.All(e=>e.GetProperty("details").GetProperty("ownerIsNull").GetBoolean()),"legacy-loader-owner-always-null");
        VerifyLoaded(mgr);
        int before=BoundaryTrace.Events.Count;
        mgr.Initialize();
        Check(BoundaryTrace.Events.Count==before,"initialize-idempotent-no-rereads");
        boundaries.Add(new{scenario="full-real-load",reads=loads.Select(e=>e.GetProperty("name").GetString()).ToArray(),events=BoundaryTrace.Events.ToArray(),parsedIdentities=identitiesCompared});
    }
    static object Boundary(string scenario,string text,bool missing=false,bool nullSource=false,bool injectLoadFailure=false)
    {
        BoundaryTrace.Clear();var provider=Provider();SetCounter(0);
        var prior=new GoalRewardConfig{id=700001,count=777};
        var source=new Dictionary<object,GoalRewardConfig>{{700001,prior}};
        if(missing)provider.NullAssets.Add(nameof(GoalRewardConfig));
        else provider.Assets[nameof(GoalRewardConfig)]=new TextAsset(text??""){name=nameof(GoalRewardConfig)};
        if(injectLoadFailure)provider.ThrowOnName=nameof(GoalRewardConfig);
        Exception failure=null;
        try{ConfigRead.readConfigByUnityJson<GoalRewardConfig>(nullSource?null:source);}catch(Exception e){failure=e;}
        int count=Counter();
        var observation=new{scenario,exception=failure?.GetType().Name,count=source.Count,readCount=count,priorIdentityPreserved=ReferenceEquals(source[700001],prior),keys=source.Keys.ToArray(),rows=source.Values.Select(r=>new{r.id,r.count}).ToArray(),events=BoundaryTrace.Events.ToArray()};
        boundaries.Add(observation);
        return new BoundaryResult(source,failure,count,prior);
    }
    record BoundaryResult(Dictionary<object,GoalRewardConfig> source,Exception exception,int readCount,GoalRewardConfig prior);
    static void EdgeCases()
    {
        var empty=(BoundaryResult)Boundary("empty-Datas","{\"Datas\":[]}");
        Check(empty.exception==null && empty.source.Count==1 && empty.readCount==1,"empty-Datas-preserves-source-and-completes");
        var nul=(BoundaryResult)Boundary("null-Datas","{\"Datas\":null}");
        Check(nul.exception==null && nul.source.Count==1 && nul.readCount==1,"null-Datas-preserves-source-and-completes");
        var dup=(BoundaryResult)Boundary("duplicate-new-key","{\"Datas\":[{\"id\":1,\"count\":2},{\"id\":1,\"count\":999}]}");
        Check(dup.exception==null && dup.source.Count==2 && dup.source[1].count==2 && dup.readCount==1,"duplicate-key-logs-and-preserves-first-row");
        var existing=(BoundaryResult)Boundary("duplicate-existing-key","{\"Datas\":[{\"id\":700001,\"count\":999}]}");
        Check(existing.exception==null && existing.source.Count==1 && ReferenceEquals(existing.source[700001],existing.prior),"existing-dictionary-row-not-overwritten");
        var malformed=(BoundaryResult)Boundary("malformed-json","{broken}");
        Check(malformed.exception is JsonException && malformed.source.Count==1 && malformed.readCount==0,"parse-exception-preserves-source-counter");
        var missing=(BoundaryResult)Boundary("missing-TextAsset",null,true);
        Check(missing.exception==null && missing.source.Count==1 && missing.readCount==1,"missing-asset-logs-and-increments-count");
        var blank=(BoundaryResult)Boundary("no-opening-brace","prefix without JSON");
        Check(blank.exception is ArgumentOutOfRangeException && blank.readCount==0,"no-brace-preserves-Substring-failure");
        var prefix=(BoundaryResult)Boundary("prefix-before-opening-brace","prefix\uFEFF\r\n{\"Datas\":[{\"id\":4,\"count\":5}]}");
        Check(prefix.exception==null && prefix.source[4].count==5 && prefix.readCount==1,"native-prefix-trim-to-first-brace");
        var nullRow=(BoundaryResult)Boundary("null-row","{\"Datas\":[null]}");
        Check(nullRow.exception is NullReferenceException && nullRow.readCount==0,"null-row-keeps-native-failure");
        var nullDict=(BoundaryResult)Boundary("null-source-nonempty","{\"Datas\":[{\"id\":4}]}",nullSource:true);
        Check(nullDict.exception is NullReferenceException && nullDict.readCount==0,"null-source-nonempty-keeps-native-failure");
        var nullDictEmpty=(BoundaryResult)Boundary("null-source-empty","{\"Datas\":[]}",nullSource:true);
        Check(nullDictEmpty.exception==null && nullDictEmpty.readCount==1,"null-source-empty-completes-without-dereference");
        var resource=(BoundaryResult)Boundary("resource-exception",null,injectLoadFailure:true);
        Check(resource.exception is InvalidOperationException && resource.readCount==0,"resource-exception-propagates-before-count");
        ObjectAndResolverCases();
        GroupAndFailureCases();
    }
    sealed class Probe:BaseConfig{}
    static void ObjectAndResolverCases()
    {
        BoundaryTrace.Clear();var provider=Provider();SetCounter(0);
        provider.NullAssets.Add(nameof(SettingConfig));
        Check(ConfigRead.readConfigVByUnityJson<SettingConfig>()==null && Counter()==0,"missing-object-returns-null-without-table-count");
        provider.NullAssets.Clear();provider.Assets[nameof(SettingConfig)]=new TextAsset("not json");
        Exception malformed=null;try{ConfigRead.readConfigVByUnityJson<SettingConfig>();}catch(Exception e){malformed=e;}
        Check(malformed is ArgumentOutOfRangeException && Counter()==0,"object-no-brace-propagates-before-table-count");
        Exception baseGetter=null;try{_ = new Probe().UniqueID;}catch(Exception e){baseGetter=e;}
        Check(baseGetter is NotImplementedException,"original-base-UniqueID-throws");
        BoundaryTrace.Clear();provider=Provider();SetCounter(0);
        ConfigRead.configRes=null;ConfigRead.isUseNewRes=true;AppSetting.UseNewRes=true;
        var source=new Dictionary<object,GoalRewardConfig>();
        ConfigRead.readConfigByUnityJson(source);
        var events=JsonSerializer.SerializeToElement(BoundaryTrace.Events).EnumerateArray().ToArray();
        Check(source.Count==17 && Counter()==1,"new-res-sync-restored-parse");
        Check(events.Select(e=>e.GetProperty("kind").GetString()).SequenceEqual(new[]{"new-load-sync","handle-release","json-parse"}),"new-res-release-before-json-parse");
        boundaries.Add(new{scenario="new-res-sync-resolver",events=BoundaryTrace.Events.ToArray()});
        BoundaryTrace.Clear();provider=Provider();SetCounter(0);
        ConfigRead.isUseNewRes=true;
        var webFlag=typeof(ConfigRead).GetField("_0092_0096uWU_008B",BindingFlags.NonPublic|BindingFlags.Static);
        webFlag.SetValue(null,true);
        ConfigRead.newResLoadForWebgl=new(){{nameof(GoalRewardConfig),provider.Assets[nameof(GoalRewardConfig)]}};
        source=new();ConfigRead.readConfigByUnityJson(source);
        Check(source.Count==17 && Counter()==1,"webgl-map-original-textasset-parse");
        ConfigRead.newResLoadForWebgl=new(){{nameof(GoalRewardConfig),new UnityEngine.Object()}};
        source=new();ConfigRead.readConfigByUnityJson(source);
        Check(source.Count==0 && Counter()==2,"webgl-wrong-object-as-cast-null-keeps-completion");
        ConfigRead.newResLoadForWebgl=null;
        source=new();ConfigRead.readConfigByUnityJson(source);
        Check(source.Count==0 && Counter()==3,"webgl-null-map-logs-and-returns-null");
        boundaries.Add(new{scenario="webgl-map-boundaries",events=BoundaryTrace.Events.ToArray()});
        webFlag.SetValue(null,false);ConfigRead.isUseNewRes=false;ConfigRead.configRes=null;AppSetting.UseNewRes=false;SetCounter(0);
        Exception absentProvider=null;try{ConfigRead.readConfigByUnityJson(new Dictionary<object,GoalRewardConfig>());}catch(Exception e){absentProvider=e;}
        Check(absentProvider is NullReferenceException && Counter()==0,"legacy-null-provider-logs-then-throws");
    }
    static void GroupAndFailureCases()
    {
        var groupMgr=new ConfigMgr();
        var a=new PoolConfigConfig{id=10,pool_id=2001};var b=new PoolConfigConfig{id=11,pool_id=2001};
        groupMgr.dicPoolConfig.Add(1,a);groupMgr.dicPoolConfig.Add(2,null);groupMgr.dicPoolConfig.Add(3,new(){id=12,pool_id=0});groupMgr.dicPoolConfig.Add(4,b);groupMgr.dicPoolConfig.Add(5,new(){id=13,pool_id=-1});
        groupMgr.dicPoolConfigByPoolId[999]=new(){new(){id=999,pool_id=999}};
        typeof(ConfigMgr).GetMethod("customRead",BindingFlags.Instance|BindingFlags.NonPublic).Invoke(groupMgr,null);
        Check(groupMgr.dicPoolConfigByPoolId.Count==1 && groupMgr.dicPoolConfigByPoolId[2001].Count==2,"custom-group-clears-stale-skips-null-and-nonpositive");
        Check(ReferenceEquals(groupMgr.dicPoolConfigByPoolId[2001][0],a) && ReferenceEquals(groupMgr.dicPoolConfigByPoolId[2001][1],b),"custom-group-preserves-row-identity-and-order");
        BoundaryTrace.Clear();var provider=Provider();SetCounter(0);provider.ThrowOnName=nameof(BuildConfigConfig);
        var failing=new ConfigMgr();BoundaryTrace.Ready=()=>failing.IsInitialize;failing.SetConfigABRes(provider);
        Exception failure=null;try{failing.Initialize();}catch(Exception e){failure=e;}
        Check(failure is InvalidOperationException && !failing.IsInitialize && Counter()==6,"mid-initialize-failure-ready-false-count-six");
        Check(failing.dicGoalReward.Count==17 && failing.dicDiceConfig.Count==6 && failing.dicBuildConfig.Count==0 && failing.dicPoolConfigByPoolId.Count==0,"mid-initialize-preserves-earlier-table-values-no-custom-group");
        boundaries.Add(new{scenario="mid-initialize-resource-failure",exception=failure?.GetType().Name,readCount=Counter(),ready=failing.IsInitialize,events=BoundaryTrace.Events.ToArray()});
    }
    static void Baseline()
    {
        BoundaryTrace.Clear();Provider();
        Check(ConfigMgr.Instance==null,"source-before-singleton-null-negative-control");
        var source=new Dictionary<object,GoalRewardConfig>();
        ConfigRead.readConfigByUnityJson(source);
        Check(source.Count==0 && BoundaryTrace.Events.Count==0,"source-before-reader-noop-negative-control");
        Check(ConfigRead.readConfigVByUnityJson<SettingConfig>()==null,"source-before-object-null-negative-control");
        var mgr=new ConfigMgr();mgr.Initialize();
        Check(!mgr.IsInitialize && mgr.dicGoalReward==null,"source-before-init-empty-negative-control");
    }
    public static int Main(string[] args)
    {
        mode=args[0];expected=JsonSerializer.Deserialize<List<Expected>>(File.ReadAllText(args[1]));
        Exception failure=null;
        try{if(mode=="baseline")Baseline();else{FullLoad();if(mode=="restored-getters")EdgeCases();}}
        catch(Exception e){failure=e;}
        var report=new{mode,passed=failure==null,limitation="Original final production ConfigMgr/ConfigRead/BaseConfig plus actual38 before/candidate/production row source files. Only external resource/TextAsset/JsonUtility adapters are controlled. JSON is System.Text.Json, not Unity JsonUtility or Editor acceptance. No fixture getter business replacement is generated.",failure=failure?.ToString(),rowsCompared,fieldsCompared,identitiesCompared,checks,boundaries};
        File.WriteAllText(args[2],JsonSerializer.Serialize(report,new JsonSerializerOptions{WriteIndented=true}));
        Console.WriteLine(JsonSerializer.Serialize(new{mode,passed=failure==null,checks=checks.Count,rowsCompared,fieldsCompared,identitiesCompared,failure=failure?.ToString()}));
        return failure==null?0:1;
    }
}
