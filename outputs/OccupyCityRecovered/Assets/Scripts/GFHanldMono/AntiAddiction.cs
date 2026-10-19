using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DBTSDK;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000002")]
public class AntiAddiction : MonoBehaviour, IAntiAddiction
{
	[Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class _003CChangeAntiAddictionTxtDoT_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		public AntiAddiction _003C_003E4__this;

		[Token(Token = "0x17000001")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x706681C", Offset = "0x706281C", VA = "0x706681C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000002")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x706685C", Offset = "0x706285C", VA = "0x706685C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x70664D8", Offset = "0x70624D8", VA = "0x70664D8")]
		[DebuggerHidden]
		public _003CChangeAntiAddictionTxtDoT_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x706673C", Offset = "0x706273C", VA = "0x706673C", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x7066740", Offset = "0x7062740", VA = "0x7066740", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x706681C", Offset = "0x706281C", VA = "0x706681C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x7066824", Offset = "0x7062824", VA = "0x7066824", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x706685C", Offset = "0x706285C", VA = "0x706685C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	private bool IsCanActive;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform AntiAddictionTxt;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	private string txtContent;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x38")]
	private Rect UIrect;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x48")]
	private Tweener AntiAddictionTxtTweener;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsCloseAntiAddiction;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x1")]
	private static bool IsShowAntiAddiction;

	[Token(Token = "0x4000008")]
	private const string tips1 = "抵制不良游戏,拒绝盗版游戏.注意自我保护,谨防受骗上当.适度游戏益脑,沉迷游戏伤身.合理安排时间,享受健康生活。";

	[Token(Token = "0x4000009")]
	private const string tipsBy8 = "抵制不良游戏,拒绝盗版游戏.注意自我保护,谨防受骗上当.适度游戏益脑,沉迷游戏伤身.合理安排时间,享受健康生活。本游戏适合8周岁(含)以上的用户使用，为了您的健康，请合理控制游戏时间。";

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x7065DB4", Offset = "0x7061DB4", VA = "0x7065DB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7065F50", Offset = "0x7061F50", VA = "0x7065F50", Slot = "4")]
	public void InitAntiAddiction(Transform parent, Rect UIrect, bool isTop, float OffsetY)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7066138", Offset = "0x7062138", VA = "0x7066138")]
	private void CheckCanShow()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x7066278", Offset = "0x7062278", VA = "0x7066278", Slot = "5")]
	public void ShowAntiAddiction(string ContentCorlor = "", string txtContent = "")
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x7066478", Offset = "0x7062478", VA = "0x7066478")]
	[IteratorStateMachine(typeof(_003CChangeAntiAddictionTxtDoT_003Ed__13))]
	private IEnumerator ChangeAntiAddictionTxtDoT()
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x7066500", Offset = "0x7062500", VA = "0x7066500", Slot = "6")]
	public void CloseAntiAddiction()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x70666EC", Offset = "0x70626EC", VA = "0x70666EC")]
	public AntiAddiction()
	{
	}
}
