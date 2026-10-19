using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FAE")]
	public class PlayerPrefs2Center : SingletonComponent<PlayerPrefs2Center>
	{
		[Token(Token = "0x4006B7E")]
		[FieldOffset(Offset = "0x20")]
		private float lastCallSaveTime;

		[Token(Token = "0x4006B7F")]
		[FieldOffset(Offset = "0x0")]
		public static float saveInterval;

		[Token(Token = "0x4006B80")]
		[FieldOffset(Offset = "0x24")]
		private bool isSave;

		[Token(Token = "0x4006B81")]
		[FieldOffset(Offset = "0x4")]
		public static bool AdapterPlayerPrefs;

		[Token(Token = "0x4006B82")]
		[FieldOffset(Offset = "0x28")]
		private Action<string> SaveToGF;

		[Token(Token = "0x4006B83")]
		[FieldOffset(Offset = "0x8")]
		private static PlayerPrefs2RunTime _playerPrefs2SaveIns;

		[Token(Token = "0x4006B84")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, Action> CoreSaveAction;

		[Token(Token = "0x4006B85")]
		[FieldOffset(Offset = "0x38")]
		private bool isInitSave;

		[Token(Token = "0x6005DD3")]
		[Address(RVA = "0x43BCD8C", Offset = "0x43B8D8C", VA = "0x43BCD8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005DD4")]
		[Address(RVA = "0x43BCE80", Offset = "0x43B8E80", VA = "0x43BCE80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6005DD5")]
		[Address(RVA = "0x43BD04C", Offset = "0x43B904C", VA = "0x43BD04C")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6005DD6")]
		[Address(RVA = "0x43BD058", Offset = "0x43B9058", VA = "0x43BD058")]
		public void AddIgnoreSave(string key)
		{
		}

		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0x43BD0C4", Offset = "0x43B90C4", VA = "0x43BD0C4")]
		private void TrySave()
		{
		}

		[Token(Token = "0x6005DD8")]
		[Address(RVA = "0x43BCE28", Offset = "0x43B8E28", VA = "0x43BCE28")]
		public void SaveRightNow()
		{
		}

		[Token(Token = "0x6005DD9")]
		[Address(RVA = "0x43BD1F0", Offset = "0x43B91F0", VA = "0x43BD1F0")]
		public void AddCoreSaveAction(string key, Action action)
		{
		}

		[Token(Token = "0x6005DDA")]
		[Address(RVA = "0x43BD2A0", Offset = "0x43B92A0", VA = "0x43BD2A0")]
		public void Init(Action<string> saveAction, string saveData)
		{
		}

		[Token(Token = "0x6005DDB")]
		[Address(RVA = "0x43BD3EC", Offset = "0x43B93EC", VA = "0x43BD3EC")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x6005DDC")]
		[Address(RVA = "0x43BD470", Offset = "0x43B9470", VA = "0x43BD470")]
		public void SetDVersion(int v)
		{
		}

		[Token(Token = "0x6005DDD")]
		[Address(RVA = "0x43B7C74", Offset = "0x43B3C74", VA = "0x43B7C74")]
		public void ReBindXXX()
		{
		}

		[Token(Token = "0x6005DDE")]
		[Address(RVA = "0x43BCEEC", Offset = "0x43B8EEC", VA = "0x43BCEEC")]
		private void ForceGameSave()
		{
		}

		[Token(Token = "0x6005DDF")]
		[Address(RVA = "0x43BD15C", Offset = "0x43B915C", VA = "0x43BD15C")]
		public string GetSave()
		{
			return null;
		}

		[Token(Token = "0x6005DE0")]
		[Address(RVA = "0x43BD518", Offset = "0x43B9518", VA = "0x43BD518")]
		public static bool HasKey(string key)
		{
			return default;
		}

		[Token(Token = "0x6005DE1")]
		[Address(RVA = "0x43BD584", Offset = "0x43B9584", VA = "0x43BD584")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6005DE2")]
		[Address(RVA = "0x43BD5F0", Offset = "0x43B95F0", VA = "0x43BD5F0")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6005DE3")]
		[Address(RVA = "0x43BD654", Offset = "0x43B9654", VA = "0x43BD654")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6005DE4")]
		[Address(RVA = "0x43BD6D0", Offset = "0x43B96D0", VA = "0x43BD6D0")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6005DE5")]
		[Address(RVA = "0x43BD754", Offset = "0x43B9754", VA = "0x43BD754")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6005DE6")]
		[Address(RVA = "0x43BD7D0", Offset = "0x43B97D0", VA = "0x43BD7D0")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6005DE7")]
		[Address(RVA = "0x43BD84C", Offset = "0x43B984C", VA = "0x43BD84C")]
		public static int GetInt(string key)
		{
			return default;
		}

		[Token(Token = "0x6005DE8")]
		[Address(RVA = "0x43BD8BC", Offset = "0x43B98BC", VA = "0x43BD8BC")]
		public static int GetInt(string key, int defaultValue)
		{
			return default;
		}

		[Token(Token = "0x6005DE9")]
		[Address(RVA = "0x43BD938", Offset = "0x43B9938", VA = "0x43BD938")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6005DEA")]
		[Address(RVA = "0x43BD9B4", Offset = "0x43B99B4", VA = "0x43BD9B4")]
		public static float GetFloat(string key)
		{
			return default;
		}

		[Token(Token = "0x6005DEB")]
		[Address(RVA = "0x43BDA24", Offset = "0x43B9A24", VA = "0x43BDA24")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default;
		}

		[Token(Token = "0x6005DEC")]
		[Address(RVA = "0x43BDAA0", Offset = "0x43B9AA0", VA = "0x43BDAA0")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6005DED")]
		[Address(RVA = "0x43BDB1C", Offset = "0x43B9B1C", VA = "0x43BDB1C")]
		public static bool GetBool(string key)
		{
			return default;
		}

		[Token(Token = "0x6005DEE")]
		[Address(RVA = "0x43BDB8C", Offset = "0x43B9B8C", VA = "0x43BDB8C")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default;
		}

		[Token(Token = "0x6005DEF")]
		[Address(RVA = "0x43BDC08", Offset = "0x43B9C08", VA = "0x43BDC08")]
		public PlayerPrefs2Center()
		{
		}
	}
}
