using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

[Token(Token = "0x20000D2")]
public class SubGameChaosTrailsBuffItem : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private struct _003CRefreshVisuals_003Ed__22 : IAsyncStateMachine
	{
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SubGameBuffConfig config;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int loadVersion;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SubGameChaosTrailsBuffItem _003C_003E4__this;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UniTask<Sprite>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x3E41858", Offset = "0x3E3D858", VA = "0x3E41858", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x3E41F54", Offset = "0x3E3DF54", VA = "0x3E41F54", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform cardRoot;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float floatAmplitude;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float floatHalfDuration;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image bg;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image icon;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI buffName;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private TextMeshProUGUI des;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Tween _floatTween;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2 _cardRootOriginPos;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool _hasCardRootOriginPos;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int _floatPhaseIndex;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _loadVersion;

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x3E4128C", Offset = "0x3E3D28C", VA = "0x3E4128C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x3E41320", Offset = "0x3E3D320", VA = "0x3E41320")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x3E41494", Offset = "0x3E3D494", VA = "0x3E41494")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x3E4154C", Offset = "0x3E3D54C", VA = "0x3E4154C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x3E41554", Offset = "0x3E3D554", VA = "0x3E41554")]
	public void SetData(int buffId)
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x3E417FC", Offset = "0x3E3D7FC", VA = "0x3E417FC")]
	public void SetFloatPhaseIndex(int index)
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x3E41290", Offset = "0x3E3D290", VA = "0x3E41290")]
	private void CacheCardRootOriginPos()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x3E41324", Offset = "0x3E3D324", VA = "0x3E41324")]
	private void StartFloatTween()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x3E4149C", Offset = "0x3E3D49C", VA = "0x3E4149C")]
	private void StopFloatTween(bool resetPos)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x3E41828", Offset = "0x3E3D828", VA = "0x3E41828")]
	private float GetFloatPhase()
	{
		return default;
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x3E4176C", Offset = "0x3E3D76C", VA = "0x3E4176C")]
	[AsyncStateMachine(typeof(_003CRefreshVisuals_003Ed__22))]
	private UniTaskVoid RefreshVisuals(SubGameBuffConfig config, int loadVersion)
	{
		return default;
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x3E41844", Offset = "0x3E3D844", VA = "0x3E41844")]
	public SubGameChaosTrailsBuffItem()
	{
	}
}
