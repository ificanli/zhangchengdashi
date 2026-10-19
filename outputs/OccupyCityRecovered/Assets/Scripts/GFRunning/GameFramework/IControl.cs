using Il2CppDummyDll;

namespace GameFramework
{
	[Token(Token = "0x200037F")]
	public interface IControl
	{
		[Token(Token = "0x17001123")]
		bool ActiveUpdate
		{
			[Token(Token = "0x6005A61")]
			get;
			[Token(Token = "0x6005A62")]
			set;
		}

		[Token(Token = "0x6005A63")]
		void OnInit();

		[Token(Token = "0x6005A64")]
		void Updata(float _008EJ_0092_009BUc, float rfjÀ_0098L);

		[Token(Token = "0x6005A65")]
		void OnDispose();
	}
}
