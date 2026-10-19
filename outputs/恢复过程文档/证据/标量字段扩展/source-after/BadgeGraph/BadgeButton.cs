using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace BadgeGraph
{
	[Token(Token = "0x2000E01")]
	public class BadgeButton : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E02")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40061DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40061DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40061DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BadgeButton _003C_003E4__this;

			[Token(Token = "0x40061DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6005685")]
			[Address(RVA = "0x433DDD0", Offset = "0x4339DD0", VA = "0x433DDD0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005686")]
			[Address(RVA = "0x433E228", Offset = "0x433A228", VA = "0x433E228", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40061D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Main")]
		[SerializeField]
		private string m_BadgeName;

		[Token(Token = "0x40061D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_InvokeEnable;

		[Token(Token = "0x40061D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Badge Point")]
		[SerializeField]
		private GameObject m_PointObj;

		[Token(Token = "0x40061D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool currentPointObjActive;

		[Token(Token = "0x40061D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool autoSetBadge;

		[Token(Token = "0x40061D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string lastCallBackName;

		[Token(Token = "0x17000EA8")]
		public string BadgeName
		{
			[Token(Token = "0x6005678")]
			[Address(RVA = "0x433D450", Offset = "0x4339450", VA = "0x433D450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005679")]
			[Address(RVA = "0x433D458", Offset = "0x4339458", VA = "0x433D458")]
			set
			{
			}
		}

		[Token(Token = "0x17000EA9")]
		public bool hadSetBadge
		{
			[Token(Token = "0x600567B")]
			[Address(RVA = "0x433D46C", Offset = "0x433946C", VA = "0x433D46C")]
			[CompilerGenerated]
			get;
			[Token(Token = "0x600567A")]
			[Address(RVA = "0x433D460", Offset = "0x4339460", VA = "0x433D460")]
			[CompilerGenerated]
			private set;
		}

		[Token(Token = "0x600567C")]
		[Address(RVA = "0x433D474", Offset = "0x4339474", VA = "0x433D474")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__13))]
		private void Awake()
		{
		}

		[Token(Token = "0x600567D")]
		[Address(RVA = "0x433D504", Offset = "0x4339504", VA = "0x433D504")]
		public void SetBadge()
		{
		}

		[Token(Token = "0x600567E")]
		[Address(RVA = "0x433DC9C", Offset = "0x4339C9C", VA = "0x433DC9C")]
		public void UpdateBadgeName(string newName)
		{
		}

		[Token(Token = "0x600567F")]
		[Address(RVA = "0x433DD8C", Offset = "0x4339D8C", VA = "0x433DD8C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6005680")]
		[Address(RVA = "0x433DB08", Offset = "0x4339B08", VA = "0x433DB08")]
		private void UpdatePointObjAction(bool active)
		{
		}

		[Token(Token = "0x6005681")]
		[Address(RVA = "0x433DD9C", Offset = "0x4339D9C", VA = "0x433DD9C")]
		private void OnBadgePointChanged(BadgeNode node)
		{
		}

		[Token(Token = "0x6005682")]
		[Address(RVA = "0x433DDBC", Offset = "0x4339DBC", VA = "0x433DDBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6005683")]
		[Address(RVA = "0x433DCC4", Offset = "0x4339CC4", VA = "0x433DCC4")]
		private void CleanCallback()
		{
		}

		[Token(Token = "0x6005684")]
		[Address(RVA = "0x433DDC0", Offset = "0x4339DC0", VA = "0x433DDC0")]
		public BadgeButton()
		{
		}
	}
}
