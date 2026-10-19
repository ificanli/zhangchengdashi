using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000C6")]
	public interface MB_IMeshBakerSettingsHolder
	{
		[Token(Token = "0x60003E9")]
		MB_IMeshBakerSettings GetMeshBakerSettings();

		[Token(Token = "0x60003EA")]
		void GetMeshBakerSettingsAsSerializedProperty(out string propertyName, out Object targetObj);
	}
}
