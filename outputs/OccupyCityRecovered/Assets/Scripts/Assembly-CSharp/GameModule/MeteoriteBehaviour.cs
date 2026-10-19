using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000395")]
	public class MeteoriteBehaviour : MonoBehaviour
	{
		[Token(Token = "0x400260B")]
		[FieldOffset(Offset = "0x20")]
		private int _attack;

		[Token(Token = "0x400260C")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 _targetPos;

		[Token(Token = "0x400260D")]
		[FieldOffset(Offset = "0x30")]
		public bool isEnemy;

		[Token(Token = "0x400260E")]
		[FieldOffset(Offset = "0x31")]
		public bool GetToPos;

		[Token(Token = "0x400260F")]
		[FieldOffset(Offset = "0x38")]
		private Tweener tw;

		[Token(Token = "0x4002610")]
		[FieldOffset(Offset = "0x40")]
		private EntityBase fireObj;

		[Token(Token = "0x6001026")]
		[Address(RVA = "0x3D9D5E0", Offset = "0x3D995E0", VA = "0x3D9D5E0")]
		public void InitInfo(Transform obj, int attack, bool isEnemy, EntityBase fireObj)
		{
		}

		[Token(Token = "0x6001027")]
		[Address(RVA = "0x3D9D804", Offset = "0x3D99804", VA = "0x3D9D804")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6001028")]
		[Address(RVA = "0x3D9D814", Offset = "0x3D99814", VA = "0x3D9D814")]
		public MeteoriteBehaviour()
		{
		}
	}
}
