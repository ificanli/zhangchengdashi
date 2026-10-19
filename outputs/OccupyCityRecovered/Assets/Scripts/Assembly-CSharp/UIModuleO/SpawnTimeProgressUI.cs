using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B70")]
	public class SpawnTimeProgressUI : SpawnTimeProgressUIComponents, IHUDElement
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B71")]
		[CompilerGenerated]
		private struct _003CImgDoShowAni_003Ed__25 : IAsyncStateMachine
		{
			[Token(Token = "0x400537C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400537D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400537E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string id;

			[Token(Token = "0x400537F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SpawnTimeProgressUI _003C_003E4__this;

			[Token(Token = "0x4005380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap1;

			[Token(Token = "0x4005381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600460F")]
			[Address(RVA = "0x421089C", Offset = "0x420C89C", VA = "0x421089C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004610")]
			[Address(RVA = "0x4210CB0", Offset = "0x420CCB0", VA = "0x4210CB0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("txtMax")]
		public GameObject txtMaxObj;

		[Token(Token = "0x4005378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _originalYOffset;

		[Token(Token = "0x4005379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _targetFillAmount;

		[Token(Token = "0x400537A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _smoothSpeed;

		[Token(Token = "0x400537B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _progressImage;

		[Token(Token = "0x17000BCC")]
		public Transform Target
		{
			[Token(Token = "0x6004600")]
			[Address(RVA = "0x42100D4", Offset = "0x420C0D4", VA = "0x42100D4", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004601")]
			[Address(RVA = "0x42100DC", Offset = "0x420C0DC", VA = "0x42100DC", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000BCD")]
		public float YOffset
		{
			[Token(Token = "0x6004602")]
			[Address(RVA = "0x42100E4", Offset = "0x420C0E4", VA = "0x42100E4", Slot = "14")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x6004603")]
			[Address(RVA = "0x42100EC", Offset = "0x420C0EC", VA = "0x42100EC", Slot = "15")]
			[CompilerGenerated]
			set;
		}

		[Token(Token = "0x17000BCE")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6004604")]
			[Address(RVA = "0x42100F4", Offset = "0x420C0F4", VA = "0x42100F4", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004605")]
			[Address(RVA = "0x42100FC", Offset = "0x420C0FC", VA = "0x42100FC", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000BCF")]
		public RectTransform CanvasRectTransform
		{
			[Token(Token = "0x6004606")]
			[Address(RVA = "0x4210104", Offset = "0x420C104", VA = "0x4210104", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004607")]
			[Address(RVA = "0x421010C", Offset = "0x420C10C", VA = "0x421010C", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6004608")]
		[Address(RVA = "0x4210114", Offset = "0x420C114", VA = "0x4210114", Slot = "20")]
		public void Init(Transform target, float yOffset)
		{
		}

		[Token(Token = "0x6004609")]
		[Address(RVA = "0x4210310", Offset = "0x420C310", VA = "0x4210310", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x600460A")]
		[Address(RVA = "0x42105C8", Offset = "0x420C5C8", VA = "0x42105C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600460B")]
		[Address(RVA = "0x42106E0", Offset = "0x420C6E0", VA = "0x42106E0")]
		public void SetMaxActive(bool isShow)
		{
		}

		[Token(Token = "0x600460C")]
		[Address(RVA = "0x4210700", Offset = "0x420C700", VA = "0x4210700")]
		[AsyncStateMachine(typeof(_003CImgDoShowAni_003Ed__25))]
		public void ImgDoShowAni(string id)
		{
		}

		[Token(Token = "0x600460D")]
		[Address(RVA = "0x42107A0", Offset = "0x420C7A0", VA = "0x42107A0")]
		public void ImgDoHideAni()
		{
		}

		[Token(Token = "0x600460E")]
		[Address(RVA = "0x4210884", Offset = "0x420C884", VA = "0x4210884")]
		public SpawnTimeProgressUI()
		{
		}
	}
}
