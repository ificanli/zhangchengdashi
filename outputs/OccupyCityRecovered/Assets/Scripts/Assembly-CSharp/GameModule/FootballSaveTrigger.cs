using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200022A")]
	public class FootballSaveTrigger : MonoBehaviour
	{
		[Token(Token = "0x4001DC4")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private Action m_Triggered;

		[Token(Token = "0x14000003")]
		public event Action Triggered
		{
			[Token(Token = "0x600091D")]
			[Address(RVA = "0x428D458", Offset = "0x4289458", VA = "0x428D458")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x428D4F4", Offset = "0x42894F4", VA = "0x428D4F4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x428D590", Offset = "0x4289590", VA = "0x428D590")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x428D614", Offset = "0x4289614", VA = "0x428D614")]
		public FootballSaveTrigger()
		{
		}
	}
}
