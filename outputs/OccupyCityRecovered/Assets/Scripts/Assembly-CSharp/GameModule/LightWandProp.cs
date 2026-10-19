using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20002D4")]
	public class LightWandProp : PropBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D6")]
		[CompilerGenerated]
		private struct _003CStartLightningSequence_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x400224E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400224F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LineRenderer liner;

			[Token(Token = "0x4002251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 startPos;

			[Token(Token = "0x4002252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<RoleBehaviour> targets;

			[Token(Token = "0x4002253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public LightWandProp _003C_003E4__this;

			[Token(Token = "0x4002254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int _003Cindex_003E5__2;

			[Token(Token = "0x4002255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x4002256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x3D48C5C", Offset = "0x3D44C5C", VA = "0x3D48C5C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000CD3")]
			[Address(RVA = "0x3D49694", Offset = "0x3D45694", VA = "0x3D49694", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20002D7")]
		[CompilerGenerated]
		private struct _003CUse_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<RoleBehaviour> target;

			[Token(Token = "0x400225A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LightWandProp _003C_003E4__this;

			[Token(Token = "0x400225B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3? releasePos;

			[Token(Token = "0x400225C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool isEnemy;

			[Token(Token = "0x400225D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private GameObject _003CbaseRes_003E5__2;

			[Token(Token = "0x400225E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private GameObject _003Cres_003E5__3;

			[Token(Token = "0x400225F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x3D496A0", Offset = "0x3D456A0", VA = "0x3D496A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x3D4A500", Offset = "0x3D46500", VA = "0x3D4A500", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject hitRes;

		[Token(Token = "0x4002249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 bornPos;

		[Token(Token = "0x400224A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject obj;

		[Token(Token = "0x400224B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject hitObj;

		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x3D483B0", Offset = "0x3D443B0", VA = "0x3D483B0")]
		public LightWandProp(string id)
		{
		}

		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x3D483B8", Offset = "0x3D443B8", VA = "0x3D483B8", Slot = "4")]
		public override void Use(bool isEnemy, List<RoleBehaviour> target)
		{
		}

		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x3D483D0", Offset = "0x3D443D0", VA = "0x3D483D0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CUse_003Ed__6))]
		public override void Use(bool isEnemy, List<RoleBehaviour> target, Vector3? releasePos)
		{
		}

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x3D48494", Offset = "0x3D44494", VA = "0x3D48494")]
		private static RoleBehaviour GetNearestTarget(List<RoleBehaviour> targets, Vector3 origin)
		{
			return null;
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x3D4864C", Offset = "0x3D4464C", VA = "0x3D4864C")]
		private static List<RoleBehaviour> BuildChainTargets(RoleBehaviour first, List<RoleBehaviour> candidates, int count)
		{
			return null;
		}

		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x3D489B4", Offset = "0x3D449B4", VA = "0x3D489B4")]
		[AsyncStateMachine(typeof(_003CStartLightningSequence_003Ed__9))]
		private void StartLightningSequence(LineRenderer liner, Vector3 startPos, List<RoleBehaviour> targets)
		{
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x3D48A80", Offset = "0x3D44A80", VA = "0x3D48A80", Slot = "6")]
		protected override void GameEnd(object o)
		{
		}
	}
}
