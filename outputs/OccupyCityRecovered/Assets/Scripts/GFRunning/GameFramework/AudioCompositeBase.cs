using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x2000323")]
	public abstract class AudioCompositeBase
	{
		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		private static Func<GameObject, AudioActionType, int, Action<int>, Action<int>, AudioActionBase> _00A7_0094GÁI_0098;

		[Token(Token = "0x4001951")]
		[FieldOffset(Offset = "0x10")]
		protected int s_NodeId;

		[Token(Token = "0x4001952")]
		[FieldOffset(Offset = "0x18")]
		protected GameObject s_AudioRoot;

		[Token(Token = "0x14000014")]
		public static event Func<GameObject, AudioActionType, int, Action<int>, Action<int>, AudioActionBase> OnCustomCreateAudio
		{
			[Token(Token = "0x60054CA")]
			[Address(RVA = "0x7150684", Offset = "0x714C684", VA = "0x7150684")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60054CB")]
			[Address(RVA = "0x7150750", Offset = "0x714C750", VA = "0x7150750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60054CC")]
		[Address(RVA = "0x715081C", Offset = "0x714C81C", VA = "0x715081C")]
		protected AudioCompositeBase(GameObject _00B7_00A8z_00A2X_00BE, int _009B_0097N_0098_00BD_008D, string _00AE_008C_009AiPJ)
		{
		}

		[Token(Token = "0x60054CD")]
		[Address(RVA = "0x71508AC", Offset = "0x714C8AC", VA = "0x71508AC")]
		public int GetNodeId()
		{
			return default;
		}

		[Token(Token = "0x60054CE")]
		[Address(RVA = "0x71508B4", Offset = "0x714C8B4", VA = "0x71508B4")]
		protected AudioActionBase NewAudio(AudioActionType GTz_0080_0080_0060, int _009DH_0084µ_009C_00B0, Action<int> wj_00AD_00A1_009A_0095, Action<int> Vt_009Aªr_00AF)
		{
			return null;
		}

		[Token(Token = "0x60054CF")]
		[Address(RVA = "0x7150A7C", Offset = "0x714CA7C", VA = "0x7150A7C")]
		public AudioActionType getAudioType(int _009DH_0084µ_009C_00B0)
		{
			return default;
		}

		[Token(Token = "0x60054D0")]
		[Address(RVA = "0x7150AB8", Offset = "0x714CAB8", VA = "0x7150AB8", Slot = "4")]
		public virtual void StopByGUID(int Ha_0098_005D_009F_0087)
		{
		}

		[Token(Token = "0x60054D1")]
		public abstract int[] Play(params int[] µb_0092f_0086_0086);

		[Token(Token = "0x60054D2")]
		public abstract int[] Play(GameObject a_0090_0091_0083_00BC_00BF, params int[] µb_0092f_0086_0086);

		[Token(Token = "0x60054D3")]
		public abstract void Stop(int _0089wV_0060_00A4U = 0);

		[Token(Token = "0x60054D4")]
		public abstract void Pause(bool lE_005E_00B4_0097E);

		[Token(Token = "0x60054D5")]
		public abstract void Destroy();
	}
}
