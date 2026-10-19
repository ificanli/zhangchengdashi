import hashlib
import json
import sys
from pathlib import Path

OWN = Path(__file__).resolve().parent
ROOT = OWN.parents[2]
SOURCE = ROOT / 'outputs/OccupyCityRecovered/Assets/Scripts/GFRunning/GameFramework/Utility.cs'
before = OWN / 'source-before/Utility.cs'
old = before.read_text(encoding='utf-8-sig')
tokens = ['0x600603C', '0x600603D']
def span(text, token):
    pos = text.index('[Token(Token = "' + token + '")]')
    start = text.index('{', pos)
    end, depth = start + 1, 1
    while depth:
        depth += (text[end] == '{') - (text[end] == '}')
        end += 1
    return pos, start, end

candidate = old
for token, lines in zip(tokens, [
    ['return GetFullName(typeof(T), _00AE_008C_009AiPJ);'],
    ['string fullName = _007BgpR_00A0V.FullName;', 'if (string.IsNullOrEmpty(_00AE_008C_009AiPJ))', '\treturn fullName;', 'return string.Format("{0}.{1}", fullName, _00AE_008C_009AiPJ);'],
]):
    pos, start, end = span(candidate, token)
    candidate = candidate[:start] + '{\n' + '\n'.join('\t\t\t\t' + line for line in lines) + '\n\t\t\t}' + candidate[end:]
(OWN / 'Utility.candidate.cs').write_text(candidate, encoding='utf-8')
mode = 'actual' if '--actual' in sys.argv else 'baseline' if '--baseline' in sys.argv else 'candidate'
path = SOURCE if mode == 'actual' else before if mode == 'baseline' else OWN / 'Utility.candidate.cs'
text = path.read_text(encoding='utf-8-sig')
parts = ['using System;', 'namespace GameFramework { public static class Utility { public static class Text {']
for token in tokens:
    pos, start, end = span(text, token)
    declaration = text[text.index('public static string GetFullName', pos):start]
    parts.append(declaration + text[start:end])
parts.append('}}}')
tests = OWN / 'tests'
tests.mkdir(exist_ok=True)
(tests / 'ActualSource.cs').write_text('\n'.join(parts), encoding='utf-8')
provenance = dict(mode=mode, source=str(path), sourceSha256=hashlib.sha256(path.read_bytes()).hexdigest(), tokens=tokens, actualBodiesDirectlyExtracted=True, boundaryAdapters=False)
(tests / ('fixture-' + mode + '.json')).write_text(json.dumps(provenance, indent=2), encoding='utf-8')
print(json.dumps(provenance))
