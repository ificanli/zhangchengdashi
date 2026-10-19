using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EEA")]
	public class UserOutsiderHexData
	{
		[Token(Token = "0x4006788")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("k")]
		public string key;

		[Token(Token = "0x4006789")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("tid")]
		public string talentId;

		[Token(Token = "0x400678A")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("p")]
		public int price;

		[Token(Token = "0x400678B")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("bid")]
		public string buildID;

		[Token(Token = "0x400678C")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("io")]
		public bool isOpen;

		[Token(Token = "0x6005A06")]
		[Address(RVA = "0x4378C60", Offset = "0x4374C60", VA = "0x4378C60")]
		public Vector3 GetPosition()
		{
			return default;
		}

		[Token(Token = "0x6005A07")]
		[Address(RVA = "0x4378D2C", Offset = "0x4374D2C", VA = "0x4378D2C")]
		public string SetKey(Vector3 ori)
		{
			return null;
		}

		[Token(Token = "0x6005A08")]
		[Address(RVA = "0x4379084", Offset = "0x4375084", VA = "0x4379084")]
		public UserOutsiderHexData()
		{
		}
	}
}
