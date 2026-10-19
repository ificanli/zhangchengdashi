using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;

namespace DataModule
{
	[Token(Token = "0x2000E38")]
	public interface IGlobalAssetsInfo
	{
		[Token(Token = "0x17000EC4")]
		string Id
		{
			[Token(Token = "0x600576B")]
			get;
		}

		[Token(Token = "0x17000EC5")]
		float IconScale
		{
			[Token(Token = "0x600576C")]
			get;
		}

		[Token(Token = "0x17000EC6")]
		Vector2 IconArchPosition
		{
			[Token(Token = "0x600576D")]
			get;
		}

		[Token(Token = "0x17000EC7")]
		string Name
		{
			[Token(Token = "0x600576E")]
			get;
		}

		[Token(Token = "0x17000EC8")]
		string Des
		{
			[Token(Token = "0x600576F")]
			get;
		}

		[Token(Token = "0x17000EC9")]
		string Explain
		{
			[Token(Token = "0x6005770")]
			get;
		}

		[Token(Token = "0x17000ECA")]
		string RewardClass
		{
			[Token(Token = "0x6005771")]
			get;
		}

		[Token(Token = "0x17000ECB")]
		string UseClass
		{
			[Token(Token = "0x6005772")]
			get;
		}

		[Token(Token = "0x17000ECC")]
		int RareLevel
		{
			[Token(Token = "0x6005773")]
			get;
		}

		[Token(Token = "0x17000ECD")]
		GlobalAssetsType Type
		{
			[Token(Token = "0x6005774")]
			get;
		}

		[Token(Token = "0x17000ECE")]
		bool ShowBGImage
		{
			[Token(Token = "0x600577A")]
			get;
		}

		[Token(Token = "0x17000ECF")]
		bool ShowTypeImage
		{
			[Token(Token = "0x600577B")]
			get;
		}

		[Token(Token = "0x6005775")]
		UniTask<Sprite> GetIconSprite(int level = -1);

		[Token(Token = "0x6005776")]
		UniTask<SkeletonDataAsset> GetIconSpine(int level = -1);

		[Token(Token = "0x6005777")]
		UniTask<Sprite> GetBgIcon();

		[Token(Token = "0x6005778")]
		UniTask<Sprite> GetTypeIcon();

		[Token(Token = "0x6005779")]
		UniTask<Sprite> GetBg2Icon();
	}
}
