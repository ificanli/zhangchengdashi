using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200004A")]
	public class DebuggerSystemMod : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200004B")]
		public class ModInfo
		{
			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0x10")]
			public string WindowPath;

			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x18")]
			public GameObject Prefab;

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x46447A0", Offset = "0x46407A0", VA = "0x46447A0")]
			public ModInfo()
			{
			}
		}

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ModInfo> _modInfos;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x46444A8", Offset = "0x46404A8", VA = "0x46444A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4644530", Offset = "0x4640530", VA = "0x4644530")]
		private void InitMod()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4644798", Offset = "0x4640798", VA = "0x4644798")]
		public DebuggerSystemMod()
		{
		}
	}
}
