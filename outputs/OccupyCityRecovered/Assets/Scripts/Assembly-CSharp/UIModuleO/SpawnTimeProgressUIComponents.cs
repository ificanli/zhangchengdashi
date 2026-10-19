using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B72")]
	public class SpawnTimeProgressUIComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B73")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__44 : IAsyncStateMachine
		{
			[Token(Token = "0x4005385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpawnTimeProgressUIComponents _003C_003E4__this;

			[Token(Token = "0x4005388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600461A")]
			[Address(RVA = "0x4210E18", Offset = "0x420CE18", VA = "0x4210E18", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600461B")]
			[Address(RVA = "0x4211090", Offset = "0x420D090", VA = "0x4211090", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageSpawnTimeProgress;

		[Token(Token = "0x4005383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CanvasGroup _canvasGroupMask;

		[Token(Token = "0x4005384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImage;

		[Token(Token = "0x17000BD0")]
		public Image ImageSpawnTimeProgress
		{
			[Token(Token = "0x6004611")]
			[Address(RVA = "0x4210248", Offset = "0x420C248", VA = "0x4210248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD1")]
		public CanvasGroup CanvasGroupMask
		{
			[Token(Token = "0x6004612")]
			[Address(RVA = "0x42107BC", Offset = "0x420C7BC", VA = "0x42107BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD2")]
		public Image ImageImage
		{
			[Token(Token = "0x6004613")]
			[Address(RVA = "0x4210BE8", Offset = "0x420CBE8", VA = "0x4210BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004614")]
		[Address(RVA = "0x4210CBC", Offset = "0x420CCBC", VA = "0x4210CBC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004615")]
		[Address(RVA = "0x4210CC0", Offset = "0x420CCC0", VA = "0x4210CC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004616")]
		[Address(RVA = "0x4210CC8", Offset = "0x420CCC8", VA = "0x4210CC8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__44))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004617")]
		[Address(RVA = "0x4210D5C", Offset = "0x420CD5C", VA = "0x4210D5C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004618")]
		[Address(RVA = "0x4210894", Offset = "0x420C894", VA = "0x4210894")]
		public SpawnTimeProgressUIComponents()
		{
		}
	}
}
