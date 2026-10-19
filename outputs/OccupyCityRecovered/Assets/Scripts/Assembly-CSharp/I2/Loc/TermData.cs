using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x2000DAB")]
	public class TermData
	{
		[Token(Token = "0x400604E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Term;

		[Token(Token = "0x400604F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public eTermType TermType;

		[NonSerialized]
		[Token(Token = "0x4006050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x4006051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Languages;

		[Token(Token = "0x4006052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] Flags;

		[Token(Token = "0x4006053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] Languages_Touch;

		[Token(Token = "0x60054D9")]
		[Address(RVA = "0x43227AC", Offset = "0x431E7AC", VA = "0x43227AC")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
			return null;
		}

		[Token(Token = "0x60054DA")]
		[Address(RVA = "0x4329B6C", Offset = "0x4325B6C", VA = "0x4329B6C")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		[Token(Token = "0x60054DB")]
		[Address(RVA = "0x4329C20", Offset = "0x4325C20", VA = "0x4329C20")]
		public void RemoveSpecialization(string specialization)
		{
		}

		[Token(Token = "0x60054DC")]
		[Address(RVA = "0x4329C74", Offset = "0x4325C74", VA = "0x4329C74")]
		public void RemoveSpecialization(int idx, string specialization)
		{
		}

		[Token(Token = "0x60054DD")]
		[Address(RVA = "0x4329DD8", Offset = "0x4325DD8", VA = "0x4329DD8")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return default;
		}

		[Token(Token = "0x60054DE")]
		[Address(RVA = "0x4329E0C", Offset = "0x4325E0C", VA = "0x4329E0C")]
		public void Validate()
		{
		}

		[Token(Token = "0x60054DF")]
		[Address(RVA = "0x4329F94", Offset = "0x4325F94", VA = "0x4329F94")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default;
		}

		[Token(Token = "0x60054E0")]
		[Address(RVA = "0x432A01C", Offset = "0x432601C", VA = "0x432A01C")]
		public bool HasSpecializations()
		{
			return default;
		}

		[Token(Token = "0x60054E1")]
		[Address(RVA = "0x432A0E4", Offset = "0x43260E4", VA = "0x432A0E4")]
		public List<string> GetAllSpecializations()
		{
			return null;
		}

		[Token(Token = "0x60054E2")]
		[Address(RVA = "0x432A1C8", Offset = "0x43261C8", VA = "0x432A1C8")]
		public TermData()
		{
		}
	}
}
