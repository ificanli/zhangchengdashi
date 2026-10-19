using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x200098A")]
	public class MaskPanel : MaskPanelComponents
	{
		[Token(Token = "0x4004772")]
		[FieldOffset(Offset = "0x48")]
		private float MaxShowTime;

		[Token(Token = "0x4004773")]
		[FieldOffset(Offset = "0x4C")]
		private float currentShowTime;

		[Token(Token = "0x4004774")]
		[FieldOffset(Offset = "0x50")]
		private string currentKey;

		[Token(Token = "0x6003870")]
		[Address(RVA = "0x40F5870", Offset = "0x40F1870", VA = "0x40F5870", Slot = "10")]
		public override void InvokeMethod(string methodName, params object[] args)
		{
		}

		[Token(Token = "0x6003871")]
		[Address(RVA = "0x40F5A38", Offset = "0x40F1A38", VA = "0x40F5A38")]
		private void Update()
		{
		}

		[Token(Token = "0x6003872")]
		[Address(RVA = "0x40F5AE8", Offset = "0x40F1AE8", VA = "0x40F5AE8", Slot = "5")]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003873")]
		[Address(RVA = "0x40F5BFC", Offset = "0x40F1BFC", VA = "0x40F5BFC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003874")]
		[Address(RVA = "0x40F5CB4", Offset = "0x40F1CB4", VA = "0x40F5CB4")]
		public MaskPanel()
		{
		}
	}
}
