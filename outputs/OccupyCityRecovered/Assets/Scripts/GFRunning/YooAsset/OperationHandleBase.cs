using System.Collections;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x2000076")]
	public abstract class OperationHandleBase : IEnumerator
	{
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x10")]
		private readonly AssetInfo _00A2K_0090_00A9_009Fj;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x18")]
		private _00A2_00A1_00B8Hcp _005B_009B_0090_00B1_00BB_00B0;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x20")]
		public object[] Args;

		[Token(Token = "0x1700003F")]
		internal _00A2_00A1_00B8Hcp _008E_00B8_0087_00B3u_00B2
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x718DE20", Offset = "0x7189E20", VA = "0x718DE20")]
			get
			{
				return _00A2_00B0_0088_0088_00A9H();
			}
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x718DE18", Offset = "0x7189E18", VA = "0x718DE18")]
			private set
			{
				JNE_009FQj(value);
			}
		}

		[Token(Token = "0x17000040")]
		public EOperationStatus Status
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x718DFB4", Offset = "0x7189FB4", VA = "0x718DFB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000041")]
		public string LastError
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x718E004", Offset = "0x718A004", VA = "0x718E004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public float Progress
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x718DF00", Offset = "0x7189F00", VA = "0x718DF00")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000043")]
		public bool IsDone
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x718E070", Offset = "0x718A070", VA = "0x718E070")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000044")]
		public bool IsValid
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x718E134", Offset = "0x718A134", VA = "0x718E134")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000045")]
		internal bool _00A9wh_00AD_0082_00B9
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x7188754", Offset = "0x7184754", VA = "0x7188754")]
			get
			{
				return i_008A_00B8m_0095_0093();
			}
		}

		[Token(Token = "0x17000046")]
		public Task Task
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x718E154", Offset = "0x718A154", VA = "0x718E154")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x718E18C", Offset = "0x718A18C", VA = "0x718E18C", Slot = "5")]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x718DE18", Offset = "0x7189E18", VA = "0x718DE18")]
		private void JNE_009FQj(_00A2_00A1_00B8Hcp _00A3_0092T_007E_00ABc)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x718DE20", Offset = "0x7189E20", VA = "0x718DE20")]
		internal _00A2_00A1_00B8Hcp _00A2_00B0_0088_0088_00A9H()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		public T GetArg<T>(int g_0097mKyÂ)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED OperationHandleBase.GetArg RVA= Token=0x6000571");
}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x71889E8", Offset = "0x71849E8", VA = "0x71889E8")]
		internal OperationHandleBase(_00A2_00A1_00B8Hcp k_00ABHJ_0083R)
		{
		}

		[Token(Token = "0x6000573")]
		internal abstract void _00B3Cq_009Cwl();

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x718DE28", Offset = "0x7189E28", VA = "0x718DE28")]
		public AssetInfo GetAssetInfo()
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x718DE30", Offset = "0x7189E30", VA = "0x718DE30")]
		public DownloadReport GetDownloadReport()
		{
			return default;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x718DE90", Offset = "0x7189E90", VA = "0x718DE90")]
		public float GetLoadProgress()
		{
			return default;
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x7188754", Offset = "0x7184754", VA = "0x7188754")]
		internal bool i_008A_00B8m_0095_0093()
		{
			return default;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x71886F0", Offset = "0x71846F0", VA = "0x71886F0")]
		internal void IGFtA_00AB()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x718E170", Offset = "0x718A170", VA = "0x718E170", Slot = "4")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x718E188", Offset = "0x718A188", VA = "0x718E188", Slot = "6")]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x718E18C", Offset = "0x718A18C", VA = "0x718E18C", Slot = "5")]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}
}
