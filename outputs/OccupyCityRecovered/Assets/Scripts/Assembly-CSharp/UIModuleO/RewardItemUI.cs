using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000ADF")]
	public class RewardItemUI : RewardItemUIComponents
	{
		[Token(Token = "0x2000AE0")]
		private struct ItemTypeInfo
		{
			[Token(Token = "0x4004FC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool IsCard;

			[Token(Token = "0x4004FC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool IsProp;

			[Token(Token = "0x4004FC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool IsBox;

			[Token(Token = "0x4004FC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
			public bool IsExpression;

			[Token(Token = "0x4004FC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool IsResource;

			[Token(Token = "0x60041CE")]
			[Address(RVA = "0x41C2E54", Offset = "0x41BEE54", VA = "0x41C2E54")]
			public static ItemTypeInfo Create(string id)
			{
				return default;
			}
		}

		[Token(Token = "0x2000AE1")]
		private struct IconLoadInfo
		{
			[Token(Token = "0x4004FC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UniTask<Sprite> SpriteTask;

			[Token(Token = "0x4004FC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UniTask<SkeletonDataAsset> SpineTask;

			[Token(Token = "0x4004FC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool UseSpine;

			[Token(Token = "0x4004FC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string SpineAnimName;

			[Token(Token = "0x4004FC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float SpineScale;

			[Token(Token = "0x4004FCA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Vector3 SpinePosition;

			[Token(Token = "0x4004FCB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool SpineLoop;
		}

		[Token(Token = "0x2000AE2")]
		public enum BoxAnimState
		{
			[Token(Token = "0x4004FCD")]
			Locked = 0,
			[Token(Token = "0x4004FCE")]
			Unlocked = 1,
			[Token(Token = "0x4004FCF")]
			Claimed = 2
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AE5")]
		[CompilerGenerated]
		private struct _003CApplyIconAsset_003Ed__57 : IAsyncStateMachine
		{
			[Token(Token = "0x4004FD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004FD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004FD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IconLoadInfo iconInfo;

			[Token(Token = "0x4004FD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public RewardItemUI _003C_003E4__this;

			[Token(Token = "0x4004FD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public RewardConfigSingle rewardConfigSingle;

			[Token(Token = "0x4004FD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Sprite iconSprite;

			[Token(Token = "0x4004FD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private UniTask<SkeletonDataAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60041D4")]
			[Address(RVA = "0x41C3000", Offset = "0x41BF000", VA = "0x41C3000", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60041D5")]
			[Address(RVA = "0x41C33D8", Offset = "0x41BF3D8", VA = "0x41C33D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AE6")]
		[CompilerGenerated]
		private struct _003CApplyLoadedAssets_003Ed__56 : IAsyncStateMachine
		{
			[Token(Token = "0x4004FDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004FDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004FDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ItemTypeInfo typeInfo;

			[Token(Token = "0x4004FDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RewardItemUI _003C_003E4__this;

			[Token(Token = "0x4004FDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RewardConfigSingle rewardConfigSingle;

			[Token(Token = "0x4004FDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Sprite typeSprite;

			[Token(Token = "0x4004FE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Sprite backSprite;

			[Token(Token = "0x4004FE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public IconLoadInfo iconInfo;

			[Token(Token = "0x4004FE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Sprite iconSprite;

			[Token(Token = "0x4004FE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60041D6")]
			[Address(RVA = "0x41C33E4", Offset = "0x41BF3E4", VA = "0x41C33E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60041D7")]
			[Address(RVA = "0x41C3B58", Offset = "0x41BFB58", VA = "0x41C3B58", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AE7")]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4004FE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004FE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004FE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RewardConfigSingle rewardConfigSingle;

			[Token(Token = "0x4004FE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RewardItemUI _003C_003E4__this;

			[Token(Token = "0x4004FE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IGlobalAssetsInfo _003Cinfo_003E5__2;

			[Token(Token = "0x4004FE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ItemTypeInfo _003CtypeInfo_003E5__3;

			[Token(Token = "0x4004FEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private IconLoadInfo _003CiconLoadInfo_003E5__4;

			[Token(Token = "0x4004FEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private UniTask<(Sprite, Sprite, Sprite)>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4004FEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60041D8")]
			[Address(RVA = "0x41C3B64", Offset = "0x41BFB64", VA = "0x41C3B64", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60041D9")]
			[Address(RVA = "0x41C43AC", Offset = "0x41C03AC", VA = "0x41C43AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004FA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Header("强行隐藏背景")]
		public bool forceHideBG;

		[Token(Token = "0x4004FA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		[Header("是否刷新背景")]
		public bool autoUpdateBG;

		[Token(Token = "0x4004FA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		[Header("是否刷新Icon")]
		public bool autoUpdateIcon;

		[Token(Token = "0x4004FA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE3")]
		[Header("数量显示+类型前缀还是X类型前缀")]
		public bool useXType;

		[Token(Token = "0x4004FA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("数量不显示类型前缀")]
		public bool noUseType;

		[Token(Token = "0x4004FA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE5")]
		[Header("数量展示不显示前缀")]
		public bool HideCountPrefix;

		[Token(Token = "0x4004FA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE6")]
		[Header("卡牌是否显示类型")]
		public bool cardShowType;

		[Token(Token = "0x4004FA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE7")]
		[Header("卡牌是否显示收集进度条")]
		public bool cardShowProgress;

		[Token(Token = "0x4004FA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Header("奖励Item背景图使用bg1还是bg2")]
		public bool bgUse1;

		[Token(Token = "0x4004FAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		[Header("是否展示红点")]
		public bool showRedDot;

		[Token(Token = "0x4004FAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		[Header("是否展示道具名字")]
		public bool showPropName;

		[Token(Token = "0x4004FAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		[Header("卡牌奖励是否使用卡牌立绘(否则使用头像切图)")]
		public bool cardRewardUseCardArt;

		[Token(Token = "0x4004FAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[Header("是否点击展示道具详情")]
		public bool showPropDetails;

		[Token(Token = "0x4004FAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		[Header("是否显示Mask")]
		public bool showMask;

		[Token(Token = "0x4004FAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
		[Header("资源展示模式：卡牌/宝箱/神器使用资源样式(背景+Icon+数量)")]
		public bool useResourceDisplayStyle;

		[Token(Token = "0x4004FB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
		[Header("强制使用Icon图片(禁用CardSpine)")]
		public bool forceSpriteIcon;

		[Token(Token = "0x4004FB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Header("保留Prefab中Icon的锚点/位置/尺寸")]
		public bool preserveIconLayout;

		[Token(Token = "0x4004FB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		[Header("保留Prefab中ImgMask的RectTransform")]
		public bool preserveMaskLayout;

		[Token(Token = "0x4004FB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		[Header("保留Prefab中Back的RectTransform")]
		public bool preserveBackLayout;

		[Token(Token = "0x4004FB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Header("Spine缩放倍数(0表示使用默认值)")]
		public float spineScaleMultiplier;

		[Token(Token = "0x4004FB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector2 _imageBackSize;

		[Token(Token = "0x4004FB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector2 _imageTypeIconSize;

		[Token(Token = "0x4004FB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector2 _imageIconSize;

		[Token(Token = "0x4004FB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector2 _maskBornSize;

		[Token(Token = "0x4004FB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector2 DefaultImageTargetSize;

		[Token(Token = "0x4004FBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool _isShowCount;

		[Token(Token = "0x4004FBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RewardConfigSingle _currentData;

		[Token(Token = "0x4004FBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _isBoxType;

		[Token(Token = "0x4004FBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private BoxAnimState? _pendingBoxAnimState;

		[Token(Token = "0x4004FBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private bool _isSpineReady;

		[Token(Token = "0x4004FBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x135")]
		private bool _spineLoop;

		[Token(Token = "0x60041A7")]
		[Address(RVA = "0x41BEAB4", Offset = "0x41BAAB4", VA = "0x41BEAB4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60041A8")]
		[Address(RVA = "0x41BEAF4", Offset = "0x41BAAF4", VA = "0x41BEAF4")]
		private void CacheOriginalSizes()
		{
		}

		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x41BF148", Offset = "0x41BB148", VA = "0x41BF148")]
		private static bool IsValidSize(Vector2 size)
		{
			return default;
		}

		[Token(Token = "0x60041AA")]
		[Address(RVA = "0x41BED9C", Offset = "0x41BAD9C", VA = "0x41BED9C")]
		private Vector2 ResolveTargetSize(RectTransform rectTransform, Vector2 cachedSize, Vector2 fallbackSize)
		{
			return default;
		}

		[Token(Token = "0x60041AB")]
		[Address(RVA = "0x41BE174", Offset = "0x41BA174", VA = "0x41BE174")]
		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__37))]
		public void UpdateInfo(RewardConfigSingle rewardConfigSingle)
		{
		}

		[Token(Token = "0x60041AC")]
		[Address(RVA = "0x41BF168", Offset = "0x41BB168", VA = "0x41BF168")]
		private void UpdateSyncUI(RewardConfigSingle rewardConfigSingle, ItemTypeInfo typeInfo)
		{
		}

		[Token(Token = "0x60041AD")]
		[Address(RVA = "0x41BF4A0", Offset = "0x41BB4A0", VA = "0x41BF4A0")]
		private void UpdateCountText(RewardConfigSingle rewardConfigSingle)
		{
		}

		[Token(Token = "0x60041AE")]
		[Address(RVA = "0x41BFAB0", Offset = "0x41BBAB0", VA = "0x41BFAB0")]
		private string GetCountPrefix()
		{
			return null;
		}

		[Token(Token = "0x60041AF")]
		[Address(RVA = "0x41BF50C", Offset = "0x41BB50C", VA = "0x41BF50C")]
		private void UpdateBackgroundDisplay(RewardConfigSingle rewardConfigSingle, ItemTypeInfo typeInfo)
		{
		}

		[Token(Token = "0x60041B0")]
		[Address(RVA = "0x41BF668", Offset = "0x41BB668", VA = "0x41BF668")]
		private void UpdateProgressDisplay(RewardConfigSingle rewardConfigSingle, ItemTypeInfo typeInfo)
		{
		}

		[Token(Token = "0x60041B1")]
		[Address(RVA = "0x41BFF1C", Offset = "0x41BBF1C", VA = "0x41BFF1C")]
		private int CalculateCardRequiredCount(UserHeroCardData heroCardData)
		{
			return default;
		}

		[Token(Token = "0x60041B2")]
		[Address(RVA = "0x41BF864", Offset = "0x41BB864", VA = "0x41BF864")]
		private void UpdateTypeIconDisplay(RewardConfigSingle rewardConfigSingle, ItemTypeInfo typeInfo)
		{
		}

		[Token(Token = "0x60041B3")]
		[Address(RVA = "0x41C03A8", Offset = "0x41BC3A8", VA = "0x41C03A8")]
		private int GetItemLevel(RewardConfigSingle rewardConfigSingle, ItemTypeInfo typeInfo)
		{
			return default;
		}

		[Token(Token = "0x60041B4")]
		[Address(RVA = "0x41C063C", Offset = "0x41BC63C", VA = "0x41C063C")]
		private (UniTask<Sprite>, UniTask<Sprite>, IconLoadInfo) PrepareAssetLoadTasks(RewardConfigSingle rewardConfigSingle, ItemTypeInfo typeInfo, int level)
		{
			return default;
		}

		[Token(Token = "0x60041B5")]
		[Address(RVA = "0x41C09F8", Offset = "0x41BC9F8", VA = "0x41C09F8")]
		private UniTask<Sprite> LoadCardArtSprite(IGlobalAssetsInfo info, int level)
		{
			return default;
		}

		[Token(Token = "0x60041B6")]
		[Address(RVA = "0x41C1234", Offset = "0x41BD234", VA = "0x41C1234")]
		private string ResolveLeveledPath(string rawPaths, int level)
		{
			return null;
		}

		[Token(Token = "0x60041B7")]
		[Address(RVA = "0x41C13DC", Offset = "0x41BD3DC", VA = "0x41C13DC")]
		private (UniTask<Sprite>, IconLoadInfo) PrepareCardAvatarAssets(IGlobalAssetsInfo info)
		{
			return default;
		}

		[Token(Token = "0x60041B8")]
		[Address(RVA = "0x41C0B78", Offset = "0x41BCB78", VA = "0x41C0B78")]
		private (UniTask<Sprite>, IconLoadInfo) PrepareDefaultAssets(IGlobalAssetsInfo info, ItemTypeInfo typeInfo, int level)
		{
			return default;
		}

		[Token(Token = "0x60041B9")]
		[Address(RVA = "0x41C191C", Offset = "0x41BD91C", VA = "0x41C191C")]
		private UniTask<SkeletonDataAsset> PrepareBoxSpineTask(string boxId)
		{
			return default;
		}

		[Token(Token = "0x60041BA")]
		[Address(RVA = "0x41C1834", Offset = "0x41BD834", VA = "0x41C1834")]
		private bool IsUniversalCard(string id)
		{
			return default;
		}

		[Token(Token = "0x60041BB")]
		[Address(RVA = "0x41C1770", Offset = "0x41BD770", VA = "0x41C1770")]
		private bool ShouldUseSpineIcon(IGlobalAssetsInfo info, ItemTypeInfo typeInfo)
		{
			return default;
		}

		[Token(Token = "0x60041BC")]
		[Address(RVA = "0x41C1908", Offset = "0x41BD908", VA = "0x41C1908")]
		private float GetSpineScale(float defaultScale)
		{
			return default;
		}

		[Token(Token = "0x60041BD")]
		[Address(RVA = "0x41C1A94", Offset = "0x41BDA94", VA = "0x41C1A94")]
		private bool IsValidAfterAwait(RewardConfigSingle rewardConfigSingle)
		{
			return default;
		}

		[Token(Token = "0x60041BE")]
		[Address(RVA = "0x41C1B14", Offset = "0x41BDB14", VA = "0x41C1B14")]
		[AsyncStateMachine(typeof(_003CApplyLoadedAssets_003Ed__56))]
		private UniTask ApplyLoadedAssets(RewardConfigSingle rewardConfigSingle, ItemTypeInfo typeInfo, Sprite typeSprite, Sprite backSprite, Sprite iconSprite, IconLoadInfo iconInfo)
		{
			return default;
		}

		[Token(Token = "0x60041BF")]
		[Address(RVA = "0x41C1C00", Offset = "0x41BDC00", VA = "0x41C1C00")]
		[AsyncStateMachine(typeof(_003CApplyIconAsset_003Ed__57))]
		private UniTask ApplyIconAsset(RewardConfigSingle rewardConfigSingle, IconLoadInfo iconInfo, Sprite iconSprite)
		{
			return default;
		}

		[Token(Token = "0x60041C0")]
		[Address(RVA = "0x41C1CC0", Offset = "0x41BDCC0", VA = "0x41C1CC0")]
		private void ShowSpineIcon(SkeletonDataAsset skeletonDataAsset, string animName, float scale, Vector3 position, bool loop)
		{
		}

		[Token(Token = "0x60041C1")]
		[Address(RVA = "0x41C20D0", Offset = "0x41BE0D0", VA = "0x41C20D0")]
		private void ShowSpriteIcon(Sprite sprite)
		{
		}

		[Token(Token = "0x60041C2")]
		[Address(RVA = "0x41C2198", Offset = "0x41BE198", VA = "0x41C2198")]
		private void ApplyFinalUISettings(IGlobalAssetsInfo info, ItemTypeInfo typeInfo)
		{
		}

		[Token(Token = "0x60041C3")]
		[Address(RVA = "0x41C2428", Offset = "0x41BE428", VA = "0x41C2428")]
		private void ApplyImageSizes()
		{
		}

		[Token(Token = "0x60041C4")]
		[Address(RVA = "0x41C25A8", Offset = "0x41BE5A8", VA = "0x41C25A8")]
		private void ApplyImageSize(Image image, Vector2 targetSize, int forceHeight = -1)
		{
		}

		[Token(Token = "0x60041C5")]
		[Address(RVA = "0x41C26D4", Offset = "0x41BE6D4", VA = "0x41C26D4")]
		private void EnsureImageSize(Image image, Vector2 fallbackSize)
		{
		}

		[Token(Token = "0x60041C6")]
		[Address(RVA = "0x41C287C", Offset = "0x41BE87C", VA = "0x41C287C")]
		public void ResizeToApproximateSize(Image image, float targetWidth = 59f, float targetHeight = 44f, int forceHeight = -1)
		{
		}

		[Token(Token = "0x60041C7")]
		[Address(RVA = "0x41C29B0", Offset = "0x41BE9B0", VA = "0x41C29B0")]
		private float CalculateResizeScale(float originalWidth, float originalHeight, float targetWidth, float targetHeight, int forceHeight)
		{
			return default;
		}

		[Token(Token = "0x60041C8")]
		[Address(RVA = "0x41C29DC", Offset = "0x41BE9DC", VA = "0x41C29DC")]
		public void SetIsShowCount(bool show)
		{
		}

		[Token(Token = "0x60041C9")]
		[Address(RVA = "0x41C2A30", Offset = "0x41BEA30", VA = "0x41C2A30")]
		public void SetBoxAnimState(BoxAnimState state)
		{
		}

		[Token(Token = "0x60041CA")]
		[Address(RVA = "0x41C2B98", Offset = "0x41BEB98", VA = "0x41C2B98")]
		public void PlayExpressionSpinePreview()
		{
		}

		[Token(Token = "0x60041CB")]
		[Address(RVA = "0x41C2C3C", Offset = "0x41BEC3C", VA = "0x41C2C3C", Slot = "12")]
		protected override void OnButtonExtendShowDesClicked()
		{
		}

		[Token(Token = "0x60041CC")]
		[Address(RVA = "0x41C2DD4", Offset = "0x41BEDD4", VA = "0x41C2DD4")]
		public RewardItemUI()
		{
		}
	}
}
