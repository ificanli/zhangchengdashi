from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/stringtool-recovery';before=(root/'work/recovery-stubs/stringtool-before/StringTool.cs').read_text(encoding='utf-8-sig');current=(root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/ToolModule/StringTool.cs').read_text(encoding='utf-8-sig')
def body(text,signature):
    i=text.index('{',text.index(signature));j=i+1;depth=1
    while depth:depth+=(text[j]=='{')-(text[j]=='}');j+=1
    return text[i:j]
signature='public static T ToEnum<T>';before=before.replace(body(before,signature),body(current,signature));(own/'StringTool.baseline-diagnostic.cs').write_text(before,encoding='utf-8');print('Prepared baseline with original two empty bodies; only unrelated illegal ToEnum stub normalized to diagnostic')
