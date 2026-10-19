using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PufferMiniGame
{
	[Token(Token = "0x2000D4D")]
	public class TipPanel : MonoBehaviour
	{
		[Token(Token = "0x4005F04")]
		[FieldOffset(Offset = "0x20")]
		private GameObject _originTip;

		[Token(Token = "0x4005F05")]
		[FieldOffset(Offset = "0x28")]
		private List<TipPopUI> _tipPool;

		[Token(Token = "0x4005F06")]
		[FieldOffset(Offset = "0x30")]
		private List<TipPopUI> _activeTips;

		[Token(Token = "0x600525B")]
		[Address(RVA = "0x430068C", Offset = "0x42FC68C", VA = "0x430068C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600525C")]
		[Address(RVA = "0x430059C", Offset = "0x42FC59C", VA = "0x430059C")]
		public void ShowTip(string text)
		{
		}

		[Token(Token = "0x600525D")]
		[Address(RVA = "0x4300778", Offset = "0x42FC778", VA = "0x4300778")]
		private TipPopUI GetPopTipFromPool()
		{
			return null;
		}

		[Token(Token = "0x600525E")]
		[Address(RVA = "0x4300B60", Offset = "0x42FCB60", VA = "0x4300B60")]
		private void UpdatePos()
		{
		}

		[Token(Token = "0x600525F")]
		[Address(RVA = "0x4300D00", Offset = "0x42FCD00", VA = "0x4300D00")]
		public void Recycle(TipPopUI tipPopUI)
		{
		}

		[Token(Token = "0x6005260")]
		[Address(RVA = "0x4300D58", Offset = "0x42FCD58", VA = "0x4300D58")]
		public TipPanel()
		{
		}
	}
}
