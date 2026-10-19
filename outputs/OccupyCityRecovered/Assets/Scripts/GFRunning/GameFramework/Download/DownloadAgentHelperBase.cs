using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.Download
{
	[Token(Token = "0x200049A")]
	public abstract class DownloadAgentHelperBase : MonoBehaviour, IDownloadAgentHelper
	{
		[Token(Token = "0x4001EFA")]
		protected const int RangeNotSatisfiableErrorCode = 416;

		[Token(Token = "0x1400001D")]
		public abstract event EventHandler<DownloadAgentHelperUpdateBytesEventArgs> DownloadAgentHelperUpdateBytes;

		[Token(Token = "0x1400001E")]
		public abstract event EventHandler<DownloadAgentHelperUpdateLengthEventArgs> DownloadAgentHelperUpdateLength;

		[Token(Token = "0x1400001F")]
		public abstract event EventHandler<DownloadAgentHelperCompleteEventArgs> DownloadAgentHelperComplete;

		[Token(Token = "0x14000020")]
		public abstract event EventHandler<DownloadAgentHelperErrorEventArgs> DownloadAgentHelperError;

		[Token(Token = "0x6006D4D")]
		[Address(RVA = "0x729B000", Offset = "0x7297000", VA = "0x729B000")]
		private void Awake()
		{
		}

		[Token(Token = "0x6006D56")]
		public abstract void Download(string _0060_00A6zºZ_00B4, object _00B4sT_00ABV_007E);

		[Token(Token = "0x6006D57")]
		public abstract void Download(string _0060_00A6zºZ_00B4, int _0095Ad_00BCVO, object _00B4sT_00ABV_007E);

		[Token(Token = "0x6006D58")]
		public abstract void Download(string _0060_00A6zºZ_00B4, int _0095Ad_00BCVO, int zÀ_0084L_00A8_0089, object _00B4sT_00ABV_007E);

		[Token(Token = "0x6006D59")]
		public abstract void Reset();

		[Token(Token = "0x6006D5A")]
		public abstract void Shutdown();

		[Token(Token = "0x6006D5B")]
		[Address(RVA = "0x729B058", Offset = "0x7297058", VA = "0x729B058")]
		protected DownloadAgentHelperBase()
		{
		}
	}
}
