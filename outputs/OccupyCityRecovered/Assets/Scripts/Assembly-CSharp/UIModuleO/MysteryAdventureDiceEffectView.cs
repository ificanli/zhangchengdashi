using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20009D1")]
	public class MysteryAdventureDiceEffectView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009D2")]
		[CompilerGenerated]
		private struct _003CPlayRollAsync_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4004930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004931")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004932")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteryAdventureDiceEffectView _003C_003E4__this;

			[Token(Token = "0x4004933")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float speedMultiplier;

			[Token(Token = "0x4004934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int diceValue;

			[Token(Token = "0x4004935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003A92")]
			[Address(RVA = "0x411835C", Offset = "0x411435C", VA = "0x411835C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003A93")]
			[Address(RVA = "0x4118A18", Offset = "0x4114A18", VA = "0x4118A18", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004924")]
		private const string RollClipName = "ani_eff_touzi";

		[Token(Token = "0x4004925")]
		private const float RollClipLength = 2f;

		[Token(Token = "0x4004926")]
		private const float MinPlayDuration = 0.15f;

		[Token(Token = "0x4004927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, Vector3> FaceRotations;

		[Token(Token = "0x4004928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage _displayImage;

		[Token(Token = "0x4004929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MysteryAdventureDiceStageView _diceStagePrefab;

		[Token(Token = "0x400492A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RenderTexture _renderTexture;

		[Token(Token = "0x400492B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MysteryAdventureDiceStageView _diceStageInstance;

		[Token(Token = "0x400492C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animation _rollAnimation;

		[Token(Token = "0x400492D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform _diceMeshTransform;

		[Token(Token = "0x400492E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera _renderCamera;

		[Token(Token = "0x400492F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _renderSetupDone;

		[Token(Token = "0x6003A83")]
		[Address(RVA = "0x41173D0", Offset = "0x41133D0", VA = "0x41173D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6003A84")]
		[Address(RVA = "0x41176E0", Offset = "0x41136E0", VA = "0x41176E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6003A85")]
		[Address(RVA = "0x4117460", Offset = "0x4113460", VA = "0x4117460")]
		public void EnsureBindings()
		{
		}

		[Token(Token = "0x6003A86")]
		[Address(RVA = "0x4117784", Offset = "0x4113784", VA = "0x4117784")]
		public void ShowIdleFace(int diceValue = 6)
		{
		}

		[Token(Token = "0x6003A87")]
		[Address(RVA = "0x41178FC", Offset = "0x41138FC", VA = "0x41178FC")]
		public void HideEffect()
		{
		}

		[Token(Token = "0x6003A88")]
		[Address(RVA = "0x4117994", Offset = "0x4113994", VA = "0x4117994")]
		[AsyncStateMachine(typeof(_003CPlayRollAsync_003Ed__17))]
		public UniTask PlayRollAsync(int diceValue, float speedMultiplier)
		{
			return default;
		}

		[Token(Token = "0x6003A89")]
		[Address(RVA = "0x41177B8", Offset = "0x41137B8", VA = "0x41177B8")]
		private void EnsureRenderSetup()
		{
		}

		[Token(Token = "0x6003A8A")]
		[Address(RVA = "0x4117A44", Offset = "0x4113A44", VA = "0x4117A44")]
		private void EnsureDisplayImage()
		{
		}

		[Token(Token = "0x6003A8B")]
		[Address(RVA = "0x4117BB8", Offset = "0x4113BB8", VA = "0x4117BB8")]
		private void EnsureDiceStageInstance()
		{
		}

		[Token(Token = "0x6003A8C")]
		[Address(RVA = "0x4117EA0", Offset = "0x4113EA0", VA = "0x4117EA0")]
		private void BindStageReferences(MysteryAdventureDiceStageView stage)
		{
		}

		[Token(Token = "0x6003A8D")]
		[Address(RVA = "0x41175A8", Offset = "0x41135A8", VA = "0x41175A8")]
		private void SetRenderActive(bool active)
		{
		}

		[Token(Token = "0x6003A8E")]
		[Address(RVA = "0x4117CFC", Offset = "0x4113CFC", VA = "0x4117CFC")]
		private static void StretchFull(RectTransform rect)
		{
		}

		[Token(Token = "0x6003A8F")]
		[Address(RVA = "0x41177EC", Offset = "0x41137EC", VA = "0x41177EC")]
		private void ApplyFace(int diceValue)
		{
		}

		[Token(Token = "0x6003A90")]
		[Address(RVA = "0x41181EC", Offset = "0x41141EC", VA = "0x41181EC")]
		public MysteryAdventureDiceEffectView()
		{
		}
	}
}
