# 完整资料下载与恢复

Git仓库保存可查看的Unity工程源文件、资源、中文过程报告及交付脚本。全部原始分析现场以去重、逐文件SHA256可恢复的GitHub Release分卷保存。

仓库：`https://github.com/ificanli/zhangchengdashi.git`

Release标签：`recovery-checkpoint-2026-10-19`

**仅git clone不会下载Release附件。** 换电脑后请先克隆，再运行恢复脚本：

```powershell
git clone https://github.com/ificanli/zhangchengdashi.git
cd zhangchengdashi
python -m pip install -r "outputs/完整资料交付/requirements.txt"
python "outputs/完整资料交付/restore_all_materials.py"
```

脚本会下载分卷并校验SHA，流式解压实际内容，按`完整资料路径与哈希清单.json`恢复APK、原生库、IDA数据库、work中的脚本/候选/失败日志/测试证据/工具及备份。不覆盖内容已改变的现有文件。原路径相对工作区恢复；脚本中的旧电脑绝对路径可据当前克隆目录调整，原地址/Token/RVA证据保持。

约数十GB的原逻辑文件采用内容SHA去重，多个相同文件只上传一个blob，恢复时会回到全部原相对路径。Git已保存的相同内容用git-copy映射恢复，不以少传原始路径为代价。分卷属于同一tar.zst流，必须全部按编号连接后读取；恢复脚本自动处理。

Unity使用`2022.3.62f3c1`打开`outputs/OccupyCityRecovered`。Library/Temp/Logs及本机UserSettings可重建，不计为学习或恢复资料。虚拟环境、node_modules、嵌套Git元数据和电脑凭据/授权文件不交付；原google-services-desktop云配置不上传，避免把原包云API配置传播到公共仓库。所有排除项在`排除项说明.json`列明。

当前恢复已经按用户要求暂停，游戏尚未完整可玩。Main6实际观察45秒Error0，但frame/time停止推进并在Version资源启动门等待，结束后真实Provider取消收据已保存；地图、开格/占领和兵堆战斗没有验收。阅读[当前进度](../恢复过程文档/00-阅读导航与当前进度.md)和[运行验收](../恢复过程文档/10-Unity运行验收.md)，不要将编译或静态场景视为运行成功。

交付会附上`附件分卷清单.json`、全部路径/hash清单和上传验证结果。恢复前可以只下载校验：

```powershell
python "outputs/完整资料交付/restore_all_materials.py" --download-only
python "outputs/完整资料交付/restore_all_materials.py" --verify-only
```
