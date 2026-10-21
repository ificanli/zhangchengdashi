using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x200019A")]
	internal struct JobDependencyAnalyzer<T> where T : struct
	{
		[Token(Token = "0x200019B")]
		private struct ReflectionData
		{
			[Token(Token = "0x40007D3")]
			[FieldOffset(Offset = "0x0")]
			public int[] fieldOffsets;

			[Token(Token = "0x40007D4")]
			[FieldOffset(Offset = "0x0")]
			public bool[] writes;

			[Token(Token = "0x40007D5")]
			[FieldOffset(Offset = "0x0")]
			public bool[] checkUninitializedRead;

			[Token(Token = "0x40007D6")]
			[FieldOffset(Offset = "0x0")]
			public string[] fieldNames;

			[Token(Token = "0x6000BF9")]
			public void Build()
			{
 var fields=new List<int>(); var writeFlags=new List<bool>(); var readFlags=new List<bool>(); var names=new List<string>();
 Build(typeof(T),fields,writeFlags,readFlags,names,0,false,false,false);
 fieldOffsets=fields.ToArray(); writes=writeFlags.ToArray(); fieldNames=names.ToArray(); checkUninitializedRead=readFlags.ToArray();
}

			[Token(Token = "0x6000BFA")]
			private void Build(Type type, List<int> fields, List<bool> writes, List<bool> reads, List<string> names, int offset, bool forceReadOnly, bool forceWriteOnly, bool forceDisableUninitializedCheck)
			{
 foreach (var field in type.GetFields((System.Reflection.BindingFlags)52)) {
  var fieldType=field.FieldType;
  if (fieldType.IsGenericType && (fieldType.GetGenericTypeDefinition()==typeof(Unity.Collections.NativeArray<>) || fieldType.GetGenericTypeDefinition()==typeof(Pathfinding.Collections.UnsafeSpan<>))) {
   int bufferOffset=fieldType.GetGenericTypeDefinition()==typeof(Unity.Collections.NativeArray<>)?BufferOffset:SpanPtrOffset;
   fields.Add(unchecked(offset+Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetFieldOffset(field)+bufferOffset));
   writes.Add(!forceReadOnly && System.Reflection.CustomAttributeExtensions.GetCustomAttribute<Unity.Collections.ReadOnlyAttribute>(field)==null);
   reads.Add(!forceWriteOnly && !forceDisableUninitializedCheck && System.Reflection.CustomAttributeExtensions.GetCustomAttribute<Unity.Collections.WriteOnlyAttribute>(field)==null && System.Reflection.CustomAttributeExtensions.GetCustomAttribute<DisableUninitializedReadCheckAttribute>(field)==null);
   names.Add(field.Name);
  } else if (!fieldType.IsPrimitive && fieldType.IsValueType && !fieldType.IsEnum) {
   Build(fieldType,fields,writes,reads,names,unchecked(offset+Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetFieldOffset(field)),System.Reflection.CustomAttributeExtensions.GetCustomAttribute<Unity.Collections.ReadOnlyAttribute>(field)!=null,System.Reflection.CustomAttributeExtensions.GetCustomAttribute<Unity.Collections.WriteOnlyAttribute>(field)!=null,System.Reflection.CustomAttributeExtensions.GetCustomAttribute<DisableUninitializedReadCheckAttribute>(field)!=null);
  }
 }
}
		}

		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x0")]
		private static ReflectionData reflectionData;

		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BufferOffset = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetFieldOffset(typeof(Unity.Collections.NativeArray<int>).GetField("m_Buffer",(System.Reflection.BindingFlags)36));

		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int SpanPtrOffset = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetFieldOffset(typeof(Pathfinding.Collections.UnsafeSpan<int>).GetField("ptr",(System.Reflection.BindingFlags)36));

		[Token(Token = "0x6000BF2")]
		private static void initReflectionData()
		{ if (reflectionData.fieldOffsets==null) reflectionData.Build(); }

		[Token(Token = "0x6000BF3")]
		private static bool HasHash(int[] hashes, int hash, int count)
		{
 for (int i=0;i<count;i++) if (hashes[i]==hash) return true;
 return false;
}

		[Token(Token = "0x6000BF4")]
		public static JobHandle GetDependencies(ref T data, JobDependencyTracker tracker)
		{ return GetDependencies(ref data,tracker,default,false); }

		[Token(Token = "0x6000BF5")]
		public static JobHandle GetDependencies(ref T data, JobDependencyTracker tracker, JobHandle additionalDependency)
		{ return GetDependencies(ref data,tracker,additionalDependency,true); }

		[Token(Token = "0x6000BF6")]
		private static JobHandle GetDependencies(ref T data, JobDependencyTracker tracker, JobHandle additionalDependency, bool useAdditionalDependency)
		{
 if (!tracker.dependenciesScratchBuffer.IsCreated) tracker.dependenciesScratchBuffer=new Unity.Collections.NativeArray<JobHandle>(16,Unity.Collections.Allocator.Persistent,Unity.Collections.NativeArrayOptions.UninitializedMemory);
 var scratch=tracker.dependenciesScratchBuffer;
 var slots=tracker.slots;
 var hashes=JobDependencyAnalyzerAssociated.tempJobDependencyHashes;
 initReflectionData();
 int count=0;
 unsafe {
  byte* pointer=(byte*)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf(ref data);
  for (int field=0;field<reflectionData.fieldOffsets.Length;field++) {
   long hash=*(long*)(pointer+reflectionData.fieldOffsets[field]);
   for (int slotIndex=0;slotIndex<=slots.Count;slotIndex++) {
    if (slotIndex==slots.Count) slots.Add(new JobDependencyTracker.NativeArraySlot { hash=hash,lastReads=Pathfinding.Pooling.ListPool<JobDependencyTracker.JobInstance>.Claim(),initialized=true });
    var slot=slots[slotIndex];
    if (slot.hash!=hash) continue;
    if (!slot.initialized && reflectionData.checkUninitializedRead[field]) throw new InvalidOperationException("A job tries to read from the native array "+typeof(T).Name+"."+reflectionData.fieldNames[field]+" which contains uninitialized data");
    if (slot.hasWrite && !HasHash(hashes,slot.lastWrite.hash,count)) {
     scratch[count]=slot.lastWrite.handle;
     hashes[count++]=slot.lastWrite.hash;
     if (count>=scratch.Length) throw new Exception("Too many dependencies for job");
    }
    if (reflectionData.writes[field]) {
     for (int read=0;read<slot.lastReads.Count;read++) {
      if (!HasHash(hashes,slot.lastReads[read].hash,count)) {
       scratch[count]=slot.lastReads[read].handle;
       hashes[count++]=slot.lastReads[read].hash;
       if (count>=scratch.Length) throw new Exception("Too many dependencies for job");
      }
     }
    }
    break;
   }
  }
 }
 if (useAdditionalDependency) scratch[count++]=additionalDependency;
 if (count==0) return default;
 if (count==1) return scratch[0];
 return JobHandle.CombineDependencies(new Unity.Collections.NativeSlice<JobHandle>(scratch,0,count));
}

		[Token(Token = "0x6000BF7")]
		internal static void Scheduled(ref T data, JobDependencyTracker tracker, JobHandle job)
		{
 int hash=JobDependencyAnalyzerAssociated.jobCounter;
 JobDependencyAnalyzerAssociated.jobCounter=unchecked(hash+1);
 unsafe {
  byte* pointer=(byte*)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf(ref data);
  for (int field=0;field<reflectionData.fieldOffsets.Length;field++) {
   long arrayHash=*(long*)(pointer+reflectionData.fieldOffsets[field]);
   if (reflectionData.writes[field]) tracker.JobWritesTo(job,arrayHash,hash);
   else tracker.JobReadsFrom(job,arrayHash,hash);
  }
 }
}
	}
}
