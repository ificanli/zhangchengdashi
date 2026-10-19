using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro.Demo
{
	[Token(Token = "0x2000007")]
	public class TCP2_Demo_AnimateMaterial : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000008")]
		public class AnimatedProperty
		{
			[Token(Token = "0x2000009")]
			public enum MaterialPropertyType
			{
				[Token(Token = "0x400001A")]
				Float = 0,
				[Token(Token = "0x400001B")]
				Color = 1,
				[Token(Token = "0x400001C")]
				Vector4 = 2
			}

			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x18")]
			public MaterialPropertyType Type;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x20")]
			public AnimationCurve Curve;

			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x28")]
			public float Duration;

			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x2C")]
			[Space]
			public float FloatFrom;

			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x30")]
			public float FloatTo;

			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x34")]
			[Space]
			public Color ColorFrom;

			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x44")]
			public Color ColorTo;

			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x54")]
			[Space]
			public Vector4 VectorFrom;

			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x64")]
			public Vector4 VectorTo;

			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x74")]
			private int propertyId;

			[Token(Token = "0x600000B")]
			[Address(RVA = "0x7D643F0", Offset = "0x7D603F0", VA = "0x7D643F0")]
			public void Init()
			{
			}

			[Token(Token = "0x600000C")]
			[Address(RVA = "0x7D6447C", Offset = "0x7D6047C", VA = "0x7D6447C")]
			public void Update(Material material)
			{
			}

			[Token(Token = "0x600000D")]
			[Address(RVA = "0x7D645DC", Offset = "0x7D605DC", VA = "0x7D645DC")]
			public AnimatedProperty()
			{
			}
		}

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		public Material material;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		public AnimatedProperty[] animatedProperties;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x7D64380", Offset = "0x7D60380", VA = "0x7D64380")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x7D64410", Offset = "0x7D60410", VA = "0x7D64410")]
		private void Update()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x7D645D4", Offset = "0x7D605D4", VA = "0x7D645D4")]
		public TCP2_Demo_AnimateMaterial()
		{
		}
	}
}
