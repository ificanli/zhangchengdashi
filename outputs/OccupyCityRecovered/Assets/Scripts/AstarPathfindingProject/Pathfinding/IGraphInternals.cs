using Il2CppDummyDll;
using Pathfinding.Serialization;

namespace Pathfinding
{
	[Token(Token = "0x20000DB")]
	public interface IGraphInternals
	{
		[Token(Token = "0x17000166")]
		string SerializedEditorSettings
		{
			[Token(Token = "0x6000740")]
			get;
			[Token(Token = "0x6000741")]
			set;
		}

		[Token(Token = "0x6000742")]
		void OnDestroy();

		[Token(Token = "0x6000743")]
		void DisposeUnmanagedData();

		[Token(Token = "0x6000744")]
		void DestroyAllNodes();

		[Token(Token = "0x6000745")]
		IGraphUpdatePromise ScanInternal(bool async);

		[Token(Token = "0x6000746")]
		void SerializeExtraInfo(GraphSerializationContext ctx);

		[Token(Token = "0x6000747")]
		void DeserializeExtraInfo(GraphSerializationContext ctx);

		[Token(Token = "0x6000748")]
		void PostDeserialization(GraphSerializationContext ctx);
	}
}
