using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000036")]
	public class ObjectField : ExpandableInspectorField
	{
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button initializeObjectButton;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xC8")]
		private bool elementsInitialized;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0xD0")]
		private IRuntimeInspectorCustomEditor customEditor;

		[Token(Token = "0x17000074")]
		protected override int Length
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x4665B90", Offset = "0x4661B90", VA = "0x4665B90", Slot = "17")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x4665C5C", Offset = "0x4661C5C", VA = "0x4665C5C", Slot = "8")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x4665CF4", Offset = "0x4661CF4", VA = "0x4665CF4", Slot = "9")]
		public override bool SupportsType(Type type)
		{
			return default;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x4665CFC", Offset = "0x4661CFC", VA = "0x4665CFC", Slot = "11")]
		protected override void OnBound(MemberInfo variable)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x4665D04", Offset = "0x4661D04", VA = "0x4665D04", Slot = "18")]
		protected override void GenerateElements()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x466658C", Offset = "0x466258C", VA = "0x466658C", Slot = "19")]
		protected override void ClearElements()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x466663C", Offset = "0x466263C", VA = "0x466663C", Slot = "14")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x466665C", Offset = "0x466265C", VA = "0x466665C", Slot = "16")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x46660A4", Offset = "0x46620A4", VA = "0x46660A4")]
		public void CreateDrawersForVariables(params string[] variables)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x4666714", Offset = "0x4662714", VA = "0x4666714")]
		public void CreateDrawersForVariablesExcluding(params string[] variablesToExclude)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4665EF0", Offset = "0x4661EF0", VA = "0x4665EF0")]
		private bool CanInitializeNewObject()
		{
			return default;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4666BFC", Offset = "0x4662BFC", VA = "0x4666BFC")]
		private void InitializeObject()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x4666C90", Offset = "0x4662C90", VA = "0x4666C90")]
		public ObjectField()
		{
		}
	}
}
