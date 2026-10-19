using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace QuickTutor
{
	[Token(Token = "0x2000C9A")]
	public class TutorialMaskProperties : MonoBehaviour
	{
		[Token(Token = "0x4005A88")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _maxCenterSize;

		[Token(Token = "0x4005A89")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _image;

		[Token(Token = "0x4005A8A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material _material;

		[Token(Token = "0x4005A8B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector4[] _centers;

		[Token(Token = "0x4005A8C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector4[] _sizes;

		[Token(Token = "0x4005A8D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float[] _radii;

		[Token(Token = "0x4005A8E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int _numRegions;

		[Token(Token = "0x4005A8F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int Array;

		[Token(Token = "0x4005A90")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int SizeArray;

		[Token(Token = "0x4005A91")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int RadiusArray;

		[Token(Token = "0x4005A92")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int Regions;

		[Token(Token = "0x4005A93")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int Softness;

		[Token(Token = "0x4005A94")]
		[FieldOffset(Offset = "0x54")]
		private float _radianRatio;

		[Token(Token = "0x4005A95")]
		[FieldOffset(Offset = "0x58")]
		private float _softness;

		[Token(Token = "0x6004F1B")]
		[Address(RVA = "0x42B3130", Offset = "0x42AF130", VA = "0x42B3130")]
		[ContextMenu("Set Properties")]
		private void SetProperties()
		{
		}

		[Token(Token = "0x6004F1C")]
		[Address(RVA = "0x42B1248", Offset = "0x42AD248", VA = "0x42B1248")]
		public void SetMask(List<ITutorialPointInfo> target)
		{
		}

		[Token(Token = "0x6004F1D")]
		[Address(RVA = "0x42B2974", Offset = "0x42AE974", VA = "0x42B2974")]
		public void CloseMask()
		{
		}

		[Token(Token = "0x6004F1E")]
		[Address(RVA = "0x42B299C", Offset = "0x42AE99C", VA = "0x42B299C")]
		public void OpenMask(float radianRatio = 1f)
		{
		}

		[Token(Token = "0x6004F1F")]
		[Address(RVA = "0x42B1530", Offset = "0x42AD530", VA = "0x42B1530")]
		public bool GetMainMaskCenterAndSize(out Vector2 center, out Vector2 size)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TutorialMaskProperties.GetMainMaskCenterAndSize RVA=0x42B1530 Token=0x6004F1F");
}

		[Token(Token = "0x6004F20")]
		[Address(RVA = "0x42B3208", Offset = "0x42AF208", VA = "0x42B3208")]
		public TutorialMaskProperties()
		{
		}
	}
}
