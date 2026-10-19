using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000312")]
	public sealed class PropAttrSnapshot
	{
		[Token(Token = "0x400235E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PropAttrSnapshot Empty;

		[Token(Token = "0x400235F")]
		[FieldOffset(Offset = "0x10")]
		private readonly float _soliderAttack;

		[Token(Token = "0x4002360")]
		[FieldOffset(Offset = "0x14")]
		private readonly float _soliderHp;

		[Token(Token = "0x4002361")]
		[FieldOffset(Offset = "0x18")]
		private readonly float _soliderAttackSpeed;

		[Token(Token = "0x4002362")]
		[FieldOffset(Offset = "0x1C")]
		private readonly float _soliderMoveSpeed;

		[Token(Token = "0x4002363")]
		[FieldOffset(Offset = "0x20")]
		private readonly float _buildingHp;

		[Token(Token = "0x4002364")]
		[FieldOffset(Offset = "0x24")]
		private readonly float _buildingSpawnEfficiency;

		[Token(Token = "0x4002365")]
		[FieldOffset(Offset = "0x28")]
		private readonly float _buildingAttack;

		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x3D672F0", Offset = "0x3D632F0", VA = "0x3D672F0")]
		private PropAttrSnapshot()
		{
		}

		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x3D672F8", Offset = "0x3D632F8", VA = "0x3D672F8")]
		private PropAttrSnapshot(float soliderAttack, float soliderHp, float soliderAttackSpeed, float soliderMoveSpeed, float buildingHp, float buildingSpawnEfficiency, float buildingAttack)
		{
		}

		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x3D6735C", Offset = "0x3D6335C", VA = "0x3D6735C")]
		public static PropAttrSnapshot FromDictionary(Dictionary<PropManager.PropAttrType, float> source)
		{
			return null;
		}

		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x3D674E4", Offset = "0x3D634E4", VA = "0x3D674E4")]
		private static float GetFromSource(Dictionary<PropManager.PropAttrType, float> source, PropManager.PropAttrType type)
		{
			return default;
		}

		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x3D67560", Offset = "0x3D63560", VA = "0x3D67560")]
		public float GetPercent(PropManager.PropAttrType type)
		{
			return default;
		}

		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x3D675C4", Offset = "0x3D635C4", VA = "0x3D675C4")]
		public PropAttrSnapshot WithCoefficient(float coefficient)
		{
			return null;
		}
	}
}
