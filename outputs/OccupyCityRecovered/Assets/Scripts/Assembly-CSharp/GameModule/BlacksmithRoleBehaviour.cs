using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000319")]
	public class BlacksmithRoleBehaviour : TerranBehaviour
	{
		[Token(Token = "0x400236D")]
		[FieldOffset(Offset = "0x2D0")]
		private int attackCount;

		[Token(Token = "0x400236E")]
		[FieldOffset(Offset = "0x2D8")]
		private readonly List<RoleBehaviour> skillTargets;

		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x3D68D1C", Offset = "0x3D64D1C", VA = "0x3D68D1C", Slot = "36")]
		protected override void OnAttackSkill(int attackNum)
		{
		}

		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x3D69080", Offset = "0x3D65080", VA = "0x3D69080", Slot = "30")]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x3D69094", Offset = "0x3D65094", VA = "0x3D69094", Slot = "39")]
		protected override void OnRecycle()
		{
		}

		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x3D69114", Offset = "0x3D65114", VA = "0x3D69114")]
		public BlacksmithRoleBehaviour()
		{
		}
	}
}
