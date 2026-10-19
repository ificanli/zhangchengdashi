using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Serialization
{
	[Token(Token = "0x2000252")]
	public class TinyJsonDeserializer
	{
		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TextReader reader;

		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string fullTextDebug;

		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject contextRoot;

		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly NumberFormatInfo numberFormat;

		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private StringBuilder builder;

		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x4480D60", Offset = "0x447CD60", VA = "0x4480D60")]
		public static object Deserialize(string text, Type type, [Optional] object populate, [Optional] GameObject contextRoot)
		{
			return null;
		}

		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x448488C", Offset = "0x448088C", VA = "0x448488C")]
		private object Deserialize(Type tp, [Optional] object populate)
		{
			return null;
		}

		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x4485CFC", Offset = "0x4481CFC", VA = "0x4485CFC")]
		private UnityEngine.Object DeserializeUnityObject()
		{
			return null;
		}

		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x4485ED4", Offset = "0x4481ED4", VA = "0x4485ED4")]
		private UnityEngine.Object DeserializeUnityObjectInner()
		{
			return null;
		}

		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x44864A8", Offset = "0x44824A8", VA = "0x44864A8")]
		private void EatWhitespace()
		{
		}

		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x4485AB0", Offset = "0x4481AB0", VA = "0x4485AB0")]
		private void Eat(string s)
		{
		}

		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x4486544", Offset = "0x4482544", VA = "0x4486544")]
		private string EatUntil(string c, bool inString)
		{
			return null;
		}

		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x4485A50", Offset = "0x4481A50", VA = "0x4485A50")]
		private bool TryEat(char c)
		{
			return default;
		}

		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x44859C8", Offset = "0x44819C8", VA = "0x44859C8")]
		private string EatField()
		{
			return null;
		}

		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x4485D80", Offset = "0x4481D80", VA = "0x4485D80")]
		private void SkipFieldData()
		{
		}

		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x448482C", Offset = "0x448082C", VA = "0x448482C")]
		public TinyJsonDeserializer()
		{
		}
	}
}
