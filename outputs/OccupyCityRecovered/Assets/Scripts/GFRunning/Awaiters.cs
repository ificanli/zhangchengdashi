using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000005")]
public static class Awaiters
{
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x0")]
	private static readonly WaitForUpdate Dbp_00A5am;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x8")]
	private static readonly WaitForFixedUpdate _007B_0095_00A1z_008Ci;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x10")]
	private static readonly WaitForEndOfFrame Â_00A7_00B9_008E_00A4_00BF;

	[Token(Token = "0x17000001")]
	public static WaitForUpdate NextFrame
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x706D020", Offset = "0x7069020", VA = "0x706D020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public static WaitForFixedUpdate FixedUpdate
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x706D078", Offset = "0x7069078", VA = "0x706D078")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public static WaitForEndOfFrame EndOfFrame
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x706D0D0", Offset = "0x70690D0", VA = "0x706D0D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x706D128", Offset = "0x7069128", VA = "0x706D128")]
	public static WaitForSeconds Seconds(float _00ACrg_00BFgZ)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x706D18C", Offset = "0x706918C", VA = "0x706D18C")]
	public static WaitForSecondsRealtime SecondsRealtime(float _00ACrg_00BFgZ)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x706D1F0", Offset = "0x70691F0", VA = "0x706D1F0")]
	public static WaitUntil Until(Func<bool> o_005Ebj_00BC_00BD)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x706D24C", Offset = "0x706924C", VA = "0x706D24C")]
	public static WaitWhile While(Func<bool> o_005Ebj_00BC_00BD)
	{
		return null;
	}
}
