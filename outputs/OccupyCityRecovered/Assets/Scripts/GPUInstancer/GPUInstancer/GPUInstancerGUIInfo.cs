using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000066")]
	public class GPUInstancerGUIInfo : MonoBehaviour
	{
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x20")]
		public bool showRenderedAmount;

		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x21")]
		public bool showPrototypesSeparate;

		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x22")]
		public bool showPrefabManagers;

		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x23")]
		public bool showDetailManagers;

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x24")]
		public bool showTreeManagers;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x0")]
		private static List<GPUInstancerRuntimeData> singlesList;

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x73FBECC", Offset = "0x73F7ECC", VA = "0x73FBECC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x73FC9F8", Offset = "0x73F89F8", VA = "0x73FC9F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x73FC5D4", Offset = "0x73F85D4", VA = "0x73FC5D4")]
		private static void DebugOnManagerGUI(string name, List<GPUInstancerRuntimeData> runtimeDataList, bool showRenderedAmount, int startPos, int enabledCount)
		{
		}

		[Token(Token = "0x6000293")]
		private static string GetRenderedAmountsGUITextFromArgs<T>(List<T> runtimeData, bool isShadow = false) where T : GPUInstancerRuntimeData
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x73FCA5C", Offset = "0x73F8A5C", VA = "0x73FCA5C")]
		public GPUInstancerGUIInfo()
		{
		}
	}
}
