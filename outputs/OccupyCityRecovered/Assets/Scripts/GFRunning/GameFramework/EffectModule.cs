using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x200036C")]
	public class EffectModule : GameFrameModule
	{
		[Token(Token = "0x4001A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<int, BaseEffect> dicEffects;

		[Token(Token = "0x4001A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<int, EffectData> dicEffectDatas;

		[Token(Token = "0x4001A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool AlreadySetData;

		[Token(Token = "0x4001A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _worldEffectRoot;

		[Token(Token = "0x4001A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _uiEffectRoot;

		[Token(Token = "0x4001A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _LineEffectRoot;

		[Token(Token = "0x170010FE")]
		internal override int Priority
		{
			[Token(Token = "0x600591E")]
			[Address(RVA = "0x7180E7C", Offset = "0x717CE7C", VA = "0x7180E7C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170010FF")]
		private Transform WorldEffectRoot
		{
			[Token(Token = "0x6005932")]
			[Address(RVA = "0x7181F3C", Offset = "0x717DF3C", VA = "0x7181F3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001100")]
		private Transform UIEffectRoot
		{
			[Token(Token = "0x6005933")]
			[Address(RVA = "0x7182020", Offset = "0x717E020", VA = "0x7182020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001101")]
		private RectTransform LineEffectRoot
		{
			[Token(Token = "0x6005934")]
			[Address(RVA = "0x7182154", Offset = "0x717E154", VA = "0x7182154")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600591F")]
		[Address(RVA = "0x7180E84", Offset = "0x717CE84", VA = "0x7180E84", Slot = "5")]
		internal override void Initialize(params object[] arg)
		{
		}

		[Token(Token = "0x6005920")]
		[Address(RVA = "0x7180F24", Offset = "0x717CF24", VA = "0x7180F24", Slot = "6")]
		internal override void Start()
		{
		}

		[Token(Token = "0x6005921")]
		[Address(RVA = "0x7180F28", Offset = "0x717CF28", VA = "0x7180F28", Slot = "7")]
		internal override void Update(float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005922")]
		[Address(RVA = "0x7180F2C", Offset = "0x717CF2C", VA = "0x7180F2C")]
		public void ReadEffectData()
		{
		}

		[Token(Token = "0x6005923")]
		[Address(RVA = "0x7181358", Offset = "0x717D358", VA = "0x7181358")]
		[Obsolete("已过时，请更新MienGameMain脚本到3.1.0版本")]
		public void SetEffectData(Dictionary<int, EffectData> datas)
		{
		}

		[Token(Token = "0x6005924")]
		[Address(RVA = "0x7181368", Offset = "0x717D368", VA = "0x7181368")]
		public EffectData GetEffectDataById(int id)
		{
			return null;
		}

		[Token(Token = "0x6005925")]
		[Address(RVA = "0x71814B8", Offset = "0x717D4B8", VA = "0x71814B8", Slot = "9")]
		internal override void Shutdown()
		{
		}

		[Token(Token = "0x6005926")]
		[Address(RVA = "0x7181624", Offset = "0x717D624", VA = "0x7181624")]
		public void ClearChildObj()
		{
		}

		[Token(Token = "0x6005927")]
		[Address(RVA = "0x71817E8", Offset = "0x717D7E8", VA = "0x71817E8")]
		private int ShowEffectWithId(int templId, Vector3 pos, Vector3 rot, Vector3 targetPos, float flyTime, [Optional] Transform parent, int effectSortingLayer = -1, int effectOrder = -1)
		{
			return default;
		}

		[Token(Token = "0x6005928")]
		[Address(RVA = "0x7181998", Offset = "0x717D998", VA = "0x7181998")]
		public int Show(int templId, [Optional] Transform parent)
		{
			return default;
		}

		[Token(Token = "0x6005929")]
		[Address(RVA = "0x7181A30", Offset = "0x717DA30", VA = "0x7181A30")]
		public int Show(int templId, Vector3 pos, [Optional] Transform parent, int effectSortingLayer = -1, int effectOrder = -1)
		{
			return default;
		}

		[Token(Token = "0x600592A")]
		[Address(RVA = "0x7181AF4", Offset = "0x717DAF4", VA = "0x7181AF4")]
		public int Show(int templId, Vector3 pos, Vector3 rot, [Optional] Transform parent, int effectSortingLayer = -1, int effectOrder = -1)
		{
			return default;
		}

		[Token(Token = "0x600592B")]
		[Address(RVA = "0x7181BD8", Offset = "0x717DBD8", VA = "0x7181BD8")]
		public int Show(int templId, Vector3 pos, Vector3 rot, Vector3 targetPos, [Optional][DefaultParameterValue(1.3f)] float flyTime, [Optional] Transform parent, int effectSortingLayer = -1, int effectOrder = -1)
		{
			return default;
		}

		[Token(Token = "0x600592C")]
		[Address(RVA = "0x7181BF4", Offset = "0x717DBF4", VA = "0x7181BF4")]
		public BaseEffect Get(int uid)
		{
			return null;
		}

		[Token(Token = "0x600592D")]
		[Address(RVA = "0x7181C64", Offset = "0x717DC64", VA = "0x7181C64")]
		public void Close(int uid)
		{
		}

		[Token(Token = "0x600592E")]
		[Address(RVA = "0x7181D14", Offset = "0x717DD14", VA = "0x7181D14")]
		public void CloseAll()
		{
		}

		[Token(Token = "0x600592F")]
		[Address(RVA = "0x7181EB4", Offset = "0x717DEB4", VA = "0x7181EB4")]
		public double GetEffectDuration(int uid)
		{
			return default;
		}

		[Token(Token = "0x6005930")]
		public T CreateEffect<T>(int templId, [Optional] Transform parent, int effectOrder = -1) where T : BaseEffect
		{
			return null;
		}

		[Token(Token = "0x6005931")]
		public T CreateEffect<T>(int templId, Vector3 pos, Vector3 rot, Vector3 targetPos, float flyTime, [Optional] Transform parent, int effectSortingLayer = -1, int effectOrder = -1) where T : BaseEffect
		{
			return null;
		}

		[Token(Token = "0x6005935")]
		[Address(RVA = "0x71803D4", Offset = "0x717C3D4", VA = "0x71803D4")]
		public Vector2 WorldToRectLocalPoint(Vector3 WorldPos)
		{
			return default;
		}

		[Token(Token = "0x6005936")]
		[Address(RVA = "0x718232C", Offset = "0x717E32C", VA = "0x718232C")]
		public EffectModule()
		{
		}
	}
}
