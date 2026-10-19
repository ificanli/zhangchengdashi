using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x2000011")]
	public class GameFrameworkLoad : MonoBehaviour
	{
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x0")]
		private static bool IsFirstEnterLoadScene;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x20")]
		private bool InitializeNextGameFrameModule;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x28")]
		private Queue<GameFrameModule> queue;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x30")]
		private bool IsStartInitialize;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x7068AC4", Offset = "0x7064AC4", VA = "0x7068AC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x7068B40", Offset = "0x7064B40", VA = "0x7068B40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x7068F3C", Offset = "0x7064F3C", VA = "0x7068F3C")]
		private void StartU3DGame()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x7069264", Offset = "0x7065264", VA = "0x7069264")]
		private void OneGameFrameModuleInitializeOver()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x7069270", Offset = "0x7065270", VA = "0x7069270")]
		private void GameFrameInitOver()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x70694A4", Offset = "0x70654A4", VA = "0x70694A4")]
		private void Update()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x7069340", Offset = "0x7065340", VA = "0x7069340")]
		private void StartMineGame()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x7069688", Offset = "0x7065688", VA = "0x7069688")]
		public GameFrameworkLoad()
		{
		}
	}
}
