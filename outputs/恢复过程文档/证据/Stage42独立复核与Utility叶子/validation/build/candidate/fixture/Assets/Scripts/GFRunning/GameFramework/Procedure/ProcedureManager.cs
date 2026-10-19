using System;
using System.Collections.Generic;
using GameFramework.Fsm;
using Il2CppDummyDll;

namespace GameFramework.Procedure
{
	[Token(Token = "0x2000453")]
	public sealed class ProcedureManager : GameFrameModule, IProcedureManager
	{
		[Token(Token = "0x4001E16")]
		[FieldOffset(Offset = "0x20")]
		private IFsmManager m_FsmManager;

		[Token(Token = "0x4001E17")]
		[FieldOffset(Offset = "0x28")]
		private IFsm<IProcedureManager> m_ProcedureFsm;

		[Token(Token = "0x170011A1")]
		internal override int Priority
		{
			[Token(Token = "0x6006A2C")]
			[Address(RVA = "0x727AB9C", Offset = "0x7276B9C", VA = "0x727AB9C", Slot = "4")]
			get
			{
				return 90;
			}
		}

		[Token(Token = "0x170011A2")]
		public ProcedureBase CurrentProcedure
		{
			[Token(Token = "0x6006A2D")]
			[Address(RVA = "0x727ABA4", Offset = "0x7276BA4", VA = "0x727ABA4", Slot = "10")]
			get
			{
				if (m_ProcedureFsm == null)
					throw new GameFrameworkException("You must initialize procedure first.");
				return (ProcedureBase)m_ProcedureFsm.CurrentState;
			}
		}

		[Token(Token = "0x170011A3")]
		public float CurrentProcedureTime
		{
			[Token(Token = "0x6006A2E")]
			[Address(RVA = "0x727ACD8", Offset = "0x7276CD8", VA = "0x727ACD8", Slot = "11")]
			get
			{
				if (m_ProcedureFsm == null)
					throw new GameFrameworkException("You must initialize procedure first.");
				return m_ProcedureFsm.CurrentStateTime;
			}
		}

		[Token(Token = "0x6006A28")]
		[Address(RVA = "0x727A9FC", Offset = "0x72769FC", VA = "0x727A9FC")]
		public ProcedureManager()
		{
			m_FsmManager = null;
			m_ProcedureFsm = null;
		}

		[Token(Token = "0x6006A29")]
		[Address(RVA = "0x727AA18", Offset = "0x7276A18", VA = "0x727AA18", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
			x_0080_008D_00B1f_0086 = true;
			Àª_00A6_00A3_00BDE?.Invoke();
		}

		[Token(Token = "0x6006A2A")]
		[Address(RVA = "0x727AA3C", Offset = "0x7276A3C", VA = "0x727AA3C")]
		public void Register(params ProcedureBase[] procedures)
		{
			m_FsmManager = GameFrameEntry.GetModule<FsmManager>();
			if (m_FsmManager == null)
				throw new GameFrameworkException("FSM manager is invalid.");
			m_ProcedureFsm = m_FsmManager.CreateFsm<IProcedureManager>(this, procedures);
		}

		[Token(Token = "0x6006A2B")]
		[Address(RVA = "0x727AB98", Offset = "0x7276B98", VA = "0x727AB98", Slot = "6")]
		internal override void Start()
		{
			// Original ARM64 0x727AB98 is a single RET.
		}

		[Token(Token = "0x6006A2F")]
		[Address(RVA = "0x727ADC0", Offset = "0x7276DC0", VA = "0x727ADC0", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
			// Original ARM64 0x727ADC0 is a single RET; FsmManager owns state updates.
		}

		[Token(Token = "0x6006A30")]
		[Address(RVA = "0x727ADC4", Offset = "0x7276DC4", VA = "0x727ADC4", Slot = "9")]
		internal override void Shutdown()
		{
			if (m_FsmManager != null)
			{
				if (m_ProcedureFsm != null)
				{
					m_FsmManager.DestroyFsm(m_ProcedureFsm);
					m_ProcedureFsm = null;
				}
				m_FsmManager = null;
			}
			x_0080_008D_00B1f_0086 = false;
		}

		[Token(Token = "0x6006A31")]
		public void StartProcedure<T>() where T : ProcedureBase
		{
			if (m_ProcedureFsm == null)
				throw new GameFrameworkException("You must initialize procedure first.");
			m_ProcedureFsm.Start<T>(Array.Empty<object>());
		}

		[Token(Token = "0x6006A32")]
		[Address(RVA = "0x727AE9C", Offset = "0x7276E9C", VA = "0x727AE9C", Slot = "13")]
		public void StartProcedure(Type procedureType)
		{
			if (m_ProcedureFsm == null)
				throw new GameFrameworkException("You must initialize procedure first.");
			m_ProcedureFsm.Start(procedureType, Array.Empty<object>());
		}

		[Token(Token = "0x6006A33")]
		public bool HasProcedure<T>() where T : ProcedureBase
		{
			if (m_ProcedureFsm == null)
				throw new GameFrameworkException("You must initialize procedure first.");
			return m_ProcedureFsm.HasState<T>();
		}

		[Token(Token = "0x6006A34")]
		[Address(RVA = "0x727AFFC", Offset = "0x7276FFC", VA = "0x727AFFC", Slot = "15")]
		public bool HasProcedure(Type procedureType)
		{
			if (m_ProcedureFsm == null)
				throw new GameFrameworkException("You must initialize procedure first.");
			return m_ProcedureFsm.HasState(procedureType);
		}

		[Token(Token = "0x6006A35")]
		public ProcedureBase GetProcedure<T>() where T : ProcedureBase
		{
			if (m_ProcedureFsm == null)
				throw new GameFrameworkException("You must initialize procedure first.");
			return m_ProcedureFsm.GetState<T>();
		}

		[Token(Token = "0x6006A36")]
		[Address(RVA = "0x727B0EC", Offset = "0x72770EC", VA = "0x727B0EC", Slot = "17")]
		public ProcedureBase GetProcedure(Type procedureType)
		{
			if (m_ProcedureFsm == null)
				throw new GameFrameworkException("You must initialize procedure first.");
			return (ProcedureBase)m_ProcedureFsm.GetState(procedureType);
		}

		[Token(Token = "0x6006A37")]
		[Address(RVA = "0x727B228", Offset = "0x7277228", VA = "0x727B228")]
		private List<Type> GetProceduresType()
		{
			List<Type> procedureTypes = new List<Type>();
			Type[] types = System.Reflection.Assembly.Load("Assembly-CSharp").GetTypes();
			foreach (Type type in types)
			{
				ProcedureTypeAttribute[] attributes = (ProcedureTypeAttribute[])type.GetCustomAttributes(typeof(ProcedureTypeAttribute), false);
				if (attributes.Length != 0)
					procedureTypes.Add(attributes[0].ProcedureType);
			}
			return procedureTypes;
		}
	}
}
