using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.Fsm
{
	[Token(Token = "0x2000490")]
	internal sealed class Fsm<T> : FsmBase, IFsm<T> where T : class
	{
		[Token(Token = "0x4001EDA")]
		[FieldOffset(Offset = "0x0")]
		private readonly T m_Owner;

		[Token(Token = "0x4001EDB")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, FsmState<T>> m_States;

		[Token(Token = "0x4001EDC")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, Variable> m_Datas;

		[Token(Token = "0x4001EDD")]
		[FieldOffset(Offset = "0x0")]
		private FsmState<T> m_CurrentState;

		[Token(Token = "0x4001EDE")]
		[FieldOffset(Offset = "0x0")]
		private float m_CurrentStateTime;

		[Token(Token = "0x4001EDF")]
		[FieldOffset(Offset = "0x0")]
		private bool m_IsDestroyed;

		[Token(Token = "0x170011D6")]
		public T Owner
		{
			[Token(Token = "0x6006CAD")]
			get
			{
			return m_Owner;
		}
		}

		[Token(Token = "0x170011D7")]
		public override Type OwnerType
		{
			[Token(Token = "0x6006CAE")]
			get
			{
			return typeof(T);
		}
		}

		[Token(Token = "0x170011D8")]
		public override int FsmStateCount
		{
			[Token(Token = "0x6006CAF")]
			get
			{
			return m_States.Count;
		}
		}

		[Token(Token = "0x170011D9")]
		public override bool IsRunning
		{
			[Token(Token = "0x6006CB0")]
			get
			{
			return m_CurrentState != null;
		}
		}

		[Token(Token = "0x170011DA")]
		public override bool IsDestroyed
		{
			[Token(Token = "0x6006CB1")]
			get
			{
			return m_IsDestroyed;
		}
		}

		[Token(Token = "0x170011DB")]
		public FsmState<T> CurrentState
		{
			[Token(Token = "0x6006CB2")]
			get
			{
			return m_CurrentState;
		}
		}

		[Token(Token = "0x170011DC")]
		public override string CurrentStateName
		{
			[Token(Token = "0x6006CB3")]
			get
			{
			return m_CurrentState == null ? null : m_CurrentState.GetType().FullName;
		}
		}

		[Token(Token = "0x170011DD")]
		public override float CurrentStateTime
		{
			[Token(Token = "0x6006CB4")]
			get
			{
			return m_CurrentStateTime;
		}
		}

		[Token(Token = "0x6006CAC")]
		public Fsm(string name, T owner, params FsmState<T>[] states) : base(name)
		{
			if (owner == null)
			    throw new GameFrameworkException("FSM owner is invalid.");
			if (states == null || states.Length == 0)
			    throw new GameFrameworkException("FSM states is invalid.");
			m_Owner = owner;
			m_States = new Dictionary<string, FsmState<T>>();
			m_Datas = new Dictionary<string, Variable>();
			foreach (FsmState<T> state in states)
			{
			    if (state == null)
			        throw new GameFrameworkException("FSM states is invalid.");
			    string stateName = state.GetType().FullName;
			    if (m_States.ContainsKey(stateName))
			        throw new GameFrameworkException(string.Format("FSM '{0}' state '{1}' is already exist.", Utility.Text.GetFullName<T>(name), stateName));
			    m_States.Add(stateName, state);
			    state.OnInit(this);
			}
			m_CurrentStateTime = 0f;
			m_CurrentState = null;
			m_IsDestroyed = false;
		}

		[Token(Token = "0x6006CB5")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
			if (m_CurrentState != null)
			{
			    m_CurrentStateTime += elapseSeconds;
			    m_CurrentState.OnUpdate(this, elapseSeconds, realElapseSeconds);
			}
		}

		[Token(Token = "0x6006CB6")]
		internal override void Shutdown()
		{
			if (m_CurrentState != null)
			{
			    m_CurrentState.OnLeave(this, true);
			    m_CurrentState = null;
			    m_CurrentStateTime = 0f;
			}
			foreach (KeyValuePair<string, FsmState<T>> state in m_States)
			    state.Value.OnDestroy(this);
			m_States.Clear();
			m_Datas.Clear();
			m_IsDestroyed = true;
		}

		[Token(Token = "0x6006CB7")]
		public void Start<TState>(params object[] args) where TState : FsmState<T>
		{
			Start(typeof(TState), args);
		}

		[Token(Token = "0x6006CB8")]
		public void Start(Type stateType, params object[] args)
		{
			if (IsRunning)
			    throw new GameFrameworkException("FSM is running, can not start again.");
			FsmState<T> state = GetState(stateType);
			if (state == null)
			    throw new GameFrameworkException(string.Format("FSM '{0}' can not start state '{1}' which is not exist.", Utility.Text.GetFullName<T>(Name), stateType.FullName));
			m_CurrentStateTime = 0f;
			m_CurrentState = state;
			if (args != null && args.Length > 0)
			    state.OnEnter(this, args);
			else
			    state.OnEnter(this);
		}

		[Token(Token = "0x6006CB9")]
		public bool HasState<TState>() where TState : FsmState<T>
		{
			return HasState(typeof(TState));
		}

		[Token(Token = "0x6006CBA")]
		public bool HasState(Type stateType)
		{
			return m_States.ContainsKey(stateType.FullName);
		}

		[Token(Token = "0x6006CBB")]
		public TState GetState<TState>() where TState : FsmState<T>
		{
			return (TState)GetState(typeof(TState));
		}

		[Token(Token = "0x6006CBC")]
		public FsmState<T> GetState(Type stateType)
		{
			FsmState<T> state;
			return m_States.TryGetValue(stateType.FullName, out state) ? state : null;
		}

		[Token(Token = "0x6006CBD")]
		public void FireEvent(object sender, int eventId)
		{
			if (m_CurrentState == null)
			    throw new GameFrameworkException("Current state is invalid.");
			m_CurrentState.OnEvent(this, sender, eventId, null);
		}

		[Token(Token = "0x6006CBE")]
		public void FireEvent(object sender, int eventId, object userData)
		{
			if (m_CurrentState == null)
			    throw new GameFrameworkException("Current state is invalid.");
			m_CurrentState.OnEvent(this, sender, eventId, userData);
		}

		[Token(Token = "0x6006CBF")]
		public bool HasData(string name)
		{
			if (string.IsNullOrEmpty(name))
			    throw new GameFrameworkException("Data name is invalid.");
			return m_Datas.ContainsKey(name);
		}

		[Token(Token = "0x6006CC0")]
		public Variable GetData(string name)
		{
			if (string.IsNullOrEmpty(name))
			    throw new GameFrameworkException("Data name is invalid.");
			Variable data;
			return m_Datas.TryGetValue(name, out data) ? data : null;
		}

		[Token(Token = "0x6006CC1")]
		public TData GetData<TData>(string name) where TData : Variable
		{
			return (TData)GetData(name);
		}

		[Token(Token = "0x6006CC2")]
		public void SetData<TData>(string name, TData data) where TData : Variable
		{
			if (string.IsNullOrEmpty(name))
			    throw new GameFrameworkException("Data name is invalid.");
			m_Datas[name] = data;
		}

		[Token(Token = "0x6006CC3")]
		public bool RemoveData(string name)
		{
			if (string.IsNullOrEmpty(name))
			    throw new GameFrameworkException("Data name is invalid.");
			return m_Datas.Remove(name);
		}

		[Token(Token = "0x6006CC4")]
		internal void ChangeState<TState>(params object[] args) where TState : FsmState<T>
		{
			ChangeState(typeof(TState), args);
		}

		[Token(Token = "0x6006CC5")]
		internal void ChangeState(Type stateType, params object[] args)
		{
			if (m_CurrentState == null)
			    throw new GameFrameworkException("Current state is invalid.");
			FsmState<T> state = GetState(stateType);
			if (state == null)
			    throw new GameFrameworkException(string.Format("FSM '{0}' can not change state to '{1}' which is not exist.", Utility.Text.GetFullName<T>(Name), stateType.FullName));
			m_CurrentState.OnLeave(this, false);
			m_CurrentStateTime = 0f;
			m_CurrentState = state;
			if (args != null && args.Length > 0)
			    state.OnEnter(this, args);
			else
			    state.OnEnter(this);
		}
	}
}
