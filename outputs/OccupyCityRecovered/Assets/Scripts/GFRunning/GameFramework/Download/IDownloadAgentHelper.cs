using System;
using Il2CppDummyDll;

namespace GameFramework.Download
{
	[Token(Token = "0x200049B")]
	public interface IDownloadAgentHelper
	{
		[Token(Token = "0x14000021")]
		event EventHandler<DownloadAgentHelperUpdateBytesEventArgs> DownloadAgentHelperUpdateBytes;

		[Token(Token = "0x14000022")]
		event EventHandler<DownloadAgentHelperUpdateLengthEventArgs> DownloadAgentHelperUpdateLength;

		[Token(Token = "0x14000023")]
		event EventHandler<DownloadAgentHelperCompleteEventArgs> DownloadAgentHelperComplete;

		[Token(Token = "0x14000024")]
		event EventHandler<DownloadAgentHelperErrorEventArgs> DownloadAgentHelperError;

		[Token(Token = "0x6006D64")]
		void Download(string _0060_00A6zºZ_00B4, object _00B4sT_00ABV_007E);

		[Token(Token = "0x6006D65")]
		void Download(string _0060_00A6zºZ_00B4, int _0095Ad_00BCVO, object _00B4sT_00ABV_007E);

		[Token(Token = "0x6006D66")]
		void Download(string _0060_00A6zºZ_00B4, int _0095Ad_00BCVO, int zÀ_0084L_00A8_0089, object _00B4sT_00ABV_007E);

		[Token(Token = "0x6006D67")]
		void Reset();

		[Token(Token = "0x6006D68")]
		void Shutdown();
	}
}
