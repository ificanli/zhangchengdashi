using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x2000380")]
	public class MineGameLogicModule : GameFrameModule
	{
		[Token(Token = "0x4001B2A")]
		[FieldOffset(Offset = "0x20")]
		private List<IControl> controls;

		[Token(Token = "0x17001124")]
		internal override int Priority
		{
			[Token(Token = "0x6005A66")]
			[Address(RVA = "0x71A5524", Offset = "0x71A1524", VA = "0x71A5524", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005A67")]
		[Address(RVA = "0x71A552C", Offset = "0x71A152C", VA = "0x71A552C", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
		}

		[Token(Token = "0x6005A68")]
		[Address(RVA = "0x71A55CC", Offset = "0x71A15CC", VA = "0x71A55CC")]
		public void RegisterLogicCtr(IControl control, bool autoInit = false)
		{
		}

		[Token(Token = "0x6005A69")]
		[Address(RVA = "0x71A57CC", Offset = "0x71A17CC", VA = "0x71A57CC")]
		public void InitCtrl(bool IsAutoInit = true)
		{
		}

		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0x71A59D0", Offset = "0x71A19D0", VA = "0x71A59D0", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0x71A5B9C", Offset = "0x71A1B9C", VA = "0x71A5B9C", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0x71A5DD0", Offset = "0x71A1DD0", VA = "0x71A5DD0", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0x71A5DD4", Offset = "0x71A1DD4", VA = "0x71A5DD4")]
		public MineGameLogicModule()
		{
		}
	}
}
