using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000069")]
	[RequireComponent(typeof(RectTransform))]
	public class RecycledListItem : MonoBehaviour
	{
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x30")]
		private IListViewAdapter adapter;

		[Token(Token = "0x170000B2")]
		public object Tag
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x467389C", Offset = "0x466F89C", VA = "0x467389C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x46738A4", Offset = "0x466F8A4", VA = "0x46738A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public int Position
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x46738AC", Offset = "0x466F8AC", VA = "0x46738AC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x46738B4", Offset = "0x466F8B4", VA = "0x46738B4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x46738BC", Offset = "0x466F8BC", VA = "0x46738BC")]
		internal void SetAdapter(IListViewAdapter adapter)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x46738C4", Offset = "0x466F8C4", VA = "0x46738C4")]
		public void OnClick()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x467396C", Offset = "0x466F96C", VA = "0x467396C")]
		public RecycledListItem()
		{
		}
	}
}
