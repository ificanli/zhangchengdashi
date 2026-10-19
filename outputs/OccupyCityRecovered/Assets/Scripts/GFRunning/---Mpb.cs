using Il2CppDummyDll;
using UnityEngine.Networking;

[Token(Token = "0x20000C1")]
internal abstract class _00A3_00BD_00B8Mpb
{
	[Token(Token = "0x20000C2")]
	public enum EStatus
	{
		[Token(Token = "0x400029A")]
		None = 0,
		[Token(Token = "0x400029B")]
		Succeed = 1,
		[Token(Token = "0x400029C")]
		Failed = 2
	}

	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x10")]
	protected readonly _007DYXCc_008B _bundleInfo;

	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x18")]
	protected readonly int _timeout;

	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x1C")]
	protected int _failedTryAgain;

	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x20")]
	protected UnityWebRequest _webRequest;

	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x28")]
	protected EStatus _status;

	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x30")]
	protected string _lastError;

	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x38")]
	protected long _lastCode;

	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x40")]
	protected int _requestCount;

	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x48")]
	protected string _requestURL;

	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x50")]
	protected float _downloadProgress;

	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x58")]
	protected ulong _downloadedBytes;

	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x60")]
	protected bool _isAbort;

	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x68")]
	protected ulong _latestDownloadBytes;

	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x70")]
	protected float _latestDownloadRealtime;

	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x74")]
	protected float _tryAgainTimer;

	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x78")]
	public bool WaitForAsyncComplete;

	[Token(Token = "0x17000082")]
	public long LastCode
	{
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x73115DC", Offset = "0x730D5DC", VA = "0x73115DC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000083")]
	public float DownloadProgress
	{
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x73115E4", Offset = "0x730D5E4", VA = "0x73115E4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000084")]
	public ulong DownloadedBytes
	{
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x73115EC", Offset = "0x730D5EC", VA = "0x73115EC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000A41")]
	[Address(RVA = "0x7311558", Offset = "0x730D558", VA = "0x7311558")]
	public _00A3_00BD_00B8Mpb(_007DYXCc_008B c_008F_00AF_00B4_00B9_007E, int _00BD_00B2F_00AF_00B8t, int _00AFF_00BD_0083_0087X)
	{
	}

	[Token(Token = "0x6000A42")]
	public abstract void SendRequest(params object[] W_00AF_0091_0094ii);

	[Token(Token = "0x6000A43")]
	public abstract void Update();

	[Token(Token = "0x6000A44")]
	public abstract void Abort();

	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x73115F4", Offset = "0x730D5F4", VA = "0x73115F4")]
	public long GetDownloadFileSize()
	{
		return default;
	}

	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x7311618", Offset = "0x730D618", VA = "0x7311618")]
	public string GetDownloadBundleName()
	{
		return null;
	}

	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x731163C", Offset = "0x730D63C", VA = "0x731163C")]
	public bool IsDone()
	{
		return default;
	}

	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x7311650", Offset = "0x730D650", VA = "0x7311650")]
	public bool HasError()
	{
		return default;
	}

	[Token(Token = "0x6000A49")]
	[Address(RVA = "0x7311660", Offset = "0x730D660", VA = "0x7311660")]
	public void ReportError()
	{
	}

	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x7311820", Offset = "0x730D820", VA = "0x7311820")]
	public void ReportWarning()
	{
	}

	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x7311688", Offset = "0x730D688", VA = "0x7311688")]
	public string GetLastError()
	{
		return null;
	}

	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x7311834", Offset = "0x730D834", VA = "0x7311834")]
	protected string GetRequestURL()
	{
		return null;
	}

	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x731186C", Offset = "0x730D86C", VA = "0x731186C")]
	protected void CheckTimeout()
	{
	}

	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x7311928", Offset = "0x730D928", VA = "0x7311928")]
	protected void CachingFile(string _00BESdUzx)
	{
	}
}
