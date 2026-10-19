using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using QuickTutor;

namespace TutorModule
{
	[Token(Token = "0x2000200")]
	public class TutorialSetupLocalizableInfo : TutorialSetupInfo
	{
		[Token(Token = "0x4001CE0")]
		[FieldOffset(Offset = "0x58")]
		private readonly string _useNextIdCondition;

		[Token(Token = "0x4001CE1")]
		[FieldOffset(Offset = "0x60")]
		private readonly string _nextIdCondition;

		[Token(Token = "0x4001CE2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex MethodRegex;

		[Token(Token = "0x4001CE3")]
		private const string ClassNameGroup = "className";

		[Token(Token = "0x4001CE4")]
		private const string MethodNameGroup = "methodName";

		[Token(Token = "0x4001CE5")]
		private const string InstanceProperty = "Instance";

		[Token(Token = "0x170000A3")]
		public override string TutorialContent
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x418D5A0", Offset = "0x41895A0", VA = "0x418D5A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public override string NextId
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x418D63C", Offset = "0x418963C", VA = "0x418D63C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x418E490", Offset = "0x418A490", VA = "0x418E490")]
		public TutorialSetupLocalizableInfo(string id, string nextId, string tutorialContent, float tutorialTextPos, float maskType, TutorialActionType tutorialActionType, List<string> maskPoints, List<string> slideAnimPoints, string startTriggerEvent, string endTriggerEvent)
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x418CAEC", Offset = "0x4188AEC", VA = "0x418CAEC")]
		public TutorialSetupLocalizableInfo(string id, string nextId, string useNextIdCondition, string nextIdCondition, string tutorialContent, float tutorialTextPos, float maskType, TutorialActionType tutorialActionType, List<string> maskPoints, List<string> slideAnimPoints, string startTriggerEvent, string endTriggerEvent)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x418E49C", Offset = "0x418A49C", VA = "0x418E49C")]
		private Type GetTypeByName(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x418D6C0", Offset = "0x41896C0", VA = "0x418D6C0")]
		private bool EvaluateCondition(string conditionPath)
		{
			return default;
		}
	}
}
