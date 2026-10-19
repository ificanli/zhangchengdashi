using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200009A")]
[CreateAssetMenu(menuName = "DamageText/Font Config")]
public class FloatingTextFontConfig : ScriptableObject
{
	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Vector2 InvalidGlyphUv;

	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x18")]
	[Header("Texture Settings")]
	public Texture2D atlasTexture;

	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x20")]
	public int charsPerRow;

	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x24")]
	public int charWidth;

	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x28")]
	public int charHeight;

	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x30")]
	[Header("Character Sequence")]
	public string charSequence;

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x3D27750", Offset = "0x3D23750", VA = "0x3D27750")]
	public Vector2 GetCharUV(char c)
	{
		return default;
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x3D277FC", Offset = "0x3D237FC", VA = "0x3D277FC")]
	public FloatingTextFontConfig()
	{
	}
}
