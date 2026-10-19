using System.Collections.Generic;
using Il2CppDummyDll;
using QuickTutor;

namespace DataModule
{
	[Token(Token = "0x2000E95")]
	public class GlobalTutorialInfo : GlobalInfoBase
	{
		[Token(Token = "0x40065A5")]
		[FieldOffset(Offset = "0x18")]
		public string nextId;

		[Token(Token = "0x40065A6")]
		[FieldOffset(Offset = "0x20")]
		public string nextIdCondition;

		[Token(Token = "0x40065A7")]
		[FieldOffset(Offset = "0x28")]
		public string useNextIdCondition;

		[Token(Token = "0x40065A8")]
		[FieldOffset(Offset = "0x30")]
		public string tutorialContent;

		[Token(Token = "0x40065A9")]
		[FieldOffset(Offset = "0x38")]
		public double tutorialTextPos;

		[Token(Token = "0x40065AA")]
		[FieldOffset(Offset = "0x40")]
		public double maskType;

		[Token(Token = "0x40065AB")]
		[FieldOffset(Offset = "0x48")]
		public TutorialActionType tutorialActionType;

		[Token(Token = "0x40065AC")]
		[FieldOffset(Offset = "0x50")]
		public string maskPoints;

		[Token(Token = "0x40065AD")]
		[FieldOffset(Offset = "0x58")]
		public string slideAnimPoints;

		[Token(Token = "0x40065AE")]
		[FieldOffset(Offset = "0x60")]
		public string startTriggerEvent;

		[Token(Token = "0x40065AF")]
		[FieldOffset(Offset = "0x68")]
		public string endTriggerEvent;

		[Token(Token = "0x17000F27")]
		public List<string> MaskPoints
		{
			[Token(Token = "0x60058C2")]
			[Address(RVA = "0x4365604", Offset = "0x4361604", VA = "0x4365604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F28")]
		public List<string> SlideAnimPoints
		{
			[Token(Token = "0x60058C3")]
			[Address(RVA = "0x436563C", Offset = "0x436163C", VA = "0x436563C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60058C4")]
		[Address(RVA = "0x4365674", Offset = "0x4361674", VA = "0x4365674")]
		public GlobalTutorialInfo()
		{
		}
	}
}
