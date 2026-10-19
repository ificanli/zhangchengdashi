using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Serializable]
	[Token(Token = "0x200003E")]
	public class GPUInstancerPrefabPrototype : GPUInstancerPrototype
	{
		[Serializable]
		[Token(Token = "0x200003F")]
		public class RigidbodyData
		{
			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x10")]
			public bool useGravity;

			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x14")]
			public float angularDrag;

			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x18")]
			public float mass;

			[Token(Token = "0x40002E7")]
			[FieldOffset(Offset = "0x1C")]
			public RigidbodyConstraints constraints;

			[Token(Token = "0x40002E8")]
			[FieldOffset(Offset = "0x20")]
			public float drag;

			[Token(Token = "0x40002E9")]
			[FieldOffset(Offset = "0x24")]
			public bool isKinematic;

			[Token(Token = "0x40002EA")]
			[FieldOffset(Offset = "0x28")]
			public RigidbodyInterpolation interpolation;

			[Token(Token = "0x600016A")]
			[Address(RVA = "0x73DB648", Offset = "0x73D7648", VA = "0x73DB648")]
			public RigidbodyData()
			{
			}
		}

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x88")]
		public bool enableRuntimeModifications;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x89")]
		public bool startWithRigidBody;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x8A")]
		public bool addRemoveInstancesAtRuntime;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x8C")]
		public int extraBufferSize;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x90")]
		public bool addRuntimeHandlerScript;

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x91")]
		public bool hasRigidBody;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x98")]
		public RigidbodyData rigidbodyData;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0xA0")]
		public bool meshRenderersDisabled;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0xA1")]
		public bool isTransformsSerialized;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0xA8")]
		public TextAsset serializedTransformData;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0xB0")]
		public int serializedTransformDataCount;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x73DB644", Offset = "0x73D7644", VA = "0x73DB644")]
		public GPUInstancerPrefabPrototype()
		{
		}
	}
}
