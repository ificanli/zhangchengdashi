# 配置主键访问器原行为恢复实施计划

**Goal:** 仅恢复 `stage41-required-getter-targets.json` 精确38个 UniqueID.get，令原同步配置表通过真实 boxed Int32 键读取。

**Spec:** `work/parallel-coordination/stage41-required-getter-targets.json`，以及 Root 的本轮38 getter生产授权。

**Architecture:** 原字段、序列化属性、Token/RVA、构造器与其他方法保持字节级正文；每个 getter 仅返回原本位于 this+0x10 的 int 字段，由 C# 执行原装箱。所有中间文件在 work，备份在 work/recovery-stubs，生产只按逐文件SHA预检后应用。

- [ ] 固定38源码、meta/GUID及原生证据快照；真实空桩getter负对照记录原失败。
- [ ] 生成只改38 getter正文的候选；独立反演审计验证其余全文与meta保持。
- [ ] 运行直接编译38真实类型的signed Int32/boxed-key/重读边界fixture；候选真实38 getter接入原41配置链，复跑927行/7424字段/930身份及异常契约。
- [ ] 用当前Unity正式rsp隔离编译完整Assembly-CSharp候选，记录完整source输入哈希；不运行Unity。
- [ ] 全部SHA/meta/nontarget预检后备份并应用38源；重新从实际源运行getter/config fixtures与fullMaincsc，确认sourceStable。
- [ ] 输出stage41扩展handoff、独立报告与证据；Unity JsonUtility/provider与真实启动链继续明确待Root验收。

本计划直接执行已授权步骤；不增加用户审批或新的业务设计。
