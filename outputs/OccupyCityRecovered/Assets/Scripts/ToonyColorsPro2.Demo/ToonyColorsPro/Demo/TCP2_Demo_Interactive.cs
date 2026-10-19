using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ToonyColorsPro.Demo
{
	[Token(Token = "0x200000B")]
	public class TCP2_Demo_Interactive : MonoBehaviour
	{
		[Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class _003CCR_MoveToContent_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000056")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x20")]
			public TCP2_Demo_Interactive _003C_003E4__this;

			[Token(Token = "0x4000059")]
			[FieldOffset(Offset = "0x28")]
			public TCP2_Demo_Interactive_Content content;

			[Token(Token = "0x400005A")]
			[FieldOffset(Offset = "0x30")]
			private Vector3 _003CstartPos_003E5__2;

			[Token(Token = "0x400005B")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 _003CendPos_003E5__3;

			[Token(Token = "0x400005C")]
			[FieldOffset(Offset = "0x48")]
			private Quaternion _003CstartQuat_003E5__4;

			[Token(Token = "0x400005D")]
			[FieldOffset(Offset = "0x58")]
			private Quaternion _003CendQuat_003E5__5;

			[Token(Token = "0x400005E")]
			[FieldOffset(Offset = "0x68")]
			private float _003Cduration_003E5__6;

			[Token(Token = "0x400005F")]
			[FieldOffset(Offset = "0x6C")]
			private float _003Ctime_003E5__7;

			[Token(Token = "0x17000002")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000025")]
				[Address(RVA = "0x7D669D0", Offset = "0x7D629D0", VA = "0x7D669D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000003")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000027")]
				[Address(RVA = "0x7D66A10", Offset = "0x7D62A10", VA = "0x7D66A10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000022")]
			[Address(RVA = "0x7D660D4", Offset = "0x7D620D4", VA = "0x7D660D4")]
			[DebuggerHidden]
			public _003CCR_MoveToContent_003Ed__35(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x7D662E4", Offset = "0x7D622E4", VA = "0x7D662E4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000024")]
			[Address(RVA = "0x7D662E8", Offset = "0x7D622E8", VA = "0x7D662E8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x7D669D0", Offset = "0x7D629D0", VA = "0x7D669D0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x7D669D8", Offset = "0x7D629D8", VA = "0x7D669D8", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x7D66A10", Offset = "0x7D62A10", VA = "0x7D66A10", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class _003CCR_ResetCamPos_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000060")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000061")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000062")]
			[FieldOffset(Offset = "0x20")]
			public TCP2_Demo_Interactive _003C_003E4__this;

			[Token(Token = "0x4000063")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 _003CstartPos_003E5__2;

			[Token(Token = "0x4000064")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 _003CendPos_003E5__3;

			[Token(Token = "0x4000065")]
			[FieldOffset(Offset = "0x40")]
			private Quaternion _003CstartQuat_003E5__4;

			[Token(Token = "0x4000066")]
			[FieldOffset(Offset = "0x50")]
			private Quaternion _003CendQuat_003E5__5;

			[Token(Token = "0x4000067")]
			[FieldOffset(Offset = "0x60")]
			private float _003Cduration_003E5__6;

			[Token(Token = "0x4000068")]
			[FieldOffset(Offset = "0x64")]
			private float _003Ctime_003E5__7;

			[Token(Token = "0x17000004")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600002B")]
				[Address(RVA = "0x7D66CE8", Offset = "0x7D62CE8", VA = "0x7D66CE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000005")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600002D")]
				[Address(RVA = "0x7D66D28", Offset = "0x7D62D28", VA = "0x7D66D28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x7D660AC", Offset = "0x7D620AC", VA = "0x7D660AC")]
			[DebuggerHidden]
			public _003CCR_ResetCamPos_003Ed__33(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x7D66A18", Offset = "0x7D62A18", VA = "0x7D66A18", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600002A")]
			[Address(RVA = "0x7D66A1C", Offset = "0x7D62A1C", VA = "0x7D66A1C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0x7D66CE8", Offset = "0x7D62CE8", VA = "0x7D66CE8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x7D66CF0", Offset = "0x7D62CF0", VA = "0x7D66CF0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x7D66D28", Offset = "0x7D62D28", VA = "0x7D66D28", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x20")]
		public TCP2_Demo_Camera demoCamera;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x28")]
		public Camera camera;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x30")]
		public Canvas canvas;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x38")]
		public CanvasScaler canvasScaler;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x40")]
		[Space]
		public HorizontalLayoutGroup layoutGroup;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x48")]
		public ContentSizeFitter sizeFitter;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x50")]
		[Space]
		public RectTransform textBox;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x58")]
		public Text text;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x60")]
		public Image line;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x68")]
		[Space]
		public float camAnimDuration;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x6C")]
		public float maxCamAnimDuration;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x70")]
		public bool camAnimBasedOnDistance;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x74")]
		public float uiAnimDuration;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x78")]
		[Space]
		public Button envButtonTemplate;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x80")]
		private Button[] envButtons;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x88")]
		public Text highlightLabel;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x90")]
		private TCP2_Demo_Interactive_Content[] contents;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x98")]
		private TCP2_Demo_Interactive_Content currentContent;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xA0")]
		private int index;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xA8")]
		private TCP2_Demo_Interactive_Environment[] lightings;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xB0")]
		private int lightingIndex;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0xB4")]
		private Color envButtonColor;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 cameraResetPos;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0xD0")]
		private Quaternion cameraResetQuat;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0xE0")]
		private Transform resetPivot;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0xE8")]
		private bool coroutineActive;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject infoBox;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x7D65164", Offset = "0x7D61164", VA = "0x7D65164")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x7D657D4", Offset = "0x7D617D4", VA = "0x7D657D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x7D65808", Offset = "0x7D61808", VA = "0x7D65808")]
		private void HandleKeyboard()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x7D65C24", Offset = "0x7D61C24", VA = "0x7D65C24")]
		public void PrevHighlight()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x7D65B5C", Offset = "0x7D61B5C", VA = "0x7D65B5C")]
		public void NextHighlight()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x7D65944", Offset = "0x7D61944", VA = "0x7D65944")]
		private void UpdateViewToCurrentContent(float lengthPercent = 1f)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x7D65D58", Offset = "0x7D61D58", VA = "0x7D65D58")]
		private void PlaceLine(Vector2 start, Vector2 end, float lengthPercentage)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x7D65AC8", Offset = "0x7D61AC8", VA = "0x7D65AC8")]
		private void ResetView()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x7D6604C", Offset = "0x7D6204C", VA = "0x7D6604C")]
		[IteratorStateMachine(typeof(_003CCR_ResetCamPos_003Ed__33))]
		private IEnumerator CR_ResetCamPos()
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x7D65CEC", Offset = "0x7D61CEC", VA = "0x7D65CEC")]
		[IteratorStateMachine(typeof(_003CCR_MoveToContent_003Ed__35))]
		private IEnumerator CR_MoveToContent(TCP2_Demo_Interactive_Content content)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x7D656C4", Offset = "0x7D616C4", VA = "0x7D656C4")]
		private void OnSelectLightingSettings(int index)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x7D66280", Offset = "0x7D62280", VA = "0x7D66280")]
		public void HideInfoBox()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x7D662A0", Offset = "0x7D622A0", VA = "0x7D662A0")]
		public TCP2_Demo_Interactive()
		{
		}
	}
}
