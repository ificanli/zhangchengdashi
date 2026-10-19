using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000243")]
	public interface IProp
	{
		[Token(Token = "0x60009B6")]
		void AddTempSpeed(float num);

		[Token(Token = "0x60009B7")]
		void ReduceTempSpeed(float num);

		[Token(Token = "0x60009B8")]
		void AddTempAttack(float num, bool haseff);

		[Token(Token = "0x60009B9")]
		void AddTempMiss(float num);

		[Token(Token = "0x60009BA")]
		void Shock(int damage, Vector3 pos, float shockDis);

		[Token(Token = "0x60009BB")]
		void AddImmediateHp(int num);

		[Token(Token = "0x60009BC")]
		void AddTempHp(float num);

		[Token(Token = "0x60009BD")]
		void AddTempAtkOffset(float num);

		[Token(Token = "0x60009BE")]
		void AddTempRange(float num);

		[Token(Token = "0x60009BF")]
		void AddTempBuildingDamageMultiplier(float percent);

		[Token(Token = "0x60009C0")]
		void ImmediateDead();

		[Token(Token = "0x60009C1")]
		void Charm(bool isCharm);
	}
}
