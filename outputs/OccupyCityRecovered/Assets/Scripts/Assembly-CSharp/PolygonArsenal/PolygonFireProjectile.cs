using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace PolygonArsenal
{
	[Token(Token = "0x2000CA7")]
	public class PolygonFireProjectile : MonoBehaviour
	{
		[Token(Token = "0x2000CA8")]
		[CompilerGenerated]
		private sealed class _003CShoot_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005ADD")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005ADE")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005ADF")]
			[FieldOffset(Offset = "0x20")]
			public PolygonFireProjectile _003C_003E4__this;

			[Token(Token = "0x17000E21")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6004F63")]
				[Address(RVA = "0x42B6054", Offset = "0x42B2054", VA = "0x42B6054", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E22")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6004F65")]
				[Address(RVA = "0x42B6094", Offset = "0x42B2094", VA = "0x42B6094", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004F60")]
			[Address(RVA = "0x42B5F28", Offset = "0x42B1F28", VA = "0x42B5F28")]
			[DebuggerHidden]
			public _003CShoot_003Ed__16(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004F61")]
			[Address(RVA = "0x42B5F8C", Offset = "0x42B1F8C", VA = "0x42B5F8C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6004F62")]
			[Address(RVA = "0x42B5F90", Offset = "0x42B1F90", VA = "0x42B5F90", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004F63")]
			[Address(RVA = "0x42B6054", Offset = "0x42B2054", VA = "0x42B6054", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004F64")]
			[Address(RVA = "0x42B605C", Offset = "0x42B205C", VA = "0x42B605C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6004F65")]
			[Address(RVA = "0x42B6094", Offset = "0x42B2094", VA = "0x42B6094", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005ACF")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] projectiles;

		[Token(Token = "0x4005AD0")]
		[FieldOffset(Offset = "0x28")]
		[Header("GUI Links")]
		public Text missileNameText;

		[Token(Token = "0x4005AD1")]
		[FieldOffset(Offset = "0x30")]
		public Toggle fullAutoButton;

		[Token(Token = "0x4005AD2")]
		[FieldOffset(Offset = "0x38")]
		public Slider speedSlider;

		[Token(Token = "0x4005AD3")]
		[FieldOffset(Offset = "0x40")]
		[Header("Projectile Settings")]
		public Transform spawnPosition;

		[Token(Token = "0x4005AD4")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public int currentProjectile;

		[Token(Token = "0x4005AD5")]
		[FieldOffset(Offset = "0x4C")]
		public float speed;

		[Token(Token = "0x4005AD6")]
		[FieldOffset(Offset = "0x50")]
		public float spawnOffset;

		[Token(Token = "0x4005AD7")]
		[FieldOffset(Offset = "0x54")]
		[Header("Firing Settings")]
		public float fireRate;

		[Token(Token = "0x4005AD8")]
		[FieldOffset(Offset = "0x58")]
		public bool isFullAuto;

		[Token(Token = "0x4005AD9")]
		[FieldOffset(Offset = "0x60")]
		[Header("Gun Settings")]
		public GameObject gunPrefab;

		[Token(Token = "0x4005ADA")]
		[FieldOffset(Offset = "0x68")]
		public float gunOffset;

		[Token(Token = "0x4005ADB")]
		[FieldOffset(Offset = "0x6C")]
		private bool canShoot;

		[Token(Token = "0x4005ADC")]
		[FieldOffset(Offset = "0x70")]
		private GameObject instantiatedGun;

		[Token(Token = "0x6004F56")]
		[Address(RVA = "0x42B4F6C", Offset = "0x42B0F6C", VA = "0x42B4F6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6004F57")]
		[Address(RVA = "0x42B5344", Offset = "0x42B1344", VA = "0x42B5344")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F58")]
		[Address(RVA = "0x42B5AE4", Offset = "0x42B1AE4", VA = "0x42B5AE4")]
		[IteratorStateMachine(typeof(_003CShoot_003Ed__16))]
		private IEnumerator Shoot()
		{
			return null;
		}

		[Token(Token = "0x6004F59")]
		[Address(RVA = "0x42B5B44", Offset = "0x42B1B44", VA = "0x42B5B44")]
		private void ShootProjectile()
		{
		}

		[Token(Token = "0x6004F5A")]
		[Address(RVA = "0x42B5708", Offset = "0x42B1708", VA = "0x42B5708")]
		private void UpdateGunPositionAndRotation()
		{
		}

		[Token(Token = "0x6004F5B")]
		[Address(RVA = "0x42B56A8", Offset = "0x42B16A8", VA = "0x42B56A8")]
		public void nextEffect()
		{
		}

		[Token(Token = "0x6004F5C")]
		[Address(RVA = "0x42B56D8", Offset = "0x42B16D8", VA = "0x42B56D8")]
		public void previousEffect()
		{
		}

		[Token(Token = "0x6004F5D")]
		[Address(RVA = "0x42B520C", Offset = "0x42B120C", VA = "0x42B520C")]
		private void UpdateDisplayName()
		{
		}

		[Token(Token = "0x6004F5E")]
		[Address(RVA = "0x42B5F50", Offset = "0x42B1F50", VA = "0x42B5F50")]
		private void OnSpeedSliderChanged(float value)
		{
		}

		[Token(Token = "0x6004F5F")]
		[Address(RVA = "0x42B5F58", Offset = "0x42B1F58", VA = "0x42B5F58")]
		public PolygonFireProjectile()
		{
		}
	}
}
