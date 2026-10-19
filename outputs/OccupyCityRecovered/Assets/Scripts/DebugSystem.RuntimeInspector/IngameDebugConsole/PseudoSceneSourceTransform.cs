using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x200000D")]
	public class PseudoSceneSourceTransform : MonoBehaviour
	{
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RuntimeHierarchy m_hierarchy;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_sceneName;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_hideOnDisable;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<Transform> childrenCurrent;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<Transform> childrenNew;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x48")]
		private bool updateChildren;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x49")]
		private bool isEnabled;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x4A")]
		private bool isQuitting;

		[Token(Token = "0x17000021")]
		public RuntimeHierarchy Hierarchy
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x465538C", Offset = "0x465138C", VA = "0x465538C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x4655394", Offset = "0x4651394", VA = "0x4655394")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public string SceneName
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x465570C", Offset = "0x465170C", VA = "0x465570C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x4655714", Offset = "0x4651714", VA = "0x4655714")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool HideOnDisable
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x465575C", Offset = "0x465175C", VA = "0x465575C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x4655764", Offset = "0x4651764", VA = "0x4655764")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		private bool ShouldUpdateChildren
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4655790", Offset = "0x4651790", VA = "0x4655790")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4655820", Offset = "0x4651820", VA = "0x4655820")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x46558EC", Offset = "0x46518EC", VA = "0x46558EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x46558F8", Offset = "0x46518F8", VA = "0x46558F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4655914", Offset = "0x4651914", VA = "0x4655914")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x46559B8", Offset = "0x46519B8", VA = "0x46559B8")]
		private void OnApplicationQuitting()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x46559C4", Offset = "0x46519C4", VA = "0x46559C4")]
		private void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x46559D0", Offset = "0x46519D0", VA = "0x46559D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x465562C", Offset = "0x465162C", VA = "0x465562C")]
		private void AddChildrenToScene()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x4655428", Offset = "0x4651428", VA = "0x4655428")]
		private void RemoveChildrenFromScene()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x4655AF8", Offset = "0x4651AF8", VA = "0x4655AF8")]
		public PseudoSceneSourceTransform()
		{
		}
	}
}
