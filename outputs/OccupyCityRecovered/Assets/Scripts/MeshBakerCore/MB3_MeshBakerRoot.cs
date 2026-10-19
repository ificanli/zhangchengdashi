using System.Collections.Generic;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200001F")]
public abstract class MB3_MeshBakerRoot : MonoBehaviour
{
	[Token(Token = "0x2000020")]
	public class ZSortObjects
	{
		[Token(Token = "0x2000021")]
		public class Item
		{
			[Token(Token = "0x400007D")]
			[FieldOffset(Offset = "0x10")]
			public GameObject go;

			[Token(Token = "0x400007E")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 point;

			[Token(Token = "0x6000081")]
			[Address(RVA = "0x7442EBC", Offset = "0x743EEBC", VA = "0x7442EBC")]
			public Item()
			{
			}
		}

		[Token(Token = "0x2000022")]
		public class ItemComparer : IComparer<Item>
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x7442ED4", Offset = "0x743EED4", VA = "0x7442ED4", Slot = "4")]
			public int Compare(Item a, Item b)
			{
				return default;
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0x7442EC4", Offset = "0x743EEC4", VA = "0x7442EC4")]
			public ItemComparer()
			{
			}
		}

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 sortAxis;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x7442A50", Offset = "0x743EA50", VA = "0x7442A50")]
		public void SortByDistanceAlongAxis(List<GameObject> gos)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x7442ECC", Offset = "0x743EECC", VA = "0x7442ECC")]
		public ZSortObjects()
		{
		}
	}

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 sortAxis;

	[Token(Token = "0x17000009")]
	[HideInInspector]
	public abstract MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x6000078")]
		get;
		[Token(Token = "0x6000079")]
		set;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x7441B64", Offset = "0x743DB64", VA = "0x7441B64", Slot = "6")]
	public virtual List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x7441B6C", Offset = "0x743DB6C", VA = "0x7441B6C", Slot = "7")]
	public virtual void PurgeNullsFromObjectsToCombine()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x7441B70", Offset = "0x743DB70", VA = "0x7441B70")]
	public static bool DoCombinedValidate(MB3_MeshBakerRoot mom, MB_ObjsToCombineTypes objToCombineType, MB2_EditorMethodsInterface editorMethods, MB2_ValidationLevel validationLevel)
	{
		return default;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x7442000", Offset = "0x743E000", VA = "0x7442000")]
	public static bool ValidateTextureBakerGameObjects(MB3_MeshBakerRoot mom, List<GameObject> objsToMesh, MB2_ValidationLevel validationLevel)
	{
		return default;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x74410D8", Offset = "0x743D0D8", VA = "0x74410D8")]
	protected MB3_MeshBakerRoot()
	{
	}
}
