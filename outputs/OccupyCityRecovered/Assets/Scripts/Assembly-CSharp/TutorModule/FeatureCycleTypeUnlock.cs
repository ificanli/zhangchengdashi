using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;

namespace TutorModule
{
	[Token(Token = "0x2000203")]
	public class FeatureCycleTypeUnlock : FeatureUnlockBase
	{
		[Token(Token = "0x4001CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int _day;

		[Token(Token = "0x4001CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly int _cycleDay;

		[Token(Token = "0x4001CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly int _cycleInterDay;

		[Token(Token = "0x4001CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<string> _cycleFeatures;

		[Token(Token = "0x4001CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _currentCycleIndex;

		[Token(Token = "0x4001CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DateTime _lastFeatureStartTime;

		[Token(Token = "0x4001CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _currentActiveFeature;

		[Token(Token = "0x4001CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float updateInterTime;

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x418B124", Offset = "0x4187124", VA = "0x418B124")]
		public FeatureCycleTypeUnlock(GlobalFeatureUnlockInfo info, bool isUnlock) : base(info, isUnlock)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeatureCycleTypeUnlock..ctor RVA=0x418B124 Token=0x0600084A; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x418EFF0", Offset = "0x418AFF0", VA = "0x418EFF0", Slot = "5")]
		public override void StartCheck()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x418EE98", Offset = "0x418AE98", VA = "0x418EE98")]
		private bool GetIsUnlock()
		{
			return default;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x418ED14", Offset = "0x418AD14", VA = "0x418ED14")]
		private void LoadFromSaveData()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x418F4A8", Offset = "0x418B4A8", VA = "0x418F4A8")]
		private void SaveToData()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x418F748", Offset = "0x418B748", VA = "0x418F748")]
		private void SaveRemainingActiveTime()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x418FA38", Offset = "0x418BA38", VA = "0x418FA38", Slot = "8")]
		public override void ToUpdate()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x418F8B4", Offset = "0x418B8B4", VA = "0x418F8B4")]
		private TimeSpan CalculateRemainingActiveTime()
		{
			return default;
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x418F368", Offset = "0x418B368", VA = "0x418F368")]
		private void InitializeCycle()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x418F0B0", Offset = "0x418B0B0", VA = "0x418F0B0")]
		private void CheckUnlock([Optional] object obj)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x418FAD4", Offset = "0x418BAD4", VA = "0x418FAD4")]
		private void OnFeatureChanged()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x418FB60", Offset = "0x418BB60", VA = "0x418FB60")]
		private void OnFeaturePaused()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x418FBC8", Offset = "0x418BBC8", VA = "0x418FBC8")]
		private void OnFeatureResumed()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x418FC54", Offset = "0x418BC54", VA = "0x418FC54", Slot = "6")]
		public override void EndCheck()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x418FC58", Offset = "0x418BC58", VA = "0x418FC58", Slot = "7")]
		public override string UnlockTip()
		{
			return null;
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x418FC60", Offset = "0x418BC60", VA = "0x418FC60")]
		public string GetCurrentActiveFeature()
		{
			return null;
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x418FC68", Offset = "0x418BC68", VA = "0x418FC68")]
		public int GetDaysToNextFeature()
		{
			return default;
		}
	}
}
