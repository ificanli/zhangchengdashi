using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20007B7")]
	public class UpgradeCardPanel : UpgradeCardPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007B9")]
		[CompilerGenerated]
		private struct _003CAddRuneStone_003Ed__40 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RareLevel rare;

			[Token(Token = "0x4003BBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x6002AC9")]
			[Address(RVA = "0x3FDFCFC", Offset = "0x3FDBCFC", VA = "0x3FDFCFC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002ACA")]
			[Address(RVA = "0x3FDFFEC", Offset = "0x3FDBFEC", VA = "0x3FDFFEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x20007BA")]
		[CompilerGenerated]
		private sealed class _003CArcMoveCoroutine_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4003BBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4003BC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4003BC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x4003BC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 _003CstartPos_003E5__2;

			[Token(Token = "0x4003BC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 _003CendPos_003E5__3;

			[Token(Token = "0x4003BC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 _003CcontrolPoint_003E5__4;

			[Token(Token = "0x4003BC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float _003Celapsed_003E5__5;

			[Token(Token = "0x1700044A")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6002ACE")]
				[Address(RVA = "0x3FE00EC", Offset = "0x3FDC0EC", VA = "0x3FE00EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700044B")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6002AD0")]
				[Address(RVA = "0x3FE012C", Offset = "0x3FDC12C", VA = "0x3FE012C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6002ACB")]
			[Address(RVA = "0x3FDDEDC", Offset = "0x3FD9EDC", VA = "0x3FDDEDC")]
			[DebuggerHidden]
			public _003CArcMoveCoroutine_003Ed__45(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002ACC")]
			[Address(RVA = "0x3FDFFF8", Offset = "0x3FDBFF8", VA = "0x3FDFFF8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6002ACD")]
			[Address(RVA = "0x3FDFFFC", Offset = "0x3FDBFFC", VA = "0x3FDFFFC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6002ACE")]
			[Address(RVA = "0x3FE00EC", Offset = "0x3FDC0EC", VA = "0x3FE00EC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6002ACF")]
			[Address(RVA = "0x3FE00F4", Offset = "0x3FDC0F4", VA = "0x3FE00F4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6002AD0")]
			[Address(RVA = "0x3FE012C", Offset = "0x3FDC12C", VA = "0x3FE012C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007BB")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x6002AD1")]
			[Address(RVA = "0x3FE0134", Offset = "0x3FDC134", VA = "0x3FE0134", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002AD2")]
			[Address(RVA = "0x3FE0398", Offset = "0x3FDC398", VA = "0x3FE0398", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007BC")]
		[CompilerGenerated]
		private struct _003CGeneralCardInit_003Ed__22 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x4003BCC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002AD3")]
			[Address(RVA = "0x3FE03A4", Offset = "0x3FDC3A4", VA = "0x3FE03A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002AD4")]
			[Address(RVA = "0x3FE08E4", Offset = "0x3FDC8E4", VA = "0x3FE08E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007BD")]
		[CompilerGenerated]
		private struct _003CHideCallBack_003Ed__62 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BCD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BCE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BCF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x6002AD5")]
			[Address(RVA = "0x3FE08F0", Offset = "0x3FDC8F0", VA = "0x3FE08F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002AD6")]
			[Address(RVA = "0x3FE0A34", Offset = "0x3FDCA34", VA = "0x3FE0A34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007BE")]
		[CompilerGenerated]
		private struct _003CLoadPrefab_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x4003BD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<(GameObject, GameObject)>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002AD7")]
			[Address(RVA = "0x3FE0A40", Offset = "0x3FDCA40", VA = "0x3FE0A40", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002AD8")]
			[Address(RVA = "0x3FE0F90", Offset = "0x3FDCF90", VA = "0x3FE0F90", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007BF")]
		[CompilerGenerated]
		private struct _003COnButtonBtnRoleClicked_003Ed__55 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x6002AD9")]
			[Address(RVA = "0x3FE0F9C", Offset = "0x3FDCF9C", VA = "0x3FE0F9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002ADA")]
			[Address(RVA = "0x3FE111C", Offset = "0x3FDD11C", VA = "0x3FE111C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007C0")]
		[CompilerGenerated]
		private struct _003COnButtonBtnTowerClicked_003Ed__56 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x6002ADB")]
			[Address(RVA = "0x3FE1128", Offset = "0x3FDD128", VA = "0x3FE1128", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002ADC")]
			[Address(RVA = "0x3FE12D0", Offset = "0x3FDD2D0", VA = "0x3FE12D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007C1")]
		[CompilerGenerated]
		private struct _003CPVESetActive_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x4003BDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002ADD")]
			[Address(RVA = "0x3FE12DC", Offset = "0x3FDD2DC", VA = "0x3FE12DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002ADE")]
			[Address(RVA = "0x3FE15B4", Offset = "0x3FDD5B4", VA = "0x3FE15B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007C2")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x4003BE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4003BE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<UniTask> _003CloadTasks_003E5__2;

			[Token(Token = "0x4003BE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private RareLevel _003CrareLevel_003E5__3;

			[Token(Token = "0x4003BE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003BE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002ADF")]
			[Address(RVA = "0x3FE15C0", Offset = "0x3FDD5C0", VA = "0x3FE15C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002AE0")]
			[Address(RVA = "0x3FE2CB0", Offset = "0x3FDECB0", VA = "0x3FE2CB0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007C3")]
		[CompilerGenerated]
		private struct _003CUpdate_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x6002AE1")]
			[Address(RVA = "0x3FE2CBC", Offset = "0x3FDECBC", VA = "0x3FE2CBC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002AE2")]
			[Address(RVA = "0x3FE2E08", Offset = "0x3FDEE08", VA = "0x3FE2E08", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007C4")]
		[CompilerGenerated]
		private struct _003CUpdateOtherUI_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4003BE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003BEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003BEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UpgradeCardPanel _003C_003E4__this;

			[Token(Token = "0x4003BEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GlobalHeroCardInfo _003Cinfo_003E5__2;

			[Token(Token = "0x4003BED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x4003BEE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4003BEF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002AE3")]
			[Address(RVA = "0x3FE2E14", Offset = "0x3FDEE14", VA = "0x3FE2E14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002AE4")]
			[Address(RVA = "0x3FE58C4", Offset = "0x3FE18C4", VA = "0x3FE58C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<GameObject> _objList;

		[Token(Token = "0x4003BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly List<GameObject> _talentList;

		[Token(Token = "0x4003BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private UserHeroCardData _data;

		[Token(Token = "0x4003BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private GameObject _resProperty;

		[Token(Token = "0x4003BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private GameObject _resTalent;

		[Token(Token = "0x4003BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private int requireDiamond;

		[Token(Token = "0x4003BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private Dictionary<int, List<ImgTalentItem>> allTalentItem;

		[Token(Token = "0x4003BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool isRolePage;

		[Token(Token = "0x4003BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x229")]
		private bool _isUnlock;

		[Token(Token = "0x4003BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[SerializeField]
		private ButtonExtend ButtonExtendBtnResetLevel;

		[Token(Token = "0x4003BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Sequence se;

		[Token(Token = "0x4003BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private List<int> customCardUnLockTalentId;

		[Token(Token = "0x4003BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public bool IsEnemyCustom;

		[Token(Token = "0x4003BAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private GameObject green;

		[Token(Token = "0x4003BAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private GameObject blue;

		[Token(Token = "0x4003BAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private GameObject violet;

		[Token(Token = "0x4003BB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private GameObject gold;

		[Token(Token = "0x4003BB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private Sequence talentRedDotSe;

		[Token(Token = "0x4003BB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private List<GameObject> _cachedPropertyItems;

		[Token(Token = "0x4003BB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private Tween tw;

		[Token(Token = "0x4003BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private Tween tw2;

		[Token(Token = "0x4003BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private Coroutine co;

		[Token(Token = "0x4003BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Dictionary<int, List<ImgTalentItem>> _cachedTalentItems;

		[Token(Token = "0x4003BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private List<GameObject> _cachedLines;

		[Token(Token = "0x4003BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private CardTalentNodeData nowUpgradeNode;

		[Token(Token = "0x17000449")]
		public string NowPageCardId
		{
			[Token(Token = "0x6002A98")]
			[Address(RVA = "0x3FDBB70", Offset = "0x3FD7B70", VA = "0x3FDBB70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002A99")]
		[Address(RVA = "0x3FDBB8C", Offset = "0x3FD7B8C", VA = "0x3FDBB8C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__19))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002A9A")]
		[Address(RVA = "0x3FDBC18", Offset = "0x3FD7C18", VA = "0x3FDBC18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6002A9B")]
		[Address(RVA = "0x3FDBCF0", Offset = "0x3FD7CF0", VA = "0x3FDBCF0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__21))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0x3FDBD8C", Offset = "0x3FD7D8C", VA = "0x3FDBD8C")]
		[AsyncStateMachine(typeof(_003CGeneralCardInit_003Ed__22))]
		private void GeneralCardInit()
		{
		}

		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0x3FDBE1C", Offset = "0x3FD7E1C", VA = "0x3FDBE1C", Slot = "17")]
		protected override void OnButtonExtendGeneralCardBtnClicked()
		{
		}

		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0x3FDBF0C", Offset = "0x3FD7F0C", VA = "0x3FDBF0C")]
		[AsyncStateMachine(typeof(_003CLoadPrefab_003Ed__24))]
		private UniTask LoadPrefab()
		{
			return default;
		}

		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x3FDBF98", Offset = "0x3FD7F98", VA = "0x3FDBF98")]
		private void SetLayerRecursively(Transform objTransform, string layerName)
		{
		}

		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x3FDC31C", Offset = "0x3FD831C", VA = "0x3FDC31C")]
		private void UpdateCardCPUI()
		{
		}

		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0x3FDC96C", Offset = "0x3FD896C", VA = "0x3FDC96C")]
		private void UpdateTalentRedDot(object o)
		{
		}

		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0x3FDC9BC", Offset = "0x3FD89BC", VA = "0x3FDC9BC")]
		[AsyncStateMachine(typeof(_003CUpdate_003Ed__29))]
		private void Update()
		{
		}

		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x3FDCA48", Offset = "0x3FD8A48", VA = "0x3FDCA48")]
		[AsyncStateMachine(typeof(_003CPVESetActive_003Ed__30))]
		private void PVESetActive()
		{
		}

		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0x3FDCAD8", Offset = "0x3FD8AD8", VA = "0x3FDCAD8")]
		private static void ReorderList(List<RectTransform> list)
		{
		}

		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0x3FDCE4C", Offset = "0x3FD8E4C", VA = "0x3FDCE4C")]
		[AsyncStateMachine(typeof(_003CUpdateOtherUI_003Ed__32))]
		private void UpdateOtherUI()
		{
		}

		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0x3FDCEE0", Offset = "0x3FD8EE0", VA = "0x3FDCEE0")]
		private void UpdateGoGetButtonVisible()
		{
		}

		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x3FDCF34", Offset = "0x3FD8F34", VA = "0x3FDCF34")]
		private void UpdateResetLevelButtonVisible()
		{
		}

		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x3FDCFE4", Offset = "0x3FD8FE4", VA = "0x3FDCFE4")]
		private void OnResetLevelButtonClicked()
		{
		}

		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x3FDD118", Offset = "0x3FD9118", VA = "0x3FDD118")]
		private void UpdateRolePropertyItem()
		{
		}

		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x3FDD410", Offset = "0x3FD9410", VA = "0x3FDD410")]
		private int UpdateAllProperty()
		{
			return default;
		}

		[Token(Token = "0x6002AAB")]
		[Address(RVA = "0x3FDD620", Offset = "0x3FD9620", VA = "0x3FDD620", Slot = "19")]
		protected override void OnButtonExtendBtnUpgradeClicked()
		{
		}

		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x3FDDD74", Offset = "0x3FD9D74", VA = "0x3FDDD74")]
		[AsyncStateMachine(typeof(_003CAddRuneStone_003Ed__40))]
		private void AddRuneStone(RareLevel rare)
		{
		}

		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x3FDDE14", Offset = "0x3FD9E14", VA = "0x3FDDE14")]
		private void StartArcMotion()
		{
		}

		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0x3FDDE7C", Offset = "0x3FD9E7C", VA = "0x3FDDE7C")]
		[IteratorStateMachine(typeof(_003CArcMoveCoroutine_003Ed__45))]
		private IEnumerator ArcMoveCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6002AAF")]
		[Address(RVA = "0x3FDDF04", Offset = "0x3FD9F04", VA = "0x3FDDF04")]
		private Vector3 CalculateControlPoint(Vector3 start, Vector3 end, float height)
		{
			return default;
		}

		[Token(Token = "0x6002AB0")]
		[Address(RVA = "0x3FDDFB8", Offset = "0x3FD9FB8", VA = "0x3FDDFB8", Slot = "20")]
		protected override void OnButtonExtendBtnEquipClicked()
		{
		}

		[Token(Token = "0x6002AB1")]
		[Address(RVA = "0x3FDE068", Offset = "0x3FDA068", VA = "0x3FDE068")]
		private void UpdateBubble(string str, int count, bool isFetter)
		{
		}

		[Token(Token = "0x6002AB2")]
		[Address(RVA = "0x3FDE4CC", Offset = "0x3FDA4CC", VA = "0x3FDE4CC", Slot = "15")]
		protected override void OnButtonExtendBtnAtkWayTypeClicked()
		{
		}

		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0x3FDE780", Offset = "0x3FDA780", VA = "0x3FDE780", Slot = "16")]
		protected override void OnButtonExtendBtnFetterClicked()
		{
		}

		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0x3FDEB04", Offset = "0x3FDAB04", VA = "0x3FDEB04")]
		private void OnBtnTalentBtnTalentClicked(object o)
		{
		}

		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x3FDEEF4", Offset = "0x3FDAEF4", VA = "0x3FDEEF4")]
		private void Clear()
		{
		}

		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0x3FDF06C", Offset = "0x3FDB06C", VA = "0x3FDF06C", Slot = "18")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002AB7")]
		[Address(RVA = "0x3FDF090", Offset = "0x3FDB090", VA = "0x3FDF090")]
		public void UpdatePage(bool isRolePage)
		{
		}

		[Token(Token = "0x6002AB8")]
		[Address(RVA = "0x3FDF2E4", Offset = "0x3FDB2E4", VA = "0x3FDF2E4", Slot = "13")]
		[AsyncStateMachine(typeof(_003COnButtonBtnRoleClicked_003Ed__55))]
		protected override void OnButtonBtnRoleClicked()
		{
		}

		[Token(Token = "0x6002AB9")]
		[Address(RVA = "0x3FDF370", Offset = "0x3FDB370", VA = "0x3FDF370", Slot = "14")]
		[AsyncStateMachine(typeof(_003COnButtonBtnTowerClicked_003Ed__56))]
		protected override void OnButtonBtnTowerClicked()
		{
		}

		[Token(Token = "0x6002ABA")]
		[Address(RVA = "0x3FDF3FC", Offset = "0x3FDB3FC", VA = "0x3FDF3FC")]
		private void UpdateTowerPropertyItem()
		{
		}

		[Token(Token = "0x6002ABB")]
		[Address(RVA = "0x3FDF7D4", Offset = "0x3FDB7D4", VA = "0x3FDF7D4", Slot = "21")]
		protected override void OnButtonExtendBtnGoGetClicked()
		{
		}

		[Token(Token = "0x6002ABC")]
		[Address(RVA = "0x3FDF844", Offset = "0x3FDB844", VA = "0x3FDF844", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002ABD")]
		[Address(RVA = "0x3FDF858", Offset = "0x3FDB858", VA = "0x3FDF858", Slot = "7")]
		protected override void OnHideAnimationComplete()
		{
		}

		[Token(Token = "0x6002ABE")]
		[Address(RVA = "0x3FDFA54", Offset = "0x3FDBA54", VA = "0x3FDFA54", Slot = "12")]
		protected override void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x3FDF9C8", Offset = "0x3FDB9C8", VA = "0x3FDF9C8")]
		[AsyncStateMachine(typeof(_003CHideCallBack_003Ed__62))]
		private void HideCallBack()
		{
		}

		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x3FDFA78", Offset = "0x3FDBA78", VA = "0x3FDFA78")]
		private void ShowUpgradeTalent(object o)
		{
		}

		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x3FDFB00", Offset = "0x3FDBB00", VA = "0x3FDFB00")]
		public UpgradeCardPanel()
		{
		}
	}
}
