using System;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UIModuleO;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

[Token(Token = "0x20000C8")]
public class CumulativeRewardItem : MonoBehaviour
{
	[Token(Token = "0x400043E")]
	private const int RewardTypeBaseRes = 0;

	[Token(Token = "0x400043F")]
	private const float ShakeAngle = 5f;

	[Token(Token = "0x4000440")]
	private const float ShakeDuration = 0.12f;

	[Token(Token = "0x4000441")]
	private const float StillDuration = 0.6f;

	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject eff;

	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform shake;

	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RewardItemUI reward;

	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject redDot;

	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button claimBtn;

	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject mask;

	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private TextMeshProUGUI dayText;

	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0x58")]
	private bool _canClaim;

	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x5C")]
	private int _rewardId;

	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x60")]
	private Action<int> _onClaim;

	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x68")]
	private Sequence _shakeSequence;

	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x70")]
	private bool _claimListenerRegistered;

	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x78")]
	private RectTransform _itemRect;

	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x80")]
	private float _cachedPosX;

	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x84")]
	private int _cachedConfigId;

	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x88")]
	private int _cachedRewardType;

	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x8C")]
	private int _cachedRewardNum;

	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x90")]
	private int _cachedNeedDays;

	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x94")]
	private bool _cachedCanClaim;

	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x95")]
	private bool _cachedIsClaimed;

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x3E3CA2C", Offset = "0x3E38A2C", VA = "0x3E3CA2C")]
	public void SetInfo(CumulativeRewardConfig config, bool canClaim, bool isClaimed, Action<int> onClaim)
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x3E3CC9C", Offset = "0x3E38C9C", VA = "0x3E3CC9C")]
	public void SetProgressPosition(float posX)
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x3E3D7FC", Offset = "0x3E397FC", VA = "0x3E3D7FC")]
	private void RefreshRewardDisplay(CumulativeRewardConfig config)
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x3E3D960", Offset = "0x3E39960", VA = "0x3E3D960")]
	private void RefreshStateUI(bool canClaim, bool isClaimed, bool stateChanged)
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x3E3DB14", Offset = "0x3E39B14", VA = "0x3E3DB14")]
	private void PlayShakeAnimation()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x3E3DD3C", Offset = "0x3E39D3C", VA = "0x3E3DD3C")]
	private void StopShakeAnimation()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x3E3DE24", Offset = "0x3E39E24", VA = "0x3E3DE24")]
	private void OnClickClaim()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x3E3DE4C", Offset = "0x3E39E4C", VA = "0x3E3DE4C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x3E3DE50", Offset = "0x3E39E50", VA = "0x3E3DE50")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x3E3DF34", Offset = "0x3E39F34", VA = "0x3E3DF34")]
	public CumulativeRewardItem()
	{
	}
}
