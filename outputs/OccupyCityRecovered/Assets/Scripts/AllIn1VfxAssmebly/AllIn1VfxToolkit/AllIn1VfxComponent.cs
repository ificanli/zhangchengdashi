using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit
{
	[Token(Token = "0x2000011")]
	[AddComponentMenu("AllIn1VfxToolkit/AddAllIn1Vfx")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class AllIn1VfxComponent : MonoBehaviour
	{
		[Token(Token = "0x2000012")]
		private enum AfterSetAction
		{
			[Token(Token = "0x400005F")]
			Clear = 0,
			[Token(Token = "0x4000060")]
			CopyMaterial = 1,
			[Token(Token = "0x4000061")]
			Reset = 2
		}

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x20")]
		private Material currMaterial;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x28")]
		private Material prevMaterial;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x30")]
		private bool matAssigned;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x31")]
		private bool destroyed;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3CEC588", Offset = "0x3CE8588", VA = "0x3CEC588")]
		private void MakeNewMaterial(string shaderName = "AllIn1Vfx", bool notifyWhenDone = false)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3CEC594", Offset = "0x3CE8594", VA = "0x3CEC594")]
		public bool MakeCopy()
		{
			return default;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x3CEC680", Offset = "0x3CE8680", VA = "0x3CEC680")]
		private bool FetchCurrentMaterial()
		{
			return default;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3CEC7A8", Offset = "0x3CE87A8", VA = "0x3CEC7A8")]
		private void ResetAllProperties(string shaderName)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3CEC58C", Offset = "0x3CE858C", VA = "0x3CEC58C")]
		private bool SetMaterial(AfterSetAction action, string shaderName)
		{
			return default;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3CEC7AC", Offset = "0x3CE87AC", VA = "0x3CEC7AC")]
		private void DoAfterSetAction(AfterSetAction action)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x3CED110", Offset = "0x3CE9110", VA = "0x3CED110")]
		public bool TryCreateNew()
		{
			return default;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3CEC7EC", Offset = "0x3CE87EC", VA = "0x3CEC7EC")]
		public void ClearAllKeywords()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3CED4C8", Offset = "0x3CE94C8", VA = "0x3CED4C8")]
		private void SetKeyword(string keyword, bool state = false)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3CED5B0", Offset = "0x3CE95B0", VA = "0x3CED5B0")]
		private void FindCurrMaterial()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x3CED318", Offset = "0x3CE9318", VA = "0x3CED318")]
		public void CleanMaterial()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3CED6D4", Offset = "0x3CE96D4", VA = "0x3CED6D4")]
		public bool SaveMaterial()
		{
			return default;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3CED6DC", Offset = "0x3CE96DC", VA = "0x3CED6DC")]
		private void SaveMaterialWithOtherName(string path, int i = 1)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3CED79C", Offset = "0x3CE979C", VA = "0x3CED79C")]
		private void DoSaving(string fileName)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x3CED4C4", Offset = "0x3CE94C4", VA = "0x3CED4C4")]
		public void SetSceneDirty()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x3CEC7A4", Offset = "0x3CE87A4", VA = "0x3CEC7A4")]
		private void MissingRenderer()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x3CED7A0", Offset = "0x3CE97A0", VA = "0x3CED7A0")]
		public AllIn1VfxComponent()
		{
		}
	}
}
