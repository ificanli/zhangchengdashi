using System;
using GameModule;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000ADA")]
	public class ResourceObtainGuideWayItem : MonoBehaviour
	{
		[Token(Token = "0x4004F8F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI title;

		[Token(Token = "0x4004F90")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI description;

		[Token(Token = "0x4004F91")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button goBtn;

		[Token(Token = "0x4004F92")]
		[FieldOffset(Offset = "0x38")]
		private ResourceObtainGuideManager.ResourceGuideWayData _wayData;

		[Token(Token = "0x4004F93")]
		[FieldOffset(Offset = "0x40")]
		private ResourceObtainGuideManager.ResourceGuidePanelData _panelData;

		[Token(Token = "0x4004F94")]
		[FieldOffset(Offset = "0x48")]
		private Action<ResourceObtainGuideManager.ResourceGuideWayData, ResourceObtainGuideManager.ResourceGuidePanelData> _clickAction;

		[Token(Token = "0x6004191")]
		[Address(RVA = "0x41BA104", Offset = "0x41B6104", VA = "0x41BA104")]
		public void Setup(ResourceObtainGuideManager.ResourceGuideWayData wayData, ResourceObtainGuideManager.ResourceGuidePanelData panelData, Action<ResourceObtainGuideManager.ResourceGuideWayData, ResourceObtainGuideManager.ResourceGuidePanelData> clickAction)
		{
		}

		[Token(Token = "0x6004192")]
		[Address(RVA = "0x41BDA60", Offset = "0x41B9A60", VA = "0x41BDA60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6004193")]
		[Address(RVA = "0x41BDB38", Offset = "0x41B9B38", VA = "0x41BDB38")]
		private void OnGoBtnClicked()
		{
		}

		[Token(Token = "0x6004194")]
		[Address(RVA = "0x41BDB60", Offset = "0x41B9B60", VA = "0x41BDB60")]
		public ResourceObtainGuideWayItem()
		{
		}
	}
}
