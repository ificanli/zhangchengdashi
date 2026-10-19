using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000350")]
	public class OrcsBehaviour : RoleBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000351")]
		[CompilerGenerated]
		private struct _003CAtkCallBack_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4002470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OrcsBehaviour _003C_003E4__this;

			[Token(Token = "0x4002473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int attackNum;

			[Token(Token = "0x4002474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000ECC")]
			[Address(RVA = "0x3D78BF4", Offset = "0x3D74BF4", VA = "0x3D78BF4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000ECD")]
			[Address(RVA = "0x3D791D4", Offset = "0x3D751D4", VA = "0x3D791D4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		protected bool CanVampire;

		[Token(Token = "0x400246A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private Transform changMao;

		[Token(Token = "0x400246B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private bool _orcsFetter4AtkSpeedActive;

		[Token(Token = "0x400246C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		private float _orcsFetter4OriginalAtkOffset;

		[Token(Token = "0x400246D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private float _orcsFetter4OriginalAttackAnimSpeed;

		[Token(Token = "0x400246E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private List<float> _orcsFetter4OriginalAttackDamageDelay;

		[Token(Token = "0x400246F")]
		private const float OrcsFetter4AtkSpeedMultiplier = 1.5f;

		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x3D6B48C", Offset = "0x3D6748C", VA = "0x3D6B48C", Slot = "20")]
		public override void Init(GlobalRoleInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] string relativeCardID, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x3D73EE4", Offset = "0x3D6FEE4", VA = "0x3D73EE4", Slot = "39")]
		protected override void OnRecycle()
		{
		}

		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x3D781E8", Offset = "0x3D741E8", VA = "0x3D781E8")]
		private void ResetOrcsFetter4NumberInit()
		{
		}

		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x3D6B810", Offset = "0x3D67810", VA = "0x3D6B810", Slot = "30")]
		[AsyncStateMachine(typeof(_003CAtkCallBack_003Ed__10))]
		protected override void AtkCallBack(int attackNum)
		{
		}

		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x3D7834C", Offset = "0x3D7434C", VA = "0x3D7834C")]
		private void OrcsCardFettersInit()
		{
		}

		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x3D78468", Offset = "0x3D74468", VA = "0x3D78468", Slot = "23")]
		protected override void OnHealthChangeTalentTrigger()
		{
		}

		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x3D68318", Offset = "0x3D64318", VA = "0x3D68318")]
		public OrcsBehaviour()
		{
		}
	}
}
