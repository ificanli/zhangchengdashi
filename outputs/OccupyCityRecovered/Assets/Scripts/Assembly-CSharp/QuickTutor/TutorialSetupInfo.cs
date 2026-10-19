using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace QuickTutor
{
	[Serializable]
	[Token(Token = "0x2000C83")]
	public class TutorialSetupInfo
	{
		[Token(Token = "0x40059F9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected string id;

		[Token(Token = "0x40059FA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string nextId;

		[Token(Token = "0x40059FB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected string tutorialContent;

		[Token(Token = "0x40059FC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected float tutorialTextPos;

		[Token(Token = "0x40059FD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected float maskType;

		[Token(Token = "0x40059FE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected TutorialActionType tutorialActionType;

		[Token(Token = "0x40059FF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected List<string> maskPoints;

		[Token(Token = "0x4005A00")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected List<string> slideAnimPoints;

		[Token(Token = "0x4005A01")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected string startTriggerEvent;

		[Token(Token = "0x4005A02")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected string endTriggerEvent;

		[Token(Token = "0x4005A03")]
		public const float TransparentMask = 2f;

		[Token(Token = "0x4005A04")]
		public const float FullScreenBlackMask = 0f;

		[Token(Token = "0x17000E09")]
		public bool IsNeedMaskPoint
		{
			[Token(Token = "0x6004E83")]
			[Address(RVA = "0x42A728C", Offset = "0x42A328C", VA = "0x42A728C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000E0A")]
		public bool IsNeedSlidePoint
		{
			[Token(Token = "0x6004E84")]
			[Address(RVA = "0x42A72AC", Offset = "0x42A32AC", VA = "0x42A72AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000E0B")]
		public virtual string ID
		{
			[Token(Token = "0x6004E85")]
			[Address(RVA = "0x42A72BC", Offset = "0x42A32BC", VA = "0x42A72BC", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E86")]
			[Address(RVA = "0x42A72C4", Offset = "0x42A32C4", VA = "0x42A72C4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000E0C")]
		public virtual string NextId
		{
			[Token(Token = "0x6004E87")]
			[Address(RVA = "0x42A72CC", Offset = "0x42A32CC", VA = "0x42A72CC", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E88")]
			[Address(RVA = "0x42A72D4", Offset = "0x42A32D4", VA = "0x42A72D4", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000E0D")]
		public virtual string TutorialContent
		{
			[Token(Token = "0x6004E89")]
			[Address(RVA = "0x42A72DC", Offset = "0x42A32DC", VA = "0x42A72DC", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E8A")]
			[Address(RVA = "0x42A72E4", Offset = "0x42A32E4", VA = "0x42A72E4", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000E0E")]
		public virtual float TutorialTextPos
		{
			[Token(Token = "0x6004E8B")]
			[Address(RVA = "0x42A72EC", Offset = "0x42A32EC", VA = "0x42A72EC", Slot = "10")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E8C")]
			[Address(RVA = "0x42A72F4", Offset = "0x42A32F4", VA = "0x42A72F4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000E0F")]
		public virtual float MaskType
		{
			[Token(Token = "0x6004E8D")]
			[Address(RVA = "0x42A72FC", Offset = "0x42A32FC", VA = "0x42A72FC", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E8E")]
			[Address(RVA = "0x42A7304", Offset = "0x42A3304", VA = "0x42A7304", Slot = "13")]
			set
			{
				maskType = value;
			}
		}

		[Token(Token = "0x17000E10")]
		public virtual TutorialActionType TutorialActionType
		{
			[Token(Token = "0x6004E8F")]
			[Address(RVA = "0x42A730C", Offset = "0x42A330C", VA = "0x42A730C", Slot = "14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E90")]
			[Address(RVA = "0x42A7314", Offset = "0x42A3314", VA = "0x42A7314", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x17000E11")]
		public virtual List<string> MaskPoints
		{
			[Token(Token = "0x6004E91")]
			[Address(RVA = "0x42A731C", Offset = "0x42A331C", VA = "0x42A731C", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E92")]
			[Address(RVA = "0x42A7324", Offset = "0x42A3324", VA = "0x42A7324", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x17000E12")]
		public virtual List<string> SlideAnimPoints
		{
			[Token(Token = "0x6004E93")]
			[Address(RVA = "0x42A732C", Offset = "0x42A332C", VA = "0x42A732C", Slot = "18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E94")]
			[Address(RVA = "0x42A7334", Offset = "0x42A3334", VA = "0x42A7334", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000E13")]
		public virtual string StartTriggerEvent
		{
			[Token(Token = "0x6004E95")]
			[Address(RVA = "0x42A733C", Offset = "0x42A333C", VA = "0x42A733C", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E96")]
			[Address(RVA = "0x42A7344", Offset = "0x42A3344", VA = "0x42A7344", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000E14")]
		public virtual string EndTriggerEvent
		{
			[Token(Token = "0x6004E97")]
			[Address(RVA = "0x42A734C", Offset = "0x42A334C", VA = "0x42A734C", Slot = "22")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E98")]
			[Address(RVA = "0x42A7354", Offset = "0x42A3354", VA = "0x42A7354", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x6004E99")]
		[Address(RVA = "0x42A735C", Offset = "0x42A335C", VA = "0x42A735C")]
		public TutorialSetupInfo()
		{
		}

		[Token(Token = "0x6004E9A")]
		[Address(RVA = "0x42A7364", Offset = "0x42A3364", VA = "0x42A7364")]
		public TutorialSetupInfo(string id, string nextId, string tutorialContent, float tutorialTextPos, float maskType, TutorialActionType tutorialActionType, List<string> maskPoints, List<string> slideAnimPoints, string startTriggerEvent, string endTriggerEvent)
		{
		}
	}
}
