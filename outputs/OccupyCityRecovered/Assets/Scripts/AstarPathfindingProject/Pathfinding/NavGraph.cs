using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000DC")]
	public abstract class NavGraph : IGraphInternals
	{
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x10")]
		public AstarPath active;

		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x18")]
		[JsonMember]
		public Pathfinding.Util.Guid guid;

		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x28")]
		[JsonMember]
		public uint initialPenalty;

		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x2C")]
		[JsonMember]
		public bool open;

		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x30")]
		public uint graphIndex;

		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x38")]
		[JsonMember]
		public string name;

		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x40")]
		[JsonMember]
		public bool drawGizmos = true;

		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x41")]
		[JsonMember]
		public bool infoScreenOpen;

		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x48")]
		[JsonMember]
		private string serializedEditorSettings;

		[Token(Token = "0x17000167")]
		internal bool exists
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x452E010", Offset = "0x452A010", VA = "0x452E010")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000168")]
		public abstract bool isScanned
		{
			[Token(Token = "0x600074A")]
			get;
		}

		[Token(Token = "0x17000169")]
		public virtual bool persistent
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x452E070", Offset = "0x452A070", VA = "0x452E070", Slot = "14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700016A")]
		public virtual bool showInInspector
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x452E078", Offset = "0x452A078", VA = "0x452E078", Slot = "15")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700016B")]
		public virtual Bounds bounds
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x452E080", Offset = "0x452A080", VA = "0x452E080", Slot = "16")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700016C")]
string IGraphInternals.SerializedEditorSettings
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x452F37C", Offset = "0x452B37C", VA = "0x452F37C", Slot = "4")]
			get
			{
				return Pathfinding_002EIGraphInternals_002Eget_SerializedEditorSettings();
			}
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x452F384", Offset = "0x452B384", VA = "0x452F384", Slot = "5")]
			set
			{
				Pathfinding_002EIGraphInternals_002Eset_SerializedEditorSettings(value);
			}
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x452E124", Offset = "0x452A124", VA = "0x452E124", Slot = "17")]
		public virtual int CountNodes()
		{
			return default;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x452E248", Offset = "0x452A248", VA = "0x452E248")]
		public void GetNodes(Func<GraphNode, bool> action)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x452E31C", Offset = "0x452A31C", VA = "0x452E31C", Slot = "18")]
		public virtual void GetNodes(Action<GraphNode> action)
		{
		}

		[Token(Token = "0x6000751")]
		public abstract void GetNodes<T>(GraphNode.NodeActionWithData<T> action, ref T data);

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x452E43C", Offset = "0x452A43C", VA = "0x452E43C", Slot = "20")]
		public virtual bool IsPointOnNavmesh(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x452E548", Offset = "0x452A548", VA = "0x452E548", Slot = "21")]
		public virtual bool IsInsideBounds(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x45293BC", Offset = "0x45253BC", VA = "0x45293BC")]
		protected void AssertSafeToUpdateGraph()
		{
 if (!active.IsAnyWorkItemInProgress && !active.isScanning) throw new System.Exception("Trying to update graphs when it is not safe to do so. Graph updates must be done inside a work item or when a graph is being scanned. See AstarPath.AddWorkItem");
}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x452E550", Offset = "0x452A550", VA = "0x452E550")]
		protected void DirtyBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x452E59C", Offset = "0x452A59C", VA = "0x452E59C", Slot = "22")]
		public virtual void RelocateNodes(Matrix4x4 deltaMatrix)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x452E6C0", Offset = "0x452A6C0", VA = "0x452E6C0", Slot = "23")]
		public virtual float NearestNodeDistanceSqrLowerBound(Vector3 position, ref NearestNodeConstraint constraint)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x452E6C8", Offset = "0x452A6C8", VA = "0x452E6C8")]
		public NNInfo GetNearest(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x452E7A4", Offset = "0x452A7A4", VA = "0x452E7A4")]
		[Obsolete("Use the overload that takes a NearestNodeConstraint instead. See the migration guide for version 5.4 for more details.")]
		public NNInfo GetNearest(Vector3 position, NNConstraint constraint)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x452E8D8", Offset = "0x452A8D8", VA = "0x452E8D8")]
		public NNInfo GetNearest(Vector3 position, NearestNodeConstraint constraint)
		{
			return default;
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x452E914", Offset = "0x452A914", VA = "0x452E914", Slot = "24")]
		public virtual NNInfo GetNearest(Vector3 position, ref NearestNodeConstraint constraint)
		{
			return default;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x452EAEC", Offset = "0x452AAEC", VA = "0x452EAEC")]
		[Obsolete("Use GetNearest instead")]
		public NNInfo GetNearestForce(Vector3 position, NNConstraint constraint)
		{
			return default;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x452EB1C", Offset = "0x452AB1C", VA = "0x452EB1C")]
		[Obsolete("Use the overload that takes a NearestNodeConstraint instead. See the migration guide for version 5.4 for more details.")]
		public NNInfo RandomPointOnSurface(NNConstraint nnConstraint, bool highQuality = true)
		{
			return default;
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x452EC2C", Offset = "0x452AC2C", VA = "0x452EC2C")]
		public NNInfo RandomPointOnSurface(bool highQuality = true)
		{
			return default;
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x452ECF4", Offset = "0x452ACF4", VA = "0x452ECF4", Slot = "25")]
		public virtual NNInfo RandomPointOnSurface(NearestNodeConstraint constraint, bool highQuality = true)
		{
			return default;
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x452EEB8", Offset = "0x452AEB8", VA = "0x452EEB8", Slot = "26")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x452EEE8", Offset = "0x452AEE8", VA = "0x452EEE8", Slot = "27")]
		protected virtual void DisposeUnmanagedData()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x452D1B8", Offset = "0x45291B8", VA = "0x452D1B8", Slot = "28")]
		protected virtual void DestroyAllNodes()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x452EEEC", Offset = "0x452AEEC", VA = "0x452EEEC", Slot = "29")]
		public virtual IGraphSnapshot Snapshot(Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x452EEF4", Offset = "0x452AEF4", VA = "0x452EEF4")]
		public void Scan()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x452EF14", Offset = "0x452AF14", VA = "0x452EF14", Slot = "30")]
		protected virtual IGraphUpdatePromise ScanInternal()
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x452EF4C", Offset = "0x452AF4C", VA = "0x452EF4C", Slot = "31")]
		protected virtual IGraphUpdatePromise ScanInternal(bool async)
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x452EF5C", Offset = "0x452AF5C", VA = "0x452EF5C", Slot = "32")]
		protected virtual void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x452EF60", Offset = "0x452AF60", VA = "0x452EF60", Slot = "33")]
		protected virtual void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x452EF64", Offset = "0x452AF64", VA = "0x452EF64", Slot = "34")]
		protected virtual void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x452D548", Offset = "0x4529548", VA = "0x452D548", Slot = "35")]
		public virtual void OnDrawGizmos(DrawingData gizmos, bool drawNodes, RedrawScope redrawScope, bool renderInGame)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x452EF68", Offset = "0x452AF68", VA = "0x452EF68")]
		protected void DrawUnwalkableNodes(DrawingData gizmos, float size, RedrawScope redrawScope, bool renderInGame)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x452F37C", Offset = "0x452B37C", VA = "0x452F37C", Slot = "4")]
		private string Pathfinding_002EIGraphInternals_002Eget_SerializedEditorSettings()
		{
			return null;
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x452F384", Offset = "0x452B384", VA = "0x452F384", Slot = "5")]
		private void Pathfinding_002EIGraphInternals_002Eset_SerializedEditorSettings(string value)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x452F38C", Offset = "0x452B38C", VA = "0x452F38C", Slot = "6")]
void IGraphInternals.OnDestroy()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x452F39C", Offset = "0x452B39C", VA = "0x452F39C", Slot = "7")]
void IGraphInternals.DisposeUnmanagedData()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x452F3AC", Offset = "0x452B3AC", VA = "0x452F3AC", Slot = "8")]
void IGraphInternals.DestroyAllNodes()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x452F3BC", Offset = "0x452B3BC", VA = "0x452F3BC", Slot = "9")]
IGraphUpdatePromise IGraphInternals.ScanInternal(bool async)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x452F3D0", Offset = "0x452B3D0", VA = "0x452F3D0", Slot = "10")]
void IGraphInternals.SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x452F3E0", Offset = "0x452B3E0", VA = "0x452F3E0", Slot = "11")]
void IGraphInternals.DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x452F3F0", Offset = "0x452B3F0", VA = "0x452F3F0", Slot = "12")]
void IGraphInternals.PostDeserialization(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x452D94C", Offset = "0x452994C", VA = "0x452D94C")]
		protected NavGraph()
		{}
	}
}
