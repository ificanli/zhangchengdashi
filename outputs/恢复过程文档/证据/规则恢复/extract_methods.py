from pathlib import Path

ROOT = next(parent for parent in Path(__file__).resolve().parents
            if (parent / "outputs/OccupyCityRecovered/Assets").is_dir())
SCRIPTS = ROOT / "outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp"

def extract(path, signature):
    source = path.read_text(encoding="utf-8-sig")
    start = source.index(signature)
    body = source.index("{", start)
    depth = 1
    end = body + 1
    while depth:
        depth += (source[end] == "{") - (source[end] == "}")
        end += 1
    return source[start:end]

hex_method = extract(SCRIPTS / "HexManager.cs", "public static int HexDistance(HexCoord a, HexCoord b)")
damage_method = extract(SCRIPTS / "GameModule/SynergyEffectManager.cs", "private int InternalCalculateDamage(int originalAttack, bool isEnemy, int fetterCount, int requiredCount)")
Path(__file__).with_name("ExtractedRules.cs").write_text(
    "// Generated from the actual restored Unity method bodies; no duplicate implementation.\n"
    "public static class HexManager { public struct HexCoord { public int q, r; }\n"
    + hex_method + "\n}\n"
    + "public class SynergyEffectManager { public int Evaluate(int attack, bool enemy, int count, int required) => InternalCalculateDamage(attack, enemy, count, required);\n"
    + damage_method + "\n}\n", encoding="utf-8"
)

