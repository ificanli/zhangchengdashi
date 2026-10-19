using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BadgeGraph
{
	[Token(Token = "0x2000E04")]
	[CreateAssetMenu(fileName = "New BadgeGraph", menuName = "New BadgeGraph", order = 1)]
	public class BadgeGraphScriptable : ScriptableObject
	{
		[Token(Token = "0x40061E0")]
		[FieldOffset(Offset = "0x18")]
		[Header("Main Settings")]
		[Tooltip("The root node name")]
		[SerializeField]
		private string m_RootNodeName;

		[Token(Token = "0x40061E1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("A symbol for split the path")]
		private char m_SplitSymbol;

		[Token(Token = "0x40061E2")]
		[FieldOffset(Offset = "0x28")]
		[Header("Graph View")]
		[SerializeField]
		private List<BadgeData> m_BadgeDataList;

		[Token(Token = "0x17000EAA")]
		public string RootNodeName
		{
			[Token(Token = "0x6005688")]
			[Address(RVA = "0x433E28C", Offset = "0x433A28C", VA = "0x433E28C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EAB")]
		public char SplitSymbol
		{
			[Token(Token = "0x6005689")]
			[Address(RVA = "0x433E294", Offset = "0x433A294", VA = "0x433E294")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000EAC")]
		public List<BadgeData> BadgeDataList
		{
			[Token(Token = "0x600568A")]
			[Address(RVA = "0x433E29C", Offset = "0x433A29C", VA = "0x433E29C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600568B")]
		[Address(RVA = "0x433E2A4", Offset = "0x433A2A4", VA = "0x433E2A4")]
		public void SetBadgeDataList(List<BadgeData> list)
		{
		}

		[Token(Token = "0x600568C")]
		[Address(RVA = "0x433E2AC", Offset = "0x433A2AC", VA = "0x433E2AC")]
		public List<string> ConverToPaths()
		{
			return null;
		}

		[Token(Token = "0x600568D")]
		[Address(RVA = "0x433E618", Offset = "0x433A618", VA = "0x433E618")]
		private BadgeData GetParent(string key, List<BadgeData> badges)
		{
			return null;
		}

		[Token(Token = "0x600568E")]
		[Address(RVA = "0x433E7B0", Offset = "0x433A7B0", VA = "0x433E7B0")]
		public BadgeGraphScriptable()
		{
		}
	}
}
