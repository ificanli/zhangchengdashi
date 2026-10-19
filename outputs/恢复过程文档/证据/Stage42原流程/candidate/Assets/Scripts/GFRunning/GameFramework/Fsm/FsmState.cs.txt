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
			m_EventHandlers = new Dictionary<int, FsmEventHandler<T>>();
		}

		[Token(Token = "0x6006CE9")]
		public virtual void OnInit(IFsm<T> fsm)
		{
			// Original default lifecycle method is RET.
		}

		[Token(Token = "0x6006CEA")]
		public virtual void OnEnter(IFsm<T> fsm)
		{
			// Original no-argument lifecycle method is RET.
		}

		[Token(Token = "0x6006CEB")]
		public virtual void OnEnter(IFsm<T> fsm, params object[] args)
		{
			// Original argument lifecycle method is independently RET.
		}

		[Token(Token = "0x6006CEC")]
		public virtual void OnUpdate(IFsm<T> fsm, float elapseSeconds, float realElapseSeconds)
		{
			// Original default lifecycle method is RET.
		}

		[Token(Token = "0x6006CED")]
		public virtual void OnLeave(IFsm<T> fsm, bool isShutdown)
		{
			// Original default lifecycle method is RET.
		}

		[Token(Token = "0x6006CEE")]
		public virtual void OnDestroy(IFsm<T> fsm)
		{
			m_EventHandlers.Clear();
		}

		[Token(Token = "0x6006CEF")]
		protected void SubscribeEvent(int eventId, FsmEventHandler<T> eventHandler)
		{
			if (eventHandler == null)
			    throw new GameFrameworkException("Event handler is invalid.");
			if (m_EventHandlers.ContainsKey(eventId))
			    m_EventHandlers[eventId] += eventHandler;
			else
			    m_EventHandlers[eventId] = eventHandler;
		}

		[Token(Token = "0x6006CF0")]
		protected void UnsubscribeEvent(int eventId, FsmEventHandler<T> eventHandler)
		{
			if (eventHandler == null)
			    throw new GameFrameworkException("Event handler is invalid.");
			if (m_EventHandlers.ContainsKey(eventId))
			    m_EventHandlers[eventId] -= eventHandler;
		}

		[Token(Token = "0x6006CF1")]
		protected void ChangeState<TState>(IFsm<T> fsm, params object[] args) where TState : FsmState<T>
		{
			if (fsm == null)
			    throw new GameFrameworkException("FSM is invalid.");
			((Fsm<T>)fsm).ChangeState<TState>(args);
		}

		[Token(Token = "0x6006CF2")]
		protected void ChangeState(IFsm<T> fsm, Type stateType, params object[] args)
		{
			if (fsm == null)
			    throw new GameFrameworkException("FSM is invalid.");
			((Fsm<T>)fsm).ChangeState(stateType, args);
		}

		[Token(Token = "0x6006CF3")]
		internal void OnEvent(IFsm<T> fsm, object sender, int eventId, object userData)
		{
			FsmEventHandler<T> handler;
			if (m_EventHandlers.TryGetValue(eventId, out handler) && handler != null)
			    handler(fsm, sender, userData);
		}
	}
}
