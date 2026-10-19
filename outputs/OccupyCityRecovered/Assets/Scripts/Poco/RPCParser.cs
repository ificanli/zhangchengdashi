using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

[Token(Token = "0x2000007")]
public class RPCParser
{
	[Token(Token = "0x2000008")]
	public delegate object RpcMethod(List<object> param);

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected Dictionary<string, RpcMethod> RPCHandler;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private JsonSerializerSettings settings;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x787B23C", Offset = "0x787723C", VA = "0x787B23C")]
	public string HandleMessage(string json)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x787BBC4", Offset = "0x7877BC4", VA = "0x787BBC4")]
	public string formatRequest(string method, object idAction, [Optional] List<object> param)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x787BA60", Offset = "0x7877A60", VA = "0x787BA60")]
	public string formatResponse(object idAction, object result)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x787B81C", Offset = "0x787781C", VA = "0x787B81C")]
	public string formatResponseError(object idAction, IDictionary<string, object> data, Exception e)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x78793DC", Offset = "0x78753DC", VA = "0x78793DC")]
	public void addRpcMethod(string name, RpcMethod method)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x787921C", Offset = "0x787521C", VA = "0x787921C")]
	public RPCParser()
	{
	}
}
