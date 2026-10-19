using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200000F")]
	public class NavMeshDemoSceneGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x20")]
		[Header("Script References")]
		public GPUICrowdManager gpuiCrowdManager;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x28")]
		public GPUInstancerLODColorDebugger gpuiLODColorDebugger;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x30")]
		public NavMeshDemoSceneController demoSceneController;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x38")]
		[Header("GUI References")]
		public Image imageManagerToggle;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject panelPrototypeControl;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x48")]
		public Text textInstanceInfo;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x50")]
		private string _prototypeInfoText;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x73C18EC", Offset = "0x73BD8EC", VA = "0x73C18EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x73C1C14", Offset = "0x73BDC14", VA = "0x73C1C14")]
		public void ToggleCrowdManager(bool isEnabled)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x73C18F0", Offset = "0x73BD8F0", VA = "0x73C18F0")]
		public void SetPrototypeInfoText()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x73C1D0C", Offset = "0x73BDD0C", VA = "0x73C1D0C")]
		public void ToggleLODColors(bool isColored)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x73C1DE0", Offset = "0x73BDDE0", VA = "0x73C1DE0")]
		public void OnAddInstances()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x73C1E1C", Offset = "0x73BDE1C", VA = "0x73C1E1C")]
		public NavMeshDemoSceneGUIHandler()
		{
		}
	}
}
