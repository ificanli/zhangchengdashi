using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000013")]
public class DBTSDKButtonBinder : MonoBehaviour
{
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x20")]
	public SDKBTNTYPE m_type;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x3D010A8", Offset = "0x3CFD0A8", VA = "0x3D010A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x3D0162C", Offset = "0x3CFD62C", VA = "0x3D0162C")]
	public DBTSDKButtonBinder()
	{
	}
}
