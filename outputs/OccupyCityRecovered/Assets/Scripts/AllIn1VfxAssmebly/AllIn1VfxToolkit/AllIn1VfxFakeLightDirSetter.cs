using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit
{
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	public class AllIn1VfxFakeLightDirSetter : MonoBehaviour
	{
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x20")]
		[Header("This script gets executed in edit mode too")]
		[SerializeField]
		private bool setOnAwake;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool setOnUpdate;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x28")]
		[Header("If target is null we'll use this object as target")]
		[Space]
		[Header("Direction is target's forward vector")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x30")]
		private int lightDirId;

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x3CED7A8", Offset = "0x3CE97A8", VA = "0x3CED7A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x3CED948", Offset = "0x3CE9948", VA = "0x3CED948")]
		private void Update()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x3CED958", Offset = "0x3CE9958", VA = "0x3CED958")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x3CED7B8", Offset = "0x3CE97B8", VA = "0x3CED7B8")]
		public void SetGlobalFakeLightDir()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x3CED95C", Offset = "0x3CE995C", VA = "0x3CED95C")]
		public void SetNewFakeLightDir(Vector3 newFakeLightDir)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3CEDA88", Offset = "0x3CE9A88", VA = "0x3CEDA88")]
		public void SetNewTarget(Transform newTarget)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x3CEDA90", Offset = "0x3CE9A90", VA = "0x3CEDA90")]
		public void SetOnUpdateBool(bool newSetOnUpdateValue)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x3CEDA9C", Offset = "0x3CE9A9C", VA = "0x3CEDA9C")]
		public AllIn1VfxFakeLightDirSetter()
		{
		}
	}
}
