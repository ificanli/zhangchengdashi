using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	[Token(Token = "0x200000A")]
	public class SpiralPlugin : ABSTweenPlugin<Vector3, Vector3, SpiralOptions>
	{
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3 DefaultDirection;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x46ADF14", Offset = "0x46A9F14", VA = "0x46ADF14", Slot = "4")]
		public override void Reset(TweenerCore<Vector3, Vector3, SpiralOptions> t)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x46ADF18", Offset = "0x46A9F18", VA = "0x46ADF18", Slot = "5")]
		public override void SetFrom(TweenerCore<Vector3, Vector3, SpiralOptions> t, bool isRelative)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x46ADF1C", Offset = "0x46A9F1C", VA = "0x46ADF1C", Slot = "6")]
		public override void SetFrom(TweenerCore<Vector3, Vector3, SpiralOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x46ADF20", Offset = "0x46A9F20", VA = "0x46ADF20")]
		public static ABSTweenPlugin<Vector3, Vector3, SpiralOptions> Get()
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x46ADF60", Offset = "0x46A9F60", VA = "0x46ADF60", Slot = "7")]
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, SpiralOptions> t, Vector3 value)
		{
			return default;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x46ADF64", Offset = "0x46A9F64", VA = "0x46ADF64", Slot = "8")]
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, SpiralOptions> t)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x46ADF68", Offset = "0x46A9F68", VA = "0x46ADF68", Slot = "9")]
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, SpiralOptions> t)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x46AE018", Offset = "0x46AA018", VA = "0x46AE018", Slot = "10")]
		public override float GetSpeedBasedDuration(SpiralOptions options, float unitsXSecond, Vector3 changeValue)
		{
			return default;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x46AE01C", Offset = "0x46AA01C", VA = "0x46AE01C", Slot = "11")]
		public override void EvaluateAndApply(SpiralOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x46AE328", Offset = "0x46AA328", VA = "0x46AE328")]
		public SpiralPlugin()
		{
		}
	}
}
