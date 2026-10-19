using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using WG.CollectKit;

namespace WarrenGameDemo
{
	[Token(Token = "0x2000DE6")]
	public class MultiplierDemo : MonoBehaviour
	{
		[Token(Token = "0x4006170")]
		[FieldOffset(Offset = "0x20")]
		private int _moneyAmount;

		[Token(Token = "0x4006171")]
		[FieldOffset(Offset = "0x28")]
		public Text moneyAmountText;

		[Token(Token = "0x4006172")]
		[FieldOffset(Offset = "0x30")]
		public int starAmount;

		[Token(Token = "0x4006173")]
		[FieldOffset(Offset = "0x34")]
		public int targetStarAmount;

		[Token(Token = "0x4006174")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform handler;

		[Token(Token = "0x4006175")]
		[FieldOffset(Offset = "0x40")]
		public Image fillImage;

		[Token(Token = "0x4006176")]
		[FieldOffset(Offset = "0x48")]
		private float _fillSize;

		[Token(Token = "0x4006177")]
		[FieldOffset(Offset = "0x4C")]
		private float _halfFillSize;

		[Token(Token = "0x4006178")]
		[FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("collectStarPanel")]
		public CollectTweenContent collectStarContent;

		[Token(Token = "0x4006179")]
		[FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("collectMoneyPanel")]
		public CollectTweenContent collectMoneyContent;

		[Token(Token = "0x400617A")]
		[FieldOffset(Offset = "0x60")]
		public Transform collectMoneyTrans;

		[Token(Token = "0x400617B")]
		[FieldOffset(Offset = "0x68")]
		public Transform collectStarTrans;

		[Token(Token = "0x400617C")]
		[FieldOffset(Offset = "0x70")]
		public Transform moneyIconTrans;

		[Token(Token = "0x400617D")]
		[FieldOffset(Offset = "0x78")]
		public Text durationText;

		[Token(Token = "0x400617E")]
		[FieldOffset(Offset = "0x80")]
		public Text valueText;

		[Token(Token = "0x400617F")]
		[FieldOffset(Offset = "0x88")]
		public Text countText;

		[Token(Token = "0x4006180")]
		[FieldOffset(Offset = "0x90")]
		public Text randomIntensityText;

		[Token(Token = "0x4006181")]
		[FieldOffset(Offset = "0x98")]
		public ToggleGroup toggleGroup;

		[Token(Token = "0x17000EA7")]
		public int MoneyAmount
		{
			[Token(Token = "0x6005632")]
			[Address(RVA = "0x433AFC4", Offset = "0x4336FC4", VA = "0x433AFC4")]
			get
			{
				return _moneyAmount;
			}
			[Token(Token = "0x6005633")]
			[Address(RVA = "0x433AFCC", Offset = "0x4336FCC", VA = "0x433AFCC")]
			set
			{
			}
		}

		[Token(Token = "0x6005634")]
		[Address(RVA = "0x433B004", Offset = "0x4337004", VA = "0x433B004")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005635")]
		[Address(RVA = "0x433B1C4", Offset = "0x43371C4", VA = "0x433B1C4")]
		public void AddStar(int value)
		{
		}

		[Token(Token = "0x6005636")]
		[Address(RVA = "0x433B200", Offset = "0x4337200", VA = "0x433B200")]
		public void AddMoney(int value)
		{
		}

		[Token(Token = "0x6005637")]
		[Address(RVA = "0x433B20C", Offset = "0x433720C", VA = "0x433B20C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005638")]
		[Address(RVA = "0x433B28C", Offset = "0x433728C", VA = "0x433B28C")]
		public void StartCollectMoney()
		{
		}

		[Token(Token = "0x6005639")]
		[Address(RVA = "0x433B4C8", Offset = "0x43374C8", VA = "0x433B4C8")]
		public void StartCollectStar()
		{
		}

		[Token(Token = "0x600563A")]
		[Address(RVA = "0x433B704", Offset = "0x4337704", VA = "0x433B704")]
		public void OnDurationSliderChange(float single)
		{
		}

		[Token(Token = "0x600563B")]
		[Address(RVA = "0x433B74C", Offset = "0x433774C", VA = "0x433B74C")]
		public void OnValueSliderChange(float single)
		{
		}

		[Token(Token = "0x600563C")]
		[Address(RVA = "0x433B794", Offset = "0x4337794", VA = "0x433B794")]
		public void OnCountSliderChange(float single)
		{
		}

		[Token(Token = "0x600563D")]
		[Address(RVA = "0x433B7DC", Offset = "0x43377DC", VA = "0x433B7DC")]
		public void OnRandomSliderChange(float single)
		{
		}

		[Token(Token = "0x600563E")]
		[Address(RVA = "0x433B824", Offset = "0x4337824", VA = "0x433B824")]
		public MultiplierDemo()
		{
		}
	}
}
