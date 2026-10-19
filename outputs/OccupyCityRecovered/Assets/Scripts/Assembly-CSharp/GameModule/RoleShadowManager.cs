using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AnimationInstancing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000455")]
	public class RoleShadowManager : ManagerBase<RoleShadowManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000456")]
		[CompilerGenerated]
		private struct _003CEnsureShadowAssetsLoaded_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RoleShadowManager _003C_003E4__this;

			[Token(Token = "0x4002A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Shader>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60014FE")]
			[Address(RVA = "0x3E0E810", Offset = "0x3E0A810", VA = "0x3E0E810", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60014FF")]
			[Address(RVA = "0x3E0EFEC", Offset = "0x3E0AFEC", VA = "0x3E0EFEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000457")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4002A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RoleShadowManager _003C_003E4__this;

			[Token(Token = "0x4002A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001500")]
			[Address(RVA = "0x3E0EFF8", Offset = "0x3E0AFF8", VA = "0x3E0EFF8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001501")]
			[Address(RVA = "0x3E0F3F4", Offset = "0x3E0B3F4", VA = "0x3E0F3F4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002A5B")]
		private const int MaxInstancedShadowCount = 1023;

		[Token(Token = "0x4002A5C")]
		private const float ShadowGroundHeight = 0.02f;

		[Token(Token = "0x4002A5D")]
		private const float ShadowFollowSmoothRate = 32f;

		[Token(Token = "0x4002A5E")]
		private const float ShadowSnapDistanceSqr = 4f;

		[Token(Token = "0x4002A5F")]
		private const float InstancedShadowSizeScale = 0.6f;

		[Token(Token = "0x4002A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, RoleBehaviour> _roleIdToRole;

		[Token(Token = "0x4002A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<int, global::AnimationInstancing.AnimationInstancing> _roleIdToAnimationInstancing;

		[Token(Token = "0x4002A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<int> _deadRoleIds;

		[Token(Token = "0x4002A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Matrix4x4[] _shadowMatrices;

		[Token(Token = "0x4002A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Dictionary<int, Vector3> _shadowPositionByRoleId;

		[Token(Token = "0x4002A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject _shadowPrefab;

		[Token(Token = "0x4002A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Shader _shadowShader;

		[Token(Token = "0x4002A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Mesh _shadowMesh;

		[Token(Token = "0x4002A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material _shadowMaterial;

		[Token(Token = "0x4002A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion _shadowRotation;

		[Token(Token = "0x4002A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 _shadowScale;

		[Token(Token = "0x4002A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _shadowLayer;

		[Token(Token = "0x4002A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _loadingAssets;

		[Token(Token = "0x4002A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _inited;

		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x3E0CF80", Offset = "0x3E08F80", VA = "0x3E0CF80", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__19))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x3E0D00C", Offset = "0x3E0900C", VA = "0x3E0D00C")]
		public void Bind(RoleBehaviour role)
		{
		}

		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x3E0D2E8", Offset = "0x3E092E8", VA = "0x3E0D2E8")]
		public void Unbind(RoleBehaviour role)
		{
		}

		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x3E0D378", Offset = "0x3E09378", VA = "0x3E0D378")]
		public void Unbind(int roleId)
		{
		}

		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x3DFA7DC", Offset = "0x3DF67DC", VA = "0x3DFA7DC")]
		public void RecycleAll()
		{
		}

		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x3E0D258", Offset = "0x3E09258", VA = "0x3E0D258")]
		[AsyncStateMachine(typeof(_003CEnsureShadowAssetsLoaded_003Ed__24))]
		private UniTask EnsureShadowAssetsLoaded()
		{
			return default;
		}

		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x3E0D420", Offset = "0x3E09420", VA = "0x3E0D420")]
		private void InitializeInstancedShadow(GameObject prefab)
		{
		}

		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x3E0DB68", Offset = "0x3E09B68", VA = "0x3E0DB68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x3E0D620", Offset = "0x3E09620", VA = "0x3E0D620")]
		private Mesh CreateQuadMesh(Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x3E0D8C8", Offset = "0x3E098C8", VA = "0x3E0D8C8")]
		private Material CreateShadowMaterial(SpriteRenderer spriteRenderer)
		{
			return null;
		}

		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x3E0E314", Offset = "0x3E0A314", VA = "0x3E0E314")]
		private void DrawShadowBatch(int count)
		{
		}

		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x3E0E150", Offset = "0x3E0A150", VA = "0x3E0E150")]
		private Vector3 GetSmoothedShadowPosition(int roleId, Vector3 targetPosition)
		{
			return default;
		}

		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x3E0E3B8", Offset = "0x3E0A3B8", VA = "0x3E0E3B8")]
		private bool IsVisibleByAnimationInstancing(int roleId, RoleBehaviour role)
		{
			return default;
		}

		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x3E0E53C", Offset = "0x3E0A53C", VA = "0x3E0E53C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x3E0E614", Offset = "0x3E0A614", VA = "0x3E0E614")]
		public RoleShadowManager()
		{
		}
	}
}
