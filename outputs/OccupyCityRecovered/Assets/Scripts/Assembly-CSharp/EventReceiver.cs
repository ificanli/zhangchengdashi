using AnimationInstancing;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000028")]
public class EventReceiver : MonoBehaviour
{
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x0")]
	private static string log;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x3D03948", Offset = "0x3CFF948", VA = "0x3D03948")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x3D0394C", Offset = "0x3CFF94C", VA = "0x3D0394C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x3D03950", Offset = "0x3CFF950", VA = "0x3D03950")]
	public void NewEvent(AnimationInstancing.AnimationEvent evt)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x3D03954", Offset = "0x3CFF954", VA = "0x3D03954")]
	public EventReceiver()
	{
	}
}
