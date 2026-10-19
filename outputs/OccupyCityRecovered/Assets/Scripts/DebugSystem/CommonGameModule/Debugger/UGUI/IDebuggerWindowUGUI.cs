using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200006A")]
	public interface IDebuggerWindowUGUI
	{
		[Token(Token = "0x17000068")]
		RectTransform Root
		{
			[Token(Token = "0x6000251")]
			get;
		}

		[Token(Token = "0x17000069")]
		bool SupportClickThrough
		{
			[Token(Token = "0x6000252")]
			get;
		}

		[Token(Token = "0x6000253")]
		void Initialize(params object[] args);

		[Token(Token = "0x6000254")]
		void OnDebuggerSystemReopen();

		[Token(Token = "0x6000255")]
		void Shutdown();

		[Token(Token = "0x6000256")]
		void OnEnter();

		[Token(Token = "0x6000257")]
		void OnLeave();

		[Token(Token = "0x6000258")]
		void OnUpdate(float elapseSeconds, float realElapseSeconds);

		[Token(Token = "0x6000259")]
		void RefreshSize(Vector2 size, bool portrait);
	}
}
