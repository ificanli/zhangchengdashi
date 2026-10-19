using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x200003C")]
	public class TextureReferenceField : ObjectReferenceField
	{
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RawImage referencePreview;

		[Token(Token = "0x17000078")]
		protected override float HeightMultiplier
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x466921C", Offset = "0x466521C", VA = "0x466921C", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x4669224", Offset = "0x4665224", VA = "0x4669224", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x466931C", Offset = "0x466531C", VA = "0x466931C", Slot = "18")]
		protected override void OnReferenceChanged(UnityEngine.Object reference)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x466942C", Offset = "0x466542C", VA = "0x466942C")]
		public TextureReferenceField()
		{
		}
	}
}
