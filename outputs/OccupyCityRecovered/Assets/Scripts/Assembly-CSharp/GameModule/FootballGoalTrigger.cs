using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000227")]
	public class FootballGoalTrigger : MonoBehaviour
	{
		[Token(Token = "0x4001DB6")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		private Action m_Triggered;

		[Token(Token = "0x14000002")]
		public event Action Triggered
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x428CFBC", Offset = "0x4288FBC", VA = "0x428CFBC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x428D058", Offset = "0x4289058", VA = "0x428D058")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x428D0F4", Offset = "0x42890F4", VA = "0x428D0F4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x428D188", Offset = "0x4289188", VA = "0x428D188")]
		public FootballGoalTrigger()
		{
		}
	}
}
