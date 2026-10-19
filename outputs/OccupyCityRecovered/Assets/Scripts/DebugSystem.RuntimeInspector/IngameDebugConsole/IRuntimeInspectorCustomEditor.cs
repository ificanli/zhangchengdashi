using Il2CppDummyDll;

namespace IngameDebugConsole
{
	[Token(Token = "0x200001E")]
	public interface IRuntimeInspectorCustomEditor
	{
		[Token(Token = "0x600014B")]
		void GenerateElements(ObjectField parent);

		[Token(Token = "0x600014C")]
		void Refresh();

		[Token(Token = "0x600014D")]
		void Cleanup();
	}
}
