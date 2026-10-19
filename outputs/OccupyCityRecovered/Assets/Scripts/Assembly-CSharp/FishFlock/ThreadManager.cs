using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FishFlock
{
	[Token(Token = "0x2000DDE")]
	public class ThreadManager : MonoBehaviour
	{
		[Token(Token = "0x400614D")]
		[FieldOffset(Offset = "0x0")]
		private static GameObject instance;

		[Token(Token = "0x400614E")]
		[FieldOffset(Offset = "0x8")]
		private static ThreadManager singleton;

		[Token(Token = "0x400614F")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<ThreadProcess> processes;

		[Token(Token = "0x6005605")]
		[Address(RVA = "0x4339C84", Offset = "0x4335C84", VA = "0x4339C84")]
		private static void SetupSingleton()
		{
		}

		[Token(Token = "0x6005606")]
		[Address(RVA = "0x4339DF8", Offset = "0x4335DF8", VA = "0x4339DF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6005607")]
		[Address(RVA = "0x4339E9C", Offset = "0x4335E9C", VA = "0x4339E9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005608")]
		[Address(RVA = "0x4339FE0", Offset = "0x4335FE0", VA = "0x4339FE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6005609")]
		[Address(RVA = "0x433A220", Offset = "0x4336220", VA = "0x433A220")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600560A")]
		[Address(RVA = "0x433A224", Offset = "0x4336224", VA = "0x433A224")]
		private void OnSceneIsUnloaded(Scene arg0)
		{
		}

		[Token(Token = "0x600560B")]
		[Address(RVA = "0x4339FE4", Offset = "0x4335FE4", VA = "0x4339FE4")]
		private void Reset()
		{
		}

		[Token(Token = "0x600560C")]
		[Address(RVA = "0x43374E4", Offset = "0x43334E4", VA = "0x43374E4")]
		public static ThreadProcess DoTask(Action callback)
		{
			return null;
		}

		[Token(Token = "0x600560D")]
		[Address(RVA = "0x433957C", Offset = "0x433557C", VA = "0x433957C")]
		public static void EndTask(ThreadProcess process)
		{
		}

		[Token(Token = "0x600560E")]
		[Address(RVA = "0x433A308", Offset = "0x4336308", VA = "0x433A308")]
		public ThreadManager()
		{
		}
	}
}
