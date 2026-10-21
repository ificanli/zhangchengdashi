using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

namespace BadgeGraph
{
	[Token(Token = "0x2000E08")]
	public class BadgeManager : ManagerBase<BadgeManager>
	{
		[Token(Token = "0x2000E09")]
        [Serializable]
        [CompilerGenerated]
        private sealed class _003C_003Ec
        {
            [Token(Token = "0x40061ED")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
            public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();
            [Token(Token = "0x40061EE")]
            [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
            public static Action<int> _003C_003E9__12_0;
            [Token(Token = "0x60056A8")]
            [Address(RVA = "0x433FB94", Offset = "0x433BB94", VA = "0x433FB94")]
            public _003C_003Ec() { }
            [Token(Token = "0x60056A9")]
            [Address(RVA = "0x433FB9C", Offset = "0x433BB9C", VA = "0x433FB9C")]
            internal void _003CRegisterBadgeCountChangeAction_003Eb__12_0(int i) { }
        }

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E0A")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x40061EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40061F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40061F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BadgeManager _003C_003E4__this;

			[Token(Token = "0x60056AA")]
			[Address(RVA = "0x433FBA0", Offset = "0x433BBA0", VA = "0x433FBA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
                try
                {
                    var manager = _003C_003E4__this;
                    global::UnityEngine.Debug.Log("badgeManager.init");
                    _ = new List<string>();
                    var data = global::UnityEngine.Resources.Load<RedDotData>("RedDotData");
                    var paths = manager.CollectAllRedDotPaths(data);
                    BadgeGraphService.Initialize("root", char.Parse("/"), paths);
                    manager.onBadgeCountChangeAction = new Dictionary<string, Action<int>>();
                }
                catch (Exception exception)
                {
                    _003C_003E1__state = -2;
                    _003C_003Et__builder.SetException(exception);
                    return;
                }
                _003C_003E1__state = -2;
                _003C_003Et__builder.SetResult();
            }

			[Token(Token = "0x60056AB")]
			[Address(RVA = "0x433FF0C", Offset = "0x433BF0C", VA = "0x433FF0C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{ _003C_003Et__builder.SetStateMachine(stateMachine); }
		}

		[Token(Token = "0x40061EA")]
		private const string Root = "root";

		[Token(Token = "0x40061EB")]
		private const string LeftSlash = "/";

		[Token(Token = "0x40061EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, Action<int>> onBadgeCountChangeAction;

		[Token(Token = "0x600569B")]
		[Address(RVA = "0x433F1F0", Offset = "0x433B1F0", VA = "0x433F1F0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override UniTask Init()
		{
            var stateMachine = new _003CInit_003Ed__2();
            stateMachine._003C_003Et__builder = AsyncUniTaskMethodBuilder.Create();
            stateMachine._003C_003E4__this = this;
            stateMachine._003C_003E1__state = -1;
            stateMachine._003C_003Et__builder.Start(ref stateMachine);
            return stateMachine._003C_003Et__builder.Task;
        }

		[Token(Token = "0x600569C")]
		[Address(RVA = "0x433F274", Offset = "0x433B274", VA = "0x433F274")]
		public List<string> CollectAllRedDotPaths(RedDotData redDotData)
		{
            var paths = new List<string>();
            if (redDotData == null || redDotData.rootNode == null)
                global::UnityEngine.Debug.LogWarning("Red dot data is not loaded!");
            else
                CollectPathsRecursive(redDotData.rootNode, "root", paths);
            return paths;
        }

		[Token(Token = "0x600569D")]
		[Address(RVA = "0x433F3A8", Offset = "0x433B3A8", VA = "0x433F3A8")]
		private void CollectPathsRecursive(RedDotNode node, string currentPath, List<string> paths)
		{
            if (node == null) return;
            paths.Add(currentPath);
            var children = node.children;
            if (children == null) return;
            for (int i = 0; i < children.Length; i++)
            {
                var child = children[i];
                string path = string.Concat(currentPath, "/", child.name);
                CollectPathsRecursive(child, path, paths);
            }
        }

		[Token(Token = "0x600569E")]
		[Address(RVA = "0x433F4EC", Offset = "0x433B4EC", VA = "0x433F4EC")]
		private string GetPath(params string[] sss)
		{
            var builder = new global::System.Text.StringBuilder();
            builder.Append("root/");
            for (int i = 0; i < sss.Length; i++)
            {
                builder.Append(sss[i]);
                if (i < sss.Length - 1) builder.Append("/");
            }
            return builder.ToString();
        }

		[Token(Token = "0x600569F")]
		[Address(RVA = "0x433F5FC", Offset = "0x433B5FC", VA = "0x433F5FC")]
		public void AddBadge(string badgeName)
		{
            int number = unchecked(BadgeGraphService.GetNodeNumber(badgeName) + 1);
            BadgeGraphService.InvokeNode(badgeName, number);
            if (onBadgeCountChangeAction.TryGetValue(badgeName, out var action)) action(number);
        }

		[Token(Token = "0x60056A0")]
		[Address(RVA = "0x433DD94", Offset = "0x4339D94", VA = "0x433DD94")]
		public int GetBadgeNodeNumber(string badgeName)
		{ return BadgeGraphService.GetNodeNumber(badgeName); }

		[Token(Token = "0x60056A1")]
		[Address(RVA = "0x433F6A0", Offset = "0x433B6A0", VA = "0x433F6A0")]
		public void SubBadge(string badgeName)
		{
            int number = unchecked(BadgeGraphService.GetNodeNumber(badgeName.ToString()) - 1);
            if (number < 0) return;
            BadgeGraphService.InvokeNode(badgeName, number);
            if (onBadgeCountChangeAction.TryGetValue(badgeName, out var action)) action(number);
        }

		[Token(Token = "0x60056A2")]
		[Address(RVA = "0x433F758", Offset = "0x433B758", VA = "0x433F758")]
		private void Update()
		{
		}

		[Token(Token = "0x60056A3")]
		[Address(RVA = "0x433F75C", Offset = "0x433B75C", VA = "0x433F75C")]
		public void SetBadgeCount(string badgeName, int num)
		{
            BadgeGraphService.InvokeNode(badgeName, num);
            if (onBadgeCountChangeAction.TryGetValue(badgeName, out var action))
                action(num);
        }

		[Token(Token = "0x60056A4")]
		[Address(RVA = "0x433F7F8", Offset = "0x433B7F8", VA = "0x433F7F8")]
		public void RegisterBadgeCountChangeAction(string key, Action<int> action)
		{
            if (onBadgeCountChangeAction == null)
                onBadgeCountChangeAction = new Dictionary<string, Action<int>>();
            onBadgeCountChangeAction.TryAdd(key, _003C_003Ec._003C_003E9__12_0 ??
                (_003C_003Ec._003C_003E9__12_0 = _003C_003Ec._003C_003E9._003CRegisterBadgeCountChangeAction_003Eb__12_0));
            onBadgeCountChangeAction[key] = (Action<int>)Delegate.Combine(onBadgeCountChangeAction[key], action);
        }

		[Token(Token = "0x60056A5")]
		[Address(RVA = "0x433F9DC", Offset = "0x433B9DC", VA = "0x433F9DC")]
		public void UnRegisterBadgeCountChangeAction(string key, Action<int> action)
		{
            if (onBadgeCountChangeAction != null && onBadgeCountChangeAction.ContainsKey(key))
                onBadgeCountChangeAction[key] = (Action<int>)Delegate.Remove(onBadgeCountChangeAction[key], action);
        }

		[Token(Token = "0x60056A6")]
		[Address(RVA = "0x433FAF0", Offset = "0x433BAF0", VA = "0x433FAF0")]
		public BadgeManager()
		{
		}
	}
}
