using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UIModuleO.UIAnim
{
	[Token(Token = "0x2000C4C")]
	public class ButtonExtend : Button
	{
		[Token(Token = "0x4005841")]
		private const float ClickBlockDuration = 0.3f;

		[Token(Token = "0x4005842")]
		[FieldOffset(Offset = "0x108")]
		public bool isCloseAnim;

		[Token(Token = "0x4005843")]
		[FieldOffset(Offset = "0x109")]
		public bool isCloseSfx;

		[Token(Token = "0x4005844")]
		[FieldOffset(Offset = "0x10C")]
		public HapticTypes clickVibrateLevel;

		[Token(Token = "0x4005845")]
		[FieldOffset(Offset = "0x110")]
		private bool _isPointerDown;

		[Token(Token = "0x4005846")]
		[FieldOffset(Offset = "0x111")]
		private bool _isClickBlockedThisPress;

		[Token(Token = "0x4005847")]
		[FieldOffset(Offset = "0x118")]
		private Tweener _clickTweener;

		[Token(Token = "0x4005848")]
		[FieldOffset(Offset = "0x120")]
		private Tweener _clickAreaTweener;

		[Token(Token = "0x4005849")]
		[FieldOffset(Offset = "0x128")]
		private Action _onPointerDown;

		[Token(Token = "0x400584A")]
		[FieldOffset(Offset = "0x130")]
		private Action _onPointerUp;

		[Token(Token = "0x400584B")]
		[FieldOffset(Offset = "0x138")]
		private float _beginScale;

		[Token(Token = "0x400584C")]
		[FieldOffset(Offset = "0x140")]
		private Image _clickAreaImage;

		[Token(Token = "0x400584D")]
		[FieldOffset(Offset = "0x148")]
		private float _beginClickAreaScale;

		[Token(Token = "0x400584E")]
		[FieldOffset(Offset = "0x150")]
		private RectTransform _rectTransform;

		[Token(Token = "0x400584F")]
		[FieldOffset(Offset = "0x158")]
		private bool _enableClickAreaImage;

		[Token(Token = "0x4005850")]
		[FieldOffset(Offset = "0x15C")]
		private float _nextAllowClickTime;

		[Token(Token = "0x17000D88")]
		public Action OnPointerDownAction
		{
			[Token(Token = "0x6004C2D")]
			[Address(RVA = "0x4274AE0", Offset = "0x4270AE0", VA = "0x4274AE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C2E")]
			[Address(RVA = "0x4274AE8", Offset = "0x4270AE8", VA = "0x4274AE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000D89")]
		public Action OnPointerUpAction
		{
			[Token(Token = "0x6004C2F")]
			[Address(RVA = "0x4274AF0", Offset = "0x4270AF0", VA = "0x4274AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C30")]
			[Address(RVA = "0x4274AF8", Offset = "0x4270AF8", VA = "0x4274AF8")]
			set
			{
			}
		}

		[Token(Token = "0x6004C2A")]
		[Address(RVA = "0x4274748", Offset = "0x4270748", VA = "0x4274748", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0x42747C8", Offset = "0x42707C8", VA = "0x42747C8")]
		private void CreateClickAreaImage()
		{
		}

		[Token(Token = "0x6004C2C")]
		[Address(RVA = "0x4274AD8", Offset = "0x4270AD8", VA = "0x4274AD8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x4274B00", Offset = "0x4270B00", VA = "0x4274B00", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004C32")]
		[Address(RVA = "0x4274E9C", Offset = "0x4270E9C", VA = "0x4274E9C", Slot = "35")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004C33")]
		[Address(RVA = "0x427502C", Offset = "0x427102C", VA = "0x427502C", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004C34")]
		[Address(RVA = "0x4275048", Offset = "0x4271048", VA = "0x4275048", Slot = "41")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004C35")]
		[Address(RVA = "0x4275128", Offset = "0x4271128", VA = "0x4275128", Slot = "42")]
		public override void OnSubmit(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6004C36")]
		[Address(RVA = "0x4274EB8", Offset = "0x4270EB8", VA = "0x4274EB8")]
		private void OnClickEnd()
		{
		}

		[Token(Token = "0x6004C37")]
		[Address(RVA = "0x42750AC", Offset = "0x42710AC", VA = "0x42750AC")]
		private bool CanTriggerClick()
		{
			return default;
		}

		[Token(Token = "0x6004C38")]
		[Address(RVA = "0x4274E78", Offset = "0x4270E78", VA = "0x4274E78")]
		private bool IsClickBlocked()
		{
			return default;
		}

		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x4275100", Offset = "0x4271100", VA = "0x4275100")]
		private void MarkClickBlocked()
		{
		}

		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x427517C", Offset = "0x427117C", VA = "0x427517C")]
		public Tween DOScale(float p0, double p1)
		{
			return null;
		}

		[Token(Token = "0x6004C3B")]
		[Address(RVA = "0x42751B4", Offset = "0x42711B4", VA = "0x42751B4")]
		public ButtonExtend()
		{
		}
	}
}
