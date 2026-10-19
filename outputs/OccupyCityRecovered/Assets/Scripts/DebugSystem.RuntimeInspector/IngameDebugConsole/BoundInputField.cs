using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000041")]
	public class BoundInputField : MonoBehaviour
	{
		[Token(Token = "0x2000042")]
		public delegate bool OnValueChangedDelegate(BoundInputField source, string input);

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x20")]
		private bool initialized;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x21")]
		private bool inputValid;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x22")]
		private bool inputAltered;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x28")]
		private InputField inputField;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x30")]
		private Image inputFieldBackground;

		[NonSerialized]
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x38")]
		public string DefaultEmptyValue;

		[NonSerialized]
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x40")]
		public bool CacheTextOnValueChange;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x48")]
		private string recentText;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x50")]
		private int m_skinVersion;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x58")]
		private UISkin m_skin;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x60")]
		public OnValueChangedDelegate OnValueChanged;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x68")]
		public OnValueChangedDelegate OnValueSubmitted;

		[Token(Token = "0x1700007B")]
		public InputField BackingField
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x466C1C4", Offset = "0x46681C4", VA = "0x466C1C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public string Text
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x466C1CC", Offset = "0x46681CC", VA = "0x466C1CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x46646E0", Offset = "0x46606E0", VA = "0x46646E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public UISkin Skin
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x466C1E8", Offset = "0x46681E8", VA = "0x466C1E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x4664930", Offset = "0x4660930", VA = "0x4664930")]
			set
			{
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x466C1F0", Offset = "0x46681F0", VA = "0x466C1F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x4663C44", Offset = "0x465FC44", VA = "0x4663C44")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x466C1F4", Offset = "0x46681F4", VA = "0x466C1F4")]
		private void InputFieldValueChanged(string str)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x466C2E4", Offset = "0x46682E4", VA = "0x466C2E4")]
		private void InputFieldValueSubmitted(string str)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x466C3B4", Offset = "0x46683B4", VA = "0x466C3B4")]
		public BoundInputField()
		{
		}
	}
}
