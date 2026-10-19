using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x200091A")]
	[RequireComponent(typeof(RectTransform))]
	public class OfferShownTracker : MonoBehaviour
	{
		[Token(Token = "0x4004467")]
		private const float ReportInterval = 1f;

		[Token(Token = "0x4004468")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform _rect;

		[Token(Token = "0x4004469")]
		[FieldOffset(Offset = "0x28")]
		private Canvas _rootCanvas;

		[Token(Token = "0x400446A")]
		[FieldOffset(Offset = "0x30")]
		private string _productId;

		[Token(Token = "0x400446B")]
		[FieldOffset(Offset = "0x38")]
		private string _placement;

		[Token(Token = "0x400446C")]
		[FieldOffset(Offset = "0x40")]
		private bool _initialized;

		[Token(Token = "0x400446D")]
		[FieldOffset(Offset = "0x41")]
		private bool _reported;

		[Token(Token = "0x400446E")]
		[FieldOffset(Offset = "0x44")]
		private float _lastReportTime;

		[Token(Token = "0x60034A0")]
		[Address(RVA = "0x40AB0B0", Offset = "0x40A70B0", VA = "0x40AB0B0")]
		public static void Track(GameObject go, string productId, string placement)
		{
		}

		[Token(Token = "0x60034A1")]
		[Address(RVA = "0x40AB428", Offset = "0x40A7428", VA = "0x40AB428")]
		public void SetProductId(string productId, string placement)
		{
		}

		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x40AB7C0", Offset = "0x40A77C0", VA = "0x40AB7C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x40AB810", Offset = "0x40A7810", VA = "0x40AB810")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x40AB818", Offset = "0x40A7818", VA = "0x40AB818")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60034A5")]
		[Address(RVA = "0x40AB4DC", Offset = "0x40A74DC", VA = "0x40AB4DC")]
		private bool IsVisible()
		{
			return default;
		}

		[Token(Token = "0x60034A6")]
		[Address(RVA = "0x40AB72C", Offset = "0x40A772C", VA = "0x40AB72C")]
		private void Report()
		{
		}

		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x40AB850", Offset = "0x40A7850", VA = "0x40AB850")]
		public OfferShownTracker()
		{
		}
	}
}
