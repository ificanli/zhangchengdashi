using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000DB6")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		[Serializable]
		[Token(Token = "0x2000DB7")]
		public struct ParamValue
		{
			[Token(Token = "0x4006062")]
			[FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x4006063")]
			[FieldOffset(Offset = "0x8")]
			public string Value;
		}

		[Token(Token = "0x4006060")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public List<ParamValue> _Params;

		[Token(Token = "0x4006061")]
		[FieldOffset(Offset = "0x28")]
		public bool _IsGlobalManager;

		[Token(Token = "0x6005509")]
		[Address(RVA = "0x432B600", Offset = "0x4327600", VA = "0x432B600", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x600550A")]
		[Address(RVA = "0x432B6C4", Offset = "0x43276C4", VA = "0x432B6C4")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		}

		[Token(Token = "0x600550B")]
		[Address(RVA = "0x432B850", Offset = "0x4327850", VA = "0x432B850")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x600550C")]
		[Address(RVA = "0x432B904", Offset = "0x4327904", VA = "0x432B904", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600550D")]
		[Address(RVA = "0x432B914", Offset = "0x4327914", VA = "0x432B914")]
		public void DoAutoRegister()
		{
		}

		[Token(Token = "0x600550E")]
		[Address(RVA = "0x432BA30", Offset = "0x4327A30", VA = "0x432BA30")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600550F")]
		[Address(RVA = "0x432BAB0", Offset = "0x4327AB0", VA = "0x432BAB0")]
		public LocalizationParamsManager()
		{
		}
	}
}
