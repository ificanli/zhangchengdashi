using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000463")]
	public class GenealogyTransCtrl
	{
		[Token(Token = "0x4002ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly float _minScale;

		[Token(Token = "0x4002ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly float _maxScale;

		[Token(Token = "0x4002AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Action<float> _onScaleChange;

		[Token(Token = "0x4002AC1")]
		private const float ZoomSpeed = 0.5f;

		[Token(Token = "0x4002AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _currentScaleRatio;

		[Token(Token = "0x4002AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _initialDistance;

		[Token(Token = "0x17000141")]
		public float MaxOrthoSize
		{
			[Token(Token = "0x6001571")]
			[Address(RVA = "0x3E19540", Offset = "0x3E15540", VA = "0x3E19540")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000142")]
		public float MinOrthoSize
		{
			[Token(Token = "0x6001572")]
			[Address(RVA = "0x3E19548", Offset = "0x3E15548", VA = "0x3E19548")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001573")]
		[Address(RVA = "0x3E19550", Offset = "0x3E15550", VA = "0x3E19550")]
		public GenealogyTransCtrl([Optional] Action<float> onScaleChange)
		{
		}

		[Token(Token = "0x6001574")]
		[Address(RVA = "0x3E193CC", Offset = "0x3E153CC", VA = "0x3E193CC")]
		public void PinchToZoomStarts(Vector2 currentFingerPosition1, Vector2 currentFingerPosition2)
		{
		}

		[Token(Token = "0x6001575")]
		[Address(RVA = "0x3E19458", Offset = "0x3E15458", VA = "0x3E19458")]
		public void PinchToZoomUpdate(Vector2 currentFingerPosition1, Vector2 currentFingerPosition2)
		{
		}

		[Token(Token = "0x6001576")]
		[Address(RVA = "0x3E19718", Offset = "0x3E15718", VA = "0x3E19718")]
		public void AddScaleRatio(float delta)
		{
		}

		[Token(Token = "0x6001577")]
		[Address(RVA = "0x3E1964C", Offset = "0x3E1564C", VA = "0x3E1964C")]
		public void OnScaleValueChange(object obj)
		{
		}

		[Token(Token = "0x6001578")]
		[Address(RVA = "0x3E19750", Offset = "0x3E15750", VA = "0x3E19750")]
		public void UpdateCurrentScaleRatio(float currentScaleRatio)
		{
		}
	}
}
