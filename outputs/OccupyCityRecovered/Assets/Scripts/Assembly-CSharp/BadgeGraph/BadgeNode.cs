using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BadgeGraph
{
	[Token(Token = "0x2000E0C")]
	public class BadgeNode
	{
		[Token(Token = "0x40061F2")]
		[FieldOffset(Offset = "0x10")]
		public string NodeName = string.Empty;

		[Token(Token = "0x40061F3")]
		[FieldOffset(Offset = "0x18")]
		public int PointNumber;

		[Token(Token = "0x40061F4")]
		[FieldOffset(Offset = "0x20")]
		public BadgeNode Parent;

		[Token(Token = "0x40061F5")]
		[FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		private OnPointNumberChanged m_OnPointNumberChangedEvent;

		[Token(Token = "0x40061F6")]
		[FieldOffset(Offset = "0x30")]
		[CompilerGenerated]
		private Dictionary<string, BadgeNode> _003CChildNodeDict_003Ek__BackingField = new Dictionary<string, BadgeNode>();

		[Token(Token = "0x17000EAD")]
		public Dictionary<string, BadgeNode> ChildNodeDict
		{
			[Token(Token = "0x60056B2")]
			[Address(RVA = "0x4340090", Offset = "0x433C090", VA = "0x4340090")]
			[CompilerGenerated]
			get
			{ return _003CChildNodeDict_003Ek__BackingField; }
			[Token(Token = "0x60056B3")]
			[Address(RVA = "0x4340098", Offset = "0x433C098", VA = "0x4340098")]
			[CompilerGenerated]
			private set
			{ _003CChildNodeDict_003Ek__BackingField = value; }
		}

		[Token(Token = "0x14000015")]
		public event OnPointNumberChanged OnPointNumberChangedEvent
		{
			[Token(Token = "0x60056B0")]
			[Address(RVA = "0x433FF58", Offset = "0x433BF58", VA = "0x433FF58")]
			[CompilerGenerated]
			add
			{
                OnPointNumberChanged previous;
                OnPointNumberChanged current = m_OnPointNumberChangedEvent;
                do
                {
                    previous = current;
                    var combined = (OnPointNumberChanged)global::System.Delegate.Combine(previous, value);
                    current = global::System.Threading.Interlocked.CompareExchange(ref m_OnPointNumberChangedEvent, combined, previous);
                } while (!global::System.Object.ReferenceEquals(current, previous));
            }
			[Token(Token = "0x60056B1")]
			[Address(RVA = "0x433FFF4", Offset = "0x433BFF4", VA = "0x433FFF4")]
			[CompilerGenerated]
			remove
			{
                OnPointNumberChanged previous;
                OnPointNumberChanged current = m_OnPointNumberChangedEvent;
                do
                {
                    previous = current;
                    var combined = (OnPointNumberChanged)global::System.Delegate.Remove(previous, value);
                    current = global::System.Threading.Interlocked.CompareExchange(ref m_OnPointNumberChangedEvent, combined, previous);
                } while (!global::System.Object.ReferenceEquals(current, previous));
            }
		}

		[Token(Token = "0x60056B4")]
		[Address(RVA = "0x433EF48", Offset = "0x433AF48", VA = "0x433EF48")]
		public void SetNumber(int number)
		{
            if (ChildNodeDict.Count > 0)
            {
                global::UnityEngine.Debug.LogError(string.Format("Only can set last node: {0}", NodeName));
                return;
            }
            PointNumber = number;
            m_OnPointNumberChangedEvent?.Invoke(this);
            if (Parent != null) Parent.ChangePredPointNum();
        }

		[Token(Token = "0x60056B5")]
		[Address(RVA = "0x43400A0", Offset = "0x433C0A0", VA = "0x43400A0")]
		private void ChangePredPointNum()
		{
            int total = 0;
            foreach (BadgeNode child in ChildNodeDict.Values)
                total = unchecked(total + child.PointNumber);
            PointNumber = total;
            m_OnPointNumberChangedEvent?.Invoke(this);
            if (Parent != null) Parent.ChangePredPointNum();
        }

		[Token(Token = "0x60056B6")]
		[Address(RVA = "0x433EF34", Offset = "0x433AF34", VA = "0x433EF34")]
		public void SetCallback(bool subscribe, OnPointNumberChanged callback)
		{
            if (subscribe) OnPointNumberChangedEvent += callback;
            else OnPointNumberChangedEvent -= callback;
        }

		[Token(Token = "0x60056B7")]
		[Address(RVA = "0x433ED04", Offset = "0x433AD04", VA = "0x433ED04")]
		public BadgeNode()
		{
		}
	}
}
