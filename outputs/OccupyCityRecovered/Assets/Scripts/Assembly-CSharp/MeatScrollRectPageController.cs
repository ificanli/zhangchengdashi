using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20000CA")]
public class MeatScrollRectPageController : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x20")]
	public ScrollRect scrollRect;

	[Token(Token = "0x400045D")]
	[FieldOffset(Offset = "0x28")]
	private Tween moveTween;

	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x30")]
	private readonly float snapThreshold;

	[Token(Token = "0x400045F")]
	[FieldOffset(Offset = "0x34")]
	private readonly float snapDuration;

	[Token(Token = "0x4000460")]
	[FieldOffset(Offset = "0x38")]
	public Action onBeforePageChange;

	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x40")]
	public Action<int> onPageChangeComplete;

	[Token(Token = "0x4000462")]
	[FieldOffset(Offset = "0x48")]
	private int _currentPageIndex;

	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x50")]
	public List<string> pageNames;

	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<string, float> pagePositions;

	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0x60")]
	public RectTransform pointBox;

	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x68")]
	private RectTransform buttonContainer;

	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x70")]
	private float segmentWidth;

	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x74")]
	public int pageCount;

	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x78")]
	public float offsetX;

	[Token(Token = "0x17000038")]
	public int CurrentPageIndex
	{
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x3E3E554", Offset = "0x3E3A554", VA = "0x3E3E554")]
		get
		{
			return _currentPageIndex;
		}
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x3E3E55C", Offset = "0x3E3A55C", VA = "0x3E3E55C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x3E3E6B8", Offset = "0x3E3A6B8", VA = "0x3E3E6B8", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x3E3E6F8", Offset = "0x3E3A6F8", VA = "0x3E3E6F8", Slot = "5")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x3E3E6FC", Offset = "0x3E3A6FC", VA = "0x3E3E6FC")]
	private void HandlePageSnap()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x3E3EA48", Offset = "0x3E3AA48", VA = "0x3E3EA48")]
	private void SnapToPage(int pageIndex, bool playAnime)
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x3E3ECF8", Offset = "0x3E3ACF8", VA = "0x3E3ECF8")]
	public void JumpToPage(string pageName, bool playAnim)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x3E3ED9C", Offset = "0x3E3AD9C", VA = "0x3E3ED9C")]
	public void OnScrollChanged(Vector2 scrollPos)
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x3E3EFCC", Offset = "0x3E3AFCC", VA = "0x3E3EFCC")]
	public MeatScrollRectPageController()
	{
	}
}
