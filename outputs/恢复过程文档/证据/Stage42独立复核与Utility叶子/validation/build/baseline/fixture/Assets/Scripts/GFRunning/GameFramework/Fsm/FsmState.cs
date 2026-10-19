using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.Fsm
{
	[Token(Token = "0x2000494")]
	public abstract class FsmState<T> where T : class
	{
		[Token(Token = "0x4001EE5")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<int, FsmEventHandler<T>> m_EventHandlers;

		[Token(Token = "0x6006CE8")]
		public FsmState()
		{
		}

		[Token(Token = "0x6006CE9")]
		public virtual void OnInit(IFsm<T> fsm)
		{
		}

		[Token(Token = "0x6006CEA")]
		public virtual void OnEnter(IFsm<T> fsm)
		{
		}

		[Token(Token = "0x6006CEB")]
		public virtual void OnEnter(IFsm<T> fsm, params object[] args)
		{
		}

		[Token(Token = "0x6006CEC")]
		public virtual void OnUpdate(IFsm<T> fsm, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6006CED")]
		public virtual void OnLeave(IFsm<T> fsm, bool isShutdown)
		{
		}

		[Token(Token = "0x6006CEE")]
		public virtual void OnDestroy(IFsm<T> fsm)
		{
		}

		[Token(Token = "0x6006CEF")]
		protected void SubscribeEvent(int eventId, FsmEventHandler<T> eventHandler)
		{
		}

		[Token(Token = "0x6006CF0")]
		protected void UnsubscribeEvent(int eventId, FsmEventHandler<T> eventHandler)
		{
		}

		[Token(Token = "0x6006CF1")]
		protected void ChangeState<TState>(IFsm<T> fsm, params object[] args) where TState : FsmState<T>
		{
		}

		[Token(Token = "0x6006CF2")]
		protected void ChangeState(IFsm<T> fsm, Type stateType, params object[] args)
		{
		}

		[Token(Token = "0x6006CF3")]
		internal void OnEvent(IFsm<T> fsm, object sender, int eventId, object userData)
		{
		}
	}
}
