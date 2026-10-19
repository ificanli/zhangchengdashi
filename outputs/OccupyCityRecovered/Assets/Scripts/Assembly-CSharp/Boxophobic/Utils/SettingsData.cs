using Boxophobic.StyledGUI;
using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.Utils
{
	[Token(Token = "0x2000E00")]
	[CreateAssetMenu(fileName = "Data", menuName = "BOXOPHOBIC/Settings Data")]
	public class SettingsData : StyledScriptableObject
	{
		[Token(Token = "0x40061D1")]
		[FieldOffset(Offset = "0x18")]
		[StyledBanner(0.65f, 0.65f, 0.65f, "Settings Data")]
		public bool styledBanner;

		[Token(Token = "0x40061D2")]
		[FieldOffset(Offset = "0x20")]
		[Space]
		public string data;

		[Token(Token = "0x6005677")]
		[Address(RVA = "0x433D400", Offset = "0x4339400", VA = "0x433D400")]
		public SettingsData()
		{
		}
	}
}
