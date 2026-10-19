using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000002")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	public class ComHelper
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x7838548", Offset = "0x7834548", VA = "0x7838548")]
		public ComHelper()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x7838550", Offset = "0x7834550", VA = "0x7838550")]
		public bool IsZipFile(string filename)
		{
			return default;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x78385A8", Offset = "0x78345A8", VA = "0x78385A8")]
		public bool IsZipFileWithExtract(string filename)
		{
			return default;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x7838604", Offset = "0x7834604", VA = "0x7838604")]
		public bool CheckZip(string filename)
		{
			return default;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x783865C", Offset = "0x783465C", VA = "0x783865C")]
		public bool CheckZipPassword(string filename, string password)
		{
			return default;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x78386C4", Offset = "0x78346C4", VA = "0x78386C4")]
		public void FixZipDirectory(string filename)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x783871C", Offset = "0x783471C", VA = "0x783871C")]
		public string GetZipLibraryVersion()
		{
			return null;
		}
	}
}
