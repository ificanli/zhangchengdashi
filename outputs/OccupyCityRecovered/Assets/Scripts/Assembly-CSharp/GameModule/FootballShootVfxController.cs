using Il2CppDummyDll;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x200022C")]
	public class FootballShootVfxController : MonoBehaviour
	{
		[Token(Token = "0x4001DC8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bgStarEffect;

		[Token(Token = "0x4001DC9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _sightEffect;

		[Token(Token = "0x4001DCA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _ballTrailEffect;

		[Token(Token = "0x4001DCB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _goalFeedbackEffect;

		[Token(Token = "0x4001DCC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _saveFeedbackEffect;

		[Token(Token = "0x4001DCD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _keeperLandDustEffect;

		[Token(Token = "0x4001DCE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _sightFollowTarget;

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x428D61C", Offset = "0x428961C", VA = "0x428D61C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x428D640", Offset = "0x4289640", VA = "0x428D640")]
		private void EnsureEffectReferences()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x428D7B0", Offset = "0x42897B0", VA = "0x428D7B0")]
		private GameObject FindEffectRoot(string effectName)
		{
			return null;
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x428D888", Offset = "0x4289888", VA = "0x428D888")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x428D974", Offset = "0x4289974", VA = "0x428D974")]
		public void BindSightFollowTarget(Transform sightTransform)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x428D7A4", Offset = "0x42897A4", VA = "0x428D7A4")]
		public void SetBackgroundActive(bool active)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x428A7DC", Offset = "0x42867DC", VA = "0x428A7DC")]
		public void SetSightEffectActive(bool active)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x428A7FC", Offset = "0x42867FC", VA = "0x428A7FC")]
		public void SetBallTrailActive(bool active)
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x4289B68", Offset = "0x4285B68", VA = "0x4289B68")]
		public void PlayGoalFeedback(Vector3 worldPosition)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x428DB18", Offset = "0x4289B18", VA = "0x428DB18")]
		public void PlaySaveFeedback(Vector3 worldPosition)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x428DB20", Offset = "0x4289B20", VA = "0x428DB20")]
		public void PlayKeeperLandDust(Vector3 worldPosition)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x428D774", Offset = "0x4289774", VA = "0x428D774")]
		public void ResetRoundEffects()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x428D88C", Offset = "0x428988C", VA = "0x428D88C")]
		private void SyncSightEffectPosition()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x428D97C", Offset = "0x428997C", VA = "0x428D97C")]
		private static void SetLoopEffectActive(GameObject effect, bool active)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x428DA34", Offset = "0x4289A34", VA = "0x428DA34")]
		private static void PlayOneShotEffect(GameObject effect, Vector3 worldPosition)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x428DB28", Offset = "0x4289B28", VA = "0x428DB28")]
		private static void StopOneShotEffect(GameObject effect)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x428DBBC", Offset = "0x4289BBC", VA = "0x428DBBC")]
		private static void RestartParticleSystems(GameObject root)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x428DD98", Offset = "0x4289D98", VA = "0x428DD98")]
		public FootballShootVfxController()
		{
		}
	}
}
