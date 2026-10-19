using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using ToolModule;

namespace GameConfigModule
{
	[Token(Token = "0x2000219")]
	public class GameConfigManager : ManagerBase<GameConfigManager>
	{
		[Token(Token = "0x4001D3E")]
		[FieldOffset(Offset = "0x20")]
		public bool initComplete;

		[Token(Token = "0x4001D3F")]
		[FieldOffset(Offset = "0x28")]
		private GameGlobalConfig _gameGlobalConfig;

		[Token(Token = "0x4001D40")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, object> gameSettingConfigsDict;

		[Token(Token = "0x170000AE")]
		public static GameGlobalConfig GameGlobalConfig
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x41966F0", Offset = "0x41926F0", VA = "0x41966F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x4196788", Offset = "0x4192788", VA = "0x4196788", Slot = "4")]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x41968A0", Offset = "0x41928A0", VA = "0x41968A0")]
		public int GetConfigInt(string gameConfigId)
		{
			return default;
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x4196AD8", Offset = "0x4192AD8", VA = "0x4196AD8")]
		public float GetConfigFloat(string gameConfigId)
		{
			return default;
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x4196C64", Offset = "0x4192C64", VA = "0x4196C64")]
		public string GetConfigStr(string gameConfigId)
		{
			return null;
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x4196DBC", Offset = "0x4192DBC", VA = "0x4196DBC")]
		public bool GetConfigBool(string gameConfigId)
		{
			return default;
		}

		[Token(Token = "0x60008B7")]
		private bool GetConfigFromCache<T>(string gameConfigId, out T result)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GameConfigManager.GetConfigFromCache RVA= Token=0x60008B7");
}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x4196A30", Offset = "0x4192A30", VA = "0x4196A30")]
		private void AddConfigToCache(string gameConfigId, object value)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x4196F54", Offset = "0x4192F54", VA = "0x4196F54")]
		public GameConfigManager()
		{
		}
	}
}
