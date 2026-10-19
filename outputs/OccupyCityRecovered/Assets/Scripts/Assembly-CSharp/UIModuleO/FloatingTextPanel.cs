using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000879")]
	public class FloatingTextPanel : DamageTextPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200087A")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__48 : IAsyncStateMachine
		{
			[Token(Token = "0x4004021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FloatingTextPanel _003C_003E4__this;

			[Token(Token = "0x4004024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4004025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002FB1")]
			[Address(RVA = "0x4039794", Offset = "0x4035794", VA = "0x4039794", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002FB2")]
			[Address(RVA = "0x4039C80", Offset = "0x4035C80", VA = "0x4039C80", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003FF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Mesh damageMesh;

		[Token(Token = "0x4003FF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Vector3> damageVertices;

		[Token(Token = "0x4003FF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Vector2> damageUv;

		[Token(Token = "0x4003FF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<Color> damageColors;

		[Token(Token = "0x4003FF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<int> damageTriangles;

		[Token(Token = "0x4003FF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Mesh hpTextMesh;

		[Token(Token = "0x4003FFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Vector3> hpTextVertices;

		[Token(Token = "0x4003FFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<Vector2> hpTextUv;

		[Token(Token = "0x4003FFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<Color> hpTextColors;

		[Token(Token = "0x4003FFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<int> hpTextTriangles;

		[Token(Token = "0x4003FFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Mesh hpBGMesh;

		[Token(Token = "0x4003FFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<Vector3> hpBgVertices;

		[Token(Token = "0x4004000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<Color> hpBgColors;

		[Token(Token = "0x4004001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<int> hpBgTriangles;

		[Token(Token = "0x4004002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<FloatingTextManager.ActiveText> activeTexts;

		[Token(Token = "0x4004003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<FloatingTextManager.ActiveText> hps;

		[Token(Token = "0x4004004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Canvas _canvas2;

		[Token(Token = "0x4004005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly Vector3[] _cornerCenters;

		[Token(Token = "0x4004006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] CornerStartAngles;

		[Token(Token = "0x4004007")]
		private const int InstanceBatchSize = 1023;

		[Token(Token = "0x4004008")]
		private const float DefaultCanvasPlaneDistance = 100f;

		[Token(Token = "0x4004009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int InstanceColorId;

		[Token(Token = "0x400400A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int UvRectId;

		[Token(Token = "0x400400B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Vector2[] OutlineOffsets;

		[Token(Token = "0x400400C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Mesh instancedQuadMesh;

		[Token(Token = "0x400400D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private MaterialPropertyBlock textPropertyBlock;

		[Token(Token = "0x400400E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private MaterialPropertyBlock colorPropertyBlock;

		[Token(Token = "0x400400F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly Matrix4x4[] textInstanceMatrices;

		[Token(Token = "0x4004010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly Vector4[] textInstanceColors;

		[Token(Token = "0x4004011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly Vector4[] textInstanceUvRects;

		[Token(Token = "0x4004012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly Matrix4x4[] colorInstanceMatrices;

		[Token(Token = "0x4004013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly Vector4[] colorInstanceColors;

		[Token(Token = "0x4004014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int textInstanceCount;

		[Token(Token = "0x4004015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int colorInstanceCount;

		[Token(Token = "0x4004016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool canvasRenderersCleared;

		[Token(Token = "0x4004017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Camera instancedRenderCamera;

		[Token(Token = "0x4004018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Material instancedTextMaterial;

		[Token(Token = "0x4004019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Material instancedColorMaterial;

		[Token(Token = "0x400401A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3 instancedRight;

		[Token(Token = "0x400401B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private Vector3 instancedUp;

		[Token(Token = "0x400401C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Quaternion instancedRotation;

		[Token(Token = "0x400401D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float instancedPlaneDistance;

		[Token(Token = "0x400401E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float instancedCanvasPixelScale;

		[Token(Token = "0x400401F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private float instancedWorldPerPixelX;

		[Token(Token = "0x4004020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private float instancedWorldPerPixelY;

		[Token(Token = "0x6002F95")]
		[Address(RVA = "0x4033F3C", Offset = "0x402FF3C", VA = "0x4033F3C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002F96")]
		[Address(RVA = "0x40342EC", Offset = "0x40302EC", VA = "0x40342EC")]
		public void PrewarmForBattle(int damageTextCapacity, int hpCapacity)
		{
		}

		[Token(Token = "0x6002F97")]
		private static void EnsureListCapacity<T>(List<T> list, int capacity)
		{
		}

		[Token(Token = "0x6002F98")]
		[Address(RVA = "0x4034640", Offset = "0x4030640", VA = "0x4034640", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__48))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002F99")]
		[Address(RVA = "0x40346DC", Offset = "0x40306DC", VA = "0x40346DC")]
		public void UpdateTexts(List<FloatingTextManager.ActiveText> damageTexts, List<FloatingTextManager.ActiveText> hpTexts)
		{
		}

		[Token(Token = "0x6002F9A")]
		[Address(RVA = "0x4034034", Offset = "0x4030034", VA = "0x4034034")]
		private void CreateInstancedResources()
		{
		}

		[Token(Token = "0x6002F9B")]
		[Address(RVA = "0x403478C", Offset = "0x403078C", VA = "0x403478C")]
		private bool TryRenderInstanced(List<FloatingTextManager.ActiveText> damageTextList, List<FloatingTextManager.ActiveText> hpTextList)
		{
			return default;
		}

		[Token(Token = "0x6002F9C")]
		[Address(RVA = "0x4034B74", Offset = "0x4030B74", VA = "0x4034B74")]
		private Camera GetInstancedRenderCamera()
		{
			return null;
		}

		[Token(Token = "0x6002F9D")]
		[Address(RVA = "0x4034C9C", Offset = "0x4030C9C", VA = "0x4034C9C")]
		private bool UpdateInstancedFrameData(Camera renderCamera)
		{
			return default;
		}

		[Token(Token = "0x6002F9E")]
		[Address(RVA = "0x4034FB4", Offset = "0x4030FB4", VA = "0x4034FB4")]
		private void ClearCanvasRenderersOnce()
		{
		}

		[Token(Token = "0x6002F9F")]
		[Address(RVA = "0x4035A00", Offset = "0x4031A00", VA = "0x4035A00")]
		private void RenderInstancedText(List<FloatingTextManager.ActiveText> tempActiveTexts)
		{
		}

		[Token(Token = "0x6002FA0")]
		[Address(RVA = "0x40350F8", Offset = "0x40310F8", VA = "0x40350F8")]
		private void RenderInstancedBackgrounds(List<FloatingTextManager.ActiveText> tempActiveTexts)
		{
		}

		[Token(Token = "0x6002FA1")]
		[Address(RVA = "0x40364D8", Offset = "0x40324D8", VA = "0x40364D8")]
		private Vector3 ScreenToInstancedWorld(Vector3 screenPoint)
		{
			return default;
		}

		[Token(Token = "0x6002FA2")]
		[Address(RVA = "0x40364FC", Offset = "0x40324FC", VA = "0x40364FC")]
		private float CanvasUnitsToWorldX(float value)
		{
			return default;
		}

		[Token(Token = "0x6002FA3")]
		[Address(RVA = "0x4036510", Offset = "0x4032510", VA = "0x4036510")]
		private float CanvasUnitsToWorldY(float value)
		{
			return default;
		}

		[Token(Token = "0x6002FA4")]
		[Address(RVA = "0x4036524", Offset = "0x4032524", VA = "0x4036524")]
		private void AddTextInstance(Vector3 center, Vector3 scale, Vector4 uvRect, Color color)
		{
		}

		[Token(Token = "0x6002FA5")]
		[Address(RVA = "0x403668C", Offset = "0x403268C", VA = "0x403668C")]
		private void AddColorInstance(Vector3 center, float width, float height, Color color)
		{
		}

		[Token(Token = "0x6002FA6")]
		[Address(RVA = "0x4036338", Offset = "0x4032338", VA = "0x4036338")]
		private void FlushTextInstances()
		{
		}

		[Token(Token = "0x6002FA7")]
		[Address(RVA = "0x403587C", Offset = "0x403187C", VA = "0x403587C")]
		private void FlushColorInstances()
		{
		}

		[Token(Token = "0x6002FA8")]
		[Address(RVA = "0x40367FC", Offset = "0x40327FC", VA = "0x40367FC")]
		private void GenerateMesh(List<FloatingTextManager.ActiveText> tempActiveTexts, List<Vector3> vertices, List<Vector2> uv, List<Color> colors, List<int> triangles, CanvasRenderer canvasRenderer, Mesh mesh, Material material, Texture texture)
		{
		}

		[Token(Token = "0x6002FA9")]
		[Address(RVA = "0x4037AAC", Offset = "0x4033AAC", VA = "0x4037AAC")]
		private void GenerateBackgroundMesh(List<FloatingTextManager.ActiveText> tempActiveTexts)
		{
		}

		[Token(Token = "0x6002FAA")]
		[Address(RVA = "0x4037238", Offset = "0x4033238", VA = "0x4037238")]
		private void AddCharacterQuad(List<Vector3> vertices, List<Vector2> uv, List<Color> colors, List<int> triangles, Vector3 position, float size, Vector2 uvPos, float uvWidth, float uvHeight, Color color, ref int vertexIndex)
		{
		}

		[Token(Token = "0x6002FAB")]
		[Address(RVA = "0x40383AC", Offset = "0x40343AC", VA = "0x40383AC")]
		private void GenerateRectangle(Vector3 center, float width, float height, Color color, ref int vertexIndex, float fontSizeScale = 1f)
		{
		}

		[Token(Token = "0x6002FAC")]
		[Address(RVA = "0x4038BDC", Offset = "0x4034BDC", VA = "0x4038BDC")]
		private void GenerateRectangleSharp(Vector3 center, float width, float height, Color color, ref int vertexIndex)
		{
		}

		[Token(Token = "0x6002FAD")]
		[Address(RVA = "0x4039204", Offset = "0x4035204", VA = "0x4039204", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002FAE")]
		[Address(RVA = "0x40392AC", Offset = "0x40352AC", VA = "0x40392AC")]
		public FloatingTextPanel()
		{
		}
	}
}
