using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.DemoAssets.TexturesDemo.Scripts
{
	[Token(Token = "0x2000005")]
	public class AllIn1DemoScaleTween : MonoBehaviour
	{
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float maxTweenScale;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float minTweenScale;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float tweenSpeed;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x2C")]
		private bool isTweening;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x30")]
		private float currentScale;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x34")]
		private float iniScale;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 scaleToApply;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x3CF24EC", Offset = "0x3CEE4EC", VA = "0x3CF24EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3CF2518", Offset = "0x3CEE518", VA = "0x3CF2518")]
		private void Update()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3CF25A0", Offset = "0x3CEE5A0", VA = "0x3CF25A0")]
		private void UpdateScaleToApply()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3CF25AC", Offset = "0x3CEE5AC", VA = "0x3CF25AC")]
		private void ApplyScale()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3CF25D8", Offset = "0x3CEE5D8", VA = "0x3CF25D8")]
		public void ScaleUpTween()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3CF25F8", Offset = "0x3CEE5F8", VA = "0x3CF25F8")]
		public void ScaleDownTween()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3CF2618", Offset = "0x3CEE618", VA = "0x3CF2618")]
		public AllIn1DemoScaleTween()
		{
		}
	}
}
