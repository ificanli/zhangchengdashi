# Root RuntimeInspector 与 compiler-artifact 只读复核

结论：**通过限定范围；未发现critical问题。** 没有修改工程，没有启动Unity。以下结果不代表恢复了字典、几何算法或Jobs行为。

## RuntimeInspector 7文件

对照 `declaration-repair-vendor-namespace.json` 和 `declarations-vendor-namespace-before`，所有前后SHA-256匹配。7文件共209个方法/accessor节点的body文本逐字节不变。

Unity EventSystems接口名及IngameDebugConsole接口名已在各文件using/同命名空间中解析到对应接口；变更只恢复显式接口身份。ArrayField/PointerEventListener/HierarchyDragDropListener的指针事件参数与接口一致；ITooltipContent/IListViewAdapter属性和方法没有补造默认实现。

## compiler-artifact 17项

17项包括13个源文件修改，以及2个ILPP生成类与各自meta共4个归档记录。所有备份/当前文件哈希与报告吻合；归档文件存在于指定任务目录，工程内对应源位置已移出。

- BurstTriangulator 11文件：仅把相关泛型struct约束恢复为unmanaged，保留现有约束接口及全部body。NativeList/指针要求与已核对官方声明支持此修改；没有替换本游戏特有的约束边界枚举或算法。不能把该结果描述为原定制Triangulator算法已恢复。
- Clipper2 SpanCompat：T*字段需要非托管T，约束修改与已知Point64使用一致；没有改变指针体、字段或构造行为。
- Poco ConcurrentDictionary：原参数化IDictionary.Item包装器改为显式C#索引器。getter继续调用 `System_002ECollections_002EIDictionary_002Eget_Item(key)`，setter继续调用 `System_002ECollections_002EIDictionary_002Eset_Item(key, value)`。辅助方法仍存在，Token对应关系保留，没有直接把wrapper改成return null或空setter。
- 两个 `__JobReflectionRegistrationOutput__...`：已检查归档C#，CreateJobReflectionData与EarlyInit均为空，文件带DOTSCompilerGenerated。当前Assets没有对这两个具体类名的其他引用。Collections 2.5.7的JobReflectionDataPostProcessor确有对应生成路径；归档合理，但后续仍必须核验Unity编译产物是否生成正确注册，不能以归档本身证明Jobs运行。

## 必须准确表述的细节

compiler-artifact这13个修改源文件共259个方法/accessor节点，**body token变化为0**。其中Poco的2个wrapper改成单行accessor时改变了空白格式，所以这2个body的原始文本不再逐字节相同；调用表达式和参数token完全一致。

因此“RuntimeInspector7文件body逐字节不变”成立；“compiler-artifact全部body逐字节不变”不成立。对后者应表述为“body逻辑/调用token保持不变”，并把Poco的格式差异列为已知转换。这不是行为错误或critical阻断项。

独立读回明细：`root-inspector-artifacts-review.json`。本次没有运行任何修复脚本或测试，没有修改root的报告12。
