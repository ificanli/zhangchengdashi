using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000071")]
	public class TooltipListener : MonoBehaviour
	{
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x20")]
		private ITooltipManager manager;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x28")]
		private ITooltipContent hoveredDrawer;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x30")]
		private PointerEventData hoveringPointer;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x38")]
		private float hoveredDrawerTooltipShowTime;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x467A5D4", Offset = "0x46765D4", VA = "0x467A5D4")]
		public void Initialize(ITooltipManager manager)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x467A5DC", Offset = "0x46765DC", VA = "0x467A5DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x467A47C", Offset = "0x467647C", VA = "0x467A47C")]
		internal void OnDrawerHovered(ITooltipContent drawer, PointerEventData pointer, bool isHovering)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x467A8E8", Offset = "0x46768E8", VA = "0x467A8E8")]
		public TooltipListener()
		{
		}
	}
}
