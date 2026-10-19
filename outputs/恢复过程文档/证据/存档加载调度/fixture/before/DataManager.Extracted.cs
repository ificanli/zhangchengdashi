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
		}
public UniTask LoadData()
		{
			return default;
		}
private void LoadAllSaveData()
		{
		}
public void StopAllSave()
		{
		}
}