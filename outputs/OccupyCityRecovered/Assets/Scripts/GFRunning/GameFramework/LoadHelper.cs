using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

namespace GameFramework
{
	[Token(Token = "0x20002E1")]
	[Obsolete("此类已经过时，请使用ResLoadHelper加载资源", false)]
	public class LoadHelper
	{
		[Token(Token = "0x20002E2")]
		private sealed class _0081ql_00A7_009A_00A3
		{
			[Token(Token = "0x400181A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<int, GameObject> CallBack;

			[Token(Token = "0x400181B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int loadID;

			[Token(Token = "0x6005260")]
			[Address(RVA = "0x712B890", Offset = "0x7127890", VA = "0x712B890")]
			public _0081ql_00A7_009A_00A3()
			{
			}

			[Token(Token = "0x6005261")]
			[Address(RVA = "0x712D9C8", Offset = "0x71299C8", VA = "0x712D9C8")]
			internal void K_0094s_00A0_0090_00A3(GameObject obj)
			{
			}
		}

		[Token(Token = "0x20002E3")]
		private sealed class º_007D_00BCw_00ABJ
		{
			[Token(Token = "0x400181C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<int, GameObject> CallBack;

			[Token(Token = "0x400181D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int loadID;

			[Token(Token = "0x6005262")]
			[Address(RVA = "0x712B4F4", Offset = "0x71274F4", VA = "0x712B4F4")]
			public º_007D_00BCw_00ABJ()
			{
			}

			[Token(Token = "0x6005263")]
			[Address(RVA = "0x712D9EC", Offset = "0x71299EC", VA = "0x712D9EC")]
			internal void _008CL_00AC_0090_00AE_007B(GameObject obj)
			{
			}
		}

		[Token(Token = "0x20002E4")]
		private sealed class µ_0092MUU_00B0<T> where T : UnityEngine.Object
		{
			[Token(Token = "0x400181E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<int, T> CallBack;

			[Token(Token = "0x400181F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int loadID;

			[Token(Token = "0x6005264")]
			public µ_0092MUU_00B0()
			{
			}

			[Token(Token = "0x6005265")]
			internal void Q_00AF_008D_0080_00BFq(T obj)
			{
			}
		}

		[Token(Token = "0x20002E5")]
		private sealed class _00AD_00B1_009E_00A8_00A6Á
		{
			[Token(Token = "0x4001820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<int, Texture> CallBack;

			[Token(Token = "0x4001821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int loadID;

			[Token(Token = "0x6005266")]
			[Address(RVA = "0x712BA74", Offset = "0x7127A74", VA = "0x712BA74")]
			public _00AD_00B1_009E_00A8_00A6Á()
			{
			}

			[Token(Token = "0x6005267")]
			[Address(RVA = "0x712DA10", Offset = "0x7129A10", VA = "0x712DA10")]
			internal void µK_0089_00A4_00B6U(Texture obj)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002E6")]
		private struct _00AD_0084_0098VXI<T> : IAsyncStateMachine where T : UnityEngine.Object
		{
			[Token(Token = "0x4001822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x4001824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetName;

			[Token(Token = "0x4001825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string assetBundleName;

			[Token(Token = "0x4001826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<T> _003C_003Eu__1;

			[Token(Token = "0x6005268")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005269")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002E7")]
		private struct _009Dsºz_005DY : IAsyncStateMachine
		{
			[Token(Token = "0x4001827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x4001829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string PrefabsName;

			[Token(Token = "0x400182A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<GameObject> _003C_003Eu__1;

			[Token(Token = "0x600526A")]
			[Address(RVA = "0x712DA34", Offset = "0x7129A34", VA = "0x712DA34", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600526B")]
			[Address(RVA = "0x712DCDC", Offset = "0x7129CDC", VA = "0x712DCDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002E8")]
		private struct _0095PH_0081_00B3_00A1 : IAsyncStateMachine
		{
			[Token(Token = "0x400182B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400182C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<GameObject> _003C_003Et__builder;

			[Token(Token = "0x400182D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string PrefabsName;

			[Token(Token = "0x400182E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<GameObject> _003C_003Eu__1;

			[Token(Token = "0x600526C")]
			[Address(RVA = "0x712DD58", Offset = "0x7129D58", VA = "0x712DD58", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600526D")]
			[Address(RVA = "0x712E030", Offset = "0x712A030", VA = "0x712E030", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002E9")]
		private struct _009FO_008B_0089_0097_005E : IAsyncStateMachine
		{
			[Token(Token = "0x400182F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sceneName;

			[Token(Token = "0x4001832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isAdditive;

			[Token(Token = "0x4001833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<float> cbProgress;

			[Token(Token = "0x4001834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600526E")]
			[Address(RVA = "0x712E0AC", Offset = "0x712A0AC", VA = "0x712E0AC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600526F")]
			[Address(RVA = "0x712E2F0", Offset = "0x712A2F0", VA = "0x712E2F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002EA")]
		private struct _00B3_00B9l_00B8_007DÂ : IAsyncStateMachine
		{
			[Token(Token = "0x4001835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<int> LoadTakId;

			[Token(Token = "0x4001838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string sceneName;

			[Token(Token = "0x4001839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isAdditive;

			[Token(Token = "0x400183A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action<float> cbProgress;

			[Token(Token = "0x400183B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action<int> CallBack;

			[Token(Token = "0x400183C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int _003CloadID_003E5__2;

			[Token(Token = "0x400183D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6005270")]
			[Address(RVA = "0x712E358", Offset = "0x712A358", VA = "0x712E358", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005271")]
			[Address(RVA = "0x712E518", Offset = "0x712A518", VA = "0x712E518", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002EB")]
		private struct _008D_0060_008EUS_005D : IAsyncStateMachine
		{
			[Token(Token = "0x400183E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400183F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<AudioClip> _003C_003Et__builder;

			[Token(Token = "0x4001840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetBundleName;

			[Token(Token = "0x4001841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<AudioClip> _003C_003Eu__1;

			[Token(Token = "0x6005272")]
			[Address(RVA = "0x712E524", Offset = "0x712A524", VA = "0x712E524", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005273")]
			[Address(RVA = "0x712E83C", Offset = "0x712A83C", VA = "0x712E83C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002EC")]
		private struct M_0060_00B0_008C_0083_007B : IAsyncStateMachine
		{
			[Token(Token = "0x4001842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4001844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetBundleName;

			[Token(Token = "0x4001845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string _003CsaveKey_003E5__2;

			[Token(Token = "0x4001846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<Texture> _003C_003Eu__1;

			[Token(Token = "0x6005274")]
			[Address(RVA = "0x712E8B8", Offset = "0x712A8B8", VA = "0x712E8B8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005275")]
			[Address(RVA = "0x712EDD8", Offset = "0x712ADD8", VA = "0x712EDD8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002ED")]
		private struct _00AFf_0096_0092qg : IAsyncStateMachine
		{
			[Token(Token = "0x4001847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			[Token(Token = "0x4001849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetBundleName;

			[Token(Token = "0x400184A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<Texture> _003C_003Eu__1;

			[Token(Token = "0x6005276")]
			[Address(RVA = "0x712EE54", Offset = "0x712AE54", VA = "0x712EE54", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005277")]
			[Address(RVA = "0x712F338", Offset = "0x712B338", VA = "0x712F338", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002EE")]
		private struct _00ACfay_00A5_0099 : IAsyncStateMachine
		{
			[Token(Token = "0x400184B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400184C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<Texture2D> _003C_003Et__builder;

			[Token(Token = "0x400184D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string spriteName;

			[Token(Token = "0x400184E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string uiAtlas;

			[Token(Token = "0x400184F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<SpriteAtlas> _003C_003Eu__1;

			[Token(Token = "0x6005278")]
			[Address(RVA = "0x712F3B4", Offset = "0x712B3B4", VA = "0x712F3B4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005279")]
			[Address(RVA = "0x712F8EC", Offset = "0x712B8EC", VA = "0x712F8EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002EF")]
		private struct ª_00AFHf_0088_00BC : IAsyncStateMachine
		{
			[Token(Token = "0x4001850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<Texture> _003C_003Et__builder;

			[Token(Token = "0x4001852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string assetBundleName;

			[Token(Token = "0x4001853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<Texture> _003C_003Eu__1;

			[Token(Token = "0x600527A")]
			[Address(RVA = "0x712F968", Offset = "0x712B968", VA = "0x712F968", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600527B")]
			[Address(RVA = "0x712FC8C", Offset = "0x712BC8C", VA = "0x712FC8C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int T_00ADC_008B_0084_00AC;

		[Token(Token = "0x6005233")]
		[Address(RVA = "0x712B0DC", Offset = "0x71270DC", VA = "0x712B0DC")]
		public LoadHelper()
		{
		}

		[Token(Token = "0x6005234")]
		[Address(RVA = "0x712B0E4", Offset = "0x71270E4", VA = "0x712B0E4")]
		public static Task<Sprite> H_00BEª_00AE_0084l(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005235")]
		[Address(RVA = "0x712B1CC", Offset = "0x71271CC", VA = "0x712B1CC")]
		[Obsolete("此类已经过时，请使用ResLoadHelper.LoadScene", false)]
		[AsyncStateMachine(typeof(_009FO_008B_0089_0097_005E))]
		public static Task LoadScene(string x_008A_00BE_0098_007Ej, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] Action<float> _008E_0086_00BD_0098k_00B9)
		{
			return null;
		}

		[Token(Token = "0x6005236")]
		[Address(RVA = "0x712B2A8", Offset = "0x71272A8", VA = "0x712B2A8")]
		public static Task<GameObject> S_009F_00B8g_00BD_008F(string _008CCxDyg)
		{
			return null;
		}

		[Token(Token = "0x6005237")]
		[Address(RVA = "0x712B38C", Offset = "0x712738C", VA = "0x712B38C")]
		[Obsolete("此类已经过时，请使用ResLoadHelper.LoadModelPrefab", false)]
		public static void LoadModelPrefab(string _008CCxDyg, Action<int, GameObject> Q_0093VK_0093y, [Optional] Action<int> TteSq_00A2)
		{
		}

		[Token(Token = "0x6005238")]
		[Address(RVA = "0x712B558", Offset = "0x7127558", VA = "0x712B558")]
		[Obsolete("此类已经过时，请使用ResLoadHelper.LoadPrefab", false)]
		[AsyncStateMachine(typeof(_0095PH_0081_00B3_00A1))]
		public static Task<GameObject> LoadPrefab(string _008CCxDyg)
		{
			return null;
		}

		[Token(Token = "0x6005239")]
		[Address(RVA = "0x712B63C", Offset = "0x712763C", VA = "0x712B63C")]
		public static Task<Texture2D> C_0087_0095_00A1_008F_00B3(string _0091_0085_005BDº_009C, string I_00AF_00B2_00BD_009DÂ)
		{
			return null;
		}

		[Token(Token = "0x600523A")]
		[Obsolete("此类已经过时，请使用ResLoadHelper.LoadAsset", false)]
		[AsyncStateMachine(typeof(global::GameFramework.LoadHelper._00AD_0084_0098VXI<>))]
		public static Task<T> LoadAsset<T>(string µZºV_0089_00AB, [Optional] string M_009E_00AD_005B_007CO) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600523B")]
		[Address(RVA = "0x712B728", Offset = "0x7127728", VA = "0x712B728")]
		public static void eD_00BE_00B2_0081_00AD(string _008CCxDyg, Action<int, GameObject> Q_0093VK_0093y, [Optional] Action<int> TteSq_00A2)
		{
		}

		[Token(Token = "0x600523C")]
		[Address(RVA = "0x712B898", Offset = "0x7127898", VA = "0x712B898")]
		[Obsolete("此类已经过时，请使用ResLoadHelper.LoadTexture加载资源", false)]
		public static void LoadTexture(string µZºV_0089_00AB, Action<int, Texture> Q_0093VK_0093y, [Optional] Action<int> TteSq_00A2)
		{
		}

		[Token(Token = "0x600523D")]
		[Address(RVA = "0x712BA7C", Offset = "0x7127A7C", VA = "0x712BA7C")]
		public static Task<AudioClip> Kf_0083_00B3_0090r(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x600523E")]
		[Address(RVA = "0x712BB60", Offset = "0x7127B60", VA = "0x712BB60")]
		public static Task<GameObject> P_008CI_00BE_00A7B(string _008CCxDyg)
		{
			return null;
		}

		[Token(Token = "0x600523F")]
		[Address(RVA = "0x712BC44", Offset = "0x7127C44", VA = "0x712BC44")]
		public static Task<GameObject> P_008B_0081_007CC_00A3(string _008CCxDyg)
		{
			return null;
		}

		[Token(Token = "0x6005240")]
		[Address(RVA = "0x712BD28", Offset = "0x7127D28", VA = "0x712BD28")]
		public static Task o_008D_00AEb_00AF_00A7(string x_008A_00BE_0098_007Ej, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] Action<float> _008E_0086_00BD_0098k_00B9)
		{
			return null;
		}

		[Token(Token = "0x6005241")]
		[Address(RVA = "0x712BE04", Offset = "0x7127E04", VA = "0x712BE04")]
		public static Task<Sprite> _00A1i_00B4_009BgZ(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005242")]
		[Obsolete("此类已经过时，请使用ResLoadHelper.LoadAsset", false)]
		public static void LoadAsset<T>(string µZºV_0089_00AB, Action<int, T> Q_0093VK_0093y, [Optional] Action<int> TteSq_00A2, [Optional] string M_009E_00AD_005B_007CO) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x6005243")]
		[Address(RVA = "0x712BEEC", Offset = "0x7127EEC", VA = "0x712BEEC")]
		public static Task<Texture> _00A8_0087tPF_00A0(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005244")]
		[Address(RVA = "0x712BFD0", Offset = "0x7127FD0", VA = "0x712BFD0")]
		public static Task<AudioClip> _008F_0082H_00A3_007Cb(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005245")]
		[Address(RVA = "0x712C0B4", Offset = "0x71280B4", VA = "0x712C0B4")]
		public static Task<Texture2D> _00B6_0090_00B6_00B2_00B2_00BF(string _0091_0085_005BDº_009C, string I_00AF_00B2_00BD_009DÂ)
		{
			return null;
		}

		[Token(Token = "0x6005246")]
		[Address(RVA = "0x712C1A0", Offset = "0x71281A0", VA = "0x712C1A0")]
		public static Task<AudioClip> i_00B9_009Bª_005El(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005247")]
		[Address(RVA = "0x712C284", Offset = "0x7128284", VA = "0x712C284")]
		public static Task _00A8_0094gE_008A_005D(string x_008A_00BE_0098_007Ej, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] Action<float> _008E_0086_00BD_0098k_00B9)
		{
			return null;
		}

		[Token(Token = "0x6005248")]
		[Address(RVA = "0x712C360", Offset = "0x7128360", VA = "0x712C360")]
		public static Task<Texture> _00AD_0096_00A8_00B3vg(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005249")]
		[Address(RVA = "0x712C444", Offset = "0x7128444", VA = "0x712C444")]
		public static Task<GameObject> _00BEB_0099_00B7_0083_007F(string _008CCxDyg)
		{
			return null;
		}

		[Token(Token = "0x600524A")]
		[Address(RVA = "0x712C528", Offset = "0x7128528", VA = "0x712C528")]
		[AsyncStateMachine(typeof(_00AFf_0096_0092qg))]
		[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
		public static Task<Sprite> LoadSpriteForAll(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x600524B")]
		[Address(RVA = "0x712C60C", Offset = "0x712860C", VA = "0x712C60C")]
		public static Task<Sprite> _009COGsju(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x600524C")]
		[Address(RVA = "0x712C6F4", Offset = "0x71286F4", VA = "0x712C6F4")]
		public static Task<GameObject> _0090_00BBnF_00AD_00A9(string _008CCxDyg)
		{
			return null;
		}

		[Token(Token = "0x600524D")]
		[Address(RVA = "0x712C7D8", Offset = "0x71287D8", VA = "0x712C7D8")]
		public static void _00A5ª_0096t_00AF_00BB(string _008CCxDyg, Action<int, GameObject> Q_0093VK_0093y, [Optional] Action<int> TteSq_00A2)
		{
		}

		[Token(Token = "0x600524E")]
		[Address(RVA = "0x712C940", Offset = "0x7128940", VA = "0x712C940")]
		public static void _0087_00A3nK_00A0_0095(string _008CCxDyg, Action<int, GameObject> Q_0093VK_0093y, [Optional] Action<int> TteSq_00A2)
		{
		}

		[Token(Token = "0x600524F")]
		[Address(RVA = "0x712CAA8", Offset = "0x7128AA8", VA = "0x712CAA8")]
		public static Task<Texture> _005EG_00B4_005E_00A5_0088(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005250")]
		[Address(RVA = "0x712CB8C", Offset = "0x7128B8C", VA = "0x712CB8C")]
		[Obsolete("此类已经过时，请使用ResLoadHelper.LoadPrefab", false)]
		public static void LoadPrefab(string _008CCxDyg, Action<int, GameObject> Q_0093VK_0093y, [Optional] Action<int> TteSq_00A2)
		{
		}

		[Token(Token = "0x6005251")]
		[Address(RVA = "0x712CCF4", Offset = "0x7128CF4", VA = "0x712CCF4")]
		public static Task B_00A5l_007E_00A1z(string x_008A_00BE_0098_007Ej, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] Action<float> _008E_0086_00BD_0098k_00B9)
		{
			return null;
		}

		[Token(Token = "0x6005252")]
		[Address(RVA = "0x712CDD0", Offset = "0x7128DD0", VA = "0x712CDD0")]
		[AsyncStateMachine(typeof(M_0060_00B0_008C_0083_007B))]
		[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
		public static Task<Sprite> LoadSprite(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005253")]
		[Address(RVA = "0x712CEB8", Offset = "0x7128EB8", VA = "0x712CEB8")]
		[AsyncStateMachine(typeof(global::GameFramework.LoadHelper._009Dsºz_005DY))]
		[Obsolete("此类已经过时，请使用ResLoadHelper.LoadModelPrefab", false)]
		public static Task<GameObject> LoadModelPrefab(string _008CCxDyg)
		{
			return null;
		}

		[Token(Token = "0x6005254")]
		[Address(RVA = "0x712CF9C", Offset = "0x7128F9C", VA = "0x712CF9C")]
		[Obsolete("此类已经过时，请使用ResLoadHelper.LoadScene", false)]
		[AsyncStateMachine(typeof(_00B3_00B9l_00B8_007DÂ))]
		public static void LoadScene(string x_008A_00BE_0098_007Ej, Action<int> Q_0093VK_0093y, [Optional] Action<int> TteSq_00A2, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] Action<float> _008E_0086_00BD_0098k_00B9)
		{
		}

		[Token(Token = "0x6005255")]
		[Address(RVA = "0x712D058", Offset = "0x7129058", VA = "0x712D058")]
		public static Task<Sprite> _00AD_00AF_00B2_0096S_009C(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005256")]
		[Address(RVA = "0x712D140", Offset = "0x7129140", VA = "0x712D140")]
		public static void _005B_008BTOWµ(string _008CCxDyg, Action<int, GameObject> Q_0093VK_0093y, [Optional] Action<int> TteSq_00A2)
		{
		}

		[Token(Token = "0x6005257")]
		[Address(RVA = "0x712D2A8", Offset = "0x71292A8", VA = "0x712D2A8")]
		public static Task _00B9g_005EzAE(string x_008A_00BE_0098_007Ej, [Optional][DefaultParameterValue(false)] bool _005Ddk_00A3Ol, [Optional] Action<float> _008E_0086_00BD_0098k_00B9)
		{
			return null;
		}

		[Token(Token = "0x6005258")]
		[Address(RVA = "0x712D384", Offset = "0x7129384", VA = "0x712D384")]
		public static Task<Texture> _00A4t_00A6_008C_009D_00B9(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x6005259")]
		[Address(RVA = "0x712D468", Offset = "0x7129468", VA = "0x712D468")]
		[AsyncStateMachine(typeof(global::GameFramework.LoadHelper._008D_0060_008EUS_005D))]
		[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
		public static Task<AudioClip> LoadSound(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x600525A")]
		[Address(RVA = "0x712B4FC", Offset = "0x71274FC", VA = "0x712B4FC")]
		private static int pO_00AF_0085G_005D()
		{
			return default;
		}

		[Token(Token = "0x600525B")]
		[Address(RVA = "0x712D54C", Offset = "0x712954C", VA = "0x712D54C")]
		public static Task<Sprite> Fwenº_00BE(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x600525C")]
		[Address(RVA = "0x712D630", Offset = "0x7129630", VA = "0x712D630")]
		public static Task<Sprite> f_0082_00B7uba(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x600525D")]
		[Address(RVA = "0x712D714", Offset = "0x7129714", VA = "0x712D714")]
		public static Task<Sprite> Aª_0089_00BDi_00A3(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x600525E")]
		[Address(RVA = "0x712D7F8", Offset = "0x71297F8", VA = "0x712D7F8")]
		[AsyncStateMachine(typeof(ª_00AFHf_0088_00BC))]
		[Obsolete("此类已经过时，请使用ResLoadHelper.LoadTexture加载资源", false)]
		public static Task<Texture> LoadTexture(string µZºV_0089_00AB)
		{
			return null;
		}

		[Token(Token = "0x600525F")]
		[Address(RVA = "0x712D8DC", Offset = "0x71298DC", VA = "0x712D8DC")]
		[AsyncStateMachine(typeof(_00ACfay_00A5_0099))]
		[Obsolete("此类已经过时，请使用ResourcesModule加载资源", false)]
		public static Task<Texture2D> LoadTexture2DForAtlas(string _0091_0085_005BDº_009C, string I_00AF_00B2_00BD_009DÂ)
		{
			return null;
		}
	}
}
