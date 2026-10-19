using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200004D")]
	public abstract class DynamicScrollItemBase<DataType, ViewSetting> where ViewSetting : class
	{
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x0")]
		private Transform _root;

		[Token(Token = "0x17000031")]
		public Transform transform
		{
			[Token(Token = "0x600013C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public GameObject gameObject
		{
			[Token(Token = "0x600013D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public abstract int Index
		{
			[Token(Token = "0x6000140")]
			get;
		}

		[Token(Token = "0x600013E")]
		public void BindTransform(Transform root)
		{
		}

		[Token(Token = "0x600013F")]
		protected virtual void AfterBindTransform()
		{
		}

		[Token(Token = "0x6000141")]
		public abstract void Init(Transform parent);

		[Token(Token = "0x6000142")]
		public abstract void Refresh(DataType data, int index, ViewSetting viewSetting);

		[Token(Token = "0x6000143")]
		public abstract void SetActive(bool active);

		[Token(Token = "0x6000144")]
		protected DynamicScrollItemBase()
		{
		}
	}
}
