using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using WG.CollectKit;

namespace WarrenGameDemo
{
	[Token(Token = "0x2000DE4")]
	public class CollectStarDemo : MonoBehaviour
	{
		[Token(Token = "0x4006161")]
		[FieldOffset(Offset = "0x20")]
		public int starAmount;

		[Token(Token = "0x4006162")]
		[FieldOffset(Offset = "0x24")]
		public int targetStarAmount;

		[Token(Token = "0x4006163")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform handler;

		[Token(Token = "0x4006164")]
		[FieldOffset(Offset = "0x30")]
		public Image fillImage;

		[Token(Token = "0x4006165")]
		[FieldOffset(Offset = "0x38")]
		private float _fillSize;

		[Token(Token = "0x4006166")]
		[FieldOffset(Offset = "0x3C")]
		private float _halfFillSize;

		[Token(Token = "0x4006167")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("collectTweenPanel")]
		public CollectTweenContent collectTweenContent;

		[Token(Token = "0x4006168")]
		[FieldOffset(Offset = "0x48")]
		public Transform startTrans;

		[Token(Token = "0x4006169")]
		[FieldOffset(Offset = "0x50")]
		public Text durationText;

		[Token(Token = "0x400616A")]
		[FieldOffset(Offset = "0x58")]
		public Text valueText;

		[Token(Token = "0x400616B")]
		[FieldOffset(Offset = "0x60")]
		public Text countText;

		[Token(Token = "0x400616C")]
		[FieldOffset(Offset = "0x68")]
		public Text randomIntensityText;

		[Token(Token = "0x400616D")]
		[FieldOffset(Offset = "0x70")]
		public ToggleGroup toggleGroup;

		[Token(Token = "0x6005626")]
		[Address(RVA = "0x433A9C0", Offset = "0x43369C0", VA = "0x433A9C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005627")]
		[Address(RVA = "0x433AAD0", Offset = "0x4336AD0", VA = "0x433AAD0")]
		public void AddStar(int value)
		{
		}

		[Token(Token = "0x6005628")]
		[Address(RVA = "0x433AB0C", Offset = "0x4336B0C", VA = "0x433AB0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005629")]
		[Address(RVA = "0x433AB8C", Offset = "0x4336B8C", VA = "0x433AB8C")]
		public void StartCollect()
		{
		}

		[Token(Token = "0x600562A")]
		[Address(RVA = "0x433ADC8", Offset = "0x4336DC8", VA = "0x433ADC8")]
		public void OnDurationSliderChange(float single)
		{
		}

		[Token(Token = "0x600562B")]
		[Address(RVA = "0x433AE10", Offset = "0x4336E10", VA = "0x433AE10")]
		public void OnValueSliderChange(float single)
		{
		}

		[Token(Token = "0x600562C")]
		[Address(RVA = "0x433AE58", Offset = "0x4336E58", VA = "0x433AE58")]
		public void OnCountSliderChange(float single)
		{
		}

		[Token(Token = "0x600562D")]
		[Address(RVA = "0x433AEA0", Offset = "0x4336EA0", VA = "0x433AEA0")]
		public void OnRandomSliderChange(float single)
		{
		}

		[Token(Token = "0x600562E")]
		[Address(RVA = "0x433AEE8", Offset = "0x4336EE8", VA = "0x433AEE8")]
		public CollectStarDemo()
		{
		}
	}
}
