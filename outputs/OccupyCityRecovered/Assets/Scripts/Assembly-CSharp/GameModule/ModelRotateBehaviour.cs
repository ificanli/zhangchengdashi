using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20003D3")]
	public class ModelRotateBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40026BA")]
		[FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x40026BB")]
		[FieldOffset(Offset = "0x24")]
		private bool isRotating;

		[Token(Token = "0x40026BC")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 initialMousePosition;

		[Token(Token = "0x40026BD")]
		[FieldOffset(Offset = "0x38")]
		private string _id;

		[Token(Token = "0x170000FE")]
		public bool isRotateSelf
		{
			[Token(Token = "0x6001137")]
			[Address(RVA = "0x3DAD73C", Offset = "0x3DA973C", VA = "0x3DAD73C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001138")]
		[Address(RVA = "0x3DAD8B0", Offset = "0x3DA98B0", VA = "0x3DAD8B0")]
		public void Init(string id)
		{
		}

		[Token(Token = "0x6001139")]
		[Address(RVA = "0x3DAD8B8", Offset = "0x3DA98B8", VA = "0x3DAD8B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600113A")]
		[Address(RVA = "0x3DADAD4", Offset = "0x3DA9AD4", VA = "0x3DADAD4")]
		public ModelRotateBehaviour()
		{
		}
	}
}
