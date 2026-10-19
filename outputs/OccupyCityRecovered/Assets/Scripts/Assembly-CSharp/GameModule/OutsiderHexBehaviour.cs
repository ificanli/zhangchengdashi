using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using Il2CppDummyDll;
using QuickTutor;
using TMPro;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20004CF")]
	public class OutsiderHexBehaviour : MonoBehaviour, ITutorialClick
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004D0")]
		[CompilerGenerated]
		private struct _003CCreatBuild_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OutsiderHexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002C4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001830")]
			[Address(RVA = "0x3E735BC", Offset = "0x3E6F5BC", VA = "0x3E735BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001831")]
			[Address(RVA = "0x3E73CB8", Offset = "0x3E6FCB8", VA = "0x3E73CB8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004D1")]
		[CompilerGenerated]
		private struct _003CCreatUI_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OutsiderHexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002C52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001832")]
			[Address(RVA = "0x3E73CC4", Offset = "0x3E6FCC4", VA = "0x3E73CC4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001833")]
			[Address(RVA = "0x3E74888", Offset = "0x3E70888", VA = "0x3E74888", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004D2")]
		[CompilerGenerated]
		private struct _003CInitInfo_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OutsiderHexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002C56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UserOutsiderHexData hexData;

			[Token(Token = "0x6001834")]
			[Address(RVA = "0x3E74894", Offset = "0x3E70894", VA = "0x3E74894", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001835")]
			[Address(RVA = "0x3E75190", Offset = "0x3E71190", VA = "0x3E75190", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004D3")]
		[CompilerGenerated]
		private struct _003CSetMat_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OutsiderHexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002C5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private MeshRenderer _003C_003E7__wrap1;

			[Token(Token = "0x4002C5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<Material>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001836")]
			[Address(RVA = "0x3E7519C", Offset = "0x3E7119C", VA = "0x3E7519C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001837")]
			[Address(RVA = "0x3E757DC", Offset = "0x3E717DC", VA = "0x3E757DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004D4")]
		[CompilerGenerated]
		private struct _003CUpdateMainTower_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4002C5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002C5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002C5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object o;

			[Token(Token = "0x4002C5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public OutsiderHexBehaviour _003C_003E4__this;

			[Token(Token = "0x4002C60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4002C61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private MeshRenderer _003C_003E7__wrap1;

			[Token(Token = "0x4002C62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<Material>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6001838")]
			[Address(RVA = "0x3E757E8", Offset = "0x3E717E8", VA = "0x3E757E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001839")]
			[Address(RVA = "0x3E761CC", Offset = "0x3E721CC", VA = "0x3E761CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UserOutsiderHexData data;

		[Token(Token = "0x4002C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isOpen;

		[Token(Token = "0x4002C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OutsiderHexBehaviour leftUpHexBehaviour;

		[Token(Token = "0x4002C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OutsiderHexBehaviour rightUpTHexBehaviour;

		[Token(Token = "0x4002C3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public OutsiderHexBehaviour upHexBehaviour;

		[Token(Token = "0x4002C3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public OutsiderHexBehaviour downHexBehaviour;

		[Token(Token = "0x4002C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OutsiderHexBehaviour leftDownHexBehaviour;

		[Token(Token = "0x4002C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OutsiderHexBehaviour rightDownHexBehaviour;

		[Token(Token = "0x4002C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject _uiRes;

		[Token(Token = "0x4002C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _showIconUIRes;

		[Token(Token = "0x4002C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _uiObj;

		[Token(Token = "0x4002C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject _showIconUIObj;

		[Token(Token = "0x4002C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshPro tmpUI;

		[Token(Token = "0x4002C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string talentID;

		[Token(Token = "0x4002C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject obj;

		[Token(Token = "0x4002C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int index;

		[Token(Token = "0x4002C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private MeshRenderer meshRenderer;

		[Token(Token = "0x4002C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private MaterialPropertyBlock propertyBlock;

		[Token(Token = "0x4002C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GameObject ground;

		[Token(Token = "0x4002C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private MeshRenderer meshGround;

		[Token(Token = "0x4002C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool scanEnd;

		[Token(Token = "0x6001818")]
		[Address(RVA = "0x3E6CE98", Offset = "0x3E68E98", VA = "0x3E6CE98")]
		[AsyncStateMachine(typeof(_003CInitInfo_003Ed__21))]
		public void InitInfo(UserOutsiderHexData hexData)
		{
		}

		[Token(Token = "0x6001819")]
		[Address(RVA = "0x3E6D110", Offset = "0x3E69110", VA = "0x3E6D110")]
		public void ScanEnd(bool isScanEnd)
		{
		}

		[Token(Token = "0x600181A")]
		[Address(RVA = "0x3E71FB0", Offset = "0x3E6DFB0", VA = "0x3E71FB0")]
		private void UpdateUpgradeMainTowerHexGroundActive(object o)
		{
		}

		[Token(Token = "0x600181B")]
		[Address(RVA = "0x3E6CF34", Offset = "0x3E68F34", VA = "0x3E6CF34")]
		public void SetGeoundScanState()
		{
		}

		[Token(Token = "0x600181C")]
		[Address(RVA = "0x3E6D13C", Offset = "0x3E6913C", VA = "0x3E6D13C")]
		public void GroundSetFalse()
		{
		}

		[Token(Token = "0x600181D")]
		[Address(RVA = "0x3E71FB4", Offset = "0x3E6DFB4", VA = "0x3E71FB4")]
		private void UpdateUpgradeMainTowerHexScanState(object o)
		{
		}

		[Token(Token = "0x600181E")]
		[Address(RVA = "0x3E71FE0", Offset = "0x3E6DFE0", VA = "0x3E71FE0")]
		private void FirstTriggerCreatUpgradeMainTower(object o)
		{
		}

		[Token(Token = "0x600181F")]
		[Address(RVA = "0x3E72114", Offset = "0x3E6E114", VA = "0x3E72114")]
		private void TriggerDestroyAllUpgradeMainBuild(object o)
		{
		}

		[Token(Token = "0x6001820")]
		[Address(RVA = "0x3E721A4", Offset = "0x3E6E1A4", VA = "0x3E721A4")]
		private void UpgradeMainTowerBuildUpdateGraph(object o)
		{
		}

		[Token(Token = "0x6001821")]
		[Address(RVA = "0x3E722FC", Offset = "0x3E6E2FC", VA = "0x3E722FC")]
		private void UpgradeMainTowerHexGroundSetActive(object o)
		{
		}

		[Token(Token = "0x6001822")]
		[Address(RVA = "0x3E72420", Offset = "0x3E6E420", VA = "0x3E72420")]
		private void UpdatePrice(object o)
		{
		}

		[Token(Token = "0x6001823")]
		[Address(RVA = "0x3E7226C", Offset = "0x3E6E26C", VA = "0x3E7226C")]
		[AsyncStateMachine(typeof(_003CCreatBuild_003Ed__32))]
		private void CreatBuild()
		{
		}

		[Token(Token = "0x6001824")]
		[Address(RVA = "0x3E726FC", Offset = "0x3E6E6FC", VA = "0x3E726FC")]
		[AsyncStateMachine(typeof(_003CCreatUI_003Ed__33))]
		private void CreatUI()
		{
		}

		[Token(Token = "0x6001825")]
		[Address(RVA = "0x3E69114", Offset = "0x3E65114", VA = "0x3E69114")]
		public void OpenHex(int woodNum)
		{
		}

		[Token(Token = "0x6001826")]
		[Address(RVA = "0x3E7281C", Offset = "0x3E6E81C", VA = "0x3E7281C")]
		private void HandleOnComplete()
		{
		}

		[Token(Token = "0x6001827")]
		[Address(RVA = "0x3E72D84", Offset = "0x3E6ED84", VA = "0x3E72D84")]
		private void CreatCitizen()
		{
		}

		[Token(Token = "0x6001828")]
		[Address(RVA = "0x3E72074", Offset = "0x3E6E074", VA = "0x3E72074")]
		[AsyncStateMachine(typeof(_003CUpdateMainTower_003Ed__37))]
		private void UpdateMainTower(object o)
		{
		}

		[Token(Token = "0x6001829")]
		[Address(RVA = "0x3E7278C", Offset = "0x3E6E78C", VA = "0x3E7278C")]
		[AsyncStateMachine(typeof(_003CSetMat_003Ed__38))]
		private void SetMat()
		{
		}

		[Token(Token = "0x600182A")]
		[Address(RVA = "0x3E72E34", Offset = "0x3E6EE34", VA = "0x3E72E34")]
		private void UpdateTmUiColor(object o)
		{
		}

		[Token(Token = "0x600182B")]
		[Address(RVA = "0x3E72FC4", Offset = "0x3E6EFC4", VA = "0x3E72FC4")]
		private void UpdateTmUiText(object o)
		{
		}

		[Token(Token = "0x600182C")]
		[Address(RVA = "0x3E73314", Offset = "0x3E6F314", VA = "0x3E73314", Slot = "4")]
		public void OnTutorialClick()
		{
		}

		[Token(Token = "0x600182D")]
		[Address(RVA = "0x3E733B0", Offset = "0x3E6F3B0", VA = "0x3E733B0")]
		public OutsiderHexBehaviour()
		{
		}
	}
}
