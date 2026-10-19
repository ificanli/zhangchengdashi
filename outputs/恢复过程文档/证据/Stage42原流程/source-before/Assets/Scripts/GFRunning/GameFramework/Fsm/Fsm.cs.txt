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
				return null;
			}
		}

		[Token(Token = "0x170011D7")]
		public override Type OwnerType
		{
			[Token(Token = "0x6006CAE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D8")]
		public override int FsmStateCount
		{
			[Token(Token = "0x6006CAF")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170011D9")]
		public override bool IsRunning
		{
			[Token(Token = "0x6006CB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170011DA")]
		public override bool IsDestroyed
		{
			[Token(Token = "0x6006CB1")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170011DB")]
		public FsmState<T> CurrentState
		{
			[Token(Token = "0x6006CB2")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011DC")]
		public override string CurrentStateName
		{
			[Token(Token = "0x6006CB3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011DD")]
		public override float CurrentStateTime
		{
			[Token(Token = "0x6006CB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6006CAC")]
		public Fsm(string name, T owner, params FsmState<T>[] states)
		{
		}

		[Token(Token = "0x6006CB5")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6006CB6")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x6006CB7")]
		public void Start<TState>(params object[] args) where TState : FsmState<T>
		{
		}

		[Token(Token = "0x6006CB8")]
		public void Start(Type stateType, params object[] args)
		{
		}

		[Token(Token = "0x6006CB9")]
		public bool HasState<TState>() where TState : FsmState<T>
		{
			return default;
		}

		[Token(Token = "0x6006CBA")]
		public bool HasState(Type stateType)
		{
			return default;
		}

		[Token(Token = "0x6006CBB")]
		public TState GetState<TState>() where TState : FsmState<T>
		{
			return null;
		}

		[Token(Token = "0x6006CBC")]
		public FsmState<T> GetState(Type stateType)
		{
			return null;
		}

		[Token(Token = "0x6006CBD")]
		public void FireEvent(object sender, int eventId)
		{
		}

		[Token(Token = "0x6006CBE")]
		public void FireEvent(object sender, int eventId, object userData)
		{
		}

		[Token(Token = "0x6006CBF")]
		public bool HasData(string name)
		{
			return default;
		}

		[Token(Token = "0x6006CC0")]
		public Variable GetData(string name)
		{
			return null;
		}

		[Token(Token = "0x6006CC1")]
		public TData GetData<TData>(string name) where TData : Variable
		{
			return null;
		}

		[Token(Token = "0x6006CC2")]
		public void SetData<TData>(string name, TData data) where TData : Variable
		{
		}

		[Token(Token = "0x6006CC3")]
		public bool RemoveData(string name)
		{
			return default;
		}

		[Token(Token = "0x6006CC4")]
		internal void ChangeState<TState>(params object[] args) where TState : FsmState<T>
		{
		}

		[Token(Token = "0x6006CC5")]
		internal void ChangeState(Type stateType, params object[] args)
		{
		}
	}
}
