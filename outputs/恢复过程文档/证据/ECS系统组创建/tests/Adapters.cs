using System;
using System.Collections.Generic;

internal static class EnvironmentModel {
    internal static readonly List<string> Trace = new List<string>();
    internal static int NextId, AllocationFailureId, DisposeFailureId;
    internal static bool CreateFailure, DestroyFailure;
    internal static readonly HashSet<int> Alive = new HashSet<int>();
    internal static void Reset() { Trace.Clear(); Alive.Clear(); NextId=AllocationFailureId=DisposeFailureId=0; CreateFailure=DestroyFailure=false; }
}
namespace Unity.Core { public struct TimeData { public double ElapsedTime; public float DeltaTime; } }
namespace Unity.Collections {
    public enum Allocator { Invalid=0, None=1, Temp=2, TempJob=3, Persistent=4 }
    public struct NativeList<T> where T: unmanaged {
        private int id;
        public NativeList(Allocator allocator) {
            id=++EnvironmentModel.NextId;
            EnvironmentModel.Trace.Add("allocate:"+id+":"+allocator);
            if(id==EnvironmentModel.AllocationFailureId) throw new InvalidOperationException("allocation");
            EnvironmentModel.Alive.Add(id);
        }
        public bool IsCreated => id!=0;
        public void Dispose() {
            EnvironmentModel.Trace.Add("dispose:"+id);
            if(id==EnvironmentModel.DisposeFailureId) throw new InvalidOperationException("dispose");
            EnvironmentModel.Alive.Remove(id); id=0;
        }
    }
}
namespace Unity.Entities {
    public interface IRateManager { bool ShouldGroupUpdate(ComponentSystemGroup group); float Timestep {get;set;} }
    [AttributeUsage(AttributeTargets.Class)] public sealed class UpdateAfterAttribute:Attribute { public UpdateAfterAttribute(Type t) {} }
    public class ComponentSystemGroup {
        private IRateManager manager;
        public bool Created {get;private set;}
        public IRateManager RateManager {get=>manager;set {EnvironmentModel.Trace.Add("assign-manager:"+Created); manager=value;}}
        protected virtual void OnCreate() { EnvironmentModel.Trace.Add("base-create"); if(EnvironmentModel.CreateFailure) throw new InvalidOperationException("base-create"); Created=true; }
        protected virtual void OnDestroy() { EnvironmentModel.Trace.Add("base-destroy"); if(EnvironmentModel.DestroyFailure) throw new InvalidOperationException("base-destroy"); Created=false; }
        protected virtual void OnUpdate() {}
        public void AddSystemToUpdateList(object system) { if(!Created) throw new InvalidOperationException("group-not-created"); }
    }
}
namespace Unity.Transforms { public sealed class TransformSystemGroup {} }
namespace UnityEngine.Scripting { [AttributeUsage(AttributeTargets.Method|AttributeTargets.Constructor)] public sealed class PreserveAttribute:Attribute {} }
