using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200002E")]
	public abstract class GPUInstancerTerrainManager : GPUInstancerManager
	{
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Terrain _terrain;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public List<Terrain> additionalTerrains;

		[NonSerialized]
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0xC8")]
		protected List<Terrain> _terrains;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0xD0")]
		public GPUInstancerTerrainSettings terrainSettings;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0xD8")]
		protected bool replacingInstances;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0xD9")]
		protected bool initalizingInstances;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0xDA")]
		protected bool _requiresTerrainUpdate;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0xE0")]
		private Queue<Terrain> _terrainsToAdd;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0xE8")]
		private Queue<Terrain> _terrainsToRemove;

		[Token(Token = "0x17000014")]
		public Terrain terrain
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x73D7714", Offset = "0x73D3714", VA = "0x73D7714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x73D77BC", Offset = "0x73D37BC", VA = "0x73D77BC", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x73D7B6C", Offset = "0x73D3B6C", VA = "0x73D7B6C", Slot = "7")]
		public override void Update()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x73D7D3C", Offset = "0x73D3D3C", VA = "0x73D7D3C", Slot = "9")]
		public override void OnDestroy()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x73D7D44", Offset = "0x73D3D44", VA = "0x73D7D44", Slot = "10")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x73D7E64", Offset = "0x73D3E64", VA = "0x73D7E64", Slot = "22")]
		public virtual void SetupManagerWithTerrain(Terrain terrain)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x73D81FC", Offset = "0x73D41FC", VA = "0x73D81FC")]
		public GPUInstancerTerrainProxy AddProxyToTerrain()
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x73D801C", Offset = "0x73D401C", VA = "0x73D801C")]
		private GPUInstancerTerrainSettings GenerateTerrainSettings(Terrain terrain, GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x73D8204", Offset = "0x73D4204", VA = "0x73D8204")]
		private static void RemoveTerrainSettings(GPUInstancerTerrainSettings terrainSettings)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x73D8208", Offset = "0x73D4208", VA = "0x73D8208", Slot = "23")]
		public virtual void UpdateTerrains()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x73D8214", Offset = "0x73D4214", VA = "0x73D8214", Slot = "24")]
		public virtual void AddTerrain(Terrain newTerrain)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x73D82B4", Offset = "0x73D42B4", VA = "0x73D82B4", Slot = "25")]
		public virtual void RemoveTerrain(Terrain terrainToRemove)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x73D8354", Offset = "0x73D4354", VA = "0x73D8354")]
		public List<Terrain> GetTerrains()
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x73D835C", Offset = "0x73D435C", VA = "0x73D835C")]
		protected GPUInstancerTerrainManager()
		{
		}
	}
}
