using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FC4")]
	internal abstract class FakeAd : MonoBehaviour
	{
		[Token(Token = "0x4006BB7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject rootView;

		[Token(Token = "0x4006BB8")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_viewButton")]
		[SerializeField]
		private Button viewButton;

		[Token(Token = "0x4006BB9")]
		[FieldOffset(Offset = "0x30")]
		public Action onClick;

		[Token(Token = "0x6005E58")]
		[Address(RVA = "0x43FBDF0", Offset = "0x43F7DF0", VA = "0x43FBDF0")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6005E59")]
		[Address(RVA = "0x43FBE80", Offset = "0x43F7E80", VA = "0x43FBE80")]
		public void StartAd()
		{
		}

		[Token(Token = "0x6005E5A")]
		[Address(RVA = "0x43FBEA0", Offset = "0x43F7EA0", VA = "0x43FBEA0")]
		public void StopAd()
		{
		}

		[Token(Token = "0x6005E5B")]
		[Address(RVA = "0x43FBF28", Offset = "0x43F7F28", VA = "0x43FBF28")]
		protected FakeAd()
		{
		}
	}
}
