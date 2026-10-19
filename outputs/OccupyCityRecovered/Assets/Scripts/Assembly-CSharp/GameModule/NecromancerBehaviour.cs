using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200034B")]
	public class NecromancerBehaviour : UndeadBehaviour
	{
		[Token(Token = "0x200034C")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			[Token(Token = "0x400244C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> allPos;

			[Token(Token = "0x400244D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NecromancerBehaviour _003C_003E4__this;

			[Token(Token = "0x400244E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<int> allStayRemove;

			[Token(Token = "0x6000EBE")]
			[Address(RVA = "0x3D76BB0", Offset = "0x3D72BB0", VA = "0x3D76BB0")]
			public _003C_003Ec__DisplayClass3_0()
			{
			}
		}

		[Token(Token = "0x200034D")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_1
		{
			[Token(Token = "0x400244F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public KeyValuePair<int, DeadUnitInfo> item;

			[Token(Token = "0x4002450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject rolePrefabRes;

			[Token(Token = "0x4002451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int posIndex;

			[Token(Token = "0x4002452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public _003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x6000EBF")]
			[Address(RVA = "0x3D76BB8", Offset = "0x3D72BB8", VA = "0x3D76BB8")]
			public _003C_003Ec__DisplayClass3_1()
			{
			}

			[Token(Token = "0x6000EC0")]
			[Address(RVA = "0x3D76BC0", Offset = "0x3D72BC0", VA = "0x3D76BC0")]
			internal void _003CNecromancerSkill_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200034E")]
		[CompilerGenerated]
		private struct _003CNecromancerSkill_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4002453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public NecromancerBehaviour _003C_003E4__this;

			[Token(Token = "0x4002456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

			[Token(Token = "0x4002457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass3_1 _003C_003E8__2;

			[Token(Token = "0x4002458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Dictionary<int, DeadUnitInfo> _003Cdic_003E5__2;

			[Token(Token = "0x4002459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private GameObject _003CeffectRes_003E5__3;

			[Token(Token = "0x400245A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int _003Cindex_003E5__4;

			[Token(Token = "0x400245B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private int _003CcreatCount_003E5__5;

			[Token(Token = "0x400245C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int _003CallCount_003E5__6;

			[Token(Token = "0x400245D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400245E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x400245F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Dictionary<int, DeadUnitInfo>.Enumerator _003C_003E7__wrap6;

			[Token(Token = "0x4002460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private GameObject _003Ceff_003E5__8;

			[Token(Token = "0x4002461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__3;

			[Token(Token = "0x6000EC1")]
			[Address(RVA = "0x3D770D0", Offset = "0x3D730D0", VA = "0x3D770D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000EC2")]
			[Address(RVA = "0x3D78174", Offset = "0x3D74174", VA = "0x3D78174", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400244B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D1")]
		private bool UsedSkill;

		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0x3D76AD8", Offset = "0x3D72AD8", VA = "0x3D76AD8", Slot = "31")]
		protected override void EmitSkill()
		{
		}

		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x3D76B8C", Offset = "0x3D72B8C", VA = "0x3D76B8C", Slot = "39")]
		protected override void OnRecycle()
		{
		}

		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x3D76AF4", Offset = "0x3D72AF4", VA = "0x3D76AF4")]
		[AsyncStateMachine(typeof(_003CNecromancerSkill_003Ed__3))]
		private void NecromancerSkill()
		{
		}

		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0x3D76BA8", Offset = "0x3D72BA8", VA = "0x3D76BA8")]
		public NecromancerBehaviour()
		{
		}
	}
}
