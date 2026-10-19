using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Serializable]
	[Token(Token = "0x2000229")]
	public class FootballGoalAreaSettings
	{
		[Token(Token = "0x4001DBD")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 center;

		[Token(Token = "0x4001DBE")]
		[FieldOffset(Offset = "0x1C")]
		public float xMin;

		[Token(Token = "0x4001DBF")]
		[FieldOffset(Offset = "0x20")]
		public float xMax;

		[Token(Token = "0x4001DC0")]
		[FieldOffset(Offset = "0x24")]
		public float yMin;

		[Token(Token = "0x4001DC1")]
		[FieldOffset(Offset = "0x28")]
		public float yMax;

		[Token(Token = "0x4001DC2")]
		[FieldOffset(Offset = "0x2C")]
		public float zPlane;

		[Token(Token = "0x4001DC3")]
		public const int ZoneCount = 5;

		[Token(Token = "0x170000B1")]
		public float XAmplitude
		{
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x428D190", Offset = "0x4289190", VA = "0x428D190")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x428D1A4", Offset = "0x42891A4", VA = "0x428D1A4")]
		public FootballGoalZone GetZone(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x428D23C", Offset = "0x428923C", VA = "0x428D23C")]
		public FootballGoalZone PickRandomZoneExcept(FootballGoalZone exclude)
		{
			return default;
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x428A750", Offset = "0x4286750", VA = "0x428A750")]
		public FootballGoalZone PickRandomOppositeSideZone(FootballGoalZone shotZone)
		{
			return default;
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x428D264", Offset = "0x4289264", VA = "0x428D264")]
		public Vector3 GetZoneCenter(FootballGoalZone zone, float z)
		{
			return default;
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x428B7A0", Offset = "0x42877A0", VA = "0x428B7A0")]
		public Vector3 GetZoneCenterWorld(FootballGoalZone zone, Transform space, float worldZ)
		{
			return default;
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x428A688", Offset = "0x4286688", VA = "0x428A688")]
		public FootballGoalZone GetZoneFromWorld(Vector3 worldPosition, Transform space)
		{
			return default;
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x428D370", Offset = "0x4289370", VA = "0x428D370")]
		public Vector3 GetSaveDeflectDirection(FootballGoalZone zone)
		{
			return default;
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x428D200", Offset = "0x4289200", VA = "0x428D200")]
		private int GetColumn(float x)
		{
			return default;
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x428D30C", Offset = "0x428930C", VA = "0x428D30C")]
		private float GetColumnCenterX(int column)
		{
			return default;
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x428D334", Offset = "0x4289334", VA = "0x428D334")]
		private float GetRowCenterY(bool isTop)
		{
			return default;
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x428D35C", Offset = "0x428935C", VA = "0x428D35C")]
		private float GetFullHeightCenterY()
		{
			return default;
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x428CA98", Offset = "0x4288A98", VA = "0x428CA98")]
		public FootballGoalAreaSettings()
		{
		}
	}
}
