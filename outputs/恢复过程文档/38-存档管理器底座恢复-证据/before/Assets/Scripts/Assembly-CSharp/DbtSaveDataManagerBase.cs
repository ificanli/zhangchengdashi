using System.Runtime.CompilerServices;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x2000073")]
[Skip]
public class DbtSaveDataManagerBase<T, TD> : DataManagerBase where T : DbtSaveDataManagerBase<T, TD> where TD : ServerBaseData, new()
{
	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x0")]
	public static T I;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x0")]
	private string _name;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x0")]
	private string _lastSaveData;

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x0")]
	public bool CanSave;

	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x0")]
	private bool _cleared;

	[Token(Token = "0x1700001F")]
	public TD Data
	{
		[Token(Token = "0x6000265")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000266")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000267")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x6000268")]
	public string ReLoadLocalData()
	{
		return null;
	}

	[Token(Token = "0x6000269")]
	protected override void UpdateDataCallBack(string str)
	{
	}

	[Token(Token = "0x600026A")]
	public override void OnSave()
	{
	}

	[Token(Token = "0x600026B")]
	public override void OnRelease()
	{
	}

	[Token(Token = "0x600026C")]
	public void Load()
	{
	}

	[Token(Token = "0x600026D")]
	public TD GetData(string str)
	{
		return null;
	}

	[Token(Token = "0x600026E")]
	public void LoadFormMemory(TD data)
	{
	}

	[Token(Token = "0x600026F")]
	public void Save()
	{
	}

	[Token(Token = "0x6000270")]
	public void LogVersion()
	{
	}

	[Token(Token = "0x6000271")]
	protected virtual void OnBeforeSerializeForSave()
	{
	}

	[Token(Token = "0x6000272")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000273")]
	private void Log(int type, string msg)
	{
	}

	[Token(Token = "0x6000274")]
	public DbtSaveDataManagerBase()
	{
	}
}
