from pathlib import Path
import hashlib
import json

root=Path(__file__).resolve().parents[2]
project=root/'outputs/OccupyCityRecovered'
own=Path(__file__).resolve().parent
applied=[]

def modify(relative,changes,addition=''):
    path=project/relative;raw=path.read_bytes();text=raw.decode('utf-8')
    backup=own/'source-before'/relative;backup.parent.mkdir(parents=True,exist_ok=True)
    if not backup.exists(): backup.write_bytes(raw)
    for token,body in changes:
        marker='[Token(Token = "'+token+'")'
        start=text.index(marker)
        opening=text.index('{',start)
        level=1;end=opening+1
        while level:
            if text[end]=='{':level+=1
            elif text[end]=='}':level-=1
            end+=1
        text=text[:opening]+'{\n'+body+'\n\t\t}'+text[end:]
    if addition:
        position=text.rfind('\n\t}')
        assert position>0
        text=text[:position]+'\n'+addition+text[position:]
    path.write_text(text,encoding='utf-8',newline='')
    applied.append({'path':relative,'beforeSha256':hashlib.sha256(backup.read_bytes()).hexdigest(),'afterSha256':hashlib.sha256(path.read_bytes()).hexdigest(),'tokens':[t for t,_ in changes]})

modify('Assets/Scripts/GFRunning/UpdateManager.cs',[
 ('0x6000418','''            if (O_00BEªA_00BE_007C == null)
            {
                GameObject host = GameObject.Find("UpdateManager");
                if (host == null) { host = new GameObject(); host.name = "UpdateManager"; }
                O_00BEªA_00BE_007C = host.GetComponent<UpdateManager>();
                if (O_00BEªA_00BE_007C == null) O_00BEªA_00BE_007C = host.AddComponent<UpdateManager>();
                UnityEngine.Object.DontDestroyOnLoad(host);
            }
            return O_00BEªA_00BE_007C;'''),
 ('0x6000420','''            _008C_00B4cx_009B_00AE = new List<int>();
            _00A8S_0098_0092Q_009B = new List<UpdateHandle>();
            _00A1_0098Á_00B6b_00B3 = new Dictionary<int, UpdateData>();
            B_0090rE_00AC_007D = 16;''')])

modify('Assets/Scripts/GFRunning/GameFramework/AppSetting.cs',[
 ('0x6005187','''            if (string.IsNullOrEmpty(_00A5ªj_007DEv))
            {
                string[] parts = UnityEngine.Application.dataPath.Split('/');
                _00A5ªj_007DEv = parts[parts.Length - 2];
            }
            return _00A5ªj_007DEv;'''),
 ('0x600518A','''            _00A5ªj_007DEv = value;''')])

modify('Assets/Scripts/GFRunning/GameFramework/VersionMondule.cs',[
 ('0x60060DA','''            return 130;'''),
 ('0x60060DB','''#if UNITY_EDITOR
            if (_recoveryInitializationFailure != null)
                throw new System.InvalidOperationException("VersionMondule Editor initialization previously failed.", _recoveryInitializationFailure);
#endif
            if (x_0080_008D_00B1f_0086)
            {
#if UNITY_EDITOR
                GameFramework.Recovery.LocalEditorResourceBridge.RequireReady();
#endif
                Àª_00A6_00A3_00BDE?.Invoke();
                return;
            }
            if (AppSetting.UseNewRes) InitForNewRes();
            else UpdateManager.Instance.StartCoroutine(Init());'''),
 ('0x60060DC','''            UpdateManager.Instance.StartCoroutine(Init());'''),
 ('0x60060DD','''#if UNITY_EDITOR
            return GameFramework.Recovery.LocalEditorResourceBridge.Guard(InitializeLocalEditor(), error => _recoveryInitializationFailure = error);
#else
            throw new System.NotSupportedException("Original VersionMondule native SDK/update/delivery state machine is not restored for this platform. Editor uses the explicit LocalEditorResourcesProvider.");
#endif'''),
 ('0x60060E0','''#if UNITY_EDITOR
            GameFramework.Recovery.LocalEditorResourceBridge.RequireReady();
#endif
            if (CurrBundleServices == null) throw new System.InvalidOperationException("No real parsed bundle services were installed before version completion.");
            if (!AppSetting.UseNewRes) GameFrameEntry.GetModule<GameFramework.Resources.ResourcesModule>().bundleServices = CurrBundleServices;
            x_0080_008D_00B1f_0086 = true;
            UnityEngine.Debug.Log("初始化VersionMondule完成 [LocalEditorResourcesProvider]");
            Àª_00A6_00A3_00BDE?.Invoke();'''),
 ('0x60060E5','''            googleDeliveryRootPath = string.Empty;''')],'''
        [Token(Token = "0x60060E6")]
        [Address(RVA = "0x71EBB24", Offset = "0x71E7B24", VA = "0x71EBB24")]
        static VersionMondule() { cashABResInfo = new Dictionary<string, IBundleServices>(); }
#if UNITY_EDITOR
        private System.Exception _recoveryInitializationFailure;
        private IEnumerator InitializeLocalEditor()
        {
            string applicationName = AppSetting.MineGameName;
            yield return GameFramework.Recovery.LocalEditorResourceBridge.Initialize(applicationName);
            var provider = GameFramework.Recovery.LocalEditorResourceBridge.RequireReady();
            CurrBundleServices = provider.BundleServices;
            if (cashABResInfo.TryGetValue(applicationName, out IBundleServices existing))
            {
                if (!object.ReferenceEquals(existing, CurrBundleServices))
                    throw new System.InvalidOperationException("A different bundle service is already cached for " + applicationName);
            }
            else cashABResInfo.Add(applicationName, CurrBundleServices);
            SetAssetBundleURL();
        }
#endif
''')

modify('Assets/Scripts/GFRunning/GameFramework/AssetbundleModule.cs',[
 ('0x6005366','''#if UNITY_EDITOR
            if (_recoveryInitializationFailure != null)
                throw new InvalidOperationException("AssetbundleModule Editor initialization previously failed.", _recoveryInitializationFailure);
            GameFramework.Recovery.LocalEditorResourceBridge.RequireReady();
            if (x_0080_008D_00B1f_0086) { Àª_00A6_00A3_00BDE?.Invoke(); return; }
            dicSprites = new Dictionary<string, Sprite>();
            dicTexture2D = new Dictionary<string, Texture2D>();
            UpdateManager.Instance.StartCoroutine(GameFramework.Recovery.LocalEditorResourceBridge.Guard(LoadManifest(), error => _recoveryInitializationFailure = error));
#else
            throw new NotSupportedException("Original AssetbundleModule native AssetBundle manager/manifest I/O is not restored on this platform.");
#endif'''),
 ('0x6005367','''#if UNITY_EDITOR
            return InitializeEditorBackend();
#else
            throw new NotSupportedException("Original native manifest loading is not restored; no manifest success is returned.");
#endif''')],'''
#if UNITY_EDITOR
        private Exception _recoveryInitializationFailure;
        private IEnumerator InitializeEditorBackend()
        {
            GameFramework.Recovery.LocalEditorResourceBridge.RequireReady();
            // The explicit platform provider has already performed actual typed
            // loads. This does not manufacture a native AssetBundleManifest.
            x_0080_008D_00B1f_0086 = true;
            yield return 0;
            yield return 0;
            UnityEngine.Debug.Log("AssetbundleModule初始化完成 [LocalEditorResourcesProvider; native Android bundle backend not selected]");
            Àª_00A6_00A3_00BDE?.Invoke();
        }
#endif
''')

modify('Assets/Scripts/GFRunning/GameFramework/Resources/ResourcesModule.cs',[
 ('0x60073F5','''#if UNITY_EDITOR
            if (_recoveryInitializationFailure != null)
                throw new InvalidOperationException("ResourcesModule Editor initialization previously failed; the original early ready flag is not accepted as success.", _recoveryInitializationFailure);
            GameFramework.Recovery.LocalEditorResourceBridge.RequireReady();
            if (x_0080_008D_00B1f_0086) { Àª_00A6_00A3_00BDE?.Invoke(); return; }
            try
            {
                if (bundleServices == null) throw new InvalidOperationException("Version initialization did not install real IBundleServices.");
                m_ResMonoObj = new GameObject("ResourcesMono", typeof(ResourcesMono));
                m_ResMono = m_ResMonoObj.GetComponent<ResourcesMono>();
                x_0080_008D_00B1f_0086 = true;
                BundleAssetInfo firstPack = bundleServices.GetAssetBundleInfo("firstpack.unity3d");
                if (firstPack == null || firstPack.BundleName != "firstpack.unity3d")
                    throw new InvalidOperationException("The actual firstpack lookup did not preserve the requested bundle Name.");
                if (!string.IsNullOrEmpty(firstPack.LocalPath))
                    throw new NotSupportedException("This APK declares a real firstpack; its actual typed loading must be implemented before completing ResourcesModule.");
                UnityEngine.Debug.Log("ResourcesModule初始化完成 [LocalEditorResourcesProvider; original manifest has no firstpack.unity3d]");
                Àª_00A6_00A3_00BDE?.Invoke();
            }
            catch (Exception exception) { _recoveryInitializationFailure = exception; throw; }
#else
            throw new NotSupportedException("Original ResourcesModule native bundle/firstpack initialization is not restored for this platform.");
#endif'''),
 ('0x60073FF','''            return _LoadAsset(assetBundleName + ".prefab", handler, Args);'''),
 ('0x6007400','''            return _LoadAsset(assetBundleName, handler, Args);'''),
 ('0x6007403','''            if (assetBundleName == null) throw new ArgumentNullException(nameof(assetBundleName));
            return Load(assetBundleName.ToLower() + ".unity3d", 0, handler, Args);'''),
 ('0x6007405','''#if UNITY_EDITOR
            GameFramework.Recovery.LocalEditorResourceBridge.RequireReady();
            var loader = new GameFramework.Recovery.LocalEditorResLoader(this, bundleName, handler, Args);
            _recoveryEditorQueue.Enqueue(loader);
            return loader;
#else
            throw new NotSupportedException("The original native resource loader queue has not been restored.");
#endif'''),
 ('0x600741D','''            _requestRemain = 100;
            _requestQueue = new List<ResLoader>();
            _nonCompleteLoaderSet = new HashSet<ResLoader>();
            _currentLoadQueue = new HashSet<ResLoader>();
            _loaderCache = new Dictionary<string, ResLoader>();
            _loadedAssetBundle = new Dictionary<string, ResourcesInfo>();
            dicDownLoderById = new Dictionary<int, BundleAssetInfo>();
            dicDownLoderByName = new Dictionary<string, BundleAssetInfo>();''')],'''
#if UNITY_EDITOR
        private Exception _recoveryInitializationFailure;
        private readonly Queue<GameFramework.Recovery.LocalEditorResLoader> _recoveryEditorQueue = new Queue<GameFramework.Recovery.LocalEditorResLoader>();
#endif
''')

# ResourcesModule.Update token is resolved separately from the exact existing declaration.
path=project/'Assets/Scripts/GFRunning/GameFramework/Resources/ResourcesModule.cs'
text=path.read_text(encoding='utf-8')
import re
match=re.search(r'\[Token\(Token = "(0x[0-9A-F]+)"\)\]\s*\[Address[^\n]*\]\s*internal override void Update\(float elapseSeconds, float realElapseSeconds\)',text)
assert match
start=text.index('{',match.end());end=text.index('}',start)+1
body='''{
#if UNITY_EDITOR
            if (_recoveryInitializationFailure != null) throw new InvalidOperationException("ResourcesModule is in a failed Editor state.", _recoveryInitializationFailure);
            while (_recoveryEditorQueue.Count != 0) _recoveryEditorQueue.Dequeue().CompleteActualLoad();
#else
            throw new NotSupportedException("Original ResourcesModule loader queue Update is not restored on this platform.");
#endif
        }'''
text=text[:start]+body+text[end:];path.write_text(text,encoding='utf-8',newline='')
applied[-1]['tokens'].append(match[1]);applied[-1]['afterSha256']=hashlib.sha256(path.read_bytes()).hexdigest()

modify('Assets/Scripts/GFRunning/GameFramework/Resources/ResourcesInfo.cs',[
 ('0x60073BC','''#if UNITY_EDITOR
            if (this is GameFramework.Recovery.LocalEditorResourcesInfo local) return local.LoadTyped<T>(_00AE_008C_009AiPJ);
#endif
            throw new System.NotSupportedException("Original ResourcesInfo native bundle LoadAsset<T> is not restored for this resource source.");'''),
 ('0x60073E5','''#if UNITY_EDITOR
            if (this is GameFramework.Recovery.LocalEditorResourcesInfo local) return local.Instantiate(_00B4M_0088_005B_0087_0093, z_0094X_00A2_009C_0083);
#endif
            throw new System.NotSupportedException("Original ResourcesInfo native bundle Instantiate is not restored for this resource source.");''')])

(own/'bootstrap-source-applied.json').write_text(json.dumps(applied,ensure_ascii=False,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'files':len(applied),'status':'applied; actual compile and runtime checks pending'},ensure_ascii=True))
