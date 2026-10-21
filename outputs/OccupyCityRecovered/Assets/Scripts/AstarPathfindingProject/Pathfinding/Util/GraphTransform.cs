using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using UnityEngine;

namespace Pathfinding.Util
{
	[Token(Token = "0x200029D")]
	public class GraphTransform : IMovementPlane, ITransform
	{
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x10")]
		private bool isXY;

		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x11")]
		private bool isXZ;

		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0x12")]
		private bool isOnlyTranslational;

		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x13")]
		private bool isIdentity;

		[Token(Token = "0x4000BD9")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 up;

		[Token(Token = "0x4000BDA")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 translation;

		[Token(Token = "0x4000BDB")]
		[FieldOffset(Offset = "0xAC")]
		private Int3 i3translation;

		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0xC8")]
		private Quaternion inverseRotation;

		[Token(Token = "0x4000BDE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GraphTransform identityTransform = new GraphTransform(Matrix4x4.identity);

		[Token(Token = "0x4000BDF")]
		[FieldOffset(Offset = "0x8")]
		public static readonly GraphTransform xyPlane = new GraphTransform(Matrix4x4.TRS(Vector3.zero,Quaternion.Euler(-90f,0f,0f),Vector3.one));

		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0x10")]
		public static readonly GraphTransform xzPlane = new GraphTransform(Matrix4x4.identity);

		[Token(Token = "0x17000270")]
		public bool identity
		{
			[Token(Token = "0x6001087")]
			[Address(RVA = "0x4495768", Offset = "0x4491768", VA = "0x4495768")]
			get
			{ return isIdentity; }
		}

		[Token(Token = "0x17000271")]
		public bool onlyTranslational
		{
			[Token(Token = "0x6001088")]
			[Address(RVA = "0x4495770", Offset = "0x4491770", VA = "0x4495770")]
			get
			{ return isOnlyTranslational; }
		}

		[Token(Token = "0x17000272")]
		public Matrix4x4 matrix
		{
			[Token(Token = "0x6001089")]
			[Address(RVA = "0x4495778", Offset = "0x4491778", VA = "0x4495778")]
			[CompilerGenerated]
			get
			;
			[Token(Token = "0x600108A")]
			[Address(RVA = "0x4495794", Offset = "0x4491794", VA = "0x4495794")]
			[CompilerGenerated]
			private set
			;
		}

		[Token(Token = "0x17000273")]
		public Matrix4x4 inverseMatrix
		{
			[Token(Token = "0x600108B")]
			[Address(RVA = "0x44957B0", Offset = "0x44917B0", VA = "0x44957B0")]
			[CompilerGenerated]
			get
			;
			[Token(Token = "0x600108C")]
			[Address(RVA = "0x44957CC", Offset = "0x44917CC", VA = "0x44957CC")]
			[CompilerGenerated]
			private set
			;
		}

		[Token(Token = "0x17000274")]
		public Quaternion rotation
		{
			[Token(Token = "0x600108D")]
			[Address(RVA = "0x44957E8", Offset = "0x44917E8", VA = "0x44957E8")]
			[CompilerGenerated]
			get
			;
			[Token(Token = "0x600108E")]
			[Address(RVA = "0x44957F4", Offset = "0x44917F4", VA = "0x44957F4")]
			[CompilerGenerated]
			private set
			;
		}

		[Token(Token = "0x600108F")]
		[Address(RVA = "0x449534C", Offset = "0x449134C", VA = "0x449534C")]
		public GraphTransform(Matrix4x4 matrix)
		{ Set(matrix); }

		[Token(Token = "0x6001090")]
		[Address(RVA = "0x44953C0", Offset = "0x44913C0", VA = "0x44953C0")]
		protected void Set(Matrix4x4 matrix)
		{
 this.matrix = matrix;
 inverseMatrix = matrix.inverse;
 isIdentity = matrix.isIdentity;
 isOnlyTranslational = MatrixIsTranslational(matrix);
 up = matrix.MultiplyVector(Vector3.up).normalized;
 translation = matrix.MultiplyPoint3x4(Vector3.zero);
 i3translation = (Int3)translation;
 rotation = Quaternion.LookRotation(TransformVector(Vector3.forward), TransformVector(Vector3.up));
 inverseRotation = Quaternion.Inverse(rotation);
 isXY = Quaternion.Dot(rotation, Quaternion.Euler(-90f, 0f, 0f)) > 0.999999f;
 isXZ = Quaternion.Dot(rotation, Quaternion.Euler(0f, 0f, 0f)) > 0.999999f;
}

		[Token(Token = "0x6001091")]
		[Address(RVA = "0x4495928", Offset = "0x4491928", VA = "0x4495928")]
		public Vector3 WorldUpAtGraphPosition(Vector3 point)
		{ return up; }

		[Token(Token = "0x6001092")]
		[Address(RVA = "0x4495800", Offset = "0x4491800", VA = "0x4495800")]
		private static bool MatrixIsTranslational(Matrix4x4 matrix)
		{
 return (matrix.GetColumn(0) - new Vector4(1, 0, 0, 0)).sqrMagnitude < 9.999999439624929e-11f
     && (matrix.GetColumn(1) - new Vector4(0, 1, 0, 0)).sqrMagnitude < 9.999999439624929e-11f
     && (matrix.GetColumn(2) - new Vector4(0, 0, 1, 0)).sqrMagnitude < 9.999999439624929e-11f
     && matrix.m33 == 1f;
}

		[Token(Token = "0x6001093")]
		[Address(RVA = "0x4495934", Offset = "0x4491934", VA = "0x4495934", Slot = "8")]
		public Vector3 Transform(Vector3 point)
		{ return isOnlyTranslational ? point + translation : matrix.MultiplyPoint3x4(point); }

		[Token(Token = "0x6001094")]
		[Address(RVA = "0x44958E8", Offset = "0x44918E8", VA = "0x44958E8")]
		public Vector3 TransformVector(Vector3 dir)
		{ return isOnlyTranslational ? dir : matrix.MultiplyVector(dir); }

		[Token(Token = "0x6001095")]
		[Address(RVA = "0x449598C", Offset = "0x449198C", VA = "0x449598C")]
		public void Transform(Int3[] arr)
		{
		}

		[Token(Token = "0x6001096")]
		[Address(RVA = "0x4495AF0", Offset = "0x4491AF0", VA = "0x4495AF0")]
		public void Transform(UnsafeSpan<Int3> arr)
		{
		}

		[Token(Token = "0x6001097")]
		[Address(RVA = "0x4495CC0", Offset = "0x4491CC0", VA = "0x4495CC0")]
		public void Transform(Vector3[] arr)
		{
		}

		[Token(Token = "0x6001098")]
		[Address(RVA = "0x4495DE0", Offset = "0x4491DE0", VA = "0x4495DE0", Slot = "9")]
		public Vector3 InverseTransform(Vector3 point)
		{ return isOnlyTranslational ? point - translation : inverseMatrix.MultiplyPoint3x4(point); }

		[Token(Token = "0x6001099")]
		[Address(RVA = "0x448EB68", Offset = "0x448AB68", VA = "0x448EB68")]
		public Vector3 InverseTransformVector(Vector3 dir)
		{
			return default;
		}

		[Token(Token = "0x600109A")]
		[Address(RVA = "0x4495E38", Offset = "0x4491E38", VA = "0x4495E38")]
		public Int3 InverseTransform(Int3 point)
		{
			return default;
		}

		[Token(Token = "0x600109B")]
		[Address(RVA = "0x4495ED0", Offset = "0x4491ED0", VA = "0x4495ED0")]
		public void InverseTransform(Int3[] arr)
		{
		}

		[Token(Token = "0x600109C")]
		[Address(RVA = "0x4495FA8", Offset = "0x4491FA8", VA = "0x4495FA8")]
		public void InverseTransform(UnsafeSpan<Int3> arr)
		{
		}

		[Token(Token = "0x600109D")]
		[Address(RVA = "0x44960B0", Offset = "0x44920B0", VA = "0x44960B0")]
		public static GraphTransform operator *(GraphTransform lhs, Matrix4x4 rhs)
		{
			return null;
		}

		[Token(Token = "0x600109E")]
		[Address(RVA = "0x449618C", Offset = "0x449218C", VA = "0x449618C")]
		public static GraphTransform operator *(Matrix4x4 lhs, GraphTransform rhs)
		{
			return null;
		}

		[Token(Token = "0x600109F")]
		[Address(RVA = "0x4496278", Offset = "0x4492278", VA = "0x4496278")]
		public Bounds Transform(Bounds bounds)
		{
 if (isOnlyTranslational) return new Bounds(bounds.center+translation,bounds.size);
 var corners=Pathfinding.Pooling.ArrayPool<Vector3>.Claim(8);
 var c=bounds.center;var e=bounds.extents;
 corners[0]=Transform(new Vector3(c.x+e.x,c.y+e.y,c.z+e.z));
 corners[1]=Transform(new Vector3(c.x+e.x,c.y+e.y,c.z-e.z));
 corners[2]=Transform(new Vector3(c.x+e.x,c.y-e.y,c.z+e.z));
 corners[3]=Transform(new Vector3(c.x+e.x,c.y-e.y,c.z-e.z));
 corners[4]=Transform(new Vector3(c.x-e.x,c.y+e.y,c.z+e.z));
 corners[5]=Transform(new Vector3(c.x-e.x,c.y+e.y,c.z-e.z));
 corners[6]=Transform(new Vector3(c.x-e.x,c.y-e.y,c.z+e.z));
 corners[7]=Transform(new Vector3(c.x-e.x,c.y-e.y,c.z-e.z));
 var min=corners[0];var max=corners[0];
 for (int i=1;i<8;i++) {
  var p=corners[i];
  min.x=p.x>min.x?min.x:p.x;min.y=p.y>min.y?min.y:p.y;
  max.x=max.x>p.x?max.x:p.x;
  min.z=min.z<p.z?min.z:p.z;
  max.y=max.y>p.y?max.y:p.y;
  max.z=max.z>p.z?max.z:p.z;
 }
 Pathfinding.Pooling.ArrayPool<Vector3>.Release(ref corners);
 return new Bounds((max+min)*0.5f,max-min);
}

		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x44965F0", Offset = "0x44925F0", VA = "0x44965F0")]
		public Bounds InverseTransform(Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x4496968", Offset = "0x4492968", VA = "0x4496968", Slot = "4")]
Vector2 IMovementPlane.ToPlane(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x44969B8", Offset = "0x44929B8", VA = "0x44969B8", Slot = "5")]
Vector2 IMovementPlane.ToPlane(Vector3 point, out float elevation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GraphTransform.ToPlane RVA=0x44969B8 Token=0x60010A2");
}

		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x4496A04", Offset = "0x4492A04", VA = "0x4496A04", Slot = "6")]
Vector3 IMovementPlane.ToWorld(Vector2 point, float elevation)
		{
			return default;
		}

		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x4496A28", Offset = "0x4492A28", VA = "0x4496A28", Slot = "7")]
		public SimpleMovementPlane ToSimpleMovementPlane()
		{
			return default;
		}

		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x4496A44", Offset = "0x4492A44", VA = "0x4496A44")]
		public void CopyTo(MutableGraphTransform graphTransform)
		{
		}
	}
}
