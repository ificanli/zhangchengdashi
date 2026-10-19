import bisect
import json
import re
import traceback
from pathlib import Path

import ida_auto
import ida_bytes
import ida_funcs
import ida_hexrays
import ida_idaapi
import ida_kernwin
import ida_loader
import ida_nalt
import ida_name
import ida_typeinf
import ida_ua
import idautils
import idc

ROOT = Path(r"C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\stage48-new-ui\ida")
status = {"stage": "started", "methods": []}
def save():
    (ROOT / "status-bounded.json").write_text(json.dumps(status, ensure_ascii=False, indent=2), encoding="utf-8")
save()

try:
    ida_idaapi.set_script_timeout(0)
    ida_auto.enable_auto(False)
    base = ida_nalt.get_imagebase()
    targets = json.loads((ROOT / "targets.json").read_text(encoding="utf-8"))
    mapping = json.loads(Path(r"C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\outputs\IDA分析材料\Il2Cpp导出\script.json").read_text(encoding="utf-8-sig"))
    method_map = {entry["Address"]: entry for entry in mapping["ScriptMethod"]}
    ends = sorted(set(mapping["Addresses"]))
    del mapping
    status["image_base"] = hex(base)
    status["type_errors"] = ida_typeinf.parse_decls(None, (ROOT / "minimal-types.h").read_text(encoding="utf-8"), None, 0)
    ida_loader.load_plugin("hexarm")
    status["hexrays_available"] = bool(ida_hexrays.init_hexrays_plugin())
    status["hexrays_version"] = ida_hexrays.get_hexrays_version() if status["hexrays_available"] else None
    for address, end, name, prototype in [
        (0x3C3D280, 0x3C3D294, "il2cpp_codegen_initialize_runtime_metadata", "void InitializeRuntimeMetadata(void** slot);"),
        (0x3C3D3B0, 0x3C3D3B4, "il2cpp_codegen_runtime_class_init", "void RuntimeClassInit(void* klass);"),
        (0x3C3D4CC, 0x3C3D4D4, "il2cpp_codegen_raise_null_reference_exception", "void __noreturn RaiseNullReferenceException(void);")
    ]:
        for ea in range(address, end, 4): ida_ua.create_insn(base + ea)
        ida_funcs.add_func(base + address, base + end)
        ida_name.set_name(base + address, name, ida_name.SN_NOCHECK | ida_name.SN_NOWARN)
        ida_typeinf.apply_cdecl(None, base + address, prototype)

    prototypes = {
        0x3D2A600: "ZCDS_Int32 HexDistance(HexManager_HexCoord_o a, HexManager_HexCoord_o b, const MethodInfo* method);",
        0x3DED9AC: "ZCDS_Int32 GetAvailableSlots(GameModule_BattleGameSceneManager_o* self, ZCDS_Bool isEnemy, const MethodInfo* method);",
        0x44298EC: "void DetermineHexCamp(GameModule_HexBehaviour_o* self, const MethodInfo* method);",
        0x4424D5C: "void OpenHex(GameModule_HexBehaviour_o* self, ZCDS_Bool isEnemy, ZCDS_Bool isHard, const MethodInfo* method);",
        0x3E0F6F0: "int InternalCalculateDamage(void* self, int originalAttack, unsigned char isEnemy, int fetterCount, int requiredCount, const MethodInfo* method);",
        0x3DE3CF4: "void ChangeCoin(void* self, int coinNum, const MethodInfo* method);",
        0x4195B70: "void GameLauncher_Start_MoveNext(void* self, const MethodInfo* method);",
    }
    def analyze_range(start, end):
        # Reject an enclosing function that autoanalysis incorrectly extended
        # across a metadata-confirmed method boundary. Preserve its earlier range.
        existing = ida_funcs.get_func(start)
        if existing and existing.start_ea != start:
            previous = existing.start_ea
            if ida_funcs.get_fchunk(start).start_ea == previous:
                if not ida_funcs.set_func_end(previous, start):
                    raise RuntimeError(f"Cannot split enclosing function {previous:#x} at {start:#x}")
            else:
                if not ida_funcs.remove_func_tail(existing, start):
                    raise RuntimeError(f"Cannot detach erroneous function tail at {start:#x}")
        ida_ua.create_insn(start)
        ida_funcs.add_func(start, end)
        existing = ida_funcs.get_func(start)
        if existing and existing.start_ea == start and existing.end_ea != end:
            if not ida_funcs.set_func_end(start, end):
                raise RuntimeError(f"Cannot correct function end {start:#x} to {end:#x}")
        ida_auto.enable_auto(True)
        try:
            return ida_auto.plan_and_wait(start, end)
        finally:
            ida_auto.enable_auto(False)

    output = ROOT / "pseudocode"
    output.mkdir(exist_ok=True)
    for target in targets:
        row = dict(target)
        status["stage"] = "analyzing " + target["name"]
        status["methods"].append(row)
        save()
        start, end = base + target["address"], base + target["end"]
        ida_name.set_name(start, target["name"], ida_name.SN_NOCHECK | ida_name.SN_NOWARN)
        row["range_analysis"] = analyze_range(start, end)
        callees = []
        for ea in idautils.Heads(start, end):
            for dest in idautils.CodeRefsFrom(ea, False):
                method = method_map.get(dest - base)
                if method and not start <= dest < end:
                    ida_name.set_name(dest, method["Name"], ida_name.SN_NOCHECK | ida_name.SN_NOWARN)
                    index = bisect.bisect_right(ends, dest - base)
                    stop = base + ends[index] if index < len(ends) else dest + 4
                    ida_ua.create_insn(dest)
                    ida_funcs.add_func(dest, stop)
                    callees.append({"callsite": hex(ea), "address": hex(dest), "name": method["Name"], "signature": method["Signature"]})
        row["direct_callees"] = callees
        # plan_and_wait or defining a callee can extend the containing function
        # again. Enforce the verified boundary after all analysis, with auto off.
        current = ida_funcs.get_func(start)
        if current and current.start_ea == start and current.end_ea != end:
            if not ida_funcs.set_func_end(start, end):
                raise RuntimeError(f"Final boundary correction failed for {start:#x}")
        prototype = target.get("prototype") or prototypes.get(target["address"])
        save()
        row["prototype_applied"] = bool(ida_typeinf.apply_cdecl(None, start, prototype)) if prototype else False
        function = ida_funcs.get_func(start)
        row["actual_function_start"] = hex(function.start_ea) if function else None
        row["actual_function_end"] = hex(function.end_ea) if function else None
        if function is None or function.start_ea != start or function.end_ea != end:
            raise RuntimeError(f"Decompile address does not identify requested function {start:#x}")
        assembly = [f"{ea:#x}: {idc.generate_disasm_line(ea, 0)}" for ea in idautils.Heads(start, end)]
        (output / (hex(target["address"]) + ".asm.txt")).write_text("\n".join(assembly), encoding="utf-8")
        try:
            text = str(ida_hexrays.decompile(start))
            (output / (hex(target["address"]) + ".c")).write_text(text, encoding="utf-8")
            row["pseudocode_chars"] = len(text)
            row["unresolved_jumpout"] = "JUMPOUT" in text
        except Exception:
            row["decompilation_error"] = traceback.format_exc()
        save()
    status["database_saved"] = bool(ida_loader.save_database())
    status["stage"] = "complete"
    save()
    idc.qexit(0)
except Exception:
    status["stage"] = "failed"
    status["error"] = traceback.format_exc()
    save()
    idc.qexit(1)
