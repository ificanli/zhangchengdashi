using Il2CppDummyDll;

[Token(Token = "0x20000AF")]
public interface IAnimation
{
	[Token(Token = "0x17000030")]
	float attackSpeed
	{
		[Token(Token = "0x6000390")]
		get;
	}

	[Token(Token = "0x600038B")]
	void ChangeAnimatorSpeed(GPUInstanceAnimationBehaviour.AnimationName animationName, float speed);

	[Token(Token = "0x600038C")]
	float GetAnimatorSpeed(GPUInstanceAnimationBehaviour.AnimationName animationName);

	[Token(Token = "0x600038D")]
	GPUInstanceAnimationBehaviour.AnimationName GetCurrentAnimationName();

	[Token(Token = "0x600038E")]
	bool GetCurrentAnimationIs(GPUInstanceAnimationBehaviour.AnimationName animationName);

	[Token(Token = "0x600038F")]
	float GetAnimationLength(GPUInstanceAnimationBehaviour.AnimationName animationName);

	[Token(Token = "0x6000391")]
	void ResetState();

	[Token(Token = "0x6000392")]
	void SetAnimation(GPUInstanceAnimationBehaviour.AnimationName animationName);
}
