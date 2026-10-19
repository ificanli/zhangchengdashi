using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x20003CD")]
	public class UIObject
	{
		[Token(Token = "0x4001C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected Dictionary<string, GameObject> objectList;

		[Token(Token = "0x4001C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x4001C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform transform;

		[Token(Token = "0x4001C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform rectTransform;

		[Token(Token = "0x4001C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool m_isVisible;

		[Token(Token = "0x4001C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isInstance;

		[Token(Token = "0x4001C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool m_isDispose;

		[Token(Token = "0x4001C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected int useSkinId;

		[Token(Token = "0x4001C87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Object, AssetOperationHandle> dynamicLoadResList;

		[Token(Token = "0x4001C88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<Object, AssetOperationHandle> customLoadResList;

		[Token(Token = "0x17001168")]
		public bool IsVisible
		{
			[Token(Token = "0x6005F83")]
			[Address(RVA = "0x71D9D68", Offset = "0x71D5D68", VA = "0x71D9D68")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005F79")]
		[Address(RVA = "0x71D9824", Offset = "0x71D5824", VA = "0x71D9824")]
		protected void initGameObject(GameObject obj)
		{
		}

		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0x71D9B28", Offset = "0x71D5B28", VA = "0x71D9B28")]
		private void SetTextFont()
		{
		}

		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0x71D9C20", Offset = "0x71D5C20", VA = "0x71D9C20", Slot = "4")]
		protected virtual void Normalize()
		{
		}

		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0x71D9C80", Offset = "0x71D5C80", VA = "0x71D9C80", Slot = "5")]
		protected virtual void InitializeComponent()
		{
		}

		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0x71D9C84", Offset = "0x71D5C84", VA = "0x71D9C84", Slot = "6")]
		protected virtual void InitializeSkin()
		{
		}

		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0x71D9C88", Offset = "0x71D5C88", VA = "0x71D9C88", Slot = "7")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0x71D9C8C", Offset = "0x71D5C8C", VA = "0x71D9C8C", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6005F80")]
		[Address(RVA = "0x71D9C90", Offset = "0x71D5C90", VA = "0x71D9C90", Slot = "9")]
		public virtual void SetVisible(bool value)
		{
		}

		[Token(Token = "0x6005F81")]
		[Address(RVA = "0x71D9CD4", Offset = "0x71D5CD4", VA = "0x71D9CD4", Slot = "10")]
		public virtual void VisibleImp(bool value)
		{
		}

		[Token(Token = "0x6005F82")]
		[Address(RVA = "0x71D9D64", Offset = "0x71D5D64", VA = "0x71D9D64", Slot = "11")]
		protected virtual void VisibleBefore(bool value)
		{
		}

		[Token(Token = "0x6005F84")]
		public T Get<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6005F85")]
		[Address(RVA = "0x71D9D70", Offset = "0x71D5D70", VA = "0x71D9D70")]
		public GameObject Get(string name)
		{
			return null;
		}

		[Token(Token = "0x6005F86")]
		public T GetComponen<T>(string path, [Optional] Transform parent) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6005F87")]
		public T GetComponen<T>(string path, Component parent) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6005F88")]
		public T GetComponen<T>(string path, GameObject parent) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6005F89")]
		[Address(RVA = "0x71D9E9C", Offset = "0x71D5E9C", VA = "0x71D9E9C")]
		protected void HideAllObject()
		{
		}

		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0x71DA000", Offset = "0x71D6000", VA = "0x71DA000")]
		protected void ShowObject(params GameObject[] obj)
		{
		}

		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0x71DA064", Offset = "0x71D6064", VA = "0x71DA064", Slot = "12")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6005F8C")]
		[Address(RVA = "0x71DA078", Offset = "0x71D6078", VA = "0x71DA078")]
		public void SetSpriteBySingle(Image img, string location, bool autoSetSize = false)
		{
		}

		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0x71DA2F0", Offset = "0x71D62F0", VA = "0x71DA2F0")]
		public void SetTextures(RawImage rawImagem, string textureLocation)
		{
		}

		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0x71DA554", Offset = "0x71D6554", VA = "0x71DA554")]
		public void SetSprite(Image image, string spriteName, string atlasName, bool autoSetSize = false)
		{
		}

		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0x71DA7D8", Offset = "0x71D67D8", VA = "0x71DA7D8")]
		public void SetSprite(SpriteRenderer spriteRenderer, string spriteName, string atlasName, bool autoSetSize = false)
		{
		}

		[Token(Token = "0x6005F90")]
		[Address(RVA = "0x71DAA5C", Offset = "0x71D6A5C", VA = "0x71DAA5C")]
		public void ReleaseDynamicResLoad()
		{
		}

		[Token(Token = "0x6005F91")]
		[Address(RVA = "0x71DABB8", Offset = "0x71D6BB8", VA = "0x71DABB8")]
		public void ReleaseCustomResLoad()
		{
		}

		[Token(Token = "0x6005F92")]
		[Address(RVA = "0x71DAD14", Offset = "0x71D6D14", VA = "0x71DAD14")]
		public void SetCustomResLoadHandler(Object obj, AssetOperationHandle loadHandle)
		{
		}

		[Token(Token = "0x6005F93")]
		[Address(RVA = "0x71DAF60", Offset = "0x71D6F60", VA = "0x71DAF60")]
		public UIObject()
		{
		}
	}
}
