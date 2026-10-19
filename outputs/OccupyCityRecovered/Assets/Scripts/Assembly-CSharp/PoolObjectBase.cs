using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000024")]
public class PoolObjectBase : MonoBehaviour
{
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x20")]
	private int _PoolID;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x24")]
	private bool _PoolState;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x28")]
	private float delayTime;

	[Token(Token = "0x1700000A")]
	public float DelayTime
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x3D03410", Offset = "0x3CFF410", VA = "0x3D03410")]
		get
		{
			return delayTime;
		}
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x3D03418", Offset = "0x3CFF418", VA = "0x3D03418")]
		set
		{
			delayTime = value;
		}
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x3D03420", Offset = "0x3CFF420", VA = "0x3D03420")]
	public bool GetPoolState()
	{
		return default;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x3D03428", Offset = "0x3CFF428", VA = "0x3D03428")]
	public void SwitchPoolState(bool state)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x3D03434", Offset = "0x3CFF434", VA = "0x3D03434")]
	public int GetPoolID()
	{
		return default;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x3D0343C", Offset = "0x3CFF43C", VA = "0x3D0343C")]
	public void SetPoolID(int id)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x3D03444", Offset = "0x3CFF444", VA = "0x3D03444", Slot = "4")]
	public virtual void DestroyObject()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x3D034F4", Offset = "0x3CFF4F4", VA = "0x3D034F4", Slot = "5")]
	public virtual void OnGet()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x3D034F8", Offset = "0x3CFF4F8", VA = "0x3D034F8", Slot = "6")]
	public virtual void Release()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x3D034FC", Offset = "0x3CFF4FC", VA = "0x3D034FC", Slot = "7")]
	public virtual void Release(float f)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x3D03408", Offset = "0x3CFF408", VA = "0x3D03408")]
	public PoolObjectBase()
	{
	}
}
