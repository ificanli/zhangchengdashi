using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;

[Token(Token = "0x200008E")]
public class AudioManager : ManagerBase<AudioManager>
{
	[Token(Token = "0x200008F")]
	private struct PlayingSFXInfo
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AudioSource source;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float remainingTime;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string clipPath;

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x3D23BE8", Offset = "0x3D1FBE8", VA = "0x3D23BE8")]
		public PlayingSFXInfo(AudioSource source, float remainingTime, string clipPath)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct _003CInit_003Ed__25 : IAsyncStateMachine
	{
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UniTask<AudioClip>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x3D24D44", Offset = "0x3D20D44", VA = "0x3D24D44", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x3D25360", Offset = "0x3D21360", VA = "0x3D25360", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class _003CInitAudio_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x17000022")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x3D254A0", Offset = "0x3D214A0", VA = "0x3D254A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000023")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x3D254E0", Offset = "0x3D214E0", VA = "0x3D254E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x3D24084", Offset = "0x3D20084", VA = "0x3D24084")]
		[DebuggerHidden]
		public _003CInitAudio_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x3D2536C", Offset = "0x3D2136C", VA = "0x3D2536C", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x3D25370", Offset = "0x3D21370", VA = "0x3D25370", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x3D254A0", Offset = "0x3D214A0", VA = "0x3D254A0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x3D254A8", Offset = "0x3D214A8", VA = "0x3D254A8", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x3D254E0", Offset = "0x3D214E0", VA = "0x3D254E0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000093")]
	[CompilerGenerated]
	private struct _003CLoadClip_003Ed__27 : IAsyncStateMachine
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder<AudioClip> _003C_003Et__builder;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string path;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UniTaskCompletionSource<AudioClip> _003CcompletionSource_003E5__2;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UniTask<AudioClip>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x3D254E8", Offset = "0x3D214E8", VA = "0x3D254E8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x3D25E70", Offset = "0x3D21E70", VA = "0x3D25E70", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct _003CPlayBGM_003Ed__31 : IAsyncStateMachine
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string bgmPath;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UniTask<AudioClip>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x3D25EC8", Offset = "0x3D21EC8", VA = "0x3D25EC8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x3D2628C", Offset = "0x3D2228C", VA = "0x3D2628C", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct _003CPlaySFX_003Ed__33 : IAsyncStateMachine
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string sfxPath;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int priority;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target3D;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UniTask<AudioClip>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x3D26298", Offset = "0x3D22298", VA = "0x3D26298", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x3D26C1C", Offset = "0x3D22C1C", VA = "0x3D26C1C", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct _003CPlaySFXFromQueue_003Ed__34 : IAsyncStateMachine
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string sfxPath;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform target3D;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitch;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int priority;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UniTask<AudioClip>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x3D26C28", Offset = "0x3D22C28", VA = "0x3D26C28", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x3D26FE0", Offset = "0x3D22FE0", VA = "0x3D26FE0", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource _bgmSource;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<string, AudioSource> _sfxSourceDict;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<AudioSource> allAudioSource;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int maxAudioSouceNumber;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool _isBgmEnabled;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool _isSfxEnabled;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action<bool> _onBgmEnableChanged;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Action<bool> _onSfxEnableChanged;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Dictionary<string, AudioClip> _clipsCatch;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Dictionary<string, UniTaskCompletionSource<AudioClip>> _loadingClips;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<PlayingSFXInfo> _playingSFXList;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool initcomplete;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Dictionary<string, float> _sfxLastPlayTime;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<string, int> _sfxPlayingCount;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int _framePlayCount;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int _lastFrameCount;

	[Token(Token = "0x40002BB")]
	private const int MAX_PLAYS_PER_FRAME = 6;

	[Token(Token = "0x40002BC")]
	private const int MAX_SAME_SFX_CONCURRENT = 2;

	[Token(Token = "0x40002BD")]
	private const float MIN_SFX_INTERVAL = 0.08f;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Queue<(string path, Transform target3D, float pitch, int priority)> _pendingSFXQueue;

	[Token(Token = "0x17000020")]
	public bool IsBgmEnabled
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x3D23704", Offset = "0x3D1F704", VA = "0x3D23704")]
		get
		{
			return _isBgmEnabled;
		}
	}

	[Token(Token = "0x17000021")]
	public bool IsSfxEnabled
	{
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x3D2370C", Offset = "0x3D1F70C", VA = "0x3D2370C")]
		get
		{
			return _isSfxEnabled;
		}
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x3D23714", Offset = "0x3D1F714", VA = "0x3D23714", Slot = "4")]
	[AsyncStateMachine(typeof(_003CInit_003Ed__25))]
	public override UniTask Init()
	{
		return default;
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x3D237A4", Offset = "0x3D1F7A4", VA = "0x3D237A4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x3D23BF8", Offset = "0x3D1FBF8", VA = "0x3D23BF8")]
	[AsyncStateMachine(typeof(_003CLoadClip_003Ed__27))]
	private UniTask<AudioClip> LoadClip(string path)
	{
		return default;
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x3D23CD4", Offset = "0x3D1FCD4", VA = "0x3D23CD4")]
	private AudioSource GetSFXSourceByPath(string path)
	{
		return null;
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x3D23E6C", Offset = "0x3D1FE6C", VA = "0x3D23E6C")]
	private AudioSource GetSFXSource()
	{
		return null;
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x3D24024", Offset = "0x3D20024", VA = "0x3D24024")]
	[IteratorStateMachine(typeof(_003CInitAudio_003Ed__30))]
	public IEnumerator InitAudio()
	{
		return null;
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x3D240AC", Offset = "0x3D200AC", VA = "0x3D240AC")]
	[AsyncStateMachine(typeof(_003CPlayBGM_003Ed__31))]
	public void PlayBGM(string bgmPath)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x3D24148", Offset = "0x3D20148", VA = "0x3D24148")]
	public void StopBGM()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x3D24168", Offset = "0x3D20168", VA = "0x3D24168")]
	[AsyncStateMachine(typeof(_003CPlaySFX_003Ed__33))]
	public void PlaySFX(string sfxPath, [Optional] Transform target3D, float pitch = 1f, int priority = 0)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x3D23B24", Offset = "0x3D1FB24", VA = "0x3D23B24")]
	[AsyncStateMachine(typeof(_003CPlaySFXFromQueue_003Ed__34))]
	private void PlaySFXFromQueue(string sfxPath, Transform target3D, float pitch, int priority)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x3D24230", Offset = "0x3D20230", VA = "0x3D24230")]
	private void PlaySFXInternal(string sfxPath, Transform target3D, float pitch, AudioClip clip, int priority = 0)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x3D245A8", Offset = "0x3D205A8", VA = "0x3D245A8")]
	public void SwitchBgmEnable()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x3D24684", Offset = "0x3D20684", VA = "0x3D24684")]
	public void SwitchSfxEnable()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x3D2473C", Offset = "0x3D2073C", VA = "0x3D2473C")]
	private AudioClip GetFromCatch(string clipPath)
	{
		return null;
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x3D247B4", Offset = "0x3D207B4", VA = "0x3D247B4")]
	public void RegisterOnBgmSwitch(Action<bool> onBgmEnableChanged)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x3D24878", Offset = "0x3D20878", VA = "0x3D24878")]
	public void RegisterOnSfxSwitch(Action<bool> onSfxEnableChanged)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x3D2493C", Offset = "0x3D2093C", VA = "0x3D2493C")]
	public AudioManager()
	{
	}
}
