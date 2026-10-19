using System.Xml;
using Il2CppDummyDll;

namespace LocalizationModule
{
	[Token(Token = "0x20001CA")]
	public static class XmlExtend
	{
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x40813DC", Offset = "0x407D3DC", VA = "0x40813DC")]
		public static XmlNodeList GetXmlNodeList(this XmlDocument xml, string path, string rootName)
		{
			return null;
		}

		[Token(Token = "0x600074D")]
		public static T GetAttribute<T>(this XmlElement xe, string attribute_name)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED XmlExtend.GetAttribute RVA= Token=0x600074D");
}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x4081430", Offset = "0x407D430", VA = "0x4081430")]
		public static XmlDocument SaveToLocal(this XmlDocument xml, string name)
		{
			return null;
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x40814F4", Offset = "0x407D4F4", VA = "0x40814F4")]
		public static XmlElement CreateXmlElement(this XmlElement xe, XmlDocument xml, string name)
		{
			return null;
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x4081510", Offset = "0x407D510", VA = "0x4081510")]
		public static XmlElement XeSetAttribute(this XmlElement xe, string name, object value)
		{
			return null;
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x4081568", Offset = "0x407D568", VA = "0x4081568")]
		public static XmlElement AddTo(this XmlElement xe, XmlNode node)
		{
			return null;
		}
	}
}
