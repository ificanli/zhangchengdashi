using System.Collections.Generic;
using Il2CppDummyDll;

namespace BadgeGraph
{
	[Token(Token = "0x2000E07")]
	public class BadgeGraphService
	{
		[Token(Token = "0x40061E7")]
		[FieldOffset(Offset = "0x0")]
		private static BadgeNode s_RootNode;

		[Token(Token = "0x40061E8")]
		[FieldOffset(Offset = "0x8")]
		private static char s_SplitSymbol;

		[Token(Token = "0x40061E9")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<string, string> s_PathMap;

		[Token(Token = "0x6005694")]
		[Address(RVA = "0x433E8E0", Offset = "0x433A8E0", VA = "0x433E8E0")]
		public static void Initialize(BadgeGraphScriptable scriptable)
		{
		}

		[Token(Token = "0x6005695")]
		[Address(RVA = "0x433E914", Offset = "0x433A914", VA = "0x433E914")]
		public static void Initialize(string rootName, char splitSymbol, List<string> pathList)
		{
            s_RootNode = new BadgeNode();
            s_RootNode.NodeName = rootName;
            s_SplitSymbol = splitSymbol;
            s_PathMap = new Dictionary<string, string>();
            int count = pathList.Count;
            for (int i = 0; i < count; i++)
            {
                BadgeNode current = s_RootNode;
                string[] nodes = pathList[i].Split(splitSymbol);
                if (nodes[0] != s_RootNode.NodeName)
                {
                    global::UnityEngine.Debug.LogWarning(string.Format("BadgeTree Root Node Error: {0}", nodes[0]));
                    continue;
                }
                if (nodes.Length < 2) continue;
                s_PathMap.Add(nodes[nodes.Length - 1], pathList[i]);
                for (int j = 1; j < nodes.Length; j++)
                {
                    string name = nodes[j];
                    if (!current.ChildNodeDict.ContainsKey(name))
                        current.ChildNodeDict.Add(name, new BadgeNode());
                    current.ChildNodeDict[name].NodeName = name;
                    current.ChildNodeDict[name].Parent = current;
                    current = current.ChildNodeDict[name];
                }
            }
        }

		[Token(Token = "0x6005696")]
		[Address(RVA = "0x433D788", Offset = "0x4339788", VA = "0x433D788")]
		public static void SetBadgeNodeCallback(string nodeName, bool subscribe, OnPointNumberChanged callback, bool invoke = false)
		{
            GetNodePath(nodeName, out string[] nodes);
            if (nodes == null || nodes.Length < 2) return;
            BadgeNode current = s_RootNode;
            for (int i = 1; i < nodes.Length; i++)
            {
                if (!current.ChildNodeDict.ContainsKey(nodes[i]))
                {
                    global::UnityEngine.Debug.LogWarning(string.Format("Does not contains child node: {0}", nodes[i]));
                    return;
                }
                current = current.ChildNodeDict[nodes[i]];
                if (i != nodes.Length - 1) continue;
                if (subscribe)
                {
                    current.OnPointNumberChangedEvent += callback;
                    if (invoke) current.SetNumber(current.PointNumber);
                }
                else current.OnPointNumberChangedEvent -= callback;
            }
        }

		[Token(Token = "0x6005697")]
		[Address(RVA = "0x433F040", Offset = "0x433B040", VA = "0x433F040")]
		public static void InvokeNode(string nodeName, int number)
		{
            GetNodePath(nodeName, out string[] nodes);
            if (nodes == null || nodes.Length < 2) return;
            BadgeNode current = s_RootNode;
            for (int i = 1; i < nodes.Length; i++)
            {
                if (!current.ChildNodeDict.ContainsKey(nodes[i]))
                {
                    global::UnityEngine.Debug.LogWarning(string.Format("Does not contains child node: {0}", nodes[i]));
                    return;
                }
                current = current.ChildNodeDict[nodes[i]];
                if (i == nodes.Length - 1) current.SetNumber(number);
            }
        }

		[Token(Token = "0x6005698")]
		[Address(RVA = "0x433D968", Offset = "0x4339968", VA = "0x433D968")]
		public static int GetNodeNumber(string nodeName)
		{
            GetNodePath(nodeName, out string[] nodes);
            if (nodes == null || nodes.Length < 2) return 0;
            BadgeNode current = s_RootNode;
            for (int i = 1; i < nodes.Length; i++)
            {
                if (!current.ChildNodeDict.ContainsKey(nodes[i]))
                {
                    global::UnityEngine.Debug.LogWarning(string.Format("Does not contains child node: {0}", nodes[i]));
                    return 0;
                }
                current = current.ChildNodeDict[nodes[i]];
                if (i == nodes.Length - 1) return current.PointNumber;
            }
            return 0;
        }

		[Token(Token = "0x6005699")]
		[Address(RVA = "0x433EDA4", Offset = "0x433ADA4", VA = "0x433EDA4")]
		private static void GetNodePath(string nodeName, out string[] nodes)
		{
            nodes = null;
            if (!s_PathMap.ContainsKey(nodeName))
            {
                global::UnityEngine.Debug.LogWarning(string.Format("Get wrong root node, name: {0}", nodeName));
                return;
            }
            string[] path = s_PathMap[nodeName].Split(s_SplitSymbol);
            if (path.Length == 1 && path[0] != s_RootNode.NodeName)
            {
                global::UnityEngine.Debug.LogWarning(string.Format("Get wrong root node, current is {0}", nodeName));
                return;
            }
            nodes = path;
        }

		[Token(Token = "0x600569A")]
		[Address(RVA = "0x433F1E8", Offset = "0x433B1E8", VA = "0x433F1E8")]
		public BadgeGraphService()
		{
		}
	}
}
