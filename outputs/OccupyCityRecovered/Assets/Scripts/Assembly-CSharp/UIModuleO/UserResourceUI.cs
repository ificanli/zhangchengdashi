using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000BF5")]
	public class UserResourceUI : UserResourceUIComponents
	{
		[Token(Token = "0x400569A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string resId;

		[Token(Token = "0x400569B")]
		[FieldOffset(Offset = "0x60")]
		private float oriScale;

		[Token(Token = "0x400569C")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine co;

		[Token(Token = "0x400569D")]
		[FieldOffset(Offset = "0x70")]
		private bool isAniIng;

		[Token(Token = "0x400569E")]
		[FieldOffset(Offset = "0x74")]
		private int endNum;

		[Token(Token = "0x400569F")]
		[FieldOffset(Offset = "0x78")]
		private string endStr;

		[Token(Token = "0x40056A0")]
		[FieldOffset(Offset = "0x80")]
		private Tween _tween;

		[Token(Token = "0x17000CEE")]
		public string ResourceId
		{
			[Token(Token = "0x60049F8")]
			[Address(RVA = "0x42531B4", Offset = "0x424F1B4", VA = "0x42531B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CEF")]
		public RectTransform IconRect
		{
			[Token(Token = "0x60049F9")]
			[Address(RVA = "0x42509EC", Offset = "0x424C9EC", VA = "0x42509EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60049FA")]
		[Address(RVA = "0x4253284", Offset = "0x424F284", VA = "0x4253284")]
		internal void SetResourceId(string id)
		{
		}

		[Token(Token = "0x60049FB")]
		[Address(RVA = "0x425328C", Offset = "0x424F28C", VA = "0x425328C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60049FC")]
		[Address(RVA = "0x425195C", Offset = "0x424D95C", VA = "0x425195C")]
		public void ChangeScaleToOri()
		{
		}

		[Token(Token = "0x60049FD")]
		[Address(RVA = "0x42533A0", Offset = "0x424F3A0", VA = "0x42533A0", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x60049FE")]
		[Address(RVA = "0x4250E6C", Offset = "0x424CE6C", VA = "0x4250E6C")]
		public void DoDiceCountAni(string addNum, int naturalCap)
		{
		}

		[Token(Token = "0x60049FF")]
		[Address(RVA = "0x42534EC", Offset = "0x424F4EC", VA = "0x42534EC")]
		private static int ParseDiceDisplayCount(string text)
		{
			return default;
		}

		[Token(Token = "0x6004A00")]
		[Address(RVA = "0x425356C", Offset = "0x424F56C", VA = "0x425356C")]
		private static string FormatDiceDisplayCount(int count, int naturalCap)
		{
			return null;
		}

		[Token(Token = "0x6004A01")]
		[Address(RVA = "0x4251FFC", Offset = "0x424DFFC", VA = "0x4251FFC")]
		public static string FormatDiceDisplayCountForPanel(int count, int naturalCap)
		{
			return null;
		}

		[Token(Token = "0x6004A02")]
		[Address(RVA = "0x42510C8", Offset = "0x424D0C8", VA = "0x42510C8")]
		public void DoAni(string num, float aniTIme)
		{
		}

		[Token(Token = "0x6004A03")]
		[Address(RVA = "0x4253760", Offset = "0x424F760", VA = "0x4253760", Slot = "12")]
		protected override void OnButtonExtendUserResourceUIClicked()
		{
		}

		[Token(Token = "0x6004A04")]
		[Address(RVA = "0x425358C", Offset = "0x424F58C", VA = "0x425358C")]
		private void ScrollNumber(int fromVal, int toVal, float dur, bool isHasK = false, bool isHasM = false)
		{
		}

		[Token(Token = "0x6004A05")]
		[Address(RVA = "0x4253B28", Offset = "0x424FB28", VA = "0x4253B28")]
		private void KillTween(object o)
		{
		}

		[Token(Token = "0x6004A06")]
		[Address(RVA = "0x4253B94", Offset = "0x424FB94", VA = "0x4253B94", Slot = "11")]
		protected override void BindButtonEvent()
		{
		}

		[Token(Token = "0x6004A07")]
		[Address(RVA = "0x4253B98", Offset = "0x424FB98", VA = "0x4253B98")]
		public UserResourceUI()
		{
		}
	}
}
