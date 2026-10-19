using System.Runtime.CompilerServices;
using GameFramework.Resources;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework.Base
{
	[Token(Token = "0x20004BD")]
	public class GameStartEntry : MonoBehaviour
	{
		[Token(Token = "0x4001F67")]
		[FieldOffset(Offset = "0x20")]
		[Header("是否屏蔽掉框架启动时的log")]
		public bool isShowInitGameLog = true;

		[Token(Token = "0x4001F68")]
		[FieldOffset(Offset = "0x28")]
		public string AppName;

		[Token(Token = "0x4001F69")]
		[FieldOffset(Offset = "0x30")]
		[Header("玩法组件代码，飞书任务获取具体的值")]
		public string gameCode;

		[Token(Token = "0x4001F6A")]
		[FieldOffset(Offset = "0x38")]
		private int tRJqx_0095 = 3001;

		[Token(Token = "0x4001F6B")]
		[FieldOffset(Offset = "0x3C")]
		private bool x_0080_008D_00B1f_0086;

		[Token(Token = "0x4001F6C")]
		[FieldOffset(Offset = "0x0")]
		public static bool EnterGame;

		[Token(Token = "0x4001F6D")]
		[FieldOffset(Offset = "0x40")]
		[Header("------APP多语言设置------")]
		[SerializeField]
		[EnumFlags]
		private LocalELangLibrary langLibrary = LocalELangLibrary.ZH_CN;

		[Token(Token = "0x4001F6E")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ELangType appDefaultLangType;

		[Token(Token = "0x4001F6F")]
		[FieldOffset(Offset = "0x48")]
		private bool Á_008A_008F_008Bvh;

		[Token(Token = "0x4001F70")]
		[FieldOffset(Offset = "0x49")]
		private bool _00BDm_00B9_008F_0096h;

		[Token(Token = "0x4001F71")]
		[FieldOffset(Offset = "0x4A")]
		private bool tÂ_007DµJ_008F;

		[Token(Token = "0x4001F72")]
		[FieldOffset(Offset = "0x4B")]
		[Header("快速模式：开启此模式后，数据类和逻辑类不再自动初始化")]
		public bool m_Fastmode;

		[Token(Token = "0x4001F73")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Header("自动存储数据：开启后，游戏切换前后台时，框架会自动触发所有的数据存储")]
		private bool m_AutoSaveData;

		[Token(Token = "0x4001F74")]
		[FieldOffset(Offset = "0x50")]
		private IGameStart _008ANUO_008B_0084;

		[Token(Token = "0x6007175")]
		[Address(RVA = "0x72E5690", Offset = "0x72E1690", VA = "0x72E5690")]
		private void ª_008C_0098_00ABV_005E()
		{
			_008A_0080M_00ACa_0083("开始初始化进游戏前的逻辑");
			if (AppSetting.IsGameColletion)
			    _009EªOl_0097F();
			_008ANUO_008B_0084.SetLayerCollisionMatrix();
			_008ANUO_008B_0084.MnieGameProjectSetting();
			_008ANUO_008B_0084.RegisterProcedure();
			_008ANUO_008B_0084.RegisterLogicCtr();
			GameFramework.AudioManager.Instance.InitAudioManager();
			GameFrameEntry.GetModule<MineGameLogicModule>().InitCtrl(!m_Fastmode);
			x_0080_008D_00B1f_0086 = true;
			tÂ_007DµJ_008F = false;
			_008A_0080M_00ACa_0083("开始游戏");
			GameFrameEntry.CommonSettings();
			DBTSDK.ReportManager.Instance.StartMineGame();
			MsgDispatcher.AddEventListener("ExitGame", _007Ea_00AEºgf);
			_008ANUO_008B_0084.StartGame();
		}

		[Token(Token = "0x6007176")]
		[Address(RVA = "0x72E5AF8", Offset = "0x72E1AF8", VA = "0x72E5AF8")]
		private void OnApplicationFocus(bool _0084_0060ÁjW_00BB)
		{
		}

		[Token(Token = "0x6007177")]
		[Address(RVA = "0x72E58F4", Offset = "0x72E18F4", VA = "0x72E58F4")]
		private void _008A_0080M_00ACa_0083(string iD_00B7m_0094À)
		{
			if (isShowInitGameLog)
			    CLog.Log(iD_00B7m_0094À);
		}

		[Token(Token = "0x6007178")]
		[Address(RVA = "0x72E5D54", Offset = "0x72E1D54", VA = "0x72E5D54")]
		private void q_0084W_0095C_008A(AllAssetsOperationHandle _00A7_00BDt_0091_00B3_00AE)
		{
		}

		[Token(Token = "0x6007179")]
		[Address(RVA = "0x72E5DD0", Offset = "0x72E1DD0", VA = "0x72E5DD0")]
		private void vj_00B7_0098_008A_007F()
		{
			_008A_0080M_00ACa_0083("VersionMondule初始化完成");
			if (AppSetting.UseNewRes)
			{
			    GameFrameModule module = NewResLoadHelper.GetNewResModule(AppSetting.IsKeWan);
			    bool isWebPlay = AppSetting.IsXYXEnvironment && !AppSetting.IsXYXNativeMode;
			    TeamType teamType = _008ANUO_008B_0084.GetNewResLoadCDNTeamType();
			    EPlayMode playMode;
			    if (isWebPlay)
			    {
			        playMode = (EPlayMode)4;
			        CLog.Log("cdnTeamTypeXYX:" + teamType.ToString() + " appPlayMode:" + playMode.ToString());
			    }
			    else
			    {
			        playMode = _008ANUO_008B_0084.GetNewResLoadAppPlayMode();
			        CLog.Log("cdnTeamType:" + teamType.ToString() + " appPlayMode:" + playMode.ToString());
			    }
			    NewResLoadHelper.Initialize(module, fÂ_00A7_0096_005D_009C, playMode, teamType);
			    return;
			}
			GameFrameEntry.Initialize(GameFrameEntry.GetModule<AssetbundleModule>(), fÂ_00A7_0096_005D_009C, System.Array.Empty<object>());
		}

		[Token(Token = "0x600717A")]
		[Address(RVA = "0x72E632C", Offset = "0x72E232C", VA = "0x72E632C")]
		private void _00BC_008D_0087H_00A6_00B6()
		{
		}

		[Token(Token = "0x600717B")]
		[Address(RVA = "0x72E6410", Offset = "0x72E2410", VA = "0x72E6410")]
		private void m_00AFj_007B_0084k(AllAssetsOperationHandle _00A7_00BDt_0091_00B3_00AE)
		{
		}

		[Token(Token = "0x600717C")]
		[Address(RVA = "0x72E648C", Offset = "0x72E248C", VA = "0x72E648C")]
		private void _0091GX_0094zA()
		{
		}

		[Token(Token = "0x600717D")]
		[Address(RVA = "0x72E6570", Offset = "0x72E2570", VA = "0x72E6570")]
		private void ÂN_007E_0080_00BC_0087()
		{
		}

		[Token(Token = "0x600717E")]
		[Address(RVA = "0x72E66A8", Offset = "0x72E26A8", VA = "0x72E66A8")]
		private void g_0095_00AC_00B3_009FB(string iD_00B7m_0094À)
		{
		}

		[Token(Token = "0x600717F")]
		[Address(RVA = "0x72E677C", Offset = "0x72E277C", VA = "0x72E677C")]
		private void _0094_0087_0095_00A1_0089_00A9(string iD_00B7m_0094À)
		{
		}

		[Token(Token = "0x6007180")]
		[Address(RVA = "0x72E684C", Offset = "0x72E284C", VA = "0x72E684C")]
		internal void whJq_00B8_00B9()
		{
			Á_008A_008F_008Bvh = true;
			ª_008C_0098_00ABV_005E();
		}

		[Token(Token = "0x6007181")]
		[Address(RVA = "0x72E6858", Offset = "0x72E2858", VA = "0x72E6858")]
		private void _00A2KT_007E_00A6A(string iD_00B7m_0094À)
		{
		}

		[Token(Token = "0x6007182")]
		[Address(RVA = "0x72E692C", Offset = "0x72E292C", VA = "0x72E692C")]
		private void fÂ_00A7_0096_005D_009C()
		{
			_008ANUO_008B_0084?.AfterGameFrameworkInit();
			_008A_0080M_00ACa_0083("资源模块初始化完成");
			if (AppSetting.UseNewRes)
			    GameFrameEntry.Initialize(GameFrameEntry.GetModule<UIModule>(), _0082_00BBf_0090_00B8_005D, System.Array.Empty<object>());
			else
			    GameFrameEntry.Initialize(GameFrameEntry.GetModule<ResourcesModule>(), _009F_008Br_00B7Mu, System.Array.Empty<object>());
		}

		[Token(Token = "0x6007183")]
		[Address(RVA = "0x72E6B44", Offset = "0x72E2B44", VA = "0x72E6B44")]
		private void O_00A9_00B3_00A7_00A0i()
		{
		}

		[Token(Token = "0x6007184")]
		[Address(RVA = "0x72E6D80", Offset = "0x72E2D80", VA = "0x72E6D80")]
		private void v_00A6n_00BD_00A7_00BF()
		{
		}

		[Token(Token = "0x6007185")]
		[Address(RVA = "0x72E6FBC", Offset = "0x72E2FBC", VA = "0x72E6FBC")]
		private void J_009DK_0099M_00AC()
		{
			GameFrameEntry.Start();
			_008A_0080M_00ACa_0083("核心模块初始化完成");
			bool showLog = !GlobalData.IsReleaseVersion || DBTSDK.SDKToolManager.Instance.IsSupportLogStatic();
			CLog.SetIsShowLog(showLog);
			if (GlobalData.IsReleaseVersion)
			{
			    if (showLog)
			    {
			        DBTSDK.SDKToolManager.Instance.ShowToast("警告：正式包开启了日志");
			        DBTSDK.ReportManager.Instance.ReportGMLogOpen();
			    }
			}
			else if (NewResLoadHelper.GetIsDeepObf())
			    DBTSDK.SDKToolManager.Instance.ShowToast("警告：当前测试包开启了深度混淆，请注意验证数据存储");
			GamePath.Instance.FindMineGamePath();
			tÂ_007DµJ_008F = true;
			GameFrameEntry.GetModule<LangModule>().SetLocalLangLibrary(langLibrary, appDefaultLangType);
			MsgDispatcher.SendMessage("GF_InitFinish");
			_008ANUO_008B_0084.InitPatchManager();
		}

		[Token(Token = "0x6007186")]
		[Address(RVA = "0x72E722C", Offset = "0x72E322C", VA = "0x72E722C")]
		private void r_00A9_008CeS_00AE(AllAssetsOperationHandle _00A7_00BDt_0091_00B3_00AE)
		{
		}

		[Token(Token = "0x6007187")]
		[Address(RVA = "0x72E72A8", Offset = "0x72E32A8", VA = "0x72E72A8")]
		private void ÁH_00B7s_007Bh()
		{
		}

		[Token(Token = "0x6007188")]
		[Address(RVA = "0x72E7514", Offset = "0x72E3514", VA = "0x72E7514")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6007189")]
		[Address(RVA = "0x72E75A0", Offset = "0x72E35A0", VA = "0x72E75A0")]
		private void Update()
		{
			if (_00BDm_00B9_008F_0096h)
			    return;
			if (tÂ_007DµJ_008F)
			    GameFrameEntry.ResourcesModuleUpdate(Time.deltaTime, Time.unscaledDeltaTime);
			if (x_0080_008D_00B1f_0086)
			    GameFrameEntry.Update(Time.deltaTime, Time.unscaledDeltaTime);
		}

		[Token(Token = "0x600718A")]
		[Address(RVA = "0x72E7684", Offset = "0x72E3684", VA = "0x72E7684")]
		private void _009CTSB_00AFv(ResourcesInfo _0088_00AB_0084E_0082F)
		{
		}

		[Token(Token = "0x600718B")]
		[Address(RVA = "0x72E76F4", Offset = "0x72E36F4", VA = "0x72E76F4")]
		private void m_00A4_008Dc_00A6_00B9()
		{
		}

		[Token(Token = "0x600718C")]
		[Address(RVA = "0x72E77D8", Offset = "0x72E37D8", VA = "0x72E77D8")]
		private void _00BBF_0090T_00A2_0092()
		{
		}

		[Token(Token = "0x600718D")]
		[Address(RVA = "0x72E7A34", Offset = "0x72E3A34", VA = "0x72E7A34")]
		private void Á_0060_0090_00A3aM()
		{
		}

		[Token(Token = "0x600718E")]
		[Address(RVA = "0x72E7EA8", Offset = "0x72E3EA8", VA = "0x72E7EA8")]
		private void _007Ea_00AEºgf(object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600718F")]
		[Address(RVA = "0x72E7FF4", Offset = "0x72E3FF4", VA = "0x72E7FF4")]
		private void _008B_00A7_0099YW_0091(ResourcesInfo _0088_00AB_0084E_0082F)
		{
			_008A_0080M_00ACa_0083("ConfigLoadOver");
			_008ANUO_008B_0084.InitConfig(_0088_00AB_0084E_0082F);
		}

		[Token(Token = "0x6007190")]
		[Address(RVA = "0x72E8064", Offset = "0x72E4064", VA = "0x72E8064")]
		[CompilerGenerated]
		private void _007F_008EdP_0088_0081(AllAssetsOperationHandle _00A7_00BDt_0091_00B3_00AE)
		{
		}

		[Token(Token = "0x6007191")]
		[Address(RVA = "0x72E80E0", Offset = "0x72E40E0", VA = "0x72E80E0")]
		private void _0083_00B8_0088_0082M_0085(object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x6007192")]
		[Address(RVA = "0x72E822C", Offset = "0x72E422C", VA = "0x72E822C")]
		private void _0080_00BF_00A7_009CKµ()
		{
		}

		[Token(Token = "0x6007193")]
		[Address(RVA = "0x72E86A4", Offset = "0x72E46A4", VA = "0x72E86A4")]
		private void Awake()
		{
			AppSetting.AutoSaveData = m_AutoSaveData;
			AppSetting.gameCode = gameCode;
			if (_008ANUO_008B_0084 == null)
			    _008ANUO_008B_0084 = GetComponent<IGameStart>();
			if (_008ANUO_008B_0084 == null)
			{
			    CLog.Error("\u6e38\u620f\u542f\u52a8\u5931\u8d25\uff0c\u7f3a\u5c11\u6e38\u620f\u542f\u52a8\u5165\u53e3\u811a\u672c");
			    return;
			}
			_008ANUO_008B_0084._007Dye_0080_00BCa(this);
			Á_008A_008F_008Bvh = false;
			AppSetting.SetCultureBasedOnSetting();
			if (AppSetting.IsGameColletion)
			{
			    AppName = GlobalData.MineAppName;
			    langLibrary = GlobalData.localELangLibrary;
			    appDefaultLangType = GlobalData.appDefaultLangType;
			}
			AppSetting.MineGameName = AppName;
			DontDestroyOnLoad(this);
			UserDataPrefs.OnInit();
			_008ANUO_008B_0084.BeforeGameFrameworkInit();
			GameFrameEntry.Initialize(GameFrameEntry.GetModule<VersionMondule>(), vj_00B7_0098_008A_007F, System.Array.Empty<object>());
		}

		[Token(Token = "0x6007194")]
		[Address(RVA = "0x72E8B14", Offset = "0x72E4B14", VA = "0x72E8B14")]
		private void _0082_00BBf_0090_00B8_005D()
		{
			_008A_0080M_00ACa_0083("UI模块初始化完成，开始初始化其他次级模块");
			GameFrameEntry.Initialize(GameFrameEntry.GetModule<LangModule>(), null, System.Array.Empty<object>());
			GameFrameEntry.Initialize(GameFrameEntry.GetModule<GameFramework.Fsm.FsmManager>(), null, System.Array.Empty<object>());
			GameFrameEntry.Initialize(GameFrameEntry.GetModule<MineGameLogicModule>(), null, System.Array.Empty<object>());
			GameFrameEntry.Initialize(GameFrameEntry.GetModule<TimeModule>(), null, System.Array.Empty<object>());
			GameFrameEntry.Initialize(GameFrameEntry.GetModule<EffectModule>(), null, System.Array.Empty<object>());
			GameFrameEntry.Initialize(GameFrameEntry.GetModule<GameFramework.ObjectPool.ObjectPoolManager>(), null, System.Array.Empty<object>());
			GameFrameEntry.Initialize(GameFrameEntry.GetModule<GameFramework.Procedure.ProcedureManager>(), J_009DK_0099M_00AC, System.Array.Empty<object>());
		}

		[Token(Token = "0x6007195")]
		[Address(RVA = "0x72E8F6C", Offset = "0x72E4F6C", VA = "0x72E8F6C")]
		private void J_00B3_007D_007D_00B4q()
		{
		}

		[Token(Token = "0x6007196")]
		[Address(RVA = "0x72E909C", Offset = "0x72E509C", VA = "0x72E909C")]
		private void i_005EN_00A5D_00A3(ResourcesInfo _0088_00AB_0084E_0082F)
		{
		}

		[Token(Token = "0x6007197")]
		[Address(RVA = "0x72E910C", Offset = "0x72E510C", VA = "0x72E910C")]
		private void _00BBC_00BCª_00A1h(bool _0084_0060ÁjW_00BB)
		{
		}

		[Token(Token = "0x6007198")]
		[Address(RVA = "0x72E9368", Offset = "0x72E5368", VA = "0x72E9368")]
		public GameStartEntry()
		{
		}

		[Token(Token = "0x6007199")]
		[Address(RVA = "0x72E9384", Offset = "0x72E5384", VA = "0x72E9384")]
		internal void _00B2RBA_0083ª()
		{
		}

		[Token(Token = "0x600719A")]
		[Address(RVA = "0x72E59C4", Offset = "0x72E19C4", VA = "0x72E59C4")]
		private void _009EªOl_0097F()
		{
		}

		[Token(Token = "0x600719B")]
		[Address(RVA = "0x72E9670", Offset = "0x72E5670", VA = "0x72E9670")]
		private void Fr_0081j_0082_00A0()
		{
		}

		[Token(Token = "0x600719C")]
		[Address(RVA = "0x72E98C8", Offset = "0x72E58C8", VA = "0x72E98C8")]
		internal void _008DªcBl_007D()
		{
		}

		[Token(Token = "0x600719D")]
		[Address(RVA = "0x72E9B2C", Offset = "0x72E5B2C", VA = "0x72E9B2C")]
		private void Â_00AD_00ADzW_007B(object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x600719E")]
		[Address(RVA = "0x72E98D0", Offset = "0x72E58D0", VA = "0x72E98D0")]
		private void _0098Y_00A2_00A0j_00BB()
		{
		}

		[Token(Token = "0x600719F")]
		[Address(RVA = "0x72E9C7C", Offset = "0x72E5C7C", VA = "0x72E9C7C")]
		internal void _008B_00BEq_00B4hc()
		{
		}

		[Token(Token = "0x60071A0")]
		[Address(RVA = "0x72E9E68", Offset = "0x72E5E68", VA = "0x72E9E68")]
		private void _007B_00A5xª_00BD_00AF()
		{
		}

		[Token(Token = "0x60071A1")]
		[Address(RVA = "0x72EA3E4", Offset = "0x72E63E4", VA = "0x72EA3E4")]
		private void y_00B6_008E_007CI_0084()
		{
		}

		[Token(Token = "0x60071A2")]
		[Address(RVA = "0x72EA5FC", Offset = "0x72E65FC", VA = "0x72EA5FC")]
		private void D_005EMD_00A1_00A3(object[] h_00A6_00BB_00B2_0089w)
		{
		}

		[Token(Token = "0x60071A3")]
		[Address(RVA = "0x72EA744", Offset = "0x72E6744", VA = "0x72EA744")]
		internal void KV_009C_00B2_0081_00B7()
		{
		}

		[Token(Token = "0x60071A4")]
		[Address(RVA = "0x72EA930", Offset = "0x72E6930", VA = "0x72EA930")]
		internal void _008CdSH_00AB_007B()
		{
		}

		[Token(Token = "0x60071A5")]
		[Address(RVA = "0x72EA93C", Offset = "0x72E693C", VA = "0x72EA93C")]
		internal void O_008AJy_0085_00BF()
		{
			_008A_0080M_00ACa_0083("LoadingUIOpen");
			DBTSDK.SDKToolManager.Instance.U3DGameStart_Override();
			if (AppSetting.UseNewRes)
			    O_00A9_00B3_00A7_00A0i();
			else
			    ResLoadHelper.LoadAsset("data/config", _008B_00A7_0099YW_0091, System.Array.Empty<object>());
		}

		[Token(Token = "0x60071A6")]
		[Address(RVA = "0x72EAB28", Offset = "0x72E6B28", VA = "0x72EAB28")]
		private void _009F_008Br_00B7Mu()
		{
			GameFrameEntry.Initialize(GameFrameEntry.GetModule<UIModule>(), _0082_00BBf_0090_00B8_005D, System.Array.Empty<object>());
		}

		[Token(Token = "0x60071A7")]
		[Address(RVA = "0x72EAC58", Offset = "0x72E6C58", VA = "0x72EAC58")]
		private void J_0092_0090X_00ABn()
		{
		}
	}
}
