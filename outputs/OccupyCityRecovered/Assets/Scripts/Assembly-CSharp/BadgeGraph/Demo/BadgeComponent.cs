using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace BadgeGraph.Demo
{
	[Token(Token = "0x2000E0E")]
	public class BadgeComponent : MonoBehaviour
	{
		[Token(Token = "0x40061FB")]
		[FieldOffset(Offset = "0x20")]
		[Header("Main")]
		[SerializeField]
		private BadgeType m_BadgeType;

		[Token(Token = "0x40061FC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_ShowNumber;

		[Token(Token = "0x40061FD")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool m_InvokeEnable;

		[Token(Token = "0x40061FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text m_NameText;

		[Token(Token = "0x40061FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Badge Point")]
		private GameObject m_PointObj;

		[Token(Token = "0x4006200")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text m_PointText;

		[Token(Token = "0x4006201")]
		[FieldOffset(Offset = "0x40")]
		[Header("Control Buttons")]
		[SerializeField]
		private Button m_AddPointButton;

		[Token(Token = "0x4006202")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button m_SubPointButton;

		[Token(Token = "0x4006203")]
		[FieldOffset(Offset = "0x50")]
		[Header("Line")]
		[SerializeField]
		private Transform m_LineParent;

		[Token(Token = "0x4006204")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image m_LineImg;

		[Token(Token = "0x4006205")]
		[FieldOffset(Offset = "0x60")]
		private string m_BadgeName;

		[Token(Token = "0x60056C0")]
		[Address(RVA = "0x43403DC", Offset = "0x433C3DC", VA = "0x43403DC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60056C1")]
		[Address(RVA = "0x43404BC", Offset = "0x433C4BC", VA = "0x43404BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60056C2")]
		[Address(RVA = "0x4340900", Offset = "0x433C900", VA = "0x4340900")]
		private void OnBadgePointChanged(BadgeNode node)
		{
		}

		[Token(Token = "0x60056C3")]
		[Address(RVA = "0x43409A0", Offset = "0x433C9A0", VA = "0x43409A0")]
		private void OnAddButtonClick()
		{
		}

		[Token(Token = "0x60056C4")]
		[Address(RVA = "0x43409C0", Offset = "0x433C9C0", VA = "0x43409C0")]
		private void OnSubButtonClick()
		{
		}

		[Token(Token = "0x60056C5")]
		[Address(RVA = "0x43406BC", Offset = "0x433C6BC", VA = "0x43406BC")]
		private void SetLine()
		{
		}

		[Token(Token = "0x60056C6")]
		[Address(RVA = "0x43409EC", Offset = "0x433C9EC", VA = "0x43409EC")]
		private float GetAngle(Vector3 start, Vector3 target)
		{
			return default;
		}

		[Token(Token = "0x60056C7")]
		[Address(RVA = "0x4340B9C", Offset = "0x433CB9C", VA = "0x4340B9C")]
		private void SetLineSize(float size, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x60056C8")]
		[Address(RVA = "0x4340C44", Offset = "0x433CC44", VA = "0x4340C44")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60056C9")]
		[Address(RVA = "0x4340CCC", Offset = "0x433CCCC", VA = "0x4340CCC")]
		public BadgeComponent()
		{
		}
	}
}
