using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace EventModule
{
	[Token(Token = "0x200062A")]
	public class EventManager : ManagerBase<EventManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200062B")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4003291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x60020A4")]
			[Address(RVA = "0x3F11D30", Offset = "0x3F0DD30", VA = "0x3F11D30", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60020A5")]
			[Address(RVA = "0x3F11DE4", Offset = "0x3F0DDE4", VA = "0x3F11DE4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400328F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, Action<object>> _eventWithObjectDictionary = new Dictionary<string, Action<object>>();

		[Token(Token = "0x4003290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, Action<object>> _eventOnceObjectDictionary = new Dictionary<string, Action<object>>();

		[Token(Token = "0x600209D")]
		[Address(RVA = "0x3F11934", Offset = "0x3F0D934", VA = "0x3F11934", Slot = "4")]
		public override UniTask Init()
		{
			return UniTask.CompletedTask;
		}

		[Token(Token = "0x600209E")]
		[Address(RVA = "0x3F07F3C", Offset = "0x3F03F3C", VA = "0x3F07F3C")]
		public void StartListening(string eventName, Action<object> listener)
		{
			if (_eventWithObjectDictionary.TryGetValue(eventName, out Action<object> eventListeners) && eventListeners != null)
			{
				_eventWithObjectDictionary[eventName] += listener;
			}
			else
			{
				_eventWithObjectDictionary[eventName] = listener;
			}
		}

		[Token(Token = "0x600209F")]
		[Address(RVA = "0x3F05D94", Offset = "0x3F01D94", VA = "0x3F05D94")]
		public void StopListening(string eventName, Action<object> listener)
		{
			if (_eventWithObjectDictionary.TryGetValue(eventName, out Action<object> eventListeners) && eventListeners != null)
			{
				_eventWithObjectDictionary[eventName] = eventListeners - listener;
			}
		}

		[Token(Token = "0x60020A0")]
		[Address(RVA = "0x3F119B4", Offset = "0x3F0D9B4", VA = "0x3F119B4")]
		public void StartListeningOnce(string eventName, Action<object> listener)
		{
			if (_eventOnceObjectDictionary.TryGetValue(eventName, out Action<object> eventListeners) && eventListeners != null)
			{
				_eventOnceObjectDictionary[eventName] += listener;
			}
			else
			{
				_eventOnceObjectDictionary[eventName] = listener;
			}
		}

		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x3F11B48", Offset = "0x3F0DB48", VA = "0x3F11B48")]
		public void StopListeningOnce(string eventName, Action<object> listener)
		{
			if (_eventOnceObjectDictionary.TryGetValue(eventName, out Action<object> eventListeners) && eventListeners != null)
			{
				_eventOnceObjectDictionary[eventName] = eventListeners - listener;
			}
		}

		[Token(Token = "0x60020A2")]
		[Address(RVA = "0x3F05F64", Offset = "0x3F01F64", VA = "0x3F05F64")]
		public void TriggerEvent(string eventName, object parameter = null)
		{
			if (_eventWithObjectDictionary.TryGetValue(eventName, out Action<object> eventListeners) && eventListeners != null)
			{
				eventListeners.Invoke(parameter);
			}
			if (_eventOnceObjectDictionary.TryGetValue(eventName, out Action<object> onceListeners) && onceListeners != null)
			{
				_eventOnceObjectDictionary.Remove(eventName);
				onceListeners.Invoke(parameter);
			}
		}

		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x3F11C88", Offset = "0x3F0DC88", VA = "0x3F11C88")]
		public EventManager()
		{
		}
	}
}
