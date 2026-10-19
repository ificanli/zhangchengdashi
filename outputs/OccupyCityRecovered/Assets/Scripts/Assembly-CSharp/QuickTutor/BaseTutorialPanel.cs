using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor
{
	[Token(Token = "0x2000C97")]
	public class BaseTutorialPanel : BaseTutorialPanelComponents, ICanvasRaycastFilter
	{
		[Token(Token = "0x4005A67")]
		[FieldOffset(Offset = "0x80")]
		private List<ITutorialPointInfo> _maskPoints;

		[Token(Token = "0x4005A68")]
		[FieldOffset(Offset = "0x88")]
		private List<ITutorialPointInfo> _slideAnimPoints;

		[Token(Token = "0x4005A69")]
		[FieldOffset(Offset = "0x90")]
		private List<RectTransform> _handRects;

		[Token(Token = "0x4005A6A")]
		[FieldOffset(Offset = "0x98")]
		private RectTransform _introRect;

		[Token(Token = "0x4005A6B")]
		[FieldOffset(Offset = "0xA0")]
		private TutorialActionType _currentTutorialActionType;

		[Token(Token = "0x4005A6C")]
		[FieldOffset(Offset = "0xA8")]
		private TutorialMaskProperties _tutorialMask;

		[Token(Token = "0x4005A6D")]
		[FieldOffset(Offset = "0xB0")]
		private Sequence _handAnim;

		[Token(Token = "0x4005A6E")]
		[FieldOffset(Offset = "0xB8")]
		private Tweener _textTweener;

		[Token(Token = "0x4005A6F")]
		[FieldOffset(Offset = "0xC0")]
		private Color _maskDefaultColor;

		[Token(Token = "0x4005A70")]
		[FieldOffset(Offset = "0xD0")]
		private float _handMoveSpeed;

		[Token(Token = "0x4005A71")]
		[FieldOffset(Offset = "0xD4")]
		private float _texAnimSpeed;

		[Token(Token = "0x4005A72")]
		[FieldOffset(Offset = "0xD8")]
		protected float _textAnimStartDelay;

		[Token(Token = "0x4005A73")]
		[FieldOffset(Offset = "0xDC")]
		protected float _inputLockEndTime;

		[Token(Token = "0x4005A74")]
		[FieldOffset(Offset = "0xE0")]
		private float _currentMaskType;

		[Token(Token = "0x4005A75")]
		[FieldOffset(Offset = "0xE4")]
		private float _textDefaultPosY;

		[Token(Token = "0x4005A76")]
		[FieldOffset(Offset = "0xE8")]
		private bool _isTexAnimPlaying;

		[Token(Token = "0x4005A77")]
		[FieldOffset(Offset = "0xE9")]
		private bool _isOpenMask;

		[Token(Token = "0x4005A78")]
		[FieldOffset(Offset = "0xEA")]
		private bool _isDragStart;

		[Token(Token = "0x4005A79")]
		[FieldOffset(Offset = "0xF0")]
		private ITutorialPointInfo _clickPoint;

		[Token(Token = "0x4005A7A")]
		[FieldOffset(Offset = "0xF8")]
		private bool _isWaitTriggerEvent;

		[Token(Token = "0x4005A7B")]
		[FieldOffset(Offset = "0xF9")]
		private bool _isFastBlockMode;

		[Token(Token = "0x4005A7C")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform _targetHighlightImage;

		[Token(Token = "0x4005A7D")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Vector2 _targetHighlightSizeOffset;

		[Token(Token = "0x6004EFA")]
		[Address(RVA = "0x42B07E8", Offset = "0x42AC7E8", VA = "0x42B07E8", Slot = "15")]
		protected virtual void Base_Init()
		{
		}

		[Token(Token = "0x6004EFB")]
		[Address(RVA = "0x42B0D48", Offset = "0x42ACD48", VA = "0x42B0D48")]
		protected void StartInputLock(float duration)
		{
		}

		[Token(Token = "0x6004EFC")]
		[Address(RVA = "0x42B0D88", Offset = "0x42ACD88", VA = "0x42B0D88", Slot = "16")]
		protected virtual void Base_LateUpdate()
		{
		}

		[Token(Token = "0x6004EFD")]
		[Address(RVA = "0x42B15E8", Offset = "0x42AD5E8", VA = "0x42B15E8", Slot = "17")]
		public virtual void Base_Open(params object[] args)
		{
		}

		[Token(Token = "0x6004EFE")]
		[Address(RVA = "0x42B07B8", Offset = "0x42AC7B8", VA = "0x42B07B8")]
		public void EnterFastBlockMode()
		{
		}

		[Token(Token = "0x6004EFF")]
		[Address(RVA = "0x42B07CC", Offset = "0x42AC7CC", VA = "0x42B07CC")]
		public void ExitFastBlockMode()
		{
		}

		[Token(Token = "0x6004F00")]
		[Address(RVA = "0x42B1ECC", Offset = "0x42ADECC", VA = "0x42B1ECC", Slot = "18")]
		public virtual void Base_Close()
		{
		}

		[Token(Token = "0x6004F01")]
		[Address(RVA = "0x42B1F18", Offset = "0x42ADF18", VA = "0x42B1F18", Slot = "19")]
		protected virtual void Base_SetHandTapAnim()
		{
		}

		[Token(Token = "0x6004F02")]
		[Address(RVA = "0x42B21DC", Offset = "0x42AE1DC", VA = "0x42B21DC", Slot = "20")]
		protected virtual void Base_SetSlideTapAnim()
		{
		}

		[Token(Token = "0x6004F03")]
		[Address(RVA = "0x42B253C", Offset = "0x42AE53C", VA = "0x42B253C", Slot = "14")]
		public bool IsRaycastLocationValid(Vector2 clickPos, Camera eventCamera)
		{
			return default;
		}

		[Token(Token = "0x6004F04")]
		[Address(RVA = "0x42B273C", Offset = "0x42AE73C", VA = "0x42B273C")]
		private bool ClickWithinAnyRects(Vector3 pos, out ITutorialPointInfo clickTrans)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BaseTutorialPanel.ClickWithinAnyRects RVA=0x42B273C Token=0x6004F04");
}

		[Token(Token = "0x6004F05")]
		[Address(RVA = "0x42B1838", Offset = "0x42AD838", VA = "0x42B1838")]
		private void SetMask()
		{
		}

		[Token(Token = "0x6004F06")]
		[Address(RVA = "0x42B1914", Offset = "0x42AD914", VA = "0x42B1914")]
		private void SetTutorialTex(string text, float textPos)
		{
		}

		[Token(Token = "0x6004F07")]
		[Address(RVA = "0x42B1DE4", Offset = "0x42ADDE4", VA = "0x42B1DE4")]
		private void SetHandAnim()
		{
		}

		[Token(Token = "0x6004F08")]
		[Address(RVA = "0x42B2BEC", Offset = "0x42AEBEC", VA = "0x42B2BEC")]
		private void EndCurrentTutorial(object obj)
		{
		}

		[Token(Token = "0x6004F09")]
		[Address(RVA = "0x42B2D8C", Offset = "0x42AED8C", VA = "0x42B2D8C", Slot = "12")]
		protected override void OnButtonIntroBackClicked()
		{
		}

		[Token(Token = "0x6004F0A")]
		[Address(RVA = "0x42B2DD4", Offset = "0x42AEDD4", VA = "0x42B2DD4")]
		public BaseTutorialPanel()
		{
		}
	}
}
