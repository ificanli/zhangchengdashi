using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Poco
{
	[Token(Token = "0x2000017")]
	public class UnityNode : AbstractNode
	{
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<string, string> TypeNames;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x8")]
		public static string DefaultTypeName;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x18")]
		private GameObject gameObject;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x20")]
		private Renderer renderer;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform rectTransform;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x30")]
		private Rect rect;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 objectPos;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x48")]
		private List<string> components;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x50")]
		private Camera camera;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x787ECC8", Offset = "0x787ACC8", VA = "0x787ECC8")]
		public UnityNode(GameObject obj)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x787F2CC", Offset = "0x787B2CC", VA = "0x787F2CC", Slot = "4")]
		public override AbstractNode getParent()
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x787F358", Offset = "0x787B358", VA = "0x787F358", Slot = "5")]
		public override List<AbstractNode> getChildren()
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x787F724", Offset = "0x787B724", VA = "0x787F724", Slot = "6")]
		public override object getAttr(string attrName)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x7881170", Offset = "0x787D170", VA = "0x7881170", Slot = "8")]
		public override Dictionary<string, object> enumerateAttrs()
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x7881350", Offset = "0x787D350", VA = "0x7881350")]
		private Dictionary<string, object> GetPayload()
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x787FEEC", Offset = "0x787BEEC", VA = "0x787FEEC")]
		private string GuessObjectTypeFromComponentNames(List<string> components)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x7880178", Offset = "0x787C178", VA = "0x7880178")]
		private bool GameObjectVisible(Renderer renderer, List<string> components)
		{
			return default;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x7881154", Offset = "0x787D154", VA = "0x7881154")]
		private int GameObjectLayer()
		{
			return default;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x7881130", Offset = "0x787D130", VA = "0x7881130")]
		private string GameObjectLayerName()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x7880CD8", Offset = "0x787CCD8", VA = "0x7880CD8")]
		private bool GameObjectClickable(List<string> components)
		{
			return default;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x7880D84", Offset = "0x787CD84", VA = "0x7880D84")]
		private string GameObjectText()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x788103C", Offset = "0x787D03C", VA = "0x788103C")]
		private string GameObjectTag()
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x787F124", Offset = "0x787B124", VA = "0x787F124")]
		private List<string> GameObjectAllComponents()
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x7880B50", Offset = "0x787CB50", VA = "0x7880B50")]
		private Dictionary<string, float> GameObjectzOrders()
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x787EF30", Offset = "0x787AF30", VA = "0x787EF30")]
		private Rect GameObjectRect(Renderer renderer, RectTransform rectTransform)
		{
			return default;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x78802CC", Offset = "0x787C2CC", VA = "0x78802CC")]
		private float[] GameObjectPosInScreen(Vector3 objectPos, Renderer renderer, RectTransform rectTransform, Rect rect)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x7881C18", Offset = "0x787DC18", VA = "0x7881C18")]
		private Canvas GetRootCanvas(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x78806C0", Offset = "0x787C6C0", VA = "0x78806C0")]
		private float[] GameObjectSizeInScreen(Rect rect, RectTransform rectTransform)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x788095C", Offset = "0x787C95C", VA = "0x788095C")]
		private float[] GameObjectAnchorInScreen(Renderer renderer, Rect rect, Vector3 objectPos)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x7880E38", Offset = "0x787CE38", VA = "0x7880E38")]
		private string GetImageSourceTexture()
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x787F028", Offset = "0x787B028", VA = "0x787F028")]
		protected static Vector2 WorldToGUIPoint(Camera camera, Vector3 world)
		{
			return default;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x78818CC", Offset = "0x787D8CC", VA = "0x78818CC")]
		protected static Rect RendererToScreenSpace(Camera camera, Renderer renderer)
		{
			return default;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x7881B58", Offset = "0x787DB58", VA = "0x7881B58")]
		protected static Rect RectTransformToScreenSpace(RectTransform rectTransform)
		{
			return default;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x787A638", Offset = "0x7876638", VA = "0x787A638")]
		public static bool SetText(GameObject go, string textVal)
		{
			return default;
		}
	}
}
