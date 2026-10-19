using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using ToolModule;
using DataModule;
namespace UIFramework {
public class UIManager : ManagerBase<UIManager> {
public Transform _panelsParent;
private Dictionary<string, UIPanel> _uiPanelsDict;
public bool initcomplete;
public override async Task Init()
{
			_uiPanelsDict = new Dictionary<string, UIPanel>();
			_panelsParent = new GameObject("UIPanelsRoot").transform;
			initcomplete = true;
		}
public async Task<UIPanel> GetPanel(string panelPath)
{
			if (_uiPanelsDict.ContainsKey(panelPath))
			    return _uiPanelsDict[panelPath];
			return await LoadPanel(panelPath);
		}
private async Task<UIPanel> LoadPanel(string panelPath)
{
			GameObject prefab = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(panelPath);
			if (_uiPanelsDict.TryGetValue(panelPath, out UIPanel cachedPanel))
			    return cachedPanel;
			if (prefab)
			{
			    UIPanel panel = UnityEngine.Object.Instantiate(prefab, _panelsParent).GetComponent<UIPanel>();
			    if (panel)
			    {
			        panel.name = panel.name.Replace("(Clone)", string.Empty);
			        panel.gameObject.SetActive(false);
			        _uiPanelsDict.Add(panelPath, panel);
			        if (panel.transform.TryGetComponent(out Canvas canvas))
			        {
			            canvas.renderMode = RenderMode.ScreenSpaceCamera;
			            canvas.worldCamera = CameraModule.CameraManager.Instance.UICamera;
			            DataModule.PanelConfig config = DataModule.DataManager.Instance.GlobalInfo.panelConfigs.Find(item => item.panelName == panel.name);
			            if (config != null)
			                canvas.sortingOrder = config.layer;
			            else
			                UnityEngine.Debug.LogError("\u8fd9\u4e2a\u9875\u9762\u6ca1\u6709\u5728PanelConfig\u8868\u4e2d\u914d\u7f6e\uff0c\u5fc5\u987b\u8981\u914d\u7f6e=>" + panelPath);
			            panel.Init(config);
			        }
			    }
			    else
			        UnityEngine.Debug.LogError("UIManager.GetPanel()==> " + panelPath + "\u9884\u5236\u4f53\u4e0a,\u6ca1\u6709\u6302\u8f7d\u5bf9\u5e94\u7684Panel\u811a\u672c");
			    return panel;
			}
			return null;
		}
}
public class UIPanel : MonoBehaviour {
private PanelConfig panelConfig;
public void Init(PanelConfig panelConfig)
{
			this.panelConfig = panelConfig;
		}
}
}