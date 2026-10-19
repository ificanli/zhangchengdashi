using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit.Demo.Scripts
{
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	public class AllIn1VfxParticleSystemTime : MonoBehaviour
	{
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool updateEveryFrame;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Header("If Y component is 0 X component will be used instead")]
		private Vector2 simulationTimeRange;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x30")]
		[Space]
		[Header("If null we search in this GameObject")]
		[SerializeField]
		private ParticleSystem targetPs;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x38")]
		private bool isValid;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x3CF220C", Offset = "0x3CEE20C", VA = "0x3CF220C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x3CF23A8", Offset = "0x3CEE3A8", VA = "0x3CF23A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x3CF23B8", Offset = "0x3CEE3B8", VA = "0x3CF23B8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x3CF2210", Offset = "0x3CEE210", VA = "0x3CF2210")]
		private void SetSimulationTime()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x3CF23BC", Offset = "0x3CEE3BC", VA = "0x3CF23BC")]
		public AllIn1VfxParticleSystemTime()
		{
		}
	}
}
