using System.IO;
using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x200012D")]
	public interface IRuntimeSource
	{
		[Token(Token = "0x60010E7")]
		ulong CompressAtlas(TFileInfo Pid_005Dm_0088);

		[Token(Token = "0x60010E8")]
		byte[] OptimizeTexture(TFileInfo Pid_005Dm_0088);

		[Token(Token = "0x60010E9")]
		Stream ParseRuntimeString(TFileInfo Pid_005Dm_0088);

		[Token(Token = "0x60010EA")]
		uint GetStagingSize();
	}
}
