using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x200004A")]
	public class DrawingSettings : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x200004B")]
		public class Settings
		{
			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x10")]
			public float lineOpacity;

			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x14")]
			public float solidOpacity;

			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x18")]
			public float textOpacity;

			[Token(Token = "0x400012F")]
			[FieldOffset(Offset = "0x1C")]
			public float lineOpacityBehindObjects;

			[Token(Token = "0x4000130")]
			[FieldOffset(Offset = "0x20")]
			public float solidOpacityBehindObjects;

			[Token(Token = "0x4000131")]
			[FieldOffset(Offset = "0x24")]
			public float textOpacityBehindObjects;

			[Token(Token = "0x4000132")]
			[FieldOffset(Offset = "0x28")]
			public float curveResolution;

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x46E98EC", Offset = "0x46E58EC", VA = "0x46E98EC")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000127")]
		public const string SettingsPathCompatibility = "Assets/Settings/ALINE.asset";

		[Token(Token = "0x4000128")]
		public const string SettingsName = "AstarGizmos";

		[Token(Token = "0x4000129")]
		public const string SettingsPath = "Assets/Settings/Resources/AstarGizmos.asset";

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int version;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x20")]
		public Settings settings;

		[Token(Token = "0x1700001E")]
		public static Settings DefaultSettings
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x46E9878", Offset = "0x46E5878", VA = "0x46E9878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x46E9914", Offset = "0x46E5914", VA = "0x46E9914")]
		public static DrawingSettings GetSettingsAsset()
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x46E996C", Offset = "0x46E596C", VA = "0x46E996C")]
		public DrawingSettings()
		{
		}
	}
}
