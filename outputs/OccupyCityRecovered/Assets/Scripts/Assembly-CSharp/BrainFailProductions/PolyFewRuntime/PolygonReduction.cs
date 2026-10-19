using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BrainFailProductions.PolyFewRuntime
{
	[Token(Token = "0x2000D16")]
	public class PolygonReduction : MonoBehaviour
	{
		[Token(Token = "0x2000D1B")]
		[CompilerGenerated]
		private sealed class _003CShowMessage_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005DB7")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005DB8")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005DB9")]
			[FieldOffset(Offset = "0x20")]
			public string message;

			[Token(Token = "0x4005DBA")]
			[FieldOffset(Offset = "0x28")]
			public PolygonReduction _003C_003E4__this;

			[Token(Token = "0x17000E5A")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005187")]
				[Address(RVA = "0x42E1618", Offset = "0x42DD618", VA = "0x42E1618", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E5B")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005189")]
				[Address(RVA = "0x42E1658", Offset = "0x42DD658", VA = "0x42E1658", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005184")]
			[Address(RVA = "0x42E0CA8", Offset = "0x42DCCA8", VA = "0x42E0CA8")]
			[DebuggerHidden]
			public _003CShowMessage_003Ed__40(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005185")]
			[Address(RVA = "0x42E14F8", Offset = "0x42DD4F8", VA = "0x42E14F8", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005186")]
			[Address(RVA = "0x42E14FC", Offset = "0x42DD4FC", VA = "0x42E14FC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005187")]
			[Address(RVA = "0x42E1618", Offset = "0x42DD618", VA = "0x42E1618", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005188")]
			[Address(RVA = "0x42E1620", Offset = "0x42DD620", VA = "0x42E1620", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005189")]
			[Address(RVA = "0x42E1658", Offset = "0x42DD658", VA = "0x42E1658", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000D1C")]
		[CompilerGenerated]
		private sealed class _003CUpdateProgress_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005DBB")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005DBC")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005DBD")]
			[FieldOffset(Offset = "0x20")]
			public PolygonReduction _003C_003E4__this;

			[Token(Token = "0x17000E5C")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600518D")]
				[Address(RVA = "0x42E17A8", Offset = "0x42DD7A8", VA = "0x42E17A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000E5D")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600518F")]
				[Address(RVA = "0x42E17E8", Offset = "0x42DD7E8", VA = "0x42E17E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600518A")]
			[Address(RVA = "0x42E0CD0", Offset = "0x42DCCD0", VA = "0x42E0CD0")]
			[DebuggerHidden]
			public _003CUpdateProgress_003Ed__42(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600518B")]
			[Address(RVA = "0x42E1660", Offset = "0x42DD660", VA = "0x42E1660", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600518C")]
			[Address(RVA = "0x42E1664", Offset = "0x42DD664", VA = "0x42E1664", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600518D")]
			[Address(RVA = "0x42E17A8", Offset = "0x42DD7A8", VA = "0x42E17A8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600518E")]
			[Address(RVA = "0x42E17B0", Offset = "0x42DD7B0", VA = "0x42E17B0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600518F")]
			[Address(RVA = "0x42E17E8", Offset = "0x42DD7E8", VA = "0x42E17E8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005D91")]
		[FieldOffset(Offset = "0x20")]
		public Slider reductionStrength;

		[Token(Token = "0x4005D92")]
		[FieldOffset(Offset = "0x28")]
		public Slider preservationStrength;

		[Token(Token = "0x4005D93")]
		[FieldOffset(Offset = "0x30")]
		public Toggle preserveUVFoldover;

		[Token(Token = "0x4005D94")]
		[FieldOffset(Offset = "0x38")]
		public Toggle preserveUVSeams;

		[Token(Token = "0x4005D95")]
		[FieldOffset(Offset = "0x40")]
		public Toggle preserveBorders;

		[Token(Token = "0x4005D96")]
		[FieldOffset(Offset = "0x48")]
		public Toggle enableSmartLinking;

		[Token(Token = "0x4005D97")]
		[FieldOffset(Offset = "0x50")]
		public Toggle preserveFace;

		[Token(Token = "0x4005D98")]
		[FieldOffset(Offset = "0x58")]
		public Toggle recalculateNormals;

		[Token(Token = "0x4005D99")]
		[FieldOffset(Offset = "0x60")]
		public Toggle regardCurvature;

		[Token(Token = "0x4005D9A")]
		[FieldOffset(Offset = "0x68")]
		public InputField trianglesCount;

		[Token(Token = "0x4005D9B")]
		[FieldOffset(Offset = "0x70")]
		public Text message;

		[Token(Token = "0x4005D9C")]
		[FieldOffset(Offset = "0x78")]
		public Text progress;

		[Token(Token = "0x4005D9D")]
		[FieldOffset(Offset = "0x80")]
		public Button exportButton;

		[Token(Token = "0x4005D9E")]
		[FieldOffset(Offset = "0x88")]
		public Button importFromFileSystem;

		[Token(Token = "0x4005D9F")]
		[FieldOffset(Offset = "0x90")]
		public Button importFromWeb;

		[Token(Token = "0x4005DA0")]
		[FieldOffset(Offset = "0x98")]
		public Slider progressSlider;

		[Token(Token = "0x4005DA1")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject uninteractivePanel;

		[Token(Token = "0x4005DA2")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject targetObject;

		[Token(Token = "0x4005DA3")]
		[FieldOffset(Offset = "0xB0")]
		public Transform preservationSphere;

		[Token(Token = "0x4005DA4")]
		[FieldOffset(Offset = "0xB8")]
		public EventSystem eventSystem;

		[Token(Token = "0x4005DA5")]
		[FieldOffset(Offset = "0xC0")]
		private PolyfewRuntime.ObjectMeshPairs objectMeshPairs;

		[Token(Token = "0x4005DA6")]
		[FieldOffset(Offset = "0xC8")]
		private bool didApplyLosslessLast;

		[Token(Token = "0x4005DA7")]
		[FieldOffset(Offset = "0xC9")]
		private bool disableTemporary;

		[Token(Token = "0x4005DA8")]
		[FieldOffset(Offset = "0xD0")]
		private GameObject barabarianRef;

		[Token(Token = "0x4005DA9")]
		[FieldOffset(Offset = "0xD8")]
		private PolyfewRuntime.ReferencedNumeric<float> downloadProgress;

		[Token(Token = "0x4005DAA")]
		[FieldOffset(Offset = "0xE0")]
		private bool isImportingFromNetwork;

		[Token(Token = "0x4005DAB")]
		[FieldOffset(Offset = "0xE1")]
		private bool isWebGL;

		[Token(Token = "0x6005165")]
		[Address(RVA = "0x42DCEE0", Offset = "0x42D8EE0", VA = "0x42DCEE0")]
		private void Start()
		{
		}

		[Token(Token = "0x6005166")]
		[Address(RVA = "0x42DD6B0", Offset = "0x42D96B0", VA = "0x42DD6B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6005167")]
		[Address(RVA = "0x42DD814", Offset = "0x42D9814", VA = "0x42DD814")]
		public void OnReductionChange(float value)
		{
		}

		[Token(Token = "0x6005168")]
		[Address(RVA = "0x42DFAF0", Offset = "0x42DBAF0", VA = "0x42DFAF0")]
		public void SimplifyLossless()
		{
		}

		[Token(Token = "0x6005169")]
		[Address(RVA = "0x42DFCF4", Offset = "0x42DBCF4", VA = "0x42DFCF4")]
		public void ImportOBJ()
		{
		}

		[Token(Token = "0x600516A")]
		[Address(RVA = "0x42E0040", Offset = "0x42DC040", VA = "0x42E0040")]
		public void ImportOBJFromNetwork()
		{
		}

		[Token(Token = "0x600516B")]
		[Address(RVA = "0x42E0438", Offset = "0x42DC438", VA = "0x42E0438")]
		public void ExportGameObjectToOBJ()
		{
		}

		[Token(Token = "0x600516C")]
		[Address(RVA = "0x42E07C8", Offset = "0x42DC7C8", VA = "0x42E07C8")]
		public void OnToggleStateChanged(bool isOn)
		{
		}

		[Token(Token = "0x600516D")]
		[Address(RVA = "0x42E0860", Offset = "0x42DC860", VA = "0x42E0860")]
		public void OnPreservationStrengthChange(float value)
		{
		}

		[Token(Token = "0x600516E")]
		[Address(RVA = "0x42E0868", Offset = "0x42DC868", VA = "0x42E0868")]
		public void Reset()
		{
		}

		[Token(Token = "0x600516F")]
		[Address(RVA = "0x42E0B2C", Offset = "0x42DCB2C", VA = "0x42E0B2C")]
		public static void OnSliderSelect()
		{
		}

		[Token(Token = "0x6005170")]
		[Address(RVA = "0x42E0B78", Offset = "0x42DCB78", VA = "0x42E0B78")]
		public static void OnSliderDeselect()
		{
		}

		[Token(Token = "0x6005171")]
		[Address(RVA = "0x42E0BC0", Offset = "0x42DCBC0", VA = "0x42E0BC0")]
		private bool IsMouseOverUI(RectTransform uiElement)
		{
			return default;
		}

		[Token(Token = "0x6005172")]
		[Address(RVA = "0x42E0C3C", Offset = "0x42DCC3C", VA = "0x42E0C3C")]
		[IteratorStateMachine(typeof(_003CShowMessage_003Ed__40))]
		private IEnumerator ShowMessage(string message)
		{
			return null;
		}

		[Token(Token = "0x6005173")]
		[Address(RVA = "0x42E0A50", Offset = "0x42DCA50", VA = "0x42E0A50")]
		private void ResetSettings()
		{
		}

		[Token(Token = "0x6005174")]
		[Address(RVA = "0x42E02EC", Offset = "0x42DC2EC", VA = "0x42E02EC")]
		[IteratorStateMachine(typeof(_003CUpdateProgress_003Ed__42))]
		private IEnumerator UpdateProgress()
		{
			return null;
		}

		[Token(Token = "0x6005175")]
		[Address(RVA = "0x42DDC00", Offset = "0x42D9C00", VA = "0x42DDC00")]
		private void AssignMeshesFromPairs()
		{
		}

		[Token(Token = "0x6005176")]
		[Address(RVA = "0x42E0CF8", Offset = "0x42DCCF8", VA = "0x42E0CF8")]
		public PolygonReduction()
		{
		}
	}
}
