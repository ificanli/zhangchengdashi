using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000009")]
public class VRSupport
{
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x0")]
	private static Queue<Action> commands;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x787AF88", Offset = "0x7876F88", VA = "0x787AF88")]
	public VRSupport()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x787973C", Offset = "0x787573C", VA = "0x787973C")]
	public void ClearCommands()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x787ABDC", Offset = "0x7876BDC", VA = "0x787ABDC")]
	public void PeekCommand()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x787BDC0", Offset = "0x7877DC0", VA = "0x787BDC0")]
	public object isVRSupported(List<object> param)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x787BE0C", Offset = "0x7877E0C", VA = "0x787BE0C")]
	public object IsQueueEmpty(List<object> param)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x787BF84", Offset = "0x7877F84", VA = "0x787BF84")]
	public object RotateObject(List<object> param)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x787C654", Offset = "0x7878654", VA = "0x787C654")]
	public object ObjectLookAt(List<object> param)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x787CD14", Offset = "0x7878D14", VA = "0x787CD14")]
	protected void rotate(GameObject go, Quaternion originalRotation, Vector3 mousePosition, float speed)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x787D184", Offset = "0x7879184", VA = "0x787D184")]
	protected void objectLookAt(GameObject go, GameObject toLookAt, float speed)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x787D60C", Offset = "0x787960C", VA = "0x787D60C")]
	protected void recoverOffset(GameObject subcontainter, GameObject cameraContainer, float speed)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x787CF00", Offset = "0x7878F00", VA = "0x787CF00")]
	protected bool RotateObject(Quaternion originalPosition, Vector3 mousePosition, GameObject cameraContainer, float rotationSpeed = 0.125f)
	{
		return default;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x787D3A0", Offset = "0x78793A0", VA = "0x787D3A0")]
	protected bool ObjectLookAtObject(GameObject go, GameObject cameraContainer, float rotationSpeed = 0.125f)
	{
		return default;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x787D7E8", Offset = "0x78797E8", VA = "0x787D7E8")]
	protected bool ObjectRecoverOffset(GameObject subcontainer, GameObject cameraContainer, float rotationSpeed = 0.125f)
	{
		return default;
	}
}
