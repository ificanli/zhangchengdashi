using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000023")]
	public class BoundsField : InspectorField
	{
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3Field inputCenter;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector3Field inputExtents;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x90")]
		private MemberInfo centerVariable;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x98")]
		private MemberInfo extentsVariable;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0xA0")]
		private MemberInfo intCenterVariable;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0xA8")]
		private MemberInfo intSizeVariable;

		[Token(Token = "0x17000060")]
		protected override float HeightMultiplier
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x465C720", Offset = "0x4658720", VA = "0x465C720", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x465C728", Offset = "0x4658728", VA = "0x465C728", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x465C878", Offset = "0x4658878", VA = "0x465C878", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x465C95C", Offset = "0x465895C", VA = "0x465C95C", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x465CAB4", Offset = "0x4658AB4", VA = "0x465CAB4", Slot = "13")]
		protected override void OnInspectorChanged()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x465CAF4", Offset = "0x4658AF4", VA = "0x465CAF4", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x465CB34", Offset = "0x4658B34", VA = "0x465CB34", Slot = "15")]
		protected override void OnDepthChanged()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x465CB7C", Offset = "0x4658B7C", VA = "0x465CB7C", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x465CBC4", Offset = "0x4658BC4", VA = "0x465CBC4")]
		public BoundsField()
		{
		}
	}
}
