using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000068")]
	public interface IListViewAdapter
	{
		[Token(Token = "0x170000B0")]
		int Count
		{
			[Token(Token = "0x6000379")]
			get;
		}

		[Token(Token = "0x170000B1")]
		float ItemHeight
		{
			[Token(Token = "0x600037A")]
			get;
		}

		[Token(Token = "0x600037B")]
		RecycledListItem CreateItem(Transform parent);

		[Token(Token = "0x600037C")]
		void SetItemContent(RecycledListItem item);

		[Token(Token = "0x600037D")]
		void OnItemClicked(RecycledListItem item);
	}
}
