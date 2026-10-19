using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000263")]
	public class CatapultsBulletBehaviour : BulletBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000265")]
		[CompilerGenerated]
		private struct _003CInitInfo_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4001F02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001F03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001F04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CatapultsBulletBehaviour _003C_003E4__this;

			[Token(Token = "0x4001F05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isEnemy;

			[Token(Token = "0x4001F06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool isLand;

			[Token(Token = "0x4001F07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public EntityBase obj;

			[Token(Token = "0x4001F08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int atk;

			[Token(Token = "0x4001F09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool isEffBullet;

			[Token(Token = "0x4001F0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public EntityBase fireObj;

			[Token(Token = "0x4001F0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CardFettersType fettersType;

			[Token(Token = "0x4001F0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x4385AC4", Offset = "0x4381AC4", VA = "0x4385AC4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x438623C", Offset = "0x438223C", VA = "0x438623C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 catapultsPos;

		[Token(Token = "0x4001EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float exploseRange;

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x4385668", Offset = "0x4381668", VA = "0x4385668", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInitInfo_003Ed__2))]
		public override void InitInfo(EntityBase obj, int atk, bool isEnemy, bool isEffBullet, [Optional] EntityBase fireObj, bool isLand = true, CardFettersType fettersType = CardFettersType.Null)
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x4385760", Offset = "0x4381760", VA = "0x4385760")]
		public void InitExploseRange(float num)
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x4385768", Offset = "0x4381768", VA = "0x4385768", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x438576C", Offset = "0x438176C", VA = "0x438576C", Slot = "9")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x4385770", Offset = "0x4381770", VA = "0x4385770")]
		public void InitCatapultsPos(Vector3 pos)
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x438577C", Offset = "0x438177C", VA = "0x438577C", Slot = "10")]
		protected override void Clear()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x4385804", Offset = "0x4381804", VA = "0x4385804")]
		public CatapultsBulletBehaviour()
		{
		}
	}
}
