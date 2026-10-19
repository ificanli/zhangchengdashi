using Cysharp.Threading.Tasks;
public enum ComflictStatus { UseLocalData=0, UseServerData=1, CompareData=2 }
public class DataManager {
 public static bool SaveConflictCheckFinish;
 public static bool HasCheckedSaveConflict;
 public static ComflictStatus ComflictStatus;
 private bool loadConfigComplete;
 public bool LoadDataCompleted { get; private set; }
 public void FixtureConfig(bool value) { loadConfigComplete=value; }
 public void FixtureCompleted(bool value) { LoadDataCompleted=value; }
 public void FixtureLoadAll() { LoadAllSaveData(); }
public void ChooseConflict(ComflictStatus comflictStatus)
		{
			ComflictStatus = comflictStatus;
			SaveConflictCheckFinish = true;
		}
public async UniTask LoadData()
		{
			while (!loadConfigComplete)
			    await UniTask.WaitForSeconds(0.1f);
			LoadDataCompleted = false;
			while (!SaveConflictCheckFinish)
			    await UniTask.WaitForSeconds(0.1f);
			LoadAllSaveData();
			if (!DbtSaveDataManager_PlayerCoreData.I.Data.LoginSuccessfully)
			{
			    DbtSaveDataManager_PlayerCoreData.I.Data.LoginSuccessfully = true;
			    DbtSaveDataManager_PlayerCoreData.I.Save();
			}
			LoadDataCompleted = true;
		}
private void LoadAllSaveData()
		{
			DbtSaveDataManager_PlayerMainCityData.I.CanSave = true;
			DbtSaveDataManager_PlayerMainCityData.I.Load();
			DbtSaveDataManager_PlayerCardData.I.CanSave = true;
			DbtSaveDataManager_PlayerCardData.I.Load();
			DbtSaveDataManager_PlayerShopData.I.CanSave = true;
			DbtSaveDataManager_PlayerShopData.I.Load();
			DbtSaveDataManager_PlayerArenaData.I.CanSave = true;
			DbtSaveDataManager_PlayerArenaData.I.Load();
			DbtSaveDataManager_PlayerRankData.I.CanSave = true;
			DbtSaveDataManager_PlayerRankData.I.Load();
			DbtSaveDataManager_PlayerResourceData.I.CanSave = true;
			DbtSaveDataManager_PlayerResourceData.I.Load();
			DbtSaveDataManager_PlayerChestData.I.CanSave = true;
			DbtSaveDataManager_PlayerChestData.I.Load();
			DbtSaveDataManager_PlayerTimeData.I.CanSave = true;
			DbtSaveDataManager_PlayerTimeData.I.Load();
			DbtSaveDataManager_PlayerAdData.I.CanSave = true;
			DbtSaveDataManager_PlayerAdData.I.Load();
			DbtSaveDataManager_PlayerArtifactData.I.CanSave = true;
			DbtSaveDataManager_PlayerArtifactData.I.Load();
			DbtSaveDataManager_PlayerCustomizationData.I.CanSave = true;
			DbtSaveDataManager_PlayerCustomizationData.I.Load();
			DbtSaveDataManager_PlayerCoreData.I.CanSave = true;
			DbtSaveDataManager_PlayerCoreData.I.Load();
			DbtSaveDataManager_PlayerGuideData.I.CanSave = true;
			DbtSaveDataManager_PlayerGuideData.I.Load();
			DbtSaveDataManager_PlayerMysteryAdventureData.I.CanSave = true;
			DbtSaveDataManager_PlayerMysteryAdventureData.I.Load();
			DbtSaveDataManager_PlayerWorldCupActivityData.I.CanSave = true;
			DbtSaveDataManager_PlayerWorldCupActivityData.I.Load();
		}
public void StopAllSave()
		{
			DbtSaveDataManager_PlayerMainCityData.I.CanSave = false;
			DbtSaveDataManager_PlayerCardData.I.CanSave = false;
			DbtSaveDataManager_PlayerShopData.I.CanSave = false;
			DbtSaveDataManager_PlayerArenaData.I.CanSave = false;
			DbtSaveDataManager_PlayerRankData.I.CanSave = false;
			DbtSaveDataManager_PlayerResourceData.I.CanSave = false;
			DbtSaveDataManager_PlayerChestData.I.CanSave = false;
			DbtSaveDataManager_PlayerTimeData.I.CanSave = false;
			DbtSaveDataManager_PlayerAdData.I.CanSave = false;
			DbtSaveDataManager_PlayerArtifactData.I.CanSave = false;
			DbtSaveDataManager_PlayerCustomizationData.I.CanSave = false;
			DbtSaveDataManager_PlayerCoreData.I.CanSave = false;
			DbtSaveDataManager_PlayerGuideData.I.CanSave = false;
			DbtSaveDataManager_PlayerMysteryAdventureData.I.CanSave = false;
			DbtSaveDataManager_PlayerWorldCupActivityData.I.CanSave = false;
		}
}