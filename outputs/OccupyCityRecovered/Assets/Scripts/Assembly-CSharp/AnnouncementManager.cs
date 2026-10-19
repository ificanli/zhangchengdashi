using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;

[Token(Token = "0x2000050")]
public class AnnouncementManager : ManagerBase<AnnouncementManager>
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct _003CInit_003Ed__8 : IAsyncStateMachine
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnnouncementManager _003C_003E4__this;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UniTask.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x3D0C53C", Offset = "0x3D0853C", VA = "0x3D0C53C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x3D0CDD4", Offset = "0x3D08DD4", VA = "0x3D0CDD4", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct _003CShowAnnouncement_003Ed__10 : IAsyncStateMachine
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool force;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UniTask.Awaiter _003C_003Eu__1;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x3D0CDE0", Offset = "0x3D08DE0", VA = "0x3D0CDE0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x3D0D3A4", Offset = "0x3D093A4", VA = "0x3D0D3A4", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000183")]
	public const string AnnouncementTag = "Announcement";

	[Token(Token = "0x4000184")]
	public const string WatchedAnnouncementIDs = "WatchedAnnouncementIDs";

	[Token(Token = "0x4000185")]
	public const string ClaimedAnnouncementIDs = "ClaimedAnnouncementIDs";

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly List<string> _watchedAnnouncementIDs;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly List<string> _claimedAnnouncementIDs;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _isListeningOnGameOver;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x3D0C0A4", Offset = "0x3D080A4", VA = "0x3D0C0A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x3D0C0A8", Offset = "0x3D080A8", VA = "0x3D0C0A8")]
	private void StopListenOnGameOver()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x3D0C180", Offset = "0x3D08180", VA = "0x3D0C180", Slot = "4")]
	[AsyncStateMachine(typeof(_003CInit_003Ed__8))]
	public override UniTask Init()
	{
		return default;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x3D0C20C", Offset = "0x3D0820C", VA = "0x3D0C20C")]
	private void OnGameOver(object args)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x3D0C2A0", Offset = "0x3D082A0", VA = "0x3D0C2A0")]
	[AsyncStateMachine(typeof(_003CShowAnnouncement_003Ed__10))]
	public void ShowAnnouncement(bool force = false)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x3D0C330", Offset = "0x3D08330", VA = "0x3D0C330")]
	public AnnouncementManager()
	{
	}
}
