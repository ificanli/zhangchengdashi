using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace WG.CollectKit
{
	[Token(Token = "0x2000004")]
	public class SingleCollection : MonoBehaviour
	{
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x50")]
		private float _time;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x54")]
		private float _speed;

		[Token(Token = "0x17000001")]
		public bool IsActive
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x854CE14", Offset = "0x8548E14", VA = "0x854CE14")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x854CE1C", Offset = "0x8548E1C", VA = "0x854CE1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public bool IsCollecting
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x854CE28", Offset = "0x8548E28", VA = "0x854CE28")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x854CE30", Offset = "0x8548E30", VA = "0x854CE30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public bool IsReachedEnd
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x854CE3C", Offset = "0x8548E3C", VA = "0x854CE3C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000004")]
		public Vector3 StartPosition
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x854CE8C", Offset = "0x8548E8C", VA = "0x854CE8C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x854CE98", Offset = "0x8548E98", VA = "0x854CE98")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public Transform EndPointTrans
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x854CEA4", Offset = "0x8548EA4", VA = "0x854CEA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x854CEAC", Offset = "0x8548EAC", VA = "0x854CEAC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Vector3 TempPos
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x854CEB4", Offset = "0x8548EB4", VA = "0x854CEB4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x854CEC0", Offset = "0x8548EC0", VA = "0x854CEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int Value
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x854CECC", Offset = "0x8548ECC", VA = "0x854CECC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x854CED4", Offset = "0x8548ED4", VA = "0x854CED4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public float Duration
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x854CEDC", Offset = "0x8548EDC", VA = "0x854CEDC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x854CEE4", Offset = "0x8548EE4", VA = "0x854CEE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public float Accelerate
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x854CEEC", Offset = "0x8548EEC", VA = "0x854CEEC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x854CEF4", Offset = "0x8548EF4", VA = "0x854CEF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float Progress
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x854CE68", Offset = "0x8548E68", VA = "0x854CE68")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000B")]
		public bool UseObjectPool
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x854CEFC", Offset = "0x8548EFC", VA = "0x854CEFC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x854CF04", Offset = "0x8548F04", VA = "0x854CF04")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x854CF10", Offset = "0x8548F10", VA = "0x854CF10", Slot = "4")]
		public virtual void Active()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x854CF1C", Offset = "0x8548F1C", VA = "0x854CF1C", Slot = "5")]
		public virtual void StartCollect(Vector3 startPosition, Transform endPointTrans, int value, float duration, float accelerate)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x854CFCC", Offset = "0x8548FCC", VA = "0x854CFCC")]
		public void CollectEnd()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x854CFDC", Offset = "0x8548FDC", VA = "0x854CFDC", Slot = "6")]
		public virtual void HideRender()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x854CFE0", Offset = "0x8548FE0", VA = "0x854CFE0", Slot = "7")]
		public virtual void InActive()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x854D084", Offset = "0x8549084", VA = "0x854D084", Slot = "8")]
		public virtual void AddProgress()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x854D0D0", Offset = "0x85490D0", VA = "0x854D0D0")]
		public SingleCollection()
		{
		}
	}
}
