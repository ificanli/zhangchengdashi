using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000116")]
	[Obsolete("This modifier is deprecated")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/advancedsmooth.html")]
	public class AdvancedSmooth : MonoModifier
	{
		[Serializable]
		[Token(Token = "0x2000117")]
		public class MaxTurn : TurnConstructor
		{
			[Token(Token = "0x40005E8")]
			[FieldOffset(Offset = "0x18")]
			private Vector3 preRightCircleCenter;

			[Token(Token = "0x40005E9")]
			[FieldOffset(Offset = "0x24")]
			private Vector3 preLeftCircleCenter;

			[Token(Token = "0x40005EA")]
			[FieldOffset(Offset = "0x30")]
			private Vector3 rightCircleCenter;

			[Token(Token = "0x40005EB")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 leftCircleCenter;

			[Token(Token = "0x40005EC")]
			[FieldOffset(Offset = "0x48")]
			private double vaRight;

			[Token(Token = "0x40005ED")]
			[FieldOffset(Offset = "0x50")]
			private double vaLeft;

			[Token(Token = "0x40005EE")]
			[FieldOffset(Offset = "0x58")]
			private double preVaLeft;

			[Token(Token = "0x40005EF")]
			[FieldOffset(Offset = "0x60")]
			private double preVaRight;

			[Token(Token = "0x40005F0")]
			[FieldOffset(Offset = "0x68")]
			private double gammaLeft;

			[Token(Token = "0x40005F1")]
			[FieldOffset(Offset = "0x70")]
			private double gammaRight;

			[Token(Token = "0x40005F2")]
			[FieldOffset(Offset = "0x78")]
			private double betaRightRight;

			[Token(Token = "0x40005F3")]
			[FieldOffset(Offset = "0x80")]
			private double betaRightLeft;

			[Token(Token = "0x40005F4")]
			[FieldOffset(Offset = "0x88")]
			private double betaLeftRight;

			[Token(Token = "0x40005F5")]
			[FieldOffset(Offset = "0x90")]
			private double betaLeftLeft;

			[Token(Token = "0x40005F6")]
			[FieldOffset(Offset = "0x98")]
			private double deltaRightLeft;

			[Token(Token = "0x40005F7")]
			[FieldOffset(Offset = "0xA0")]
			private double deltaLeftRight;

			[Token(Token = "0x40005F8")]
			[FieldOffset(Offset = "0xA8")]
			private double alfaRightRight;

			[Token(Token = "0x40005F9")]
			[FieldOffset(Offset = "0xB0")]
			private double alfaLeftLeft;

			[Token(Token = "0x40005FA")]
			[FieldOffset(Offset = "0xB8")]
			private double alfaRightLeft;

			[Token(Token = "0x40005FB")]
			[FieldOffset(Offset = "0xC0")]
			private double alfaLeftRight;

			[Token(Token = "0x6000976")]
			[Address(RVA = "0x4550CE0", Offset = "0x454CCE0", VA = "0x4550CE0", Slot = "5")]
			public override void OnTangentUpdate()
			{
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0x4550E24", Offset = "0x454CE24", VA = "0x4550E24", Slot = "4")]
			public override void Prepare(int i, Vector3[] vectorPath)
			{
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0x4550F30", Offset = "0x454CF30", VA = "0x4550F30", Slot = "8")]
			public override void TangentToTangent(List<Turn> turnList)
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0x4551D38", Offset = "0x454DD38", VA = "0x4551D38", Slot = "6")]
			public override void PointToTangent(List<Turn> turnList)
			{
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x45522B4", Offset = "0x454E2B4", VA = "0x45522B4", Slot = "7")]
			public override void TangentToPoint(List<Turn> turnList)
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0x4552718", Offset = "0x454E718", VA = "0x4552718", Slot = "9")]
			public override void GetPath(Turn turn, List<Vector3> output)
			{
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0x4550BC4", Offset = "0x454CBC4", VA = "0x4550BC4")]
			public MaxTurn()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000118")]
		public class ConstantTurn : TurnConstructor
		{
			[Token(Token = "0x40005FC")]
			[FieldOffset(Offset = "0x18")]
			private Vector3 circleCenter;

			[Token(Token = "0x40005FD")]
			[FieldOffset(Offset = "0x28")]
			private double gamma1;

			[Token(Token = "0x40005FE")]
			[FieldOffset(Offset = "0x30")]
			private double gamma2;

			[Token(Token = "0x40005FF")]
			[FieldOffset(Offset = "0x38")]
			private bool clockwise;

			[Token(Token = "0x600097D")]
			[Address(RVA = "0x4552D6C", Offset = "0x454ED6C", VA = "0x4552D6C", Slot = "4")]
			public override void Prepare(int i, Vector3[] vectorPath)
			{
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0x4552D70", Offset = "0x454ED70", VA = "0x4552D70", Slot = "8")]
			public override void TangentToTangent(List<Turn> turnList)
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x4553134", Offset = "0x454F134", VA = "0x4553134", Slot = "9")]
			public override void GetPath(Turn turn, List<Vector3> output)
			{
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x4550C78", Offset = "0x454CC78", VA = "0x4550C78")]
			public ConstantTurn()
			{
			}
		}

		[Token(Token = "0x2000119")]
		public abstract class TurnConstructor
		{
			[Token(Token = "0x4000600")]
			[FieldOffset(Offset = "0x10")]
			public float constantBias;

			[Token(Token = "0x4000601")]
			[FieldOffset(Offset = "0x14")]
			public float factorBias;

			[Token(Token = "0x4000602")]
			[FieldOffset(Offset = "0x0")]
			public static float turningRadius;

			[Token(Token = "0x4000603")]
			public const double ThreeSixtyRadians = Math.PI * 2.0;

			[Token(Token = "0x4000604")]
			[FieldOffset(Offset = "0x4")]
			public static Vector3 prev;

			[Token(Token = "0x4000605")]
			[FieldOffset(Offset = "0x10")]
			public static Vector3 current;

			[Token(Token = "0x4000606")]
			[FieldOffset(Offset = "0x1C")]
			public static Vector3 next;

			[Token(Token = "0x4000607")]
			[FieldOffset(Offset = "0x28")]
			public static Vector3 t1;

			[Token(Token = "0x4000608")]
			[FieldOffset(Offset = "0x34")]
			public static Vector3 t2;

			[Token(Token = "0x4000609")]
			[FieldOffset(Offset = "0x40")]
			public static Vector3 normal;

			[Token(Token = "0x400060A")]
			[FieldOffset(Offset = "0x4C")]
			public static Vector3 prevNormal;

			[Token(Token = "0x400060B")]
			[FieldOffset(Offset = "0x58")]
			public static bool changedPreviousTangent;

			[Token(Token = "0x6000981")]
			public abstract void Prepare(int i, Vector3[] vectorPath);

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x45534B8", Offset = "0x454F4B8", VA = "0x45534B8", Slot = "5")]
			public virtual void OnTangentUpdate()
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x45534BC", Offset = "0x454F4BC", VA = "0x45534BC", Slot = "6")]
			public virtual void PointToTangent(List<Turn> turnList)
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x45534C0", Offset = "0x454F4C0", VA = "0x45534C0", Slot = "7")]
			public virtual void TangentToPoint(List<Turn> turnList)
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x45534C4", Offset = "0x454F4C4", VA = "0x45534C4", Slot = "8")]
			public virtual void TangentToTangent(List<Turn> turnList)
			{
			}

			[Token(Token = "0x6000986")]
			public abstract void GetPath(Turn turn, List<Vector3> output);

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x455049C", Offset = "0x454C49C", VA = "0x455049C")]
			public static void Setup(int i, Vector3[] vectorPath)
			{
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0x4550924", Offset = "0x454C924", VA = "0x4550924")]
			public static void PostPrepare()
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x4552AA0", Offset = "0x454EAA0", VA = "0x4552AA0")]
			public void AddCircleSegment(double startAngle, double endAngle, bool clockwise, Vector3 center, List<Vector3> output, float radius)
			{
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0x45534C8", Offset = "0x454F4C8", VA = "0x45534C8")]
			public void DebugCircleSegment(Vector3 center, double startAngle, double endAngle, double radius, Color color)
			{
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x4553654", Offset = "0x454F654", VA = "0x4553654")]
			public void DebugCircle(Vector3 center, double radius, Color color)
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x4551CA0", Offset = "0x454DCA0", VA = "0x4551CA0")]
			public double GetLengthFromAngle(double angle, double radius)
			{
				return default;
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x4551C18", Offset = "0x454DC18", VA = "0x4551C18")]
			public double ClockwiseAngle(double from, double to)
			{
				return default;
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x4551C5C", Offset = "0x454DC5C", VA = "0x4551C5C")]
			public double CounterClockwiseAngle(double from, double to)
			{
				return default;
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x4551CA8", Offset = "0x454DCA8", VA = "0x4551CA8")]
			public Vector3 AngleToVector(double a)
			{
				return default;
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x45537F4", Offset = "0x454F7F4", VA = "0x45537F4")]
			public double ToDegrees(double rad)
			{
				return default;
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x45537B4", Offset = "0x454F7B4", VA = "0x45537B4")]
			public double ClampAngle(double a)
			{
				return default;
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x4550DC0", Offset = "0x454CDC0", VA = "0x4550DC0")]
			public double Atan2(Vector3 v)
			{
				return default;
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x4552D5C", Offset = "0x454ED5C", VA = "0x4552D5C")]
			protected TurnConstructor()
			{
			}
		}

		[Token(Token = "0x200011A")]
		public struct Turn : IComparable<Turn>
		{
			[Token(Token = "0x400060C")]
			[FieldOffset(Offset = "0x0")]
			public float length;

			[Token(Token = "0x400060D")]
			[FieldOffset(Offset = "0x4")]
			public int id;

			[Token(Token = "0x400060E")]
			[FieldOffset(Offset = "0x8")]
			public TurnConstructor constructor;

			[Token(Token = "0x170001BF")]
			public float score
			{
				[Token(Token = "0x6000995")]
				[Address(RVA = "0x4553854", Offset = "0x454F854", VA = "0x4553854")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x4551D28", Offset = "0x454DD28", VA = "0x4551D28")]
			public Turn(float length, TurnConstructor constructor, int id = 0)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AdvancedSmooth.Turn..ctor RVA=0x4551D28 Token=0x6000996");
}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x4550B00", Offset = "0x454CB00", VA = "0x4550B00")]
			public void GetPath(List<Vector3> output)
			{
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x455387C", Offset = "0x454F87C", VA = "0x455387C", Slot = "4")]
			public int CompareTo(Turn t)
			{
				return default;
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x45538D8", Offset = "0x454F8D8", VA = "0x45538D8")]
			public static bool operator <(Turn lhs, Turn rhs)
			{
				return default;
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x4553918", Offset = "0x454F918", VA = "0x4553918")]
			public static bool operator >(Turn lhs, Turn rhs)
			{
				return default;
			}
		}

		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x30")]
		public float turningRadius;

		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x38")]
		public MaxTurn turnConstruct1;

		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x40")]
		public ConstantTurn turnConstruct2;

		[Token(Token = "0x170001BE")]
		public override int Order
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x455011C", Offset = "0x454C11C", VA = "0x455011C", Slot = "20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x4550124", Offset = "0x454C124", VA = "0x4550124", Slot = "22")]
		public override void Apply(Path p)
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x455097C", Offset = "0x454C97C", VA = "0x455097C")]
		private void EvaluatePaths(List<Turn> turnList, List<Vector3> output)
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x4550B30", Offset = "0x454CB30", VA = "0x4550B30")]
		public AdvancedSmooth()
		{
		}
	}
}
