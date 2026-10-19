using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200004C")]
	[CreateAssetMenu(fileName = "DebuggerSystemSkinUGUI", menuName = "CommonGameModule/DebuggerSystemSkinUGUI")]
	public class DebuggerSystemSkinUGUI : ScriptableObject
	{
		[Token(Token = "0x40000ED")]
		private const string DefaultFontName = "LegacyRuntime.ttf";

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x18")]
		[Header("Toggle 文本颜色")]
		public Color toggleOnColor;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x28")]
		public Color toggleOffColor;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x38")]
		[Header("Console窗口皮肤")]
		public ConsoleWindowSkin consoleWindowSkin;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x40")]
		private SkinRuntimeData _skinRuntimeData;

		[Token(Token = "0x17000030")]
		public SkinRuntimeData RuntimeData
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x46447A8", Offset = "0x46407A8", VA = "0x46447A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x46447B0", Offset = "0x46407B0", VA = "0x46447B0", Slot = "4")]
		public virtual void GetSkinRuntimeData(Action<DebuggerSystemSkinUGUI> callBack)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x463662C", Offset = "0x463262C", VA = "0x463662C")]
		public void SetFont(Font font)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x46448B8", Offset = "0x46408B8", VA = "0x46448B8")]
		public DebuggerSystemSkinUGUI()
		{
		}
	}
}
