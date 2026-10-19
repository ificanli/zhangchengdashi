using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x2000015")]
	public class UIOutlet : MonoBehaviour, IUIoutlet
	{
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x20")]
		public List<OutletInfo> OutletInfos;

		[Token(Token = "0x17000013")]
GameObject IUIoutlet.MgameObject
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x706A270", Offset = "0x7066270", VA = "0x706A270", Slot = "4")]
			get
			{
				return GameFramework_002EIUIoutlet_002Eget_MgameObject();
			}
		}

		[Token(Token = "0x17000014")]
List<OutletInfo> IUIoutlet.OutletInfos
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x706A278", Offset = "0x7066278", VA = "0x706A278", Slot = "5")]
			get
			{
				return GameFramework_002EIUIoutlet_002Eget_OutletInfos();
			}
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x706A270", Offset = "0x7066270", VA = "0x706A270", Slot = "4")]
		private GameObject GameFramework_002EIUIoutlet_002Eget_MgameObject()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x706A278", Offset = "0x7066278", VA = "0x706A278", Slot = "5")]
		private List<OutletInfo> GameFramework_002EIUIoutlet_002Eget_OutletInfos()
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x706A280", Offset = "0x7066280", VA = "0x706A280")]
		public UIOutlet()
		{
		}
	}
}
