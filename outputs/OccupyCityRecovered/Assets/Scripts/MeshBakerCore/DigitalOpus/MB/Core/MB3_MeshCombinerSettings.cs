using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000053")]
	[CreateAssetMenu(fileName = "MeshBakerSettings", menuName = "Mesh Baker/Mesh Baker Settings")]
	public class MB3_MeshCombinerSettings : ScriptableObject, MB_IMeshBakerSettingsHolder
	{
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x18")]
		public MB3_MeshCombinerSettingsData data;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x744F1E8", Offset = "0x744B1E8", VA = "0x744F1E8", Slot = "4")]
		public MB_IMeshBakerSettings GetMeshBakerSettings()
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x744F1F0", Offset = "0x744B1F0", VA = "0x744F1F0", Slot = "5")]
		public void GetMeshBakerSettingsAsSerializedProperty(out string propertyName, out Object targetObj)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_MeshCombinerSettings.GetMeshBakerSettingsAsSerializedProperty RVA=0x744F1F0 Token=0x600022B");
}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x744F24C", Offset = "0x744B24C", VA = "0x744F24C")]
		public MB3_MeshCombinerSettings()
		{
		}
	}
}
