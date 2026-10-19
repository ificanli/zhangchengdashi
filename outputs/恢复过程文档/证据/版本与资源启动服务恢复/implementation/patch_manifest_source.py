from pathlib import Path
source=Path(__file__).with_name('apply_bootstrap_sources.py').read_text(encoding='utf-8')
exec(compile(source.split("\nmodify('Assets/Scripts")[0],str(__file__)+':method-patcher','exec'))

modify('Assets/Scripts/GFRunning/GameFramework/Resources/PatchManifest.cs',[
 ('0x600733C','''            return RK_0099_0083r_00A3;'''),
 ('0x6007345','''            return _00BE_00BD_007C_00BDÂ_00BC;'''),
 ('0x600733F','''            if (string.IsNullOrEmpty(_0087_00AE_008D_00B2Ám))
            {
                CLog.R_00BD_00AFu_008Fe("清单文件为空");
                return;
            }
            string[] lines = _0087_00AE_008D_00B2Ám.Split('\u005cn');
            string[] header = lines[0].Split('|');
            ResourceVersion = System.Convert.ToInt32(header[0]);
            GFVersion = header[2];
            if (header.Length >= 4) { IsEncrypAB = true; RK_0099_0083r_00A3 = header[3]; }
            ResourceVersionData = header[1];
            for (int i = 1; i < lines.Length; ++i) _009DneB_009F_008A(lines[i]);'''),
 ('0x6007336','''            string[] fields = E_0096Yw_008F_009E.Split('|');
            if (fields.Length < 4) return;
            var element = new PatchElement();
            element.EName = fields[0];
            element.ObfuscatorName = fields[1];
            element.MD5 = fields[2];
            element.Size = System.Convert.ToUInt64(fields[3]);
            element.Version = fields.Length == 5 ? System.Convert.ToInt32(fields[4]) : ResourceVersion;
            _00BE_00BD_007C_00BDÂ_00BC.Add(element.EName, element);'''),
 ('0x600734B','''            return _00BE_00BD_007C_00BDÂ_00BC.TryGetValue(_00B4A_00A5_00AE_00A4_00B1, out _00B6_00AC_007D_00A8_00A2_008F);''')])
path=project/'Assets/Scripts/GFRunning/GameFramework/Resources/PatchManifest.cs'
text=path.read_text(encoding='utf-8')
old='private Dictionary<string, PatchElement> _00BE_00BD_007C_00BDÂ_00BC;'
assert text.count(old)==1
text=text.replace(old,old[:-1]+' = new Dictionary<string, PatchElement>();')
path.write_text(text,encoding='utf-8',newline='')
applied[-1]['afterSha256']=hashlib.sha256(path.read_bytes()).hexdigest()
(own/'patch-manifest-source-applied.json').write_text(json.dumps(applied,ensure_ascii=False,indent=2)+'\n',encoding='utf-8')
print('PATCH_MANIFEST_APPLIED')
