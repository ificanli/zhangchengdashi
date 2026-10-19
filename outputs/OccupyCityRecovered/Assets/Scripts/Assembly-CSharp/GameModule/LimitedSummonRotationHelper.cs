using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x20004D7")]
	public static class LimitedSummonRotationHelper
	{
		[Token(Token = "0x4002C6F")]
		private const int RotatePeriodDays = 7;

		[Token(Token = "0x4002C70")]
		private const double ArtifactsFeatureUnlockCacheSeconds = 1.0;

		[Token(Token = "0x4002C71")]
		[FieldOffset(Offset = "0x0")]
		private static bool _listenersRegistered;

		[Token(Token = "0x4002C72")]
		[FieldOffset(Offset = "0x8")]
		private static List<int> _sortedOrderIds;

		[Token(Token = "0x4002C73")]
		[FieldOffset(Offset = "0x10")]
		private static int _minOrderId;

		[Token(Token = "0x4002C74")]
		[FieldOffset(Offset = "0x14")]
		private static int _orderIdCount;

		[Token(Token = "0x4002C75")]
		[FieldOffset(Offset = "0x18")]
		private static bool _hasArtifactsFeatureUnlockCache;

		[Token(Token = "0x4002C76")]
		[FieldOffset(Offset = "0x19")]
		private static bool _isArtifactsFeatureUnlockedCache;

		[Token(Token = "0x4002C77")]
		[FieldOffset(Offset = "0x20")]
		private static DateTime _lastArtifactsFeatureUnlockCheckTime;

		[Token(Token = "0x6001857")]
		[Address(RVA = "0x3E7837C", Offset = "0x3E7437C", VA = "0x3E7837C")]
		public static void EnsureListeningTimeToZero()
		{
		}

		[Token(Token = "0x6001858")]
		[Address(RVA = "0x3E7850C", Offset = "0x3E7450C", VA = "0x3E7850C")]
		private static void OnTimeToZero(object obj)
		{
		}

		[Token(Token = "0x6001859")]
		[Address(RVA = "0x3E7880C", Offset = "0x3E7480C", VA = "0x3E7880C")]
		private static void OnArtifactsFeatureUnlocked(object obj)
		{
		}

		[Token(Token = "0x600185A")]
		[Address(RVA = "0x3E77AF4", Offset = "0x3E73AF4", VA = "0x3E77AF4")]
		public static void SyncRotationFromAnchor()
		{
		}

		[Token(Token = "0x600185B")]
		[Address(RVA = "0x3E78E38", Offset = "0x3E74E38", VA = "0x3E78E38")]
		public static TimeSpan GetTimeSpanToNextRotate()
		{
			return default;
		}

		[Token(Token = "0x600185C")]
		[Address(RVA = "0x3E79014", Offset = "0x3E75014", VA = "0x3E79014")]
		public static string GetFormattedRemainingTimeToNextRotate()
		{
			return null;
		}

		[Token(Token = "0x600185D")]
		[Address(RVA = "0x3E77D6C", Offset = "0x3E73D6C", VA = "0x3E77D6C")]
		public static int GetCurrentPeriodIndex()
		{
			return default;
		}

		[Token(Token = "0x600185E")]
		[Address(RVA = "0x3E79070", Offset = "0x3E75070", VA = "0x3E79070")]
		public static TimeSpan GetTimeSpanToNextPeriodReset()
		{
			return default;
		}

		[Token(Token = "0x600185F")]
		[Address(RVA = "0x3E790BC", Offset = "0x3E750BC", VA = "0x3E790BC")]
		public static string GetFormattedRemainingTimeToNextPeriodReset()
		{
			return null;
		}

		[Token(Token = "0x6001860")]
		[Address(RVA = "0x3E79108", Offset = "0x3E75108", VA = "0x3E79108")]
		public static int GetCurrentDisplayOrderId()
		{
			return default;
		}

		[Token(Token = "0x6001861")]
		[Address(RVA = "0x3E79228", Offset = "0x3E75228", VA = "0x3E79228")]
		public static List<LimitedPropOrderConfig> GetSortedLimitedPropOrderList()
		{
			return null;
		}

		[Token(Token = "0x6001862")]
		[Address(RVA = "0x3E78C54", Offset = "0x3E74C54", VA = "0x3E78C54")]
		private static int GetPeriodIndex(DateTime today, long anchorDayTicks)
		{
			return default;
		}

		[Token(Token = "0x6001863")]
		[Address(RVA = "0x3E78D38", Offset = "0x3E74D38", VA = "0x3E78D38")]
		private static int GetOrderIdByPeriodIndex(int periodIndex)
		{
			return default;
		}

		[Token(Token = "0x6001864")]
		[Address(RVA = "0x3E788A0", Offset = "0x3E748A0", VA = "0x3E788A0")]
		private static void CacheOrderIds()
		{
		}

		[Token(Token = "0x6001865")]
		[Address(RVA = "0x3E76AE4", Offset = "0x3E72AE4", VA = "0x3E76AE4")]
		public static bool IsRotationEnvironmentReady()
		{
			return default;
		}

		[Token(Token = "0x6001866")]
		[Address(RVA = "0x3E7857C", Offset = "0x3E7457C", VA = "0x3E7857C")]
		private static bool IsArtifactsFeatureUnlocked()
		{
			return default;
		}
	}
}
