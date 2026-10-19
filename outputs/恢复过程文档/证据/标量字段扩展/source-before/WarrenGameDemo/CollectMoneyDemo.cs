using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using WG.CollectKit;

namespace WarrenGameDemo
{
	[Token(Token = "0x2000DE2")]
	public class CollectMoneyDemo : MonoBehaviour
	{
		[Token(Token = "0x4006155")]
		[FieldOffset(Offset = "0x20")]
		private int _moneyAmount;

		[Token(Token = "0x4006156")]
		[FieldOffset(Offset = "0x28")]
		public Text coinAmountText;

		[Token(Token = "0x4006157")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("collectTweenPanel")]
		public CollectTweenContent collectTweenContent;

		[Token(Token = "0x4006158")]
		[FieldOffset(Offset = "0x38")]
		public Transform startTrans;

		[Token(Token = "0x4006159")]
		[FieldOffset(Offset = "0x40")]
		public Transform moneyIconTrans;

		[Token(Token = "0x400615A")]
		[FieldOffset(Offset = "0x48")]
		public Text durationText;

		[Token(Token = "0x400615B")]
		[FieldOffset(Offset = "0x50")]
		public Text valueText;

		[Token(Token = "0x400615C")]
		[FieldOffset(Offset = "0x58")]
		public Text countText;

		[Token(Token = "0x400615D")]
		[FieldOffset(Offset = "0x60")]
		public Text randomIntensityText;

		[Token(Token = "0x400615E")]
		[FieldOffset(Offset = "0x68")]
		public ToggleGroup toggleGroup;

		[Token(Token = "0x17000EA6")]
		public int MoneyAmount
		{
			[Token(Token = "0x6005619")]
			[Address(RVA = "0x433A440", Offset = "0x4336440", VA = "0x433A440")]
			get
			{
				return default;
			}
			[Token(Token = "0x600561A")]
			[Address(RVA = "0x433A448", Offset = "0x4336448", VA = "0x433A448")]
			set
			{
			}
		}

		[Token(Token = "0x600561B")]
		[Address(RVA = "0x433A480", Offset = "0x4336480", VA = "0x433A480")]
		private void Awake()
		{
		}

		[Token(Token = "0x600561C")]
		[Address(RVA = "0x433A584", Offset = "0x4336584", VA = "0x433A584")]
		public void AddCoin(int value)
		{
		}

		[Token(Token = "0x600561D")]
		[Address(RVA = "0x433A590", Offset = "0x4336590", VA = "0x433A590")]
		public void StartCollect()
		{
		}

		[Token(Token = "0x600561E")]
		[Address(RVA = "0x433A7CC", Offset = "0x43367CC", VA = "0x433A7CC")]
		public void OnDurationSliderChange(float single)
		{
		}

		[Token(Token = "0x600561F")]
		[Address(RVA = "0x433A814", Offset = "0x4336814", VA = "0x433A814")]
		public void OnValueSliderChange(float single)
		{
		}

		[Token(Token = "0x6005620")]
		[Address(RVA = "0x433A85C", Offset = "0x433685C", VA = "0x433A85C")]
		public void OnCountSliderChange(float single)
		{
		}

		[Token(Token = "0x6005621")]
		[Address(RVA = "0x433A8A4", Offset = "0x43368A4", VA = "0x433A8A4")]
		public void OnRandomSliderChange(float single)
		{
		}

		[Token(Token = "0x6005622")]
		[Address(RVA = "0x433A8EC", Offset = "0x43368EC", VA = "0x433A8EC")]
		public CollectMoneyDemo()
		{
		}
	}
}
