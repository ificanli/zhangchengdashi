using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor
{
	[Token(Token = "0x2000C86")]
	public interface ITutorialResourceManager
	{
		[Token(Token = "0x6004E9C")]
		BaseTutorialPanel GetTutorialPanel();

		[Token(Token = "0x6004E9D")]
		Camera GetMainCamera();

		[Token(Token = "0x6004E9E")]
		Camera GetUICamera();

		[Token(Token = "0x6004E9F")]
		List<TutorialSetupInfo> GetTutorialInfo();

		[Token(Token = "0x6004EA0")]
		bool IsComplete(string tutorialId);

		[Token(Token = "0x6004EA1")]
		void SetComplete(string tutorialId);

		[Token(Token = "0x6004EA2")]
		void SetUnComplete(string tutorialId);

		[Token(Token = "0x6004EA3")]
		Transform GetUIRootTransform();
	}
}
