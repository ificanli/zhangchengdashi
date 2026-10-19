import json
from pathlib import Path
w=Path('work/stage38-savebase')
paths=['Assets/Scripts/Assembly-CSharp/DbtSaveDataManagerBase.cs','Assets/Scripts/GFRunning/GameFramework/DataManagerBase.cs','Assets/Scripts/Assembly-CSharp/DataModule/PlayerTimeData.cs','Assets/Scripts/Assembly-CSharp/L_Tools/DataCompressTools.cs','Assets/Scripts/GFRunning/GameFramework/DataManagerPool.cs','Assets/Scripts/GFRunning/GameFramework/ModelRegister.cs','Assets/Scripts/GFRunning/----d-.cs','Assets/Scripts/GFRunning/GameFramework/Utility.cs']
(w/'owned-scope.json').write_text(json.dumps(dict(stage=38,productionWritesAuthorized=True,files=paths,limits={'----d-.cs':'Only original ctor and initialization body','Utility.cs':'Only nested AssemblyUtility original 3 methods','EditorAdapter':'Only local storage I/O in DataManagerBase, isolated task work path','external':'No emulator/user save data, no SDK/login/server flags or further ecosystem restoration'}),ensure_ascii=False,indent=2),encoding='utf-8')
