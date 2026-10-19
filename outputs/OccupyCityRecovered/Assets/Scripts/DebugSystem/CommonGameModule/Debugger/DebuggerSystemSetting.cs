using CommonGameModule.Debugger.UGUI;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x2000008")]
	[CreateAssetMenu(fileName = "DebuggerSystemSetting", menuName = "CommonGameModule/DebuggerSystemSetting")]
	public class DebuggerSystemSetting : ScriptableObject
	{
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		[Header("初始皮肤，会覆盖预制上的设置")]
		public DebuggerSystemSkinUGUI defaultSkin;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x20")]
		[Header("要发送的飞书群ID（需要先在飞书群添加机器人）")]
		public string chatGroupId;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x28")]
		public string Ver;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x30")]
		public string GFVer;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x38")]
		public string GetUACBuildIDAssemblyName;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x40")]
		public string GetUACBuildIDTypeName;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x48")]
		public string GetUACBuildIDMethodName;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x46300DC", Offset = "0x462C0DC", VA = "0x46300DC")]
		public DebuggerSystemSetting()
		{
		}
	}
}
