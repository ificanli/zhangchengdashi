using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using SuperScrollView;
using TimeModuleO;
using UnityEngine;
using UnityEngine.UI;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000B55")]
	public class ShopPanel : ShopPanelComponents, IPanelOnOnSecondClick
	{
		[Token(Token = "0x2000B56")]
		private struct SalesPrefabs
		{
			[Token(Token = "0x40052BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject HumanPackItemPrefab;

			[Token(Token = "0x40052BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject MonthCardItemPrefab;

			[Token(Token = "0x40052BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject ArtifactPackItemPrefab;

			[Token(Token = "0x40052BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject CommonCardPackItemPrefab;

			[Token(Token = "0x40052BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject AllFetterGiftPackItemPrefab;

			[Token(Token = "0x40052C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject WeeklyActivityThroughItemPrefab;
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B57")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x40052C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004584")]
			[Address(RVA = "0x4203FB8", Offset = "0x41FFFB8", VA = "0x4203FB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004585")]
			[Address(RVA = "0x420525C", Offset = "0x420125C", VA = "0x420525C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B58")]
		[CompilerGenerated]
		private struct _003CCreatAbilityStone_003Ed__84 : IAsyncStateMachine
		{
			[Token(Token = "0x40052C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<GlobalShopInfo> shopInfo;

			[Token(Token = "0x40052C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004586")]
			[Address(RVA = "0x4205268", Offset = "0x4201268", VA = "0x4205268", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004587")]
			[Address(RVA = "0x4205BE0", Offset = "0x4201BE0", VA = "0x4205BE0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B59")]
		[CompilerGenerated]
		private struct _003CCreatCard_003Ed__80 : IAsyncStateMachine
		{
			[Token(Token = "0x40052CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<GlobalShopInfo> shopInfo;

			[Token(Token = "0x40052CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004588")]
			[Address(RVA = "0x4205BEC", Offset = "0x4201BEC", VA = "0x4205BEC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004589")]
			[Address(RVA = "0x42066E4", Offset = "0x42026E4", VA = "0x42066E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B5A")]
		[CompilerGenerated]
		private struct _003CCreatCheast_003Ed__79 : IAsyncStateMachine
		{
			[Token(Token = "0x40052CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x600458A")]
			[Address(RVA = "0x42066F0", Offset = "0x42026F0", VA = "0x42066F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600458B")]
			[Address(RVA = "0x4206700", Offset = "0x4202700", VA = "0x4206700", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B5B")]
		[CompilerGenerated]
		private struct _003CCreatCoin_003Ed__82 : IAsyncStateMachine
		{
			[Token(Token = "0x40052D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<GlobalShopInfo> shopInfo;

			[Token(Token = "0x40052D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600458C")]
			[Address(RVA = "0x420670C", Offset = "0x420270C", VA = "0x420670C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600458D")]
			[Address(RVA = "0x4207048", Offset = "0x4203048", VA = "0x4207048", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B5C")]
		[CompilerGenerated]
		private struct _003CCreatCrystal_003Ed__85 : IAsyncStateMachine
		{
			[Token(Token = "0x40052D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<GlobalShopInfo> shopInfo;

			[Token(Token = "0x40052DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600458E")]
			[Address(RVA = "0x4207054", Offset = "0x4203054", VA = "0x4207054", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600458F")]
			[Address(RVA = "0x42079E4", Offset = "0x42039E4", VA = "0x42079E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B5D")]
		[CompilerGenerated]
		private struct _003CCreatCrystalPack_003Ed__72 : IAsyncStateMachine
		{
			[Token(Token = "0x40052DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private CrystalPackConfig _003Cpack_003E5__2;

			[Token(Token = "0x40052DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private RectTransform _003Cparent_003E5__3;

			[Token(Token = "0x40052E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004590")]
			[Address(RVA = "0x42079F0", Offset = "0x42039F0", VA = "0x42079F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004591")]
			[Address(RVA = "0x42080D4", Offset = "0x42040D4", VA = "0x42080D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B5E")]
		[CompilerGenerated]
		private struct _003CCreatDailyOffers_003Ed__78 : IAsyncStateMachine
		{
			[Token(Token = "0x40052E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<GlobalShopInfo> _003CdailyShopInfo_003E5__2;

			[Token(Token = "0x40052E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<UserDailyShopCardData> _003Cdata_003E5__3;

			[Token(Token = "0x40052E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004592")]
			[Address(RVA = "0x42080E0", Offset = "0x42040E0", VA = "0x42080E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004593")]
			[Address(RVA = "0x4208BF0", Offset = "0x4204BF0", VA = "0x4208BF0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B5F")]
		[CompilerGenerated]
		private struct _003CCreatGem_003Ed__81 : IAsyncStateMachine
		{
			[Token(Token = "0x40052E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<GlobalShopInfo> shopInfo;

			[Token(Token = "0x40052EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004594")]
			[Address(RVA = "0x4208BFC", Offset = "0x4204BFC", VA = "0x4208BFC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004595")]
			[Address(RVA = "0x4209268", Offset = "0x4205268", VA = "0x4209268", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B60")]
		[CompilerGenerated]
		private struct _003CCreatRuneStonePack_003Ed__71 : IAsyncStateMachine
		{
			[Token(Token = "0x40052EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private (bool, string) _003Citem_003E5__2;

			[Token(Token = "0x40052F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private RectTransform _003Cparent_003E5__3;

			[Token(Token = "0x40052F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6004596")]
			[Address(RVA = "0x4209274", Offset = "0x4205274", VA = "0x4209274", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004597")]
			[Address(RVA = "0x4209954", Offset = "0x4205954", VA = "0x4209954", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B61")]
		[CompilerGenerated]
		private struct _003CCreatSales_003Ed__47 : IAsyncStateMachine
		{
			[Token(Token = "0x40052F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<GlobalShopInfo> shopInfo;

			[Token(Token = "0x40052F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool shouldPlaySlideUpAnimation;

			[Token(Token = "0x40052F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			private bool _003CuseShopImproveV1BLayout_003E5__2;

			[Token(Token = "0x40052F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<GlobalShopInfo> _003Cinfo_003E5__3;

			[Token(Token = "0x40052F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask<SalesPrefabs>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40052FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__2;

			[Token(Token = "0x40052FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private UniTask.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6004598")]
			[Address(RVA = "0x4209960", Offset = "0x4205960", VA = "0x4209960", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004599")]
			[Address(RVA = "0x420A208", Offset = "0x4206208", VA = "0x420A208", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B62")]
		[CompilerGenerated]
		private struct _003CCreatWood_003Ed__83 : IAsyncStateMachine
		{
			[Token(Token = "0x40052FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40052FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40052FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x40052FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<GlobalShopInfo> shopInfo;

			[Token(Token = "0x4005300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600459A")]
			[Address(RVA = "0x420A214", Offset = "0x4206214", VA = "0x420A214", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600459B")]
			[Address(RVA = "0x420AB50", Offset = "0x4206B50", VA = "0x420AB50", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B63")]
		[CompilerGenerated]
		private struct _003CGoToBuyChests_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x4005301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x4005304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600459C")]
			[Address(RVA = "0x420AB5C", Offset = "0x4206B5C", VA = "0x420AB5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600459D")]
			[Address(RVA = "0x420AD70", Offset = "0x4206D70", VA = "0x420AD70", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B64")]
		[CompilerGenerated]
		private struct _003CHide_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4005305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x600459E")]
			[Address(RVA = "0x420AD7C", Offset = "0x4206D7C", VA = "0x420AD7C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600459F")]
			[Address(RVA = "0x420AE88", Offset = "0x4206E88", VA = "0x420AE88", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B65")]
		[CompilerGenerated]
		private struct _003CJumpToSalesTargetAsync_003Ed__94 : IAsyncStateMachine
		{
			[Token(Token = "0x4005308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400530A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x400530B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SalesJumpTargetType targetType;

			[Token(Token = "0x400530C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GameObject _003CtargetObj_003E5__2;

			[Token(Token = "0x400530D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x400530E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60045A0")]
			[Address(RVA = "0x420AE94", Offset = "0x4206E94", VA = "0x420AE94", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60045A1")]
			[Address(RVA = "0x420B214", Offset = "0x4207214", VA = "0x420B214", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B66")]
		[CompilerGenerated]
		private struct _003CLoadSalesPrefabsAsync_003Ed__54 : IAsyncStateMachine
		{
			[Token(Token = "0x400530F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<SalesPrefabs> _003C_003Et__builder;

			[Token(Token = "0x4005311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private string _003CmonthCardItemPrefabPath_003E5__2;

			[Token(Token = "0x4005312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string _003CartifactPackItemPrefabPath_003E5__3;

			[Token(Token = "0x4005313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private GameObject _003ChumanPackItemPrefab_003E5__4;

			[Token(Token = "0x4005314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private GameObject _003CmonthCardItemPrefab_003E5__5;

			[Token(Token = "0x4005315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private GameObject _003CartifactPackItemPrefab_003E5__6;

			[Token(Token = "0x4005316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private GameObject _003CcommonCardPackItemPrefab_003E5__7;

			[Token(Token = "0x4005317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private GameObject _003CallFetterGiftPackItemPrefab_003E5__8;

			[Token(Token = "0x4005318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60045A2")]
			[Address(RVA = "0x420B220", Offset = "0x4207220", VA = "0x420B220", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60045A3")]
			[Address(RVA = "0x420BF54", Offset = "0x4207F54", VA = "0x420BF54", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B67")]
		[CompilerGenerated]
		private struct _003CMonthPassExpire_003Ed__75 : IAsyncStateMachine
		{
			[Token(Token = "0x4005319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400531A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x60045A4")]
			[Address(RVA = "0x420BFAC", Offset = "0x4207FAC", VA = "0x420BFAC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60045A5")]
			[Address(RVA = "0x420BFBC", Offset = "0x4207FBC", VA = "0x420BFBC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B68")]
		[CompilerGenerated]
		private struct _003CPlaySlideUpAnimation_003Ed__49 : IAsyncStateMachine
		{
			[Token(Token = "0x400531B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400531C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400531D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x400531E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60045A6")]
			[Address(RVA = "0x420BFC8", Offset = "0x4207FC8", VA = "0x420BFC8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60045A7")]
			[Address(RVA = "0x420C704", Offset = "0x4208704", VA = "0x420C704", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B69")]
		[CompilerGenerated]
		private struct _003CRewardFlyCollectAnimation_003Ed__92 : IAsyncStateMachine
		{
			[Token(Token = "0x400531F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string cofig;

			[Token(Token = "0x4005322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x4005323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<RectTransform> _003CrectItem_003E5__2;

			[Token(Token = "0x4005324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string _003CresID_003E5__3;

			[Token(Token = "0x4005325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string _003CresNum_003E5__4;

			[Token(Token = "0x4005326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int _003CitemIndex_003E5__5;

			[Token(Token = "0x4005327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60045A8")]
			[Address(RVA = "0x420C710", Offset = "0x4208710", VA = "0x420C710", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60045A9")]
			[Address(RVA = "0x420D3EC", Offset = "0x42093EC", VA = "0x420D3EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B6A")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4005328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400532A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x400532B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60045AA")]
			[Address(RVA = "0x420D3F8", Offset = "0x42093F8", VA = "0x420D3F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60045AB")]
			[Address(RVA = "0x420E3D4", Offset = "0x420A3D4", VA = "0x420E3D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B6B")]
		[CompilerGenerated]
		private struct _003CShowArena_003Ed__89 : IAsyncStateMachine
		{
			[Token(Token = "0x400532C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400532D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400532E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x60045AC")]
			[Address(RVA = "0x420E3E0", Offset = "0x420A3E0", VA = "0x420E3E0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60045AD")]
			[Address(RVA = "0x420E720", Offset = "0x420A720", VA = "0x420E720", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B6C")]
		[CompilerGenerated]
		private struct _003CShowPrimary_003Ed__88 : IAsyncStateMachine
		{
			[Token(Token = "0x400532F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x60045AE")]
			[Address(RVA = "0x420E72C", Offset = "0x420A72C", VA = "0x420E72C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60045AF")]
			[Address(RVA = "0x420EC08", Offset = "0x420AC08", VA = "0x420EC08", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B6D")]
		[CompilerGenerated]
		private struct _003CShowSales_003Ed__87 : IAsyncStateMachine
		{
			[Token(Token = "0x4005332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopPanel _003C_003E4__this;

			[Token(Token = "0x60045B0")]
			[Address(RVA = "0x420EC14", Offset = "0x420AC14", VA = "0x420EC14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60045B1")]
			[Address(RVA = "0x420EEFC", Offset = "0x420AEFC", VA = "0x420EEFC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005295")]
		public const string DailyDiscountContent = "DailyDiscount";

		[Token(Token = "0x4005296")]
		public const string CommonCardContent = "CommonCard";

		[Token(Token = "0x4005297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private bool refreshEnd;

		[Token(Token = "0x4005298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private TimeManager.Timer timeToRefreshAdTimer;

		[Token(Token = "0x4005299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private List<BtnBuyUniversalCardItem> allCardItem;

		[Token(Token = "0x400529A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool primaryIsShow;

		[Token(Token = "0x400529B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x229")]
		private bool refresh_daily_shop;

		[Token(Token = "0x400529C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22A")]
		private bool hasPlayedSalesBIntroAnim;

		[Token(Token = "0x400529D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22B")]
		private bool _pendingPlaySlideUpAnimation;

		[Token(Token = "0x400529E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private bool _hasTriggeredPlaySlideUpAnimationOnce;

		[Token(Token = "0x400529F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Tween salesIntroTween;

		[Token(Token = "0x40052A0")]
		private const float SalesIntroReferenceDistance = 3000f;

		[Token(Token = "0x40052A1")]
		private const float SalesIntroReferenceDuration = 2f;

		[Token(Token = "0x40052A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private List<RectTransform> gemAllRect;

		[Token(Token = "0x40052A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private List<RectTransform> coinAllRect;

		[Token(Token = "0x40052A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private List<RectTransform> woodAllRect;

		[Token(Token = "0x40052A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private List<RectTransform> stoneAllRect;

		[Token(Token = "0x40052A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private List<RectTransform> crystalAllRect;

		[Token(Token = "0x40052A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private List<ArenaPackageData> arenaPackItemList;

		[Token(Token = "0x40052A8")]
		private const string ArenaPackItem = "ArenaPackItem";

		[Token(Token = "0x40052A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private GameObject dailyRes;

		[Token(Token = "0x40052AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private GameObject runeStoneObj;

		[Token(Token = "0x40052AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private GameObject runeStoneRes;

		[Token(Token = "0x40052AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private GameObject crystalPackObj;

		[Token(Token = "0x40052AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private GameObject crystalPackRes;

		[Token(Token = "0x40052AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private Dictionary<SalesJumpTargetType, GameObject> salesJumpTargetMap;

		[Token(Token = "0x40052AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private float _nextUpdateTime;

		[Token(Token = "0x40052B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private List<BtnMonthlyCardItem> allMonthCardItem;

		[Token(Token = "0x40052B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private List<BtnHumanPackItem> allGiftPackItem;

		[Token(Token = "0x40052B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private List<BtnArtifactPackItem> allArtifactPackItem;

		[Token(Token = "0x40052B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private List<BtnCommonCardPackItem> allCommonCardPackItem;

		[Token(Token = "0x40052B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private List<BtnAllFetterGiftPackItem> allAllFetterGiftPackItem;

		[Token(Token = "0x40052B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private List<BtnMonthlyCardItemB> allMonthCardItemB;

		[Token(Token = "0x40052B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private List<BtnFetterGiftPackItem> allFetterGiftPackItem;

		[Token(Token = "0x40052B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private List<BtnArtifactPackItemB> allArtifactPackItemB;

		[Token(Token = "0x40052B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private List<BtnWeeklyActivityThroughItem> allWeeklyActivityThroughItem;

		[Token(Token = "0x40052B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private bool hadBuyMonthPass;

		[Token(Token = "0x40052BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private List<GameObject> allDailyItem;

		[Token(Token = "0x17000B91")]
		private bool IsShopLockedByTraining
		{
			[Token(Token = "0x600453F")]
			[Address(RVA = "0x41FD3A0", Offset = "0x41F93A0", VA = "0x41FD3A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004540")]
		[Address(RVA = "0x41FD468", Offset = "0x41F9468", VA = "0x41FD468")]
		private bool IsCrystalShopSectionVisible()
		{
			return default;
		}

		[Token(Token = "0x6004541")]
		[Address(RVA = "0x41FD4D4", Offset = "0x41F94D4", VA = "0x41FD4D4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__29))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004542")]
		[Address(RVA = "0x41FD564", Offset = "0x41F9564", VA = "0x41FD564")]
		private LoopListViewItem2 OnGetItemByIndex(LoopListView2 listView, int index)
		{
			return null;
		}

		[Token(Token = "0x6004543")]
		[Address(RVA = "0x41FD664", Offset = "0x41F9664", VA = "0x41FD664")]
		private void Update()
		{
		}

		[Token(Token = "0x6004544")]
		[Address(RVA = "0x41FDBD8", Offset = "0x41F9BD8", VA = "0x41FDBD8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__33))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004545")]
		[Address(RVA = "0x41FDC6C", Offset = "0x41F9C6C", VA = "0x41FDC6C")]
		[AsyncStateMachine(typeof(_003CGoToBuyChests_003Ed__34))]
		private void GoToBuyChests(object o)
		{
		}

		[Token(Token = "0x6004546")]
		[Address(RVA = "0x41FDCFC", Offset = "0x41F9CFC", VA = "0x41FDCFC")]
		private void RefreshDailyItem(object o)
		{
		}

		[Token(Token = "0x6004547")]
		[Address(RVA = "0x41FDF38", Offset = "0x41F9F38", VA = "0x41FDF38")]
		private void RefreshDailyAdCallBack()
		{
		}

		[Token(Token = "0x6004548")]
		[Address(RVA = "0x41FE324", Offset = "0x41FA324", VA = "0x41FE324", Slot = "6")]
		[AsyncStateMachine(typeof(_003CHide_003Ed__37))]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004549")]
		[Address(RVA = "0x41FE3B0", Offset = "0x41FA3B0", VA = "0x41FE3B0")]
		[AsyncStateMachine(typeof(_003CCreatSales_003Ed__47))]
		private void CreatSales(List<GlobalShopInfo> shopInfo, bool shouldPlaySlideUpAnimation)
		{
		}

		[Token(Token = "0x600454A")]
		[Address(RVA = "0x41FE458", Offset = "0x41FA458", VA = "0x41FE458")]
		public void PreparePlaySlideUpAnimation()
		{
		}

		[Token(Token = "0x600454B")]
		[Address(RVA = "0x41FE470", Offset = "0x41FA470", VA = "0x41FE470")]
		[AsyncStateMachine(typeof(_003CPlaySlideUpAnimation_003Ed__49))]
		private UniTask PlaySlideUpAnimation()
		{
			return default;
		}

		[Token(Token = "0x600454C")]
		[Address(RVA = "0x41FE4F8", Offset = "0x41FA4F8", VA = "0x41FE4F8")]
		private void KillSalesIntroAnimation()
		{
		}

		[Token(Token = "0x600454D")]
		[Address(RVA = "0x41FD858", Offset = "0x41F9858", VA = "0x41FD858")]
		private void TryCancelSalesBIntroOnPlayerInput()
		{
		}

		[Token(Token = "0x600454E")]
		[Address(RVA = "0x41FE60C", Offset = "0x41FA60C", VA = "0x41FE60C")]
		private List<GlobalShopInfo> FilterPackSales(List<GlobalShopInfo> shopInfo)
		{
			return null;
		}

		[Token(Token = "0x600454F")]
		[Address(RVA = "0x41FE7C4", Offset = "0x41FA7C4", VA = "0x41FE7C4")]
		[AsyncStateMachine(typeof(_003CLoadSalesPrefabsAsync_003Ed__54))]
		private UniTask<SalesPrefabs> LoadSalesPrefabsAsync(bool useShopImproveV1BLayout)
		{
			return default;
		}

		[Token(Token = "0x6004550")]
		[Address(RVA = "0x41FE8A0", Offset = "0x41FA8A0", VA = "0x41FE8A0")]
		private bool ShouldCreateSalesItem(GlobalShopInfo shopItem)
		{
			return default;
		}

		[Token(Token = "0x6004551")]
		[Address(RVA = "0x41FE9F4", Offset = "0x41FA9F4", VA = "0x41FE9F4")]
		private void CreateOrReuseSalesItem(GlobalShopInfo shopItem, SalesPrefabs prefabs, bool useShopImproveV1BLayout, ref int monthIndex, ref int giftIndex, ref int artifactIndex, ref int commonIndex, ref int allFetterIndex, ref int weeklyThroughIndex, ref GameObject monthCardObj, ref GameObject artifactPackObj)
		{
		}

		[Token(Token = "0x6004552")]
		[Address(RVA = "0x41FF250", Offset = "0x41FB250", VA = "0x41FF250")]
		private void CreateOrReuseCommonCardItem(GlobalShopInfo shopItem, GameObject commonCardPrefab, ref int commonIndex)
		{
		}

		[Token(Token = "0x6004553")]
		[Address(RVA = "0x41FF64C", Offset = "0x41FB64C", VA = "0x41FF64C")]
		private void CreateOrReuseAllFetterItem(GlobalShopInfo shopItem, GameObject allFetterPrefab, ref int allFetterIndex)
		{
		}

		[Token(Token = "0x6004554")]
		[Address(RVA = "0x41FED24", Offset = "0x41FAD24", VA = "0x41FED24")]
		private void CreateOrReuseMonthCardItem(GlobalShopInfo shopItem, GameObject monthCardPrefab, bool useShopImproveV1BLayout, ref int monthIndex, ref GameObject monthCardObj)
		{
		}

		[Token(Token = "0x6004555")]
		[Address(RVA = "0x41FEF98", Offset = "0x41FAF98", VA = "0x41FEF98")]
		private void CreateOrReuseArtifactItem(GlobalShopInfo shopItem, GameObject artifactPrefab, bool useShopImproveV1BLayout, ref int artifactIndex, ref GameObject artifactPackObj)
		{
		}

		[Token(Token = "0x6004556")]
		[Address(RVA = "0x41FFF60", Offset = "0x41FBF60", VA = "0x41FFF60")]
		private void CreateOrReuseGiftItem(GlobalShopInfo shopItem, GameObject humanPackPrefab, bool useShopImproveV1BLayout, ref int giftIndex)
		{
		}

		[Token(Token = "0x6004557")]
		[Address(RVA = "0x41FFA48", Offset = "0x41FBA48", VA = "0x41FFA48")]
		private void CreateOrReuseWeeklyActivityThroughItem(GameObject weeklyActivityThroughItemPrefab, bool useShopImproveV1BLayout, ref int weeklyThroughIndex)
		{
		}

		[Token(Token = "0x6004558")]
		private static GameObject GetFirstActiveSalesObject<T>(List<T> items) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6004559")]
		private static List<GameObject> GetActiveSalesObjects<T>(List<T> items) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600455A")]
		[Address(RVA = "0x42003DC", Offset = "0x41FC3DC", VA = "0x42003DC")]
		private void RegisterSalesJumpTarget(GameObject targetObj, params SalesJumpTargetType[] keys)
		{
		}

		[Token(Token = "0x600455B")]
		[Address(RVA = "0x42002F0", Offset = "0x41FC2F0", VA = "0x42002F0")]
		private void RegisterSalesShopItemJumpTarget(GlobalShopInfo shopItem, GameObject targetObj, params SalesJumpTargetType[] extraKeys)
		{
		}

		[Token(Token = "0x600455C")]
		[Address(RVA = "0x42004C4", Offset = "0x41FC4C4", VA = "0x42004C4")]
		private SalesJumpTargetType GetSalesJumpTargetType(GlobalShopInfo shopItem)
		{
			return default;
		}

		[Token(Token = "0x600455D")]
		[Address(RVA = "0x4200740", Offset = "0x41FC740", VA = "0x4200740")]
		private GameObject GetSalesJumpTarget(SalesJumpTargetType targetType)
		{
			return null;
		}

		[Token(Token = "0x600455E")]
		[Address(RVA = "0x4200820", Offset = "0x41FC820", VA = "0x4200820")]
		private void UpdateSalesSiblingIndex()
		{
		}

		[Token(Token = "0x600455F")]
		[Address(RVA = "0x4200DE0", Offset = "0x41FCDE0", VA = "0x4200DE0")]
		private void HideExtraSalesItems(int giftIndex, int monthIndex, int artifactIndex, int commonIndex, int allFetterIndex, int weeklyThroughIndex)
		{
		}

		[Token(Token = "0x6004560")]
		[Address(RVA = "0x4201214", Offset = "0x41FD214", VA = "0x4201214")]
		[AsyncStateMachine(typeof(_003CCreatRuneStonePack_003Ed__71))]
		private void CreatRuneStonePack(object o)
		{
		}

		[Token(Token = "0x6004561")]
		[Address(RVA = "0x42012A4", Offset = "0x41FD2A4", VA = "0x42012A4")]
		[AsyncStateMachine(typeof(_003CCreatCrystalPack_003Ed__72))]
		private void CreatCrystalPack(object o)
		{
		}

		[Token(Token = "0x6004562")]
		[Address(RVA = "0x4201338", Offset = "0x41FD338", VA = "0x4201338")]
		private void UpdateShopMonthCardItemActice()
		{
		}

		[Token(Token = "0x6004563")]
		[Address(RVA = "0x4201458", Offset = "0x41FD458", VA = "0x4201458")]
		[AsyncStateMachine(typeof(_003CMonthPassExpire_003Ed__75))]
		private void MonthPassExpire(object o)
		{
		}

		[Token(Token = "0x6004564")]
		[Address(RVA = "0x42014DC", Offset = "0x41FD4DC", VA = "0x42014DC")]
		private void CreatPrimary(List<GlobalShopInfo> shopInfo)
		{
		}

		[Token(Token = "0x6004565")]
		[Address(RVA = "0x41FDEA4", Offset = "0x41F9EA4", VA = "0x41FDEA4")]
		[AsyncStateMachine(typeof(_003CCreatDailyOffers_003Ed__78))]
		private void CreatDailyOffers(List<GlobalShopInfo> shopInfo)
		{
		}

		[Token(Token = "0x6004566")]
		[Address(RVA = "0x4201C8C", Offset = "0x41FDC8C", VA = "0x4201C8C")]
		[AsyncStateMachine(typeof(_003CCreatCheast_003Ed__79))]
		private void CreatCheast(List<GlobalShopInfo> shopInfo)
		{
		}

		[Token(Token = "0x6004567")]
		[Address(RVA = "0x4201BF0", Offset = "0x41FDBF0", VA = "0x4201BF0")]
		[AsyncStateMachine(typeof(_003CCreatCard_003Ed__80))]
		private void CreatCard(List<GlobalShopInfo> shopInfo)
		{
		}

		[Token(Token = "0x6004568")]
		[Address(RVA = "0x4201EA0", Offset = "0x41FDEA0", VA = "0x4201EA0")]
		[AsyncStateMachine(typeof(_003CCreatGem_003Ed__81))]
		private void CreatGem(List<GlobalShopInfo> shopInfo)
		{
		}

		[Token(Token = "0x6004569")]
		[Address(RVA = "0x4201F3C", Offset = "0x41FDF3C", VA = "0x4201F3C")]
		[AsyncStateMachine(typeof(_003CCreatCoin_003Ed__82))]
		private void CreatCoin(List<GlobalShopInfo> shopInfo)
		{
		}

		[Token(Token = "0x600456A")]
		[Address(RVA = "0x4201FD8", Offset = "0x41FDFD8", VA = "0x4201FD8")]
		[AsyncStateMachine(typeof(_003CCreatWood_003Ed__83))]
		private void CreatWood(List<GlobalShopInfo> shopInfo)
		{
		}

		[Token(Token = "0x600456B")]
		[Address(RVA = "0x4202074", Offset = "0x41FE074", VA = "0x4202074")]
		[AsyncStateMachine(typeof(_003CCreatAbilityStone_003Ed__84))]
		private void CreatAbilityStone(List<GlobalShopInfo> shopInfo)
		{
		}

		[Token(Token = "0x600456C")]
		[Address(RVA = "0x4202110", Offset = "0x41FE110", VA = "0x4202110")]
		[AsyncStateMachine(typeof(_003CCreatCrystal_003Ed__85))]
		private void CreatCrystal(List<GlobalShopInfo> shopInfo)
		{
		}

		[Token(Token = "0x600456D")]
		[Address(RVA = "0x42021AC", Offset = "0x41FE1AC", VA = "0x42021AC")]
		private void OnTabChanged(int index)
		{
		}

		[Token(Token = "0x600456E")]
		[Address(RVA = "0x42021D0", Offset = "0x41FE1D0", VA = "0x42021D0")]
		[AsyncStateMachine(typeof(_003CShowSales_003Ed__87))]
		private void ShowSales()
		{
		}

		[Token(Token = "0x600456F")]
		[Address(RVA = "0x420225C", Offset = "0x41FE25C", VA = "0x420225C")]
		[AsyncStateMachine(typeof(_003CShowPrimary_003Ed__88))]
		private void ShowPrimary()
		{
		}

		[Token(Token = "0x6004570")]
		[Address(RVA = "0x42022E8", Offset = "0x41FE2E8", VA = "0x42022E8")]
		[AsyncStateMachine(typeof(_003CShowArena_003Ed__89))]
		private void ShowArena()
		{
		}

		[Token(Token = "0x6004571")]
		[Address(RVA = "0x4202374", Offset = "0x41FE374", VA = "0x4202374")]
		private void ArenaPakeRefresh(object o)
		{
		}

		[Token(Token = "0x6004572")]
		[Address(RVA = "0x4202560", Offset = "0x41FE560", VA = "0x4202560")]
		private void ShopRewardFlyAni(object o)
		{
		}

		[Token(Token = "0x6004573")]
		[Address(RVA = "0x4202594", Offset = "0x41FE594", VA = "0x4202594")]
		[AsyncStateMachine(typeof(_003CRewardFlyCollectAnimation_003Ed__92))]
		private UniTask RewardFlyCollectAnimation(string cofig)
		{
			return default;
		}

		[Token(Token = "0x6004574")]
		[Address(RVA = "0x4202634", Offset = "0x41FE634", VA = "0x4202634")]
		public void JumpToSalesTarget(SalesJumpTargetType targetType)
		{
		}

		[Token(Token = "0x6004575")]
		[Address(RVA = "0x4202654", Offset = "0x41FE654", VA = "0x4202654")]
		[AsyncStateMachine(typeof(_003CJumpToSalesTargetAsync_003Ed__94))]
		private UniTaskVoid JumpToSalesTargetAsync(SalesJumpTargetType targetType)
		{
			return default;
		}

		[Token(Token = "0x6004576")]
		[Address(RVA = "0x42026DC", Offset = "0x41FE6DC", VA = "0x42026DC")]
		private void ScrollSalesToTarget(Transform targetTf, float duration)
		{
		}

		[Token(Token = "0x6004577")]
		[Address(RVA = "0x42029FC", Offset = "0x41FE9FC", VA = "0x42029FC")]
		public void JumpToResPos(object parm)
		{
		}

		[Token(Token = "0x6004578")]
		[Address(RVA = "0x42031E8", Offset = "0x41FF1E8", VA = "0x42031E8")]
		private void ScrollPrimaryToTarget(Transform targetTf, float duration)
		{
		}

		[Token(Token = "0x6004579")]
		[Address(RVA = "0x4202708", Offset = "0x41FE708", VA = "0x4202708")]
		private void ScrollRectToTargetTopAligned(ScrollRect scrollRect, Transform targetTf, float duration)
		{
		}

		[Token(Token = "0x600457A")]
		[Address(RVA = "0x42032DC", Offset = "0x41FF2DC", VA = "0x42032DC", Slot = "24")]
		public void PanelOnOnSecondClickInit()
		{
		}

		[Token(Token = "0x600457B")]
		[Address(RVA = "0x4203398", Offset = "0x41FF398", VA = "0x4203398", Slot = "25")]
		public void OnSecondClick(object o)
		{
		}

		[Token(Token = "0x600457C")]
		[Address(RVA = "0x42035C4", Offset = "0x41FF5C4", VA = "0x42035C4", Slot = "26")]
		public void OnHide()
		{
		}

		[Token(Token = "0x600457D")]
		[Address(RVA = "0x4203488", Offset = "0x41FF488", VA = "0x4203488")]
		private void ApplyTrainingLockUI()
		{
		}

		[Token(Token = "0x600457E")]
		[Address(RVA = "0x4203A50", Offset = "0x41FFA50", VA = "0x4203A50")]
		public ShopPanel()
		{
		}
	}
}
