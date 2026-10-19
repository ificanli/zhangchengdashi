# 52：四路整合、暂停与完整Git资料交付

当前恢复已按用户要求暂停。四个新窗口的结果已全部合入，额外战斗、存档、UI、默认数据和旧配置主键补齐也已落盘。**游戏尚未完整可玩，核心地图、开格/占领、兵堆战斗未验收。** 本报告记录本批整合和资料上传的实际完成情况，不将上传完成视为恢复目标完成。

## 已整合的当前批

| 阶段 | 正式整合范围 | 验证边界 |
|---|---|---|
| 41 旧配置 | 3源、15原方法 | 原读取顺序、受控资源/JSON消费及独立编译 |
| 42 FSM/Procedure | 6源、82原方法 | 原ARM64/实际链与命名依赖，独立编译 |
| 43 地图/格子 | 3源、45原方法 | 原数值、开格判定/回调、索引/邻接；完整生成后半链未闭合 |
| 44 单位战斗 | 4源、197原方法 | 独立复核、原oracle、受控生命周期；完整移动/攻击主链未闭合 |
| 50 内部Shader | 4官方同版本正文 | Unity实际Pass、keyword、GUID/Renderer读回通过 |
| 51 必需配置键 | 38原UniqueID getter | 实际源1178检查与受控配置830检查，无getter替身 |

四个新窗口加44共339原方法正文；必要38主键getter另计。所有文件使用source-before SHA保护整合，原meta/GUID保留。编译为必要独立官方rsp检查；正式运行以第10篇为准。

## 最后真实Unity状态

Main6使用用户GUI Editor3808打开原MineGameMain，观察45秒、22快照、Error0。此前CoreBlit缺HDR关键字和invalid pass错误消失，Unity实际两个CoreBlit为25Pass、两个ColorAndDepth为2Pass，四者supported、compileErrors0，两套Renderer及当前pipeline绑定正确。

但后半段frame固定1803、gameTime约9.987，原启动仍只有VersionMondule，后台原本地资源Provider未结束，观察期结束时生成cancelled_editor_session/ready=false收据。因此不能称原场景持续运行或版本链通过。独立私有Editor Probe已通过34载荷、50旧TextAsset、5142定位与53typed loads，它没有调用原Version、开/存场景、造场景对象或改变共享Provider。

用户指令“做完停下来，传一下git”已执行：恢复目标status=paused，后续不再展开玩法恢复，当前Editor保留。下一次恢复应先诊断GUI帧停止与后台资源等待，再继续原生成、占领和战斗主链。

## 仓库与全部资料

仓库：[ificanli/zhangchengdashi](https://github.com/ificanli/zhangchengdashi)

完整资料Release：[recovery-checkpoint-2026-10-19](https://github.com/ificanli/zhangchengdashi/releases/tag/recovery-checkpoint-2026-10-19)

资料清单覆盖107487个原路径、23678805567字节（约23.7GB）。Git直接保存32944个清单内源/资源/报告文件；其余内容以SHA去重，原不同的IDA数据库全部保留，仅完全相同字节合并。46224个独立blob经流式tar.zst压缩为5卷、2422300362字节（约2.42GB）。原路径映射包含APK、ELF、元数据、IL2CPP导出、各独立IDA分析库、work工具/候选/备份/失败log、编译/运行证据。335原Unity编译rsp和19导入log特别归档，不因Library/Logs缓存边界丢失。

本机生成Library/Temp/UserSettings、虚拟环境、node_modules、pycache、嵌套Git元数据等可重建内容不交付；凭据/许可证和明文原google-services-desktop云配置排除。没有上传用户电脑授权或令牌。排除列表公开保存在交付目录；原APK保持原样，原客户端资料的恢复/公开上传范围来自本轮用户明确指令。

## 实际上传验证

- 5卷本地SHA检查通过，并逐个解压46224blob核对原SHA，失败0。
- Git提交中32944个清单内文件逐个读取blob核对，失败0。
- 本地main与GitHub远程提交核对，原35.9MB完整清单从GitHub实际下载SHA一致。
- 13个Release附件均uploaded，GitHub存储的size/digest与本地全部匹配；Release已published。
- 第一卷额外作65536字节远程回读，内容和本地匹配；公开清单下载另作核对。
- 恢复脚本实际夹具验证分卷拼接、中文路径、去重副本、git-copy、拒绝覆盖用户改动和路径越界，失败0。未因验证而在本机额外展开23.7GB重复副本。

首次中文附件名被GitHub归一为default.json导致422重名。已保持数据SHA，用英文附件名上传，原误命名清单只改名不删除数据。修复publisher另存upload_github_release_ascii.py，保留原脚本与历史失败说明。

## 换电脑恢复

**git clone不会取得Release附件。** 先克隆main，再按[下载与完整恢复说明](../完整资料交付/README-下载与完整恢复.md)执行：

```powershell
git clone https://github.com/ificanli/zhangchengdashi.git
cd zhangchengdashi
python -m pip install -r "outputs/完整资料交付/requirements.txt"
python "outputs/完整资料交付/restore_all_materials.py"
```

脚本下载5卷、先校验SHA，再按原相对路径还原资料；存在的改动文件不会被覆盖。随后用Unity2022.3.62f3c1打开outputs/OccupyCityRecovered。脚本中的旧电脑绝对路径按当前克隆目录调整；原方法地址/字段Token/原机器码证据不变。

证据：[上传验证结果](../完整资料交付/上传验证结果.json)、[全部资料路径与哈希](../完整资料交付/完整资料路径与哈希清单.json)、[5卷清单](../完整资料交付/附件分卷清单.json)、[交付验证目录](../完整资料交付/交付验证/)、[最终本批运行](10-Unity运行验收.md)。
