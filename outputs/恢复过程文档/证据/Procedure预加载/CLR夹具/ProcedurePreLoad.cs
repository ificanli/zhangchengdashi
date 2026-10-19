using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using GameFramework.Fsm;
using GameFramework.Procedure;
using Il2CppDummyDll;
using L_Tools;

namespace ljzs_lt.Procedure
{
	[Token(Token = "0x2000F51")]
	public class ProcedurePreLoad : ProcedureBase
	{
		[Token(Token = "0x2000F52")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x40069D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LoginControl loginControl;

			[Token(Token = "0x40069D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action afterLoginAction;

			[Token(Token = "0x6005BBE")]
			[Address(RVA = "0x439FED8", Offset = "0x439BED8", VA = "0x439FED8")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6005BC0")]
			[Address(RVA = "0x439FF74", Offset = "0x439BF74", VA = "0x439FF74")]
			internal void _003CPreLoadAsync_003Eb__1(bool b)
			{
    if (b)
    {
        GameFramework.CLog.Log("Login 登录成功");
        afterLoginAction?.Invoke();
    }
    else
    {
        AccountMsgCanvas.SetContent(I2.Loc.LocalizationManager.GetTranslation("Login_Failed", true, 0, true, false, null, null, true), I2.Loc.LocalizationManager.GetTranslation("Login_Failed_Message", true, 0, true, false, null, null, true), "重试", _003CPreLoadAsync_003Eg__TryLogin_007C0, false, false);
    }
}

[Token(Token = "0x6005BBF")]
[Address(RVA = "0x439FEE0", Offset = "0x439BEE0", VA = "0x439FEE0")]
internal void _003CPreLoadAsync_003Eg__TryLogin_007C0()
{
 loginControl.Login(_003CPreLoadAsync_003Eb__1, false);
}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000F53")]
		[CompilerGenerated]
		private struct _003CPreLoadAsync_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x40069D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40069D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40069D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ProcedurePreLoad _003C_003E4__this;

			[Token(Token = "0x40069D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

			[Token(Token = "0x40069D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005BC1")]
			[Address(RVA = "0x43A01BC", Offset = "0x439C1BC", VA = "0x43A01BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005BC2")]
			[Address(RVA = "0x43A0798", Offset = "0x439C798", VA = "0x43A0798", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40069D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IFsm<IProcedureManager> m_ProcedureOwner;

		[Token(Token = "0x6005BB4")]
		[Address(RVA = "0x439F84C", Offset = "0x439B84C", VA = "0x439F84C", Slot = "4")]
		public override void OnInit(IFsm<IProcedureManager> procedureOwner)
		{
    base.OnInit(procedureOwner);
    m_ProcedureOwner = procedureOwner;
}

		[Token(Token = "0x6005BB5")]
		[Address(RVA = "0x439F874", Offset = "0x439B874", VA = "0x439F874", Slot = "5")]
		public override void OnEnter(IFsm<IProcedureManager> procedureOwner)
		{
    base.OnEnter(procedureOwner);
    PreLoad();
}

		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0x439F890", Offset = "0x439B890", VA = "0x439F890")]
		private void PreLoad()
		{
    PreLoadAsync();
    UnityEngine.Debug.Log("预加载完成");
    ChangeState<ProcedureStarGame>(m_ProcedureOwner, System.Array.Empty<object>());
}

		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0x439F998", Offset = "0x439B998", VA = "0x439F998")]
		private async void PreLoadAsync()
		{
    var closure = new _003C_003Ec__DisplayClass4_0();
    InitGameSetting();
    var assetsManager = AssetsModule.AssetsManager.Instance;
    UnityEngine.Object.DontDestroyOnLoad(assetsManager.gameObject);
    await assetsManager.Init();
    LocalizationModule.Runtime.CustomBundlesManager.Instance.Preload().Forget();
    new UnityEngine.GameObject("DataCompareMgr").AddComponent<DataModule.DataCompareMgr>();
    closure.loginControl = new L_Tools.LoginControl(OnLoginValid);
    string appChannelGroup = DBTSDK.AppInfoManager.Instance.GetAppChannelGroup();
    if (!string.IsNullOrEmpty(appChannelGroup))
    {
        UnityEngine.Debug.Log(appChannelGroup);
        if (appChannelGroup.ToLower().Contains("huawei"))
        {
            closure.loginControl.IsDefaultTouristLogin = false;
            closure.loginControl.UseLoginCache = false;
        }
    }

    closure.afterLoginAction = null;
    closure._003CPreLoadAsync_003Eg__TryLogin_007C0();
}

		[Token(Token = "0x6005BB8")]
		[Address(RVA = "0x439FA28", Offset = "0x439BA28", VA = "0x439FA28")]
		private void InitGameSetting()
		{
    I2.Loc.LocalizationManager.EnableChangingCultureInfo(false);
    LocalizationModule.StartupLanguageHelper.EnsureStartupLanguage();
    System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
    System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
    System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
    ToolModule.LitJsonExtent.Init();
}

		[Token(Token = "0x6005BB9")]
		[Address(RVA = "0x439FB50", Offset = "0x439BB50", VA = "0x439FB50")]
		private void OnLoginValid(int errorCode)
		{
    if (errorCode == 1019)
    {
        AccountMsgCanvas.SetContent(I2.Loc.LocalizationManager.GetTranslation("Login_Vaild", true, 0, true, false, null, null, true), I2.Loc.LocalizationManager.GetTranslation("Login_Vaild_Message", true, 0, true, false, null, null, true), I2.Loc.LocalizationManager.GetTranslation("Exit_Game", true, 0, true, false, null, null, true), AccountMsgCanvas.ExitGame, false, false);
    }
    else if (errorCode == 3302)
    {
        AccountMsgCanvas.SetContent(I2.Loc.LocalizationManager.GetTranslation("Login_Vaild", true, 0, true, false, null, null, true), "该账号已被封禁,如有疑问请联系客服反馈", I2.Loc.LocalizationManager.GetTranslation("Exit_Game", true, 0, true, false, null, null, true), AccountMsgCanvas.ExitGame, true, true);
    }
    else
    {
        AccountMsgCanvas.SetContent(I2.Loc.LocalizationManager.GetTranslation("Login_Failed", true, 0, true, false, null, null, true), string.Format("Error Code : {0}", errorCode), I2.Loc.LocalizationManager.GetTranslation("Exit_Game", true, 0, true, false, null, null, true), AccountMsgCanvas.ExitGame, false, false);
    }
}

		[Token(Token = "0x6005BBA")]
		[Address(RVA = "0x439FEBC", Offset = "0x439BEBC", VA = "0x439FEBC", Slot = "7")]
		public override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
    base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
}

		[Token(Token = "0x6005BBB")]
		[Address(RVA = "0x439FEC4", Offset = "0x439BEC4", VA = "0x439FEC4", Slot = "8")]
		public override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
		{
    base.OnLeave(procedureOwner, isShutdown);
}

		[Token(Token = "0x6005BBC")]
		[Address(RVA = "0x439FED0", Offset = "0x439BED0", VA = "0x439FED0", Slot = "9")]
		public override void OnDestroy(IFsm<IProcedureManager> procedureOwner)
		{
    base.OnDestroy(procedureOwner);
}

		[Token(Token = "0x6005BBD")]
		[Address(RVA = "0x439BC74", Offset = "0x4397C74", VA = "0x439BC74")]
		public ProcedurePreLoad()
		{
		}
	}
}
