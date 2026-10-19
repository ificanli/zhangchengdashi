using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameFramework;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F9C")]
	public class RichControlBase<T> where T : IControl, new()
	{
		[Token(Token = "0x4006B4C")]
		[FieldOffset(Offset = "0x0")]
		protected static T instance;

		[Token(Token = "0x4006B4D")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, MsgDispatcher.EventHandler> ListenerDic;

		[Token(Token = "0x4006B4E")]
		[FieldOffset(Offset = "0x0")]
		protected bool Added;

		[Token(Token = "0x4006B4F")]
		[FieldOffset(Offset = "0x0")]
		protected bool CustomInit;

		[Token(Token = "0x4006B50")]
		[FieldOffset(Offset = "0x0")]
		public string StartKey;

		[Token(Token = "0x4006B52")]
		[FieldOffset(Offset = "0x0")]
		protected bool CanUpdate;

		[Token(Token = "0x17000F9D")]
		public static T I
		{
			[Token(Token = "0x6005D7F")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RichControlBase.I.get RVA= Token=0x6005D7F");
}
		}

		[Token(Token = "0x17000F9E")]
		public bool ActiveUpdate
		{
			[Token(Token = "0x6005D80")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6005D81")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6005D82")]
		public virtual void OnDispose()
		{
		}

		[Token(Token = "0x6005D83")]
		public virtual void DefaultListener()
		{
		}

		[Token(Token = "0x6005D84")]
		public virtual void OnInit()
		{
		}

		[Token(Token = "0x6005D85")]
		private void InitAfterLoginListener(object[] args)
		{
		}

		[Token(Token = "0x6005D86")]
		private void StopControlListener(object[] args)
		{
		}

		[Token(Token = "0x6005D87")]
		public virtual void InitAfterLogin()
		{
		}

		[Token(Token = "0x6005D88")]
		public virtual void StopControl()
		{
		}

		[Token(Token = "0x6005D89")]
		public virtual void Updata(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005D8A")]
		public virtual void SwitchListener(int state)
		{
		}

		[Token(Token = "0x6005D8B")]
		public void RegListener(string key, MsgDispatcher.EventHandler eventHandle)
		{
		}

		[Token(Token = "0x6005D8C")]
		private void SwitchListener(object[] args)
		{
		}

		[Token(Token = "0x6005D8D")]
		private void AddAllListener()
		{
		}

		[Token(Token = "0x6005D8E")]
		private void RemoveAllListener()
		{
		}

		[Token(Token = "0x6005D8F")]
		public RichControlBase()
		{
		}
	}
}
