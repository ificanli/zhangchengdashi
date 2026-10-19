using System;
namespace GameFramework { public static class Utility { public static class Text {
public static string GetFullName<T>(string _00AE_008C_009AiPJ)
			{
				return GetFullName(typeof(T), _00AE_008C_009AiPJ);
			}
public static string GetFullName(Type _007BgpR_00A0V, string _00AE_008C_009AiPJ)
			{
				string fullName = _007BgpR_00A0V.FullName;
				if (string.IsNullOrEmpty(_00AE_008C_009AiPJ))
					return fullName;
				return string.Format("{0}.{1}", fullName, _00AE_008C_009AiPJ);
			}
}}}