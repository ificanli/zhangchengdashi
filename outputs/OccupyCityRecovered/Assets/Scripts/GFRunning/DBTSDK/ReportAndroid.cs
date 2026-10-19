using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x2000207")]
	public class ReportAndroid
	{
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x70CBFB0", Offset = "0x70C7FB0", VA = "0x70CBFB0")]
		public static void OnEvent(string event_id, string label)
		{
		}

		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x70CC0A8", Offset = "0x70C80A8", VA = "0x70CC0A8")]
		public static void OnEvent(string event_id, string label, int n)
		{
		}

		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x70CC200", Offset = "0x70C8200", VA = "0x70CC200")]
		public static void OnEventDuration(string event_id, int ms)
		{
		}

		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x70CC324", Offset = "0x70C8324", VA = "0x70CC324")]
		public static void OnEventDuration(string event_id, string label, int ms)
		{
		}

		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x70CC47C", Offset = "0x70C847C", VA = "0x70CC47C")]
		public static void OnEventOnlyOnce(string event_id, string label)
		{
		}

		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x70CC574", Offset = "0x70C8574", VA = "0x70CC574")]
		public static void OnEventOnlyOnce(string event_id, string label, int n)
		{
		}

		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x70CC6CC", Offset = "0x70C86CC", VA = "0x70CC6CC")]
		public static void TrackVideoStatic(int type)
		{
		}

		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x70CC7C4", Offset = "0x70C87C4", VA = "0x70CC7C4")]
		public static void OnEventHomeApp()
		{
		}

		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x70CC928", Offset = "0x70C8928", VA = "0x70CC928")]
		public static void OnNewEvent(string eventId)
		{
		}

		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x70CC9EC", Offset = "0x70C89EC", VA = "0x70CC9EC")]
		public static void OnNewEvent(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x70CCAE4", Offset = "0x70C8AE4", VA = "0x70CCAE4")]
		public static void OnNewEventOnlyOnce(string eventId)
		{
		}

		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x70CCBA8", Offset = "0x70C8BA8", VA = "0x70CCBA8")]
		public static void OnNewEventOnlyOnce(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x6001AB0")]
		[Address(RVA = "0x70CCCA0", Offset = "0x70C8CA0", VA = "0x70CCCA0")]
		public static void OnNewEventToGravity(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x6001AB1")]
		[Address(RVA = "0x70CCEC0", Offset = "0x70C8EC0", VA = "0x70CCEC0")]
		public static void OnNewEventToApplovin(string eventId, string jsonProperties)
		{
		}

		[Token(Token = "0x6001AB2")]
		[Address(RVA = "0x70CD0E0", Offset = "0x70C90E0", VA = "0x70CD0E0")]
		public ReportAndroid()
		{
		}
	}
}
