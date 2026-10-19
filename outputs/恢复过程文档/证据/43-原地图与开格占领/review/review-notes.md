# Stage43 独立候选审查记录

日期：2026-10-19。角色：父任务的只读审查子代理。所有写入仅发生在本任务 work/parallel-43-hex/review。未启动/停止 Unity，未操作 IDA 数据库，未修改 candidate 或实际工程文件。

## 已验证

- audit_candidate.py 从 captured source-before 与实际 candidate 读取原 Token、RVA、正文。最新 3 文件原 Token 序列、RVA、既有非空正文均保留；实际工程 3 源 SHA 仍等于 source-before。此前 CRLF 偏移错误确实导致原成员错位，已由父任务修正。
- 独立 IDA 状态读回 50/50 原函数 start/end 与目标边界一致。SyncLegendaryGridEffectWithPriceUi 的 JUMPOUT 是数组越界异常尾部，需要主任务保留汇编核查与依赖状态，不能当成普通实现缺失。
- numeric_native_oracle.py 直接执行原 libil2cpp ARM64 字节。220 组坐标构造/哈希、660 组 Equals/eq/neq、220 组六邻接、1100 组 QR→世界坐标、868 组世界→QR、217 组 GetKey。GetHexQR/GetKey 使用 libc modf 与 tuple 构造的 ABI 数据适配；float32 算术、native rounding、int32 修正均执行原指令。原跳表也从 ELF 读取。
- numeric_fixture.py 从当前候选正文重提取数值实现，最小 Vector3/Mathf 仅提供数据适配。修正精确 float 常量后 **8779 检查 / 0 失败**。负对照从 source-before 正文提取：**5919 检查 / 4708 失败**；构造抛未实现异常导致部分场景提前失败，所以两侧检查总数不同。
- 已复核 AddRole/RemoveRole/RefreshRoleCamp 的集合变更顺序，GetNeighborsArray 的 LU/RU/Up/Down/LD/RD 顺序，OpenHex 的桥格/已开/Gaming 门、opener 与 owner 阵营区分、金矿原 price 恢复、字段与事件顺序、翻转后 DOMoveY(-1,0.1) 再 HandleOnComplete 回调对应。

## 已发现并由主任务修正的问题

1. source-before 文件由 read_text 自动将 CRLF 转换为 LF，但 owned-scope 使用原字节解码的偏移，候选切片落错位置。审查发现 3 文件 Token 序列变更和 22 原成员丢失，包含原 HexDistance。父任务已改为 read_bytes().decode 保持偏移，写出前统一行尾，保护复查通过。
2. 反编译显示 0.66667/-0.33333/0.57735/1.7321 是显示精度截断。实读原 ELF bits 分别为 3F2AAAAB/BEAAAAAB/3F13CD3A/3FDDB3D7。初始数值候选 **8779 检查 / 1109 失败**；改为精确 float32 字面后全部通过。
3. OpenHex 原门是 self+0x1A4 的 isBridge，self+0x1A5 的 _isDoOpenHexAni 是稍后写入字段。父任务候选保持了桥格门。

## 已修正的对象有效性边界

FindHexByPos 原 RVA 0x4415360 在 TryGetValue 命中后先写 out，再执行 Unity Object implicit 判断。空值或 destroyed 对象命中时返回 false，out 保留字典命中值。候选审查时只 return TryGetValue，因此两种命中会错误返回 true。

find_hex_boundary_fixture.py 从候选实际正文提取，只固定 GetKeyToString 到单一字典键隔离返回/out 行为，以 Unity destroyed 对象 adapter 验证四个边界。首次候选 **4 检查 / 2 失败**：null 值命中和 destroyed 值命中。source-before 负对照 **4 检查 / 4 失败**（均未实现异常）。主任务已将候选修正为 TryGetValue 命中且 hexOut != null；独立重新提取最新候选复跑，**4 检查 / 0 失败**。此项已闭合。

最新源码保护复查为 **3 文件通过 / 62 原生边界全部匹配**，原 Token 顺序、RVA、HexDistance 正文与 source-before SHA 保护仍通过。新加入 GenerateHexBehaviour 的资源方法属于父任务的后继批次，不包含在数值/四边界测试范围。构造字段目前放在构造正文中，C# MonoBehaviour 基类调用与集合赋值的时序未独立验证，已向父任务说明。

## 可复现命令

```powershell
& 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe' -X utf8 work/parallel-43-hex/review/audit_candidate.py
& 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe' -X utf8 work/parallel-43-hex/review/numeric_native_oracle.py
& 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe' -X utf8 work/parallel-43-hex/review/numeric_fixture.py
dotnet run --project work/parallel-43-hex/review/numeric-tests/NumericTests.csproj -c Release -- work/parallel-43-hex/review/numeric-native-golden.json work/parallel-43-hex/review/numeric-tests/candidate-result.json
& 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe' -X utf8 work/parallel-43-hex/review/find_hex_boundary_fixture.py
dotnet run --project work/parallel-43-hex/review/find-hex-tests/FindHexTests.csproj -c Release -- work/parallel-43-hex/review/find-hex-tests/candidate-result.json
```

加 --baseline 从 source-before 生成负对照；运行结果路径应改为 baseline-result.json。上述只验证原方法/边界在独立 CLR 数据适配下的行为。未证明原资源、生成完整地图、占领动画最终资源/单位创建、Unity player loop 或完整场景已运行。
