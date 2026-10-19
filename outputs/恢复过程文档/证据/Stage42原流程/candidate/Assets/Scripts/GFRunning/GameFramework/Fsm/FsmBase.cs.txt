using System;
using Il2CppDummyDll;

namespace GameFramework.Fsm
{
	[Token(Token = "0x2000491")]
	public abstract class FsmBase
	{
		[Token(Token = "0x4001EE0")]
		[FieldOffset(Offset = "0x10")]
		private readonly string m_Name;

		[Token(Token = "0x4001EE1")]
		[FieldOffset(Offset = "0x18")]
		private string m_FullName;

		[Token(Token = "0x170011DE")]
		public string Name
		{
			[Token(Token = "0x6006CC8")]
			[Address(RVA = "0x7296BB8", Offset = "0x7292BB8", VA = "0x7296BB8", Slot = "4")]
			get
			{
			return m_Name;
		}
		}

		[Token(Token = "0x170011DF")]
		public string FullName
		{
			[Token(Token = "0x6006CC9")]
			[Address(RVA = "0x7296BC0", Offset = "0x7292BC0", VA = "0x7296BC0", Slot = "5")]
			get
			{
			return m_FullName;
		}
			[Token(Token = "0x6006CCA")]
			[Address(RVA = "0x7296BC8", Offset = "0x7292BC8", VA = "0x7296BC8")]
			set
			{
			m_FullName = value;
		}
		}

		[Token(Token = "0x170011E0")]
		public abstract Type OwnerType
		{
			[Token(Token = "0x6006CCB")]
			get;
		}

		[Token(Token = "0x170011E1")]
		public abstract int FsmStateCount
		{
			[Token(Token = "0x6006CCC")]
			get;
		}

		[Token(Token = "0x170011E2")]
		public abstract bool IsRunning
		{
			[Token(Token = "0x6006CCD")]
			get;
		}

		[Token(Token = "0x170011E3")]
		public abstract bool IsDestroyed
		{
			[Token(Token = "0x6006CCE")]
			get;
		}

		[Token(Token = "0x170011E4")]
		public abstract string CurrentStateName
		{
			[Token(Token = "0x6006CCF")]
			get;
		}

		[Token(Token = "0x170011E5")]
		public abstract float CurrentStateTime
		{
			[Token(Token = "0x6006CD0")]
			get;
		}

		[Token(Token = "0x6006CC6")]
		[Address(RVA = "0x7296B44", Offset = "0x7292B44", VA = "0x7296B44")]
		public FsmBase() : this(null)
		{
			// Native 0x7296B44 delegates to the named constructor with null.
		}

		[Token(Token = "0x6006CC7")]
		[Address(RVA = "0x7296B4C", Offset = "0x7292B4C", VA = "0x7296B4C")]
		public FsmBase(string name)
		{
			m_Name = name ?? string.Empty;
		}

		[Token(Token = "0x6006CD1")]
		internal abstract void Update(float elapseSeconds, float realElapseSeconds);

		[Token(Token = "0x6006CD2")]
		internal abstract void Shutdown();
	}
}
