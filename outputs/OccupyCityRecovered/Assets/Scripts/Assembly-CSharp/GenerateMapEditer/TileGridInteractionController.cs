using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using ToolModule;
using UnityEngine;
using UnityEngine.UI;

namespace GenerateMapEditer
{
	[Token(Token = "0x20001E2")]
	public class TileGridInteractionController : ManagerBase<TileGridInteractionController>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001E3")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__39 : IAsyncStateMachine
		{
			[Token(Token = "0x4001C54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x4180234", Offset = "0x417C234", VA = "0x4180234", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x41802E8", Offset = "0x417C2E8", VA = "0x41802E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool canControllerCamera;

		[Token(Token = "0x4001C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector2 currentResolution;

		[Token(Token = "0x4001C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 downPos;

		[Token(Token = "0x4001C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 upPos;

		[Token(Token = "0x4001C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool drag;

		[Token(Token = "0x4001C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 offset;

		[Token(Token = "0x4001C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _dis;

		[Token(Token = "0x4001C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 min;

		[Token(Token = "0x4001C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 max;

		[Token(Token = "0x4001C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool leftMouseDown;

		[Token(Token = "0x4001C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool rightMouseDown;

		[NonSerialized]
		[Token(Token = "0x4001C3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		public bool isCanDrag;

		[Token(Token = "0x4001C3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Camera mainCamera;

		[Token(Token = "0x4001C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform controllerCamera;

		[Token(Token = "0x4001C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float slideSpeed;

		[Token(Token = "0x4001C3E")]
		private const float BaseWidth = 750f;

		[Token(Token = "0x4001C3F")]
		private const float BaseHeight = 1334f;

		[Token(Token = "0x4001C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 endPos;

		[Token(Token = "0x4001C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool prevTouchPositionsSet;

		[Token(Token = "0x4001C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float zoomSpeed;

		[Token(Token = "0x4001C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private MapTileBehaviour currentSetTile;

		[Token(Token = "0x4001C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public GameObject setTilePanel;

		[Token(Token = "0x4001C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public GameObject cardEditorPanel;

		[Token(Token = "0x4001C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TMP_InputField typeInput;

		[Token(Token = "0x4001C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public TMP_InputField numberInput;

		[Token(Token = "0x4001C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public TMP_InputField buildModelInput;

		[Token(Token = "0x4001C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public TMP_InputField enemyModelInPut;

		[Token(Token = "0x4001C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public TMP_InputField eventTypeInput;

		[Token(Token = "0x4001C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Button okBtn;

		[Token(Token = "0x4001C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Button deckBtn;

		[Token(Token = "0x4001C4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Button CardPanelCloseBtn;

		[Token(Token = "0x4001C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Button ChangeType;

		[Token(Token = "0x4001C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public GameObject select1;

		[Token(Token = "0x4001C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public GameObject select2;

		[Token(Token = "0x4001C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool curSelect1;

		[Token(Token = "0x4001C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		private bool setTileDataing;

		[Token(Token = "0x4001C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private MapTileBehaviour currentRayTile;

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x408E690", Offset = "0x408A690", VA = "0x408E690")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x408E954", Offset = "0x408A954", VA = "0x408E954")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x408F3F8", Offset = "0x408B3F8", VA = "0x408F3F8", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__39))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x408F484", Offset = "0x408B484", VA = "0x408F484")]
		public TileGridInteractionController()
		{
		}
	}
}
