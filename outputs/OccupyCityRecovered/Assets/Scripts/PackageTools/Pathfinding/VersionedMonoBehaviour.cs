using Il2CppDummyDll;
using Pathfinding.Drawing;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000007")]
	public abstract class VersionedMonoBehaviour : MonoBehaviourGizmos, ISerializationCallbackReceiver, IVersionedMonoBehaviourInternal, IEntityIndex
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private int version;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x24")]
		private int Pathfinding_002EUtil_002EIEntityIndex_002EEntityIndex__BackingField;

		[Token(Token = "0x17000001")]
int IEntityIndex.EntityIndex
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x7838010", Offset = "0x7834010", VA = "0x7838010", Slot = "10")]
			get
			{
				return Pathfinding_002EUtil_002EIEntityIndex_002Eget_EntityIndex();
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x7838018", Offset = "0x7834018", VA = "0x7838018", Slot = "11")]
			set
			{
				Pathfinding_002EUtil_002EIEntityIndex_002Eset_EntityIndex(value);
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x7838010", Offset = "0x7834010", VA = "0x7838010", Slot = "10")]
		private int Pathfinding_002EUtil_002EIEntityIndex_002Eget_EntityIndex()
		{
			return default;
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x7838018", Offset = "0x7834018", VA = "0x7838018", Slot = "11")]
		private void Pathfinding_002EUtil_002EIEntityIndex_002Eset_EntityIndex(int value)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x7838020", Offset = "0x7834020", VA = "0x7838020", Slot = "12")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x7838148", Offset = "0x7834148", VA = "0x7838148", Slot = "13")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x7838194", Offset = "0x7834194", VA = "0x7838194")]
		private void DisableGizmosIcon()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x7838198", Offset = "0x7834198", VA = "0x7838198", Slot = "7")]
void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x783819C", Offset = "0x783419C", VA = "0x783819C", Slot = "8")]
void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x78381A4", Offset = "0x78341A4", VA = "0x78381A4")]
		protected void UpgradeSerializedData(bool isUnityThread)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x7838388", Offset = "0x7834388", VA = "0x7838388", Slot = "14")]
		protected virtual void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x7838430", Offset = "0x7834430", VA = "0x7838430", Slot = "9")]
void IVersionedMonoBehaviourInternal.UpgradeFromUnityThread()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x7838438", Offset = "0x7834438", VA = "0x7838438")]
		protected VersionedMonoBehaviour()
		{
		}
	}
}
