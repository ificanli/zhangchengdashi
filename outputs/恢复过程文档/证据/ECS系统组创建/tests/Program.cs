using System;
using System.Reflection;
using Pathfinding.ECS;
using Unity.Entities;

internal sealed class ExposedGroup:AIMovementSystemGroup { public void Create()=>OnCreate(); public void Destroy()=>OnDestroy(); }
internal sealed class OtherRateManager:IRateManager { public bool ShouldGroupUpdate(ComponentSystemGroup group)=>false; public float Timestep {get;set;} }
internal static class Program {
    static int scenarios,checks,failures;
    static void Check(bool value,string reason) {checks++;if(!value)throw new Exception(reason);}
    static void Trace(string expected)=>Check(string.Join(",",EnvironmentModel.Trace)==expected,"trace: "+string.Join(",",EnvironmentModel.Trace));
    static void Throws<T>(Action action,string reason) where T:Exception {try{action();}catch(T){checks++;return;}throw new Exception("missing "+typeof(T).Name+": "+reason);}
    static object Field(object obj,string name)=>obj.GetType().GetField(name,BindingFlags.NonPublic|BindingFlags.Instance).GetValue(obj);
    static void Scenario(string name,Action action) {scenarios++;EnvironmentModel.Reset();try{action();Console.WriteLine("PASS "+name);}catch(Exception e){failures++;Console.WriteLine("FAIL "+name+": "+e.Message);}}
    static int Main() {
        Scenario("original group creation permits ECS registration and releases owned lists",()=>{
            var group=new ExposedGroup();Throws<InvalidOperationException>(()=>group.AddSystemToUpdateList(new object()),"registration before create");
            group.Create();group.AddSystemToUpdateList(new object());Check(group.Created,"base creation not reached");
            Check(group.RateManager is AIMovementSystemGroup.TimeScaledRateManager,"original rate manager missing");
            Check(EnvironmentModel.Alive.Count==2,"two persistent queues not owned");Trace("base-create,allocate:1:Persistent,allocate:2:Persistent,assign-manager:True");
            var manager=(AIMovementSystemGroup.TimeScaledRateManager)group.RateManager;
            Check(manager.CustomTimeScale==1d,"original scale");Check(BitConverter.SingleToInt32Bits((float)Field(manager,"maximumDt"))==1023969417,"original maximum dt bits");
            group.Destroy();Check(!group.Created,"base destroy missing");Check(EnvironmentModel.Alive.Count==0,"persistent queues leaked");
            Trace("base-create,allocate:1:Persistent,allocate:2:Persistent,assign-manager:True,base-destroy,dispose:1,dispose:2");
            Check(ReferenceEquals(group.RateManager,manager),"native retained manager reference");
        });
        Scenario("standalone manager creates distinct persistent queues then disposes both",()=>{
            var manager=new AIMovementSystemGroup.TimeScaledRateManager();Check(EnvironmentModel.Alive.Count==2,"constructor queue allocation");
            Check((int)Field(manager,"numUpdatesThisFrame")==0&&(int)Field(manager,"updateIndex")==0,"zero initialized indices");
            Check((float)Field(manager,"stepDt")==0f&&(double)Field(manager,"lastFullSimulation")==0d,"zero initialized times");
            manager.Dispose();Check(EnvironmentModel.Alive.Count==0,"dispose queue ownership");Trace("allocate:1:Persistent,allocate:2:Persistent,dispose:1,dispose:2");
        });
        Scenario("base create failure does not create or assign rate manager",()=>{
            EnvironmentModel.CreateFailure=true;var group=new ExposedGroup();Throws<InvalidOperationException>(group.Create,"base create failure");Check(group.RateManager==null,"assigned on failed base create");Trace("base-create");
        });
        Scenario("second native allocation failure does not synthesize rollback",()=>{
            EnvironmentModel.AllocationFailureId=2;var group=new ExposedGroup();Throws<InvalidOperationException>(group.Create,"allocation failure");Check(group.Created,"base creation ordering");Check(group.RateManager==null,"incomplete manager assigned");Check(EnvironmentModel.Alive.Count==1,"native has no invented rollback");Trace("base-create,allocate:1:Persistent,allocate:2:Persistent");
        });
        Scenario("base destroy failure stops before rate manager disposal",()=>{
            var group=new ExposedGroup();group.Create();EnvironmentModel.Trace.Clear();EnvironmentModel.DestroyFailure=true;Throws<InvalidOperationException>(group.Destroy,"base destroy failure");Check(EnvironmentModel.Alive.Count==2,"disposed despite failed base destroy");Trace("base-destroy");
        });
        Scenario("null manager produces original null failure after base destroy",()=>{
            var group=new ExposedGroup();group.Create();group.RateManager=null;EnvironmentModel.Trace.Clear();Throws<NullReferenceException>(group.Destroy,"null manager");Check(!group.Created,"base destroy ordering");Trace("base-destroy");
        });
        Scenario("wrong manager type produces original null failure after base destroy",()=>{
            var group=new ExposedGroup();group.Create();group.RateManager=new OtherRateManager();EnvironmentModel.Trace.Clear();Throws<NullReferenceException>(group.Destroy,"wrong manager type");Check(!group.Created,"base destroy ordering");Trace("base-destroy");
        });
        Scenario("first dispose failure stops before second native queue disposal",()=>{
            var manager=new AIMovementSystemGroup.TimeScaledRateManager();EnvironmentModel.Trace.Clear();EnvironmentModel.DisposeFailureId=1;Throws<InvalidOperationException>(manager.Dispose,"first disposal failure");Trace("dispose:1");Check(EnvironmentModel.Alive.Count==2,"unexpected cleanup path");
        });
        Console.WriteLine($"RESULT scenarios={scenarios} checks={checks} failures={failures}");return failures==0?0:1;
    }
}
