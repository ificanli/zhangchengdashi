using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x200000D")]
	public class ModelOutlet : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000E")]
		public class ModelOutletInfo
		{
			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x10")]
			public string NodeName;

			[Token(Token = "0x400002B")]
			[FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x7068240", Offset = "0x7064240", VA = "0x7068240")]
			public ModelOutletInfo()
			{
			}
		}

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x20")]
		public List<ModelOutletInfo> OutletInfos;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Transform> m_dicOutletInfo;

		[Token(Token = "0x1700000B")]
		public Dictionary<string, Transform> dicOutletInfo
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x7067F88", Offset = "0x7063F88", VA = "0x7067F88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000039")]
		public T GetComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x7068148", Offset = "0x7064148", VA = "0x7068148")]
		public Transform GetNode(string name)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x70681C4", Offset = "0x70641C4", VA = "0x70681C4")]
		public ModelOutlet()
		{
		}
	}
}
