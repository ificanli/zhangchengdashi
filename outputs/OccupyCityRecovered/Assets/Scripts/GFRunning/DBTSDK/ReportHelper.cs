using System.Text;
using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001D0")]
	public class ReportHelper
	{
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x0")]
		private static StringBuilder stringBuilder;

		[Token(Token = "0x600179E")]
		public static string ToNewReportJsonProperties<T>(T obj) where T : NewReportJsonProperties
		{
			return null;
		}

		[Token(Token = "0x600179F")]
		[Address(RVA = "0x7394D04", Offset = "0x7390D04", VA = "0x7394D04")]
		public ReportHelper()
		{
		}
	}
}
