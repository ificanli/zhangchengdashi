using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x200000E")]
	public class AllIn1DemoScaleTween : MonoBehaviour
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float maxTweenScale;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float minTweenScale;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float tweenSpeed;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x2C")]
		private bool isTweening;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x30")]
		private float currentScale;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 scaleToApply;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x3CEF9A0", Offset = "0x3CEB9A0", VA = "0x3CEF9A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3CEFA28", Offset = "0x3CEBA28", VA = "0x3CEFA28")]
		private void UpdateScaleToApply()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3CEFA34", Offset = "0x3CEBA34", VA = "0x3CEFA34")]
		private void ApplyScale()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x3CEF030", Offset = "0x3CEB030", VA = "0x3CEF030")]
		public void ScaleUpTween()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3CEFA60", Offset = "0x3CEBA60", VA = "0x3CEFA60")]
		public void ScaleDownTween()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3CEFA78", Offset = "0x3CEBA78", VA = "0x3CEFA78")]
		public AllIn1DemoScaleTween()
		{
		}
	}
}
