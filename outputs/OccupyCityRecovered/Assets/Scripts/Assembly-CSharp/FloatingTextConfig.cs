using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000099")]
[CreateAssetMenu(menuName = "DamageText/FloatingTextConfig")]
public class FloatingTextConfig : ScriptableObject
{
	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("文本的字体大小")]
	[Min(1f)]
	[Header("文本外观设置 (Text Appearance)")]
	public int fontSize;

	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x1C")]
	[Tooltip("文本的基础颜色（如暴击可由逻辑覆盖，此处为默认）")]
	public Color textColor;

	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x2C")]
	[Tooltip("字符间距：默认值为1，增大此值会拉开字符间的距离")]
	public float characterSpacing;

	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x30")]
	[Min(0f)]
	[Tooltip("描边宽度：0 表示无描边")]
	public float outlineWidth;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x34")]
	[Tooltip("描边颜色")]
	public Color outlineColor;

	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x44")]
	[Header("治疗飘字设置 (Heal Settings)")]
	[Tooltip("回血数字向上漂浮的速度 (数值越小飘得越低)")]
	public float healMoveSpeed;

	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x48")]
	[Header("弧线运动设置 (Arc Movement)")]
	[Tooltip("飘字存在的总生命周期（秒），超过此时间将被回收或销毁")]
	public float lifeTime;

	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x4C")]
	[Tooltip("水平扩散范围：飘字会随机向四周炸开的最大距离")]
	public float horizontalSpread;

	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x50")]
	[Tooltip("水平移动曲线：建议设为 'Fast Out, Slow In' (0->1，斜率逐渐变平)，模拟空气阻力")]
	public AnimationCurve spreadCurve;

	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x58")]
	[Tooltip("垂直跳跃高度：决定抛物线的最高点")]
	public float popMoveHeight;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x60")]
	[Tooltip("垂直运动曲线：关键！必须设为抛物线形状 (0 -> 1 -> <0)，模拟跳起落下")]
	public AnimationCurve popMoveCurve;

	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x68")]
	[Tooltip("是否启用出生时的缩放（弹跳）动画")]
	[Header("缩放动画 (Q-Bounce)")]
	public bool enableScaleAnimation;

	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x70")]
	[Tooltip("Q弹曲线：0s(0.2)->0.15s(1.6)->0.3s(1.0)，制造极速弹出的果冻感")]
	public AnimationCurve popScaleCurve;

	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public float scaleStartValue;

	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public float scaleEndValue;

	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public float scaleDuration;

	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x84")]
	[HideInInspector]
	public float moveSpeed;

	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x88")]
	[Header("淡入淡出设置 (Fade In/Out)")]
	[Tooltip("是否启用出生时的淡入效果")]
	public bool enableFadeIn;

	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x8C")]
	[Tooltip("淡入持续时间（秒）- 建议设短一点，配合瞬间爆发")]
	public float fadeInDuration;

	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x90")]
	[Tooltip("是否启用结束时的淡出效果")]
	public bool enableFadeOut;

	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x94")]
	[Tooltip("淡出持续时间（秒）")]
	public float fadeOutDuration;

	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x98")]
	[Tooltip("是否限制飘字在屏幕范围内")]
	[Header("屏幕边界检查 (Visibility)")]
	public bool checkScreenBounds;

	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x9C")]
	[Tooltip("屏幕边缘留白比例（0-0.5）")]
	[Range(0f, 0.5f)]
	public float screenMargin;

	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0xA0")]
	[Header("背景与进度条 (Background & Progress)")]
	[Tooltip("是否显示背景底板")]
	public bool showBackground;

	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0xA4")]
	[Tooltip("默认背景颜色（底板颜色）")]
	public Color defaultBackgroundColor;

	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0xB4")]
	[Tooltip("默认进度条颜色（实际血量颜色）")]
	public Color defaultProgressColor;

	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0xC4")]
	[Tooltip("背景底板的标准尺寸")]
	public Vector2 backgroundSize;

	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0xCC")]
	[Tooltip("背景内容的内边距")]
	public float backgroundPadding;

	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0xD0")]
	[Tooltip("进度条在 X 方向的缩进比例 (0-0.5)")]
	[Range(0f, 0.5f)]
	[Header("进度条缩进 (Progress Padding)")]
	public float progressPaddingX;

	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0xD4")]
	[Tooltip("进度条在 Y 方向的缩进比例 (0-0.5)")]
	[Range(0f, 0.5f)]
	public float progressPaddingY;

	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0xD8")]
	[Tooltip("进度条是否从左向右填充")]
	public bool progressFromLeft;

	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0xDC")]
	[Tooltip("圆角半径（像素值）。0表示直角，最大支持到14")]
	[Range(0f, 14f)]
	[Header("圆角样式 (Visual Style)")]
	public float cornerRadius;

	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0xE0")]
	[Header("幻影白条设置 (Ghost HP)")]
	[Tooltip("是否启用扣血时的白条缓冲效果")]
	public bool enableGhostHp;

	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0xE4")]
	[Tooltip("白条的颜色（通常为白色或亮灰色）")]
	public Color ghostColor;

	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0xF4")]
	[Tooltip("扣血后，白条停留不动的延迟时间（秒）")]
	public float ghostDelay;

	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0xF8")]
	[Tooltip("白条追赶真实血量的速度（数值越大追得越快）")]
	public float ghostSpeed;

	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0xFC")]
	[Tooltip("额外的Y轴偏移（屏幕空间），正值向上。常用于将血条或飘字整体上移")]
	[Header("位置偏移 (Position Offset)")]
	public float extraOffsetY;

	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x100")]
	[Tooltip("对象逻辑死亡后的延迟销毁时间（秒）")]
	[Header("死亡延迟 (Death Logic)")]
	public float deathDelayDuration;

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x3D273A4", Offset = "0x3D233A4", VA = "0x3D273A4")]
	public FloatingTextConfig()
	{
	}
}
