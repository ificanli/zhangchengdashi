using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Poco;
using TcpServer;
using UnityEngine;

[Token(Token = "0x2000003")]
public class PocoManager : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	private class RPC : Attribute
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x787B034", Offset = "0x7877034", VA = "0x787B034")]
		public RPC()
		{
		}
	}

	[Token(Token = "0x4000001")]
	public const int versionCode = 6;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public int port;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x24")]
	private bool mRunning;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	public AsyncTcpServer server;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	private RPCParser rpc;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	private SimpleProtocolFilter prot;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	private UnityDumper dumper;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x48")]
	private ConcurrentDictionary<string, TcpClientState> inbox;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	private VRSupport vr_support;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<string, long> debugProfilingData;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x0")]
	internal static bool isCreated;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7878800", Offset = "0x7874800", VA = "0x7878800")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x7878904", Offset = "0x7874904", VA = "0x7878904")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x78797B4", Offset = "0x78757B4", VA = "0x78797B4")]
	private static void server_ClientConnected(object sender, TcpClientConnectedEventArgs e)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x787986C", Offset = "0x787586C", VA = "0x787986C")]
	private static void server_ClientDisconnected(object sender, TcpClientDisconnectedEventArgs e)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x7879924", Offset = "0x7875924", VA = "0x7879924")]
	private void server_Received(object sender, TcpDatagramReceivedEventArgs<byte[]> e)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x7879B38", Offset = "0x7875B38", VA = "0x7879B38")]
	[RPC]
	private object Dump(List<object> param)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x7879CF0", Offset = "0x7875CF0", VA = "0x7879CF0")]
	[RPC]
	private object Screenshot(List<object> param)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7879F3C", Offset = "0x7875F3C", VA = "0x7879F3C")]
	[RPC]
	private object GetScreenSize(List<object> param)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x7879FCC", Offset = "0x7875FCC", VA = "0x7879FCC")]
	public void stopListening()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x787A44C", Offset = "0x787644C", VA = "0x787A44C")]
	[RPC]
	private object GetDebugProfilingData(List<object> param)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x787A454", Offset = "0x7876454", VA = "0x787A454")]
	[RPC]
	private object SetText(List<object> param)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x787A71C", Offset = "0x787671C", VA = "0x787A71C")]
	[RPC]
	private object GetSDKVersion(List<object> param)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x787A76C", Offset = "0x787676C", VA = "0x787A76C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x787AD44", Offset = "0x7876D44", VA = "0x787AD44")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x787AD5C", Offset = "0x7876D5C", VA = "0x787AD5C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x787AD74", Offset = "0x7876D74", VA = "0x787AD74")]
	public PocoManager()
	{
	}
}
