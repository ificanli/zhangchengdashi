using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000083")]
	public class RuntimeInspectorWindow : MonoBehaviour, IDebuggerWindowUGUI
	{
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x20")]
		[Header("等界面开启后再打开")]
		[SerializeField]
		private GameObject[] _children;

		[Token(Token = "0x4000238")]
		private const string WindowPath = "Hierarchy";

		[Token(Token = "0x4000239")]
		private const string PrefabPath = "RuntimeInspector/HierarchyAndInspectorPanel";

		[Token(Token = "0x1700007D")]
		public RectTransform Root
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x468DACC", Offset = "0x4689ACC", VA = "0x468DACC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public bool SupportClickThrough
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x468DB2C", Offset = "0x4689B2C", VA = "0x468DB2C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x468DB34", Offset = "0x4689B34", VA = "0x468DB34", Slot = "6")]
		public void Initialize(params object[] args)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x468DC2C", Offset = "0x4689C2C", VA = "0x468DC2C", Slot = "7")]
		public void OnDebuggerSystemReopen()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x468DC30", Offset = "0x4689C30", VA = "0x468DC30", Slot = "9")]
		public void OnEnter()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x468DC34", Offset = "0x4689C34", VA = "0x468DC34", Slot = "10")]
		public void OnLeave()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x468DC38", Offset = "0x4689C38", VA = "0x468DC38", Slot = "11")]
		public void OnUpdate(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x468DC3C", Offset = "0x4689C3C", VA = "0x468DC3C", Slot = "12")]
		public void RefreshSize(Vector2 size, bool portrait)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x468DC40", Offset = "0x4689C40", VA = "0x468DC40", Slot = "8")]
		public void Shutdown()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x468DC44", Offset = "0x4689C44", VA = "0x468DC44")]
		public static void RegisterWindow()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x468DE30", Offset = "0x4689E30", VA = "0x468DE30")]
		public RuntimeInspectorWindow()
		{
		}
	}
}
