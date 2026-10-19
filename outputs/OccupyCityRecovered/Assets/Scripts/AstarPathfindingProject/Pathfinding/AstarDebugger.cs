using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200006D")]
	[AddComponentMenu("Pathfinding/Pathfinding Debugger")]
	[ExecuteInEditMode]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/astardebugger.html")]
	public class AstarDebugger : VersionedMonoBehaviour
	{
		[Token(Token = "0x200006E")]
		private struct GraphPoint
		{
			[Token(Token = "0x400027C")]
			[FieldOffset(Offset = "0x0")]
			public float fps;

			[Token(Token = "0x400027D")]
			[FieldOffset(Offset = "0x4")]
			public float memory;

			[Token(Token = "0x400027E")]
			[FieldOffset(Offset = "0x8")]
			public bool collectEvent;
		}

		[Token(Token = "0x200006F")]
		private struct PathTypeDebug
		{
			[Token(Token = "0x400027F")]
			[FieldOffset(Offset = "0x0")]
			private string name;

			[Token(Token = "0x4000280")]
			[FieldOffset(Offset = "0x8")]
			private Func<int> getSize;

			[Token(Token = "0x4000281")]
			[FieldOffset(Offset = "0x10")]
			private Func<int> getTotalCreated;

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x44FD164", Offset = "0x44F9164", VA = "0x44FD164")]
			public PathTypeDebug(string name, Func<int> getSize, Func<int> getTotalCreated)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarDebugger.PathTypeDebug..ctor RVA=0x44FD164 Token=0x600041C");
}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x44FC708", Offset = "0x44F8708", VA = "0x44FC708")]
			public void Print(StringBuilder text)
			{
			}
		}

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x28")]
		public int yOffset;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x2C")]
		public bool show;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x2D")]
		public bool showInEditor;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x2E")]
		public bool showFPS;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x2F")]
		public bool showPathProfile;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x30")]
		public bool showMemProfile;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x31")]
		public bool showGraph;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x34")]
		public int graphBufferSize;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x38")]
		public Font font;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x40")]
		public int fontSize;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x48")]
		private StringBuilder text;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x50")]
		private string cachedText;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x58")]
		private float lastUpdate;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x60")]
		private GraphPoint[] graph;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x68")]
		private float delayedDeltaTime;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x6C")]
		private float lastCollect;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x70")]
		private float lastCollectNum;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x74")]
		private float delta;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x78")]
		private float lastDeltaTime;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x7C")]
		private int allocRate;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x80")]
		private int lastAllocMemory;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x84")]
		private float lastAllocSet;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x88")]
		private int allocMem;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x8C")]
		private int collectAlloc;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x90")]
		private int peakAlloc;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x94")]
		private int fpsDropCounterSize;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x98")]
		private float[] fpsDrops;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0xA0")]
		private Rect boxRect;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0xB0")]
		private GUIStyle style;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0xC0")]
		private float graphWidth;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0xC4")]
		private float graphHeight;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0xC8")]
		private float graphOffset;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0xCC")]
		private int maxVecPool;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0xD0")]
		private int maxNodePool;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0xD8")]
		private PathTypeDebug[] debugTypes;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x44FACB4", Offset = "0x44F6CB4", VA = "0x44FACB4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x44FAE14", Offset = "0x44F6E14", VA = "0x44FAE14")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x44FB4D8", Offset = "0x44F74D8", VA = "0x44FB4D8")]
		private void DrawGraphLine(int index, Matrix4x4 m, float x1, float x2, float y1, float y2, Color color)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x44FB614", Offset = "0x44F7614", VA = "0x44FB614")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x44FC850", Offset = "0x44F8850", VA = "0x44FC850")]
		public AstarDebugger()
		{
		}
	}
}
