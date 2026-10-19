from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gzip-recovery';text=(own/'GZipTool.candidate.cs').read_text(encoding='utf-8-sig')
text=text.replace('new MemoryStream(', 'new CleanupProbe.Memory(').replace('new GZipStream(', 'new CleanupProbe.Gzip(').replace('ArrayPool<byte>.Shared','CleanupProbe.Pool')
(own/'cleanup').mkdir(exist_ok=True);(own/'cleanup/GZipTool.instrumented.cs').write_text('// Test-only constructor/pool substitution for cleanup fault injection. Not installed.\n'+text,encoding='utf-8')
