using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000015")]
	public class AllIn1VfxDemoController : MonoBehaviour
	{
		[Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class _003CCurrentEffectLabelTweenEffectCR_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400008F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000090")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000091")]
			[FieldOffset(Offset = "0x20")]
			public AllIn1VfxDemoController _003C_003E4__this;

			[Token(Token = "0x4000092")]
			[FieldOffset(Offset = "0x28")]
			private Color _003CstartColor_003E5__2;

			[Token(Token = "0x17000003")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600005A")]
				[Address(RVA = "0x3CF2058", Offset = "0x3CEE058", VA = "0x3CF2058", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000004")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600005C")]
				[Address(RVA = "0x3CF2098", Offset = "0x3CEE098", VA = "0x3CF2098", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x3CF1F38", Offset = "0x3CEDF38", VA = "0x3CF1F38")]
			[DebuggerHidden]
			public _003CCurrentEffectLabelTweenEffectCR_003Ed__38(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x3CF1F7C", Offset = "0x3CEDF7C", VA = "0x3CF1F7C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0x3CF1F80", Offset = "0x3CEDF80", VA = "0x3CF1F80", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0x3CF2058", Offset = "0x3CEE058", VA = "0x3CF2058", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600005B")]
			[Address(RVA = "0x3CF2060", Offset = "0x3CEE060", VA = "0x3CF2060", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0x3CF2098", Offset = "0x3CEE098", VA = "0x3CF2098", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int startingCollectionIndex;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int startingEffectIndex;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Space]
		[Header("Demo Effects")]
		private All1VfxDemoEffectCollection[] effectsToSpawnCollections;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Space]
		[Space]
		[Header("Projectile References")]
		private GameObject projectileBasePrefab;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject projectileSceneSetupObject;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform projectileSpawnPoint;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Demo Controller Input")]
		[Space]
		private KeyCode playEffectKey;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private KeyCode nextEffectKey;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private KeyCode nextEffectKeyAlt;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private KeyCode previousEffectKey;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private KeyCode previousEffectKeyAlt;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Space]
		[Header("UI and Other References")]
		private Text currentEffectLabel;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button playEffectButton;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject playEffectInstructionsGo;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button nextEffectButton;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button previousEffectButton;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform groundSpawnTransform;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform cameraPivotTransform;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float camPivotHeightSmoothing;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject projectileEffectUI;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject normalEffectUI;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0xB0")]
		private All1VfxDemoEffect currDemoEffect;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xB8")]
		private int currDemoCollectionIndex;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0xBC")]
		private int currDemoEffectIndex;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0xC0")]
		private int currentEffectPlays;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0xC8")]
		private AllIn1DemoScaleTween currLabelTween;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0xD0")]
		private AllIn1DemoScaleTween playButtTween;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0xD8")]
		private AllIn1DemoScaleTween nextButtTween;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0xE0")]
		private AllIn1DemoScaleTween prevButtTween;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0xE8")]
		private float timeSinceEffectPlay;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0xF0")]
		private AllIn1TimeControl allIn1TimeControl;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x3CF0E58", Offset = "0x3CECE58", VA = "0x3CF0E58")]
		private void Start()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x3CF10B0", Offset = "0x3CED0B0", VA = "0x3CF10B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x3CF1A5C", Offset = "0x3CEDA5C", VA = "0x3CF1A5C")]
		private void CooldownHandling()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x3CF1274", Offset = "0x3CED274", VA = "0x3CF1274")]
		public void PlayCurrentEffect(bool isAfterSetupAndInstantiateEffect = false)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x3CF19D8", Offset = "0x3CED9D8", VA = "0x3CF19D8")]
		public void ChangeCurrentEffect(int changeAmount)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x3CF0F48", Offset = "0x3CECF48", VA = "0x3CF0F48")]
		private void SetupAndInstantiateCurrentEffect()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x3CF1E44", Offset = "0x3CEDE44", VA = "0x3CF1E44")]
		private void ComputeValidEffectAndCollectionIndex()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x3CF1DE4", Offset = "0x3CEDDE4", VA = "0x3CF1DE4")]
		[IteratorStateMachine(typeof(_003CCurrentEffectLabelTweenEffectCR_003Ed__38))]
		private IEnumerator CurrentEffectLabelTweenEffectCR()
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x3CF1ADC", Offset = "0x3CEDADC", VA = "0x3CF1ADC")]
		private void DestroyAllChildren()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x3CF1F60", Offset = "0x3CEDF60", VA = "0x3CF1F60")]
		public AllIn1VfxDemoController()
		{
		}
	}
}
