using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

[Token(Token = "0x200009C")]
public class HexManager : ManagerBase<HexManager>
{
	[Token(Token = "0x200009D")]
	public struct HexCoord : IEquatable<HexCoord>, IComparable<HexCoord>
	{
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly int q;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public readonly int r;

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x3D28514", Offset = "0x3D24514", VA = "0x3D28514")]
		public HexCoord(int q, int r)
		{
		this.q = q; this.r = r;
	}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x3D2A2C4", Offset = "0x3D262C4", VA = "0x3D2A2C4", Slot = "4")]
		public bool Equals(HexCoord other)
		{
		return q == other.q && r == other.r;
	}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x3D2A8A0", Offset = "0x3D268A0", VA = "0x3D2A8A0", Slot = "2")]
		public override int GetHashCode()
		{
		return unchecked((q << 16) | (r & 0xffff));
	}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x3D2A8B0", Offset = "0x3D268B0", VA = "0x3D2A8B0")]
		public static bool operator ==(HexCoord a, HexCoord b)
		{
		return a.q == b.q && a.r == b.r;
	}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x3D2A8D0", Offset = "0x3D268D0", VA = "0x3D2A8D0")]
		public static bool operator !=(HexCoord a, HexCoord b)
		{
		return a.q != b.q || a.r != b.r;
	}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x3D2A8F0", Offset = "0x3D268F0", VA = "0x3D2A8F0", Slot = "5")]
		public int CompareTo(HexCoord other)
		{
		int result = q.CompareTo(other.q);
		return result != 0 ? result : r.CompareTo(other.r);
	}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct _003CFindNearestWithinDistance_003Ed__14 : IAsyncStateMachine
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder<(GameObject nearestObj, int distance, List<HexCoord> path)> _003C_003Et__builder;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject sourceObj;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IEnumerable<GameObject> targetObjs;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxStraightDistance;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x3D2B090", Offset = "0x3D27090", VA = "0x3D2B090", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x3D2B938", Offset = "0x3D27938", VA = "0x3D2B938", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class _003CGetNeighbors_003Ed__25 : IEnumerable<HexCoord>, IEnumerable, IEnumerator<HexCoord>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private HexCoord _003C_003E2__current;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HexCoord coord;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HexCoord _003C_003E3__coord;

		[Token(Token = "0x17000024")]
HexCoord System.Collections.Generic.IEnumerator<HexManager.HexCoord>.Current
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x3D2BA40", Offset = "0x3D27A40", VA = "0x3D2BA40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CHexManager_002EHexCoord_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000025")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x3D2BA80", Offset = "0x3D27A80", VA = "0x3D2BA80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x3D2A7D4", Offset = "0x3D267D4", VA = "0x3D2A7D4")]
		[DebuggerHidden]
		public _003CGetNeighbors_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x3D2B990", Offset = "0x3D27990", VA = "0x3D2B990", Slot = "7")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x3D2B994", Offset = "0x3D27994", VA = "0x3D2B994", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x3D2BA40", Offset = "0x3D27A40", VA = "0x3D2BA40", Slot = "6")]
		[DebuggerHidden]
		private HexCoord System_002ECollections_002EGeneric_002EIEnumerator_003CHexManager_002EHexCoord_003E_002Eget_Current()
		{
			return default;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x3D2BA48", Offset = "0x3D27A48", VA = "0x3D2BA48", Slot = "10")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x3D2BA80", Offset = "0x3D27A80", VA = "0x3D2BA80", Slot = "9")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x3D2BADC", Offset = "0x3D27ADC", VA = "0x3D2BADC", Slot = "4")]
		[DebuggerHidden]
IEnumerator<HexCoord> System.Collections.Generic.IEnumerable<HexManager.HexCoord>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x3D2BB78", Offset = "0x3D27B78", VA = "0x3D2BB78", Slot = "5")]
		[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class _003CGetWalkableNeighbors_003Ed__21 : IEnumerable<HexCoord>, IEnumerable, IEnumerator<HexCoord>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private HexCoord _003C_003E2__current;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HexBehaviour hex;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HexBehaviour _003C_003E3__hex;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int maxAllowedPriority;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int _003C_003E3__maxAllowedPriority;

		[Token(Token = "0x17000026")]
HexCoord System.Collections.Generic.IEnumerator<HexManager.HexCoord>.Current
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x3D2BE80", Offset = "0x3D27E80", VA = "0x3D2BE80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CHexManager_002EHexCoord_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000027")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x3D2BEC0", Offset = "0x3D27EC0", VA = "0x3D2BEC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x3D2A6A0", Offset = "0x3D266A0", VA = "0x3D2A6A0")]
		[DebuggerHidden]
		public _003CGetWalkableNeighbors_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x3D2BB7C", Offset = "0x3D27B7C", VA = "0x3D2BB7C", Slot = "7")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x3D2BB80", Offset = "0x3D27B80", VA = "0x3D2BB80", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x3D2BE80", Offset = "0x3D27E80", VA = "0x3D2BE80", Slot = "6")]
		[DebuggerHidden]
		private HexCoord System_002ECollections_002EGeneric_002EIEnumerator_003CHexManager_002EHexCoord_003E_002Eget_Current()
		{
			return default;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x3D2BE88", Offset = "0x3D27E88", VA = "0x3D2BE88", Slot = "10")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x3D2BEC0", Offset = "0x3D27EC0", VA = "0x3D2BEC0", Slot = "9")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x3D2BF1C", Offset = "0x3D27F1C", VA = "0x3D2BF1C", Slot = "4")]
		[DebuggerHidden]
IEnumerator<HexCoord> System.Collections.Generic.IEnumerable<HexManager.HexCoord>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x3D2BFC0", Offset = "0x3D27FC0", VA = "0x3D2BFC0", Slot = "5")]
		[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct _003CInit_003Ed__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x3D2BFC4", Offset = "0x3D27FC4", VA = "0x3D2BFC4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x3D2C078", Offset = "0x3D28078", VA = "0x3D2C078", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct _003CPrecomputeAllDistances_003Ed__24 : IAsyncStateMachine
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxDistance;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<HexCoord> _003CallCoords_003E5__2;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _003Ctotal_003E5__3;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _003Ci_003E5__4;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x3D2C084", Offset = "0x3D28084", VA = "0x3D2C084", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x3D2CE7C", Offset = "0x3D28E7C", VA = "0x3D2CE7C", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<HexCoord, HexBehaviour> _hexMap;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static float _hexSize;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static float _sqrt3;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Dictionary<(HexCoord, HexCoord), int> _precomputedDistances;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Dictionary<HexCoord, Dictionary<HexCoord, List<HexCoord>>> _precomputedPaths;

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x3D27EC0", Offset = "0x3D23EC0", VA = "0x3D27EC0", Slot = "4")]
	[AsyncStateMachine(typeof(_003CInit_003Ed__1))]
	public override UniTask Init()
	{
		return UniTask.CompletedTask;
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x3D27F40", Offset = "0x3D23F40", VA = "0x3D27F40")]
	public static void Clear()
	{
		_hexMap = new Dictionary<HexCoord, HexBehaviour>();
		_precomputedDistances?.Clear();
		_precomputedDistances = null;
		_precomputedPaths?.Clear();
		_precomputedPaths = null;
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x3D2806C", Offset = "0x3D2406C", VA = "0x3D2806C")]
	public static void Initialize(IEnumerable<HexBehaviour> hexes, float hexSize)
	{
		_hexSize = (hexSize * 3.4641016f) / 3f;
		_hexMap = new Dictionary<HexCoord, HexBehaviour>();
		foreach (HexBehaviour hex in hexes)
		{
		    HexCoord coord = WorldToHexCoord_FlatTop(hex.transform.position);
		    hex.InitializeHexCoord(coord);
		    _hexMap[coord] = hex;
		}
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x3D279B4", Offset = "0x3D239B4", VA = "0x3D279B4")]
	public static (int, int) GetHexQR(Vector3 worldPos)
	{
		float x = worldPos.x / _hexSize;
		float z = worldPos.z / _hexSize;
		float q = x * 0.6666667f;
		float r = z * 0.57735026f + x * -0.33333334f;
		float s = -q - r;
		int roundedQ = RoundNative(q);
		int roundedR = RoundNative(r);
		int roundedS = RoundNative(s);
		unchecked
		{
		    if (roundedQ + roundedR + roundedS != 0)
		    {
		        float qDifference = Mathf.Abs((float)roundedQ - q);
		        float rDifference = Mathf.Abs((float)roundedR - r);
		        float sDifference = Mathf.Abs((float)roundedS - s);
		        if (qDifference > rDifference && qDifference > sDifference)
		            roundedQ = -(roundedR + roundedS);
		        else if (rDifference > sDifference)
		            roundedR = -(roundedQ + roundedS);
		    }
		}
		return (roundedQ, roundedR);

		int RoundNative(float value)
		{
		    double rounded = Math.Round((double)value, MidpointRounding.ToEven);
		    if (double.IsNaN(rounded)) return 0;
		    if (double.IsPositiveInfinity(rounded)) return int.MinValue;
		    if (rounded >= int.MaxValue) return int.MaxValue;
		    if (rounded <= int.MinValue) return int.MinValue;
		    return (int)rounded;
		}
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x3D27E1C", Offset = "0x3D23E1C", VA = "0x3D27E1C")]
	public static Vector3 GetWorldPositionFromQR(int q, int r)
	{
		return new Vector3((_hexSize * 1.5f) * (float)q, 0f,
		    ((float)q * 0.5f + (float)r) * (_hexSize * 1.7320508f));
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x3D284A0", Offset = "0x3D244A0", VA = "0x3D284A0")]
	public static HexCoord WorldToHexCoord_FlatTop(Vector3 worldPos)
	{
		var qr = GetHexQR(worldPos);
		return new HexCoord(qr.Item1, qr.Item2);
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x3D2851C", Offset = "0x3D2451C", VA = "0x3D2851C")]
	public static bool TryGetHexAt(Vector3 worldPos, out HexBehaviour hex)
	{
		return _hexMap.TryGetValue(WorldToHexCoord_FlatTop(worldPos), out hex);
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x3D285D0", Offset = "0x3D245D0", VA = "0x3D285D0")]
	public static (Dictionary<GameObject, (GameObject, int, List<HexCoord>)>, Dictionary<GameObject, (GameObject, int, List<HexCoord>)>) FindMutualNearest(IEnumerable<GameObject> groupA, IEnumerable<GameObject> groupB, float maxStraightDistance)
	{
		return default;
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x3D2929C", Offset = "0x3D2529C", VA = "0x3D2929C")]
	[AsyncStateMachine(typeof(_003CFindNearestWithinDistance_003Ed__14))]
	public static UniTask<(GameObject, int, List<HexCoord>)> FindNearestWithinDistance(GameObject sourceObj, IEnumerable<GameObject> targetObjs, float maxStraightDistance)
	{
		return default;
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x3D2938C", Offset = "0x3D2538C", VA = "0x3D2938C")]
	public static HexBehaviour GetHexBehaviour(HexCoord coord)
	{
		_hexMap.TryGetValue(coord, out HexBehaviour hex);
		return hex;
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x3D29424", Offset = "0x3D25424", VA = "0x3D29424")]
	public static (int, List<HexCoord>) FindPath(GameObject startObj, GameObject endObj)
	{
		return default;
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x3D2916C", Offset = "0x3D2516C", VA = "0x3D2916C")]
	private static bool TryGetHexCoord(GameObject obj, out HexCoord coord)
	{
		coord = default;
		if (obj == null) return false;
		coord = WorldToHexCoord_FlatTop(obj.transform.position);
		return _hexMap.ContainsKey(coord);
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x3D29560", Offset = "0x3D25560", VA = "0x3D29560")]
	public static (int, List<HexCoord>) FindPath(HexCoord start, HexCoord end)
	{
		return default;
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x3D29B20", Offset = "0x3D25B20", VA = "0x3D29B20")]
	private static (int, List<HexCoord>) AStarSearch(HexCoord start, HexCoord end, int maxAllowedPriority)
	{
		return default;
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x3D2A4F8", Offset = "0x3D264F8", VA = "0x3D2A4F8")]
	private static int CalculateHexCost(HexCoord coord)
	{
		if (!_hexMap.TryGetValue(coord, out HexBehaviour hex)) return 500;
		if (hex.hasArchitecture)
		{
		    if (hex.isEnemyHex)
		    {
		        if (!hex.isDestroy) return 150;
		    }
		    else if (!hex.isDestroy) return 15;
		}
		return 10;
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x3D2A478", Offset = "0x3D26478", VA = "0x3D2A478")]
	[IteratorStateMachine(typeof(_003CGetWalkableNeighbors_003Ed__21))]
	private static IEnumerable<HexCoord> GetWalkableNeighbors(HexBehaviour hex, int maxAllowedPriority)
	{
		return null;
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x3D2A2EC", Offset = "0x3D262EC", VA = "0x3D2A2EC")]
	private static List<HexCoord> ReconstructPath(Dictionary<HexCoord, HexCoord> cameFrom, HexCoord end)
	{
		return null;
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x3D2A600", Offset = "0x3D26600", VA = "0x3D2A600")]
	public static int HexDistance(HexCoord a, HexCoord b)
	{
		// Recovered from ARM64 RVA 0x3D2A600. Preserve the native int32 wrap semantics.
		unchecked
		{
			int dq = a.q - b.q;
			int ds = a.r + a.q - b.q - b.r;
			int dr = a.r - b.r;
			if (dq < 0) dq = -dq;
			if (ds < 0) ds = -ds;
			if (dr < 0) dr = -dr;
			return (dr + dq + ds) / 2;
		}
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x3D2A6D4", Offset = "0x3D266D4", VA = "0x3D2A6D4")]
	[AsyncStateMachine(typeof(_003CPrecomputeAllDistances_003Ed__24))]
	public static UniTask PrecomputeAllDistances(int maxDistance)
	{
		return default;
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x3D2A764", Offset = "0x3D26764", VA = "0x3D2A764")]
	[IteratorStateMachine(typeof(_003CGetNeighbors_003Ed__25))]
	private static IEnumerable<HexCoord> GetNeighbors(HexCoord coord)
	{
		unchecked
		{
		    yield return new HexCoord(coord.q + 1, coord.r);
		    yield return new HexCoord(coord.q - 1, coord.r);
		    yield return new HexCoord(coord.q, coord.r + 1);
		    yield return new HexCoord(coord.q, coord.r - 1);
		    yield return new HexCoord(coord.q + 1, coord.r - 1);
		    yield return new HexCoord(coord.q - 1, coord.r + 1);
		}
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x3D2A808", Offset = "0x3D26808", VA = "0x3D2A808")]
	public HexManager()
	{
	}
}
