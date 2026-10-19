using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000BF")]
	public class MB3_UVTransformUtility
	{
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x7483EA4", Offset = "0x747FEA4", VA = "0x7483EA4")]
		public static void Test()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x748413C", Offset = "0x748013C", VA = "0x748413C")]
		public static float TransformX(DRect r, double x)
		{
			return default;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x74840F0", Offset = "0x74800F0", VA = "0x74840F0")]
		public static DRect CombineTransforms(ref DRect r1, ref DRect r2)
		{
			return default;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x748414C", Offset = "0x748014C", VA = "0x748414C")]
		public static Rect CombineTransforms(ref Rect r1, ref Rect r2)
		{
			return default;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x74840C8", Offset = "0x74800C8", VA = "0x74840C8")]
		public static DRect InverseTransform(ref DRect t)
		{
			return default;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x748416C", Offset = "0x748016C", VA = "0x748416C")]
		public static DRect GetShiftTransformToFitBinA(ref DRect A, ref DRect B)
		{
			return default;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x7484270", Offset = "0x7480270", VA = "0x7484270")]
		public static DRect GetEncapsulatingRectShifted(ref DRect uvRect1, ref DRect willBeIn)
		{
			return default;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x74843D8", Offset = "0x74803D8", VA = "0x74843D8")]
		public static DRect GetEncapsulatingRect(ref DRect uvRect1, ref DRect uvRect2)
		{
			return default;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x7484444", Offset = "0x7480444", VA = "0x7484444")]
		public static bool RectContainsShifted(ref DRect bucket, ref DRect tryFit)
		{
			return default;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x7484550", Offset = "0x7480550", VA = "0x7484550")]
		public static bool RectContainsShifted(ref Rect bucket, ref Rect tryFit)
		{
			return default;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x74846F0", Offset = "0x74806F0", VA = "0x74846F0")]
		public static bool LineSegmentContainsShifted(float bucketOffset, float bucketLength, float tryFitOffset, float tryFitLength)
		{
			return default;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x74847D8", Offset = "0x74807D8", VA = "0x74847D8")]
		public static bool RectContains(ref DRect bigRect, ref DRect smallToTestIfFits)
		{
			return default;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x7484650", Offset = "0x7480650", VA = "0x7484650")]
		public static bool RectContains(ref Rect bigRect, ref Rect smallToTestIfFits)
		{
			return default;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x748411C", Offset = "0x748011C", VA = "0x748411C")]
		public static Vector2 TransformPoint(ref DRect r, Vector2 p)
		{
			return default;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x7484878", Offset = "0x7480878", VA = "0x7484878")]
		public static DVector2 TransformPoint(ref DRect r, DVector2 p)
		{
			return default;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x7484894", Offset = "0x7480894", VA = "0x7484894")]
		public MB3_UVTransformUtility()
		{
		}
	}
}
