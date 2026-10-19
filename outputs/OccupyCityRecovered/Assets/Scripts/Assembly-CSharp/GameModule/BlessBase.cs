using System.Runtime.CompilerServices;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000256")]
	public abstract class BlessBase
	{
		[Token(Token = "0x4001EE6")]
		[FieldOffset(Offset = "0x1C")]
		protected CardFettersType cardFettersType;

		[Token(Token = "0x4001EE7")]
		[FieldOffset(Offset = "0x20")]
		protected AtkWayType atkWayType;

		[Token(Token = "0x170000C2")]
		public string BlessId
		{
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x4383EEC", Offset = "0x437FEEC", VA = "0x4383EEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x4383EF4", Offset = "0x437FEF4", VA = "0x4383EF4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public float Value
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x4383EFC", Offset = "0x437FEFC", VA = "0x4383EFC")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x4383F04", Offset = "0x437FF04", VA = "0x4383F04")]
			[CompilerGenerated]
			protected set;
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x4383F0C", Offset = "0x437FF0C", VA = "0x4383F0C")]
		protected BlessBase(string blessId, float value)
		{
		}

		[Token(Token = "0x6000A3E")]
		public abstract void HandleRoleNumber(RolePropertyTemp propertyTemp);

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x4383F44", Offset = "0x437FF44", VA = "0x4383F44")]
		public void SetType(CardFettersType fettersType, AtkWayType atkType)
		{
		}
	}
}
