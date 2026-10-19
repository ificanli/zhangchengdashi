using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	[Token(Token = "0x2000024")]
	[AddComponentMenu("Pathfinding/Seeker")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/seeker.html")]
	[DisallowMultipleComponent]
	public class Seeker : VersionedMonoBehaviour
	{
		[Token(Token = "0x2000025")]
		public enum ModifierPass
		{
			[Token(Token = "0x4000135")]
			PreProcess = 0,
			[Token(Token = "0x4000136")]
			PostProcess = 2
		}

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x28")]
		public bool drawGizmos;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x29")]
		public bool detailedGizmos;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x30")]
		public StartEndModifier startEndModifier;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x38")]
		public int traversableTags;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x40")]
		public float[] tagCostMultipliers;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("tagPenalties")]
		public uint[] tagEntryCosts;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x50")]
		public GraphMask graphMask;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x58")]
		public ITraversalProvider traversalProvider;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("graphMask")]
		private int graphMaskCompatibility;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x68")]
		[Obsolete("Pass a callback every time to the StartPath method instead, or use ai.SetPath+ai.pathPending on the movement script. You can cache it in your own script if you want to avoid the GC allocation of creating a new delegate.")]
		public OnPathDelegate pathCallback;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x70")]
		public OnPathDelegate preProcessPath;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x78")]
		public OnPathDelegate postProcessPath;

		[NonSerialized]
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x80")]
		protected Path path;

		[NonSerialized]
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x88")]
		private Path prevPath;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x90")]
		private readonly OnPathDelegate onPathDelegate;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x98")]
		private readonly OnPathDelegate onPartialPathDelegate;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0xA0")]
		private OnPathDelegate tmpPathCallback;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xA8")]
		protected uint lastPathID;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<IPathModifier> modifiers;

		[Token(Token = "0x170000B4")]
		[Obsolete("Use tagEntryCosts or tagCostMultipliers instead", false)]
		public uint[] tagPenalties
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x445B768", Offset = "0x4457768", VA = "0x445B768")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x445B770", Offset = "0x4457770", VA = "0x445B770")]
			set
			{
			}
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x445B778", Offset = "0x4457778", VA = "0x445B778")]
		public Seeker()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x445BA5C", Offset = "0x4457A5C", VA = "0x445BA5C", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x445BA88", Offset = "0x4457A88", VA = "0x445BA88")]
		public Path GetCurrentPath()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x445BA90", Offset = "0x4457A90", VA = "0x445BA90")]
		public void CancelCurrentPathRequest(bool pool = true)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x445BB50", Offset = "0x4457B50", VA = "0x445BB50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x445BB90", Offset = "0x4457B90", VA = "0x445BB90")]
		private void ReleaseClaimedPath()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x445BBBC", Offset = "0x4457BBC", VA = "0x445BBBC")]
		public void RegisterModifier(IPathModifier modifier)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x445BD64", Offset = "0x4457D64", VA = "0x445BD64")]
		public void DeregisterModifier(IPathModifier modifier)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x445BDBC", Offset = "0x4457DBC", VA = "0x445BDBC")]
		private void ForceRegisterModifiers()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x445BEDC", Offset = "0x4457EDC", VA = "0x445BEDC")]
		public void PostProcess(Path path)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x445BEE8", Offset = "0x4457EE8", VA = "0x445BEE8")]
		public void RunModifiers(ModifierPass pass, Path path)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x445BB30", Offset = "0x4457B30", VA = "0x445BB30")]
		public bool IsDone()
		{
			return default;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x445C124", Offset = "0x4458124", VA = "0x445C124")]
		private void OnPathComplete(Path path)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x445C130", Offset = "0x4458130", VA = "0x445C130")]
		private void OnPathComplete(Path p, bool runModifiers, bool sendCallbacks)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x445C26C", Offset = "0x445826C", VA = "0x445C26C")]
		private void OnPartialPathComplete(Path p)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x445C278", Offset = "0x4458278", VA = "0x445C278")]
		private void OnMultiPathComplete(Path p)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x445C284", Offset = "0x4458284", VA = "0x445C284")]
		[Obsolete("Use the overload that takes a callback instead")]
		public Path StartPath(Vector3 start, Vector3 end)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x445C2AC", Offset = "0x44582AC", VA = "0x445C2AC")]
		public Path StartPath(Vector3 start, Vector3 end, OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x445C318", Offset = "0x4458318", VA = "0x445C318")]
		public Path StartPath(Vector3 start, Vector3 end, OnPathDelegate callback, GraphMask graphMask)
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x445C394", Offset = "0x4458394", VA = "0x445C394")]
		public Path StartPath(Path p)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x445C2E0", Offset = "0x44582E0", VA = "0x445C2E0")]
		public Path StartPath(Path p, OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x445C370", Offset = "0x4458370", VA = "0x445C370")]
		public Path StartPath(Path p, OnPathDelegate callback, GraphMask graphMask)
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x445C3AC", Offset = "0x44583AC", VA = "0x445C3AC")]
		private void StartPathInternal(Path p, OnPathDelegate callback)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x445C680", Offset = "0x4458680", VA = "0x445C680")]
		public MultiTargetPath StartMultiTargetPath(Vector3 start, Vector3[] endPoints, bool pathsForAll, OnPathDelegate callback, GraphMask graphMask)
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x445C6EC", Offset = "0x44586EC", VA = "0x445C6EC")]
		public MultiTargetPath StartMultiTargetPath(Vector3 start, Vector3[] endPoints, bool pathsForAll, OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x445C6F8", Offset = "0x44586F8", VA = "0x445C6F8")]
		public MultiTargetPath StartMultiTargetPath(Vector3[] startPoints, Vector3 end, bool pathsForAll, OnPathDelegate callback, GraphMask graphMask)
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x445C764", Offset = "0x4458764", VA = "0x445C764")]
		public MultiTargetPath StartMultiTargetPath(Vector3[] startPoints, Vector3 end, bool pathsForAll, OnPathDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x445C770", Offset = "0x4458770", VA = "0x445C770", Slot = "14")]
		protected override void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}
	}
}
