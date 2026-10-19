using System;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000016")]
public class MB3_BatchPrefabBaker : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000017")]
	public class MB3_PrefabBakerRow
	{
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x10")]
		public GameObject sourcePrefab;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x18")]
		public GameObject resultPrefab;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x743E98C", Offset = "0x743A98C", VA = "0x743E98C")]
		public MB3_PrefabBakerRow()
		{
		}
	}

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x20")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x28")]
	[NonReorderable]
	public MB3_PrefabBakerRow[] prefabRows;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x30")]
	public string outputPrefabFolder;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x743E8A4", Offset = "0x743A8A4", VA = "0x743E8A4")]
	[ContextMenu("Create Instances For Prefab Rows")]
	public void CreateSourceAndResultPrefabInstances()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x743E90C", Offset = "0x743A90C", VA = "0x743E90C")]
	public MB3_BatchPrefabBaker()
	{
	}
}
