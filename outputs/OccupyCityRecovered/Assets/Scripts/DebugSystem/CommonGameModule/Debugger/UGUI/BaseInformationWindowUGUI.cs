using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000073")]
	public abstract class BaseInformationWindowUGUI : IDebuggerWindowUGUI, IDebuggerWindowSkinSlot
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly InformationWindowUGUI windowUgui;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly StringBuilder[] m_StringBuilders;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoResetOnEnter;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected float refreshInterval;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_LastRefreshTime;

		[Token(Token = "0x1700007B")]
		public RectTransform Root
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x4688B3C", Offset = "0x4684B3C", VA = "0x4688B3C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public bool SupportClickThrough
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x4688BA8", Offset = "0x4684BA8", VA = "0x4688BA8", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x4688BB0", Offset = "0x4684BB0", VA = "0x4688BB0")]
		public BaseInformationWindowUGUI(InformationWindowUGUI windowUgui)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x4688CA4", Offset = "0x4684CA4", VA = "0x4688CA4", Slot = "14")]
		public virtual void Initialize(params object[] args)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x4688CA8", Offset = "0x4684CA8", VA = "0x4688CA8", Slot = "15")]
		public virtual void OnDebuggerSystemReopen()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x4688CAC", Offset = "0x4684CAC", VA = "0x4688CAC", Slot = "16")]
		public virtual void Shutdown()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x4688CB0", Offset = "0x4684CB0", VA = "0x4688CB0", Slot = "17")]
		public virtual void OnEnter()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x4688D4C", Offset = "0x4684D4C", VA = "0x4688D4C", Slot = "18")]
		public virtual void OnLeave()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x4688D50", Offset = "0x4684D50", VA = "0x4688D50", Slot = "19")]
		public virtual void OnUpdate(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x4688DD8", Offset = "0x4684DD8", VA = "0x4688DD8", Slot = "12")]
		public void RefreshSize(Vector2 size, bool portrait)
		{
		}

		[Token(Token = "0x60002A5")]
		protected abstract void OnRefreshText();

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x4688CEC", Offset = "0x4684CEC", VA = "0x4688CEC")]
		protected void ClearDraw()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x4688DF4", Offset = "0x4684DF4", VA = "0x4688DF4")]
		protected void DrawItem(string first, [Optional] string second, [Optional] string third)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x4688DB8", Offset = "0x4684DB8", VA = "0x4688DB8")]
		protected void ApplyDraw()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x4688ECC", Offset = "0x4684ECC", VA = "0x4688ECC")]
		protected void DrawEmptyLine()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x4688F5C", Offset = "0x4684F5C", VA = "0x4688F5C")]
		protected static string GetByteLengthString(long byteLength)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x46891A4", Offset = "0x46851A4", VA = "0x46891A4", Slot = "13")]
		public void ApplySkin(DebuggerSystemSkinUGUI skin)
		{
		}
	}
}
