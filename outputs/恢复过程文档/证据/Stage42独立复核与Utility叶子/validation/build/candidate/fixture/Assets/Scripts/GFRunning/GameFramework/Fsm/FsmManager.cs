using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.Fsm
{
	[Token(Token = "0x2000493")]
	public sealed class FsmManager : GameFrameModule, IFsmManager
	{
		[Token(Token = "0x4001EE2")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, FsmBase> m_Fsms;

		[Token(Token = "0x4001EE3")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<FsmBase> m_TempFsms;

		[Token(Token = "0x4001EE4")]
		[FieldOffset(Offset = "0x30")]
		private List<FsmBase> m_deleteFsm = new List<FsmBase>();

		[Token(Token = "0x170011E6")]
		internal override int Priority
		{
			[Token(Token = "0x6006CD8")]
			[Address(RVA = "0x7296CB0", Offset = "0x7292CB0", VA = "0x7296CB0", Slot = "4")]
			get
			{
			return 80;
		}
		}

		[Token(Token = "0x170011E7")]
		public int Count
		{
			[Token(Token = "0x6006CD9")]
			[Address(RVA = "0x7296CB8", Offset = "0x7292CB8", VA = "0x7296CB8", Slot = "10")]
			get
			{
			return m_Fsms.Count;
		}
		}

		[Token(Token = "0x6006CD7")]
		[Address(RVA = "0x7296BD0", Offset = "0x7292BD0", VA = "0x7296BD0")]
		public FsmManager()
		{
			m_Fsms = new Dictionary<string, FsmBase>();
			m_TempFsms = new List<FsmBase>();
		}

		[Token(Token = "0x6006CDA")]
		[Address(RVA = "0x7296D08", Offset = "0x7292D08", VA = "0x7296D08", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
			for (int i = 0; i < m_TempFsms.Count; i++)
			{
			    FsmBase fsm = m_TempFsms[i];
			    if (!fsm.IsDestroyed)
			        fsm.Update(elapseSeconds, realElapseSeconds);
			}
		}

		[Token(Token = "0x6006CDB")]
		[Address(RVA = "0x7296DD0", Offset = "0x7292DD0", VA = "0x7296DD0", Slot = "9")]
		internal override void Shutdown()
		{
			foreach (KeyValuePair<string, FsmBase> fsm in m_Fsms)
			    fsm.Value.Shutdown();
			m_Fsms.Clear();
			m_TempFsms.Clear();
			x_0080_008D_00B1f_0086 = false;
		}

		[Token(Token = "0x6006CDC")]
		public bool HasFsm<T>() where T : class
		{
			return HasFsm<T>(string.Empty);
		}

		[Token(Token = "0x6006CDD")]
		public bool HasFsm<T>(string name) where T : class
		{
			return m_Fsms.ContainsKey(Utility.Text.GetFullName<T>(name));
		}

		[Token(Token = "0x6006CDE")]
		public IFsm<T> GetFsm<T>() where T : class
		{
			return GetFsm<T>(string.Empty);
		}

		[Token(Token = "0x6006CDF")]
		public IFsm<T> GetFsm<T>(string name) where T : class
		{
			FsmBase fsm;
			return m_Fsms.TryGetValue(Utility.Text.GetFullName<T>(name), out fsm) ? (Fsm<T>)fsm : null;
		}

		[Token(Token = "0x6006CE0")]
		[Address(RVA = "0x7296F9C", Offset = "0x7292F9C", VA = "0x7296F9C", Slot = "15")]
		public FsmBase[] GetAllFsms()
		{
			FsmBase[] fsms = new FsmBase[m_Fsms.Count];
			int index = 0;
			foreach (KeyValuePair<string, FsmBase> fsm in m_Fsms)
			    fsms[index++] = fsm.Value;
			return fsms;
		}

		[Token(Token = "0x6006CE1")]
		public IFsm<T> CreateFsm<T>(T owner, params FsmState<T>[] states) where T : class
		{
			return CreateFsm(string.Empty, owner, states);
		}

		[Token(Token = "0x6006CE2")]
		public IFsm<T> CreateFsm<T>(string name, T owner, params FsmState<T>[] states) where T : class
		{
			if (HasFsm<T>(name))
			    throw new GameFrameworkException(string.Format("Already exist FSM '{0}'.", Utility.Text.GetFullName<T>(name)));
			Fsm<T> fsm = new Fsm<T>(name, owner, states);
			fsm.FullName = Utility.Text.GetFullName<T>(name);
			m_Fsms.Add(fsm.FullName, fsm);
			m_TempFsms.Add(fsm);
			return fsm;
		}

		[Token(Token = "0x6006CE3")]
		public bool DestroyFsm<T>() where T : class
		{
			return DestroyFsm<T>(string.Empty);
		}

		[Token(Token = "0x6006CE4")]
		public bool DestroyFsm<T>(string name) where T : class
		{
			string fullName = Utility.Text.GetFullName<T>(name);
			FsmBase fsm;
			if (!m_Fsms.TryGetValue(fullName, out fsm))
			    return false;
			fsm.Shutdown();
			m_Fsms.Remove(fullName);
			m_TempFsms.Remove(fsm);
			return true;
		}

		[Token(Token = "0x6006CE5")]
		public bool DestroyFsm<T>(IFsm<T> fsm) where T : class
		{
			if (fsm == null)
			    throw new GameFrameworkException("FSM is invalid.");
			return DestroyFsm<T>(fsm.Name);
		}

		[Token(Token = "0x6006CE6")]
		[Address(RVA = "0x7297184", Offset = "0x7293184", VA = "0x7297184", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
			x_0080_008D_00B1f_0086 = true;
			Àª_00A6_00A3_00BDE?.Invoke();
		}

		[Token(Token = "0x6006CE7")]
		[Address(RVA = "0x72971A8", Offset = "0x72931A8", VA = "0x72971A8", Slot = "6")]
		internal override void Start()
		{
			// Original ARM64 method is RET.
		}
	}
}
