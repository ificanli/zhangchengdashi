using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBT_Adapte
{
	[Token(Token = "0x2000F68")]
	public static class RemoteConfig
	{
		[Token(Token = "0x4006A68")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, List<object>> _cfg = new Dictionary<string, List<object>>();

		[Token(Token = "0x4006A69")]
		[FieldOffset(Offset = "0x8")]
		private static bool _isInit = false;

		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x43B0770", Offset = "0x43AC770", VA = "0x43B0770")]
		public static void Init()
		{
            if (_isInit) return;
            _isInit = true;
            UnityEngine.TextAsset asset = UnityEngine.Resources.Load<UnityEngine.TextAsset>("RemoteConfig");
            Newtonsoft.Json.Linq.JObject config = Newtonsoft.Json.Linq.JObject.Parse(asset.text);
            foreach (KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item in config)
            {
                try
                {
                    List<object> list = item.Value.ToObject<List<object>>();
                    if (!_cfg.ContainsKey(item.Key)) _cfg.Add(item.Key, list);
                }
                catch (System.Exception)
                {
                    try
                    {
                        List<object> list = new List<object>();
                        object value = item.Value.ToObject<object>();
                        if (!_cfg.ContainsKey(item.Key))
                        {
                            list.Add(value);
                            _cfg.Add(item.Key, list);
                        }
                    }
                    catch (System.Exception)
                    {
                        UnityEngine.Debug.LogError("配置" + item.Key + "解析失败");
                    }
                }
            }
        }

		[Token(Token = "0x6005C85")]
		public static T GetItemOrDefault<T>() where T : class, new()
		{
            Init();
            string key = typeof(T).Name;
            if (_cfg.ContainsKey(key)) return GetItemOrDefault_TryGet<T>(key);
            key = typeof(T).FullName;
            if (_cfg.ContainsKey(key)) return GetItemOrDefault_TryGet<T>(key);
            return System.Activator.CreateInstance<T>();
        }

		[Token(Token = "0x6005C86")]
		public static T GetFireBaseObjectValue<T>(string key) where T : class
		{
            Init();
            if (!_cfg.ContainsKey(key)) return null;
            List<object> list = _cfg[key];
            if (list != null && list.Count < 1) return null;
            try
            {
                object value = list[0];
                if (value is T) return (T)value;
                T item = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value.ToString());
                list[0] = item;
                return item;
            }
            catch
            {
                return null;
            }
        }

		[Token(Token = "0x6005C87")]
		public static T GetFireBaseValue<T>(string key) where T : struct
		{
            Init();
            if (!_cfg.ContainsKey(key)) return default;
            List<object> list = _cfg[key];
            if (list != null && list.Count < 1) return default;
            try
            {
                object value = list[0];
                T item = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value.ToString());
                list[0] = item;
                return item;
            }
            catch
            {
                return default;
            }
        }

		[Token(Token = "0x6005C88")]
		public static List<T> GetAllItems<T>() where T : class, new()
		{
            Init();
            string key = typeof(T).Name;
            List<T> result = new List<T>();
            if (!_cfg.ContainsKey(key)) return result;
            List<object> list = _cfg[key];
            for (int i = 0; i < list.Count; ++i)
            {
                object value = list[i];
                if (value is T)
                {
                    result.Add((T)value);
                }
                else
                {
                    T item = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value.ToString());
                    list[i] = item;
                    result.Add(item);
                }
            }
            return result;
        }

		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x43B0E70", Offset = "0x43ACE70", VA = "0x43B0E70")]
		public static List<object> GetAllItems()
		{
            Init();
            List<object> result = new List<object>();
            foreach (string key in _cfg.Keys)
            {
                List<object> list = _cfg[key];
                if (list != null)
                {
                    for (int i = 0; i < list.Count; ++i)
                        UnityEngine.Debug.Log(string.Format("Key:{0},Value:{1}", key, list[i]));
                }
                else
                {
                    UnityEngine.Debug.Log(string.Format("Key:{0},Value:{1}", key, null));
                }
            }
            return result;
        }
        // Original 0x6005C8A / RVA 0x43B11A8 is emitted by the two ordered field initializers.

        // Original compiler-generated <GetItemOrDefault>g__TryGet|3_0<T>.
        [Token(Token = "0x6005C8B")]
        [System.Runtime.CompilerServices.CompilerGenerated]
        private static T GetItemOrDefault_TryGet<T>(string key) where T : class, new()
        {
            List<object> list = _cfg[key];
            if (list.Count >= 1)
            {
                object value = list[0];
                if (value is T) return (T)value;
                T item = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value.ToString());
                list[0] = item;
                return item;
            }
            UnityEngine.Debug.LogError("NotFind :" + key);
            return System.Activator.CreateInstance<T>();
        }

	}
}
