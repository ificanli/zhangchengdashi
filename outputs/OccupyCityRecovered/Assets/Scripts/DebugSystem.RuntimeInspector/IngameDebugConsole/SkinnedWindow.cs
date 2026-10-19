using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000074")]
	public abstract class SkinnedWindow : MonoBehaviour
	{
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISkin m_skin;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x28")]
		private int m_skinVersion;

		[Token(Token = "0x170000C1")]
		public UISkin Skin
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x467ADF0", Offset = "0x4676DF0", VA = "0x467ADF0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x467ADF8", Offset = "0x4676DF8", VA = "0x467ADF8")]
			set
			{
			}
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x467AEA8", Offset = "0x4676EA8", VA = "0x467AEA8", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x467AF58", Offset = "0x4676F58", VA = "0x467AF58", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003D8")]
		protected abstract void RefreshSkin();

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x467AFF4", Offset = "0x4676FF4", VA = "0x467AFF4")]
		protected SkinnedWindow()
		{
		}
	}
}
