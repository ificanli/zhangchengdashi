import hashlib,json
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gzip-recovery';source=root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/ToolModule/GZipTool.cs'
text=source.read_text(encoding='utf-8-sig')
text=text.replace('using System.IO.Compression;','using System;\nusing System.Buffers;\nusing System.IO;\nusing System.IO.Compression;')
text=text.replace('private static readonly Encoding DefaultEncoding;','private static readonly Encoding DefaultEncoding = Encoding.UTF8;')
bodies={
'public static string DecompressFromBase64(string base64Data)':'''{
            if (string.IsNullOrEmpty(base64Data))
            {
                return string.Empty;
            }
            try
            {
                byte[] compressedData = Convert.FromBase64String(base64Data);
                return DefaultEncoding.GetString(DecompressCore(compressedData));
            }
            catch (Exception error)
            {
                UnityEngine.Debug.LogError("解压失败：" + base64Data);
                Console.WriteLine(error);
                throw;
            }
        }''',
'public static byte[] Decompress(byte[] compressedData)':'''{
            return DecompressCore(compressedData);
        }''',
'private static byte[] DecompressCore(byte[] compressedData)':'''{
            if (compressedData == null || compressedData.Length == 0)
            {
                return compressedData;
            }
            try
            {
                using (MemoryStream inputStream = new MemoryStream(compressedData))
                using (GZipStream gzipStream = new GZipStream(inputStream, CompressionMode.Decompress))
                using (MemoryStream outputStream = new MemoryStream())
                {
                    byte[] buffer = ArrayPool<byte>.Shared.Rent(BufferSize);
                    try
                    {
                        int count;
                        while ((count = gzipStream.Read(buffer, 0, BufferSize)) > 0)
                        {
                            outputStream.Write(buffer, 0, count);
                        }
                    }
                    finally
                    {
                        ArrayPool<byte>.Shared.Return(buffer, false);
                    }
                    return outputStream.ToArray();
                }
            }
            catch (Exception)
            {
                return compressedData;
            }
        }'''}
for signature,body in bodies.items():
    start=text.index('{',text.index(signature));end=start+1;depth=1
    while depth:depth+=(text[end]=='{')-(text[end]=='}');end+=1
    old=text[start:end];assert old.strip()=='{\n\t\t\treturn null;\n\t\t}',(signature,old)
    # Keep the existing file's tab-based method indentation.
    lines=body.splitlines();body='\n'.join(lines[:1]+['\t\t'+line[8:] for line in lines[1:]])
    text=text[:start]+body+text[end:]
original=source.read_bytes();encoded=text.replace('\n','\r\n').encode('utf-8-sig' if original.startswith(b'\xef\xbb\xbf') else 'utf-8')
(own/'GZipTool.candidate.cs').write_bytes(encoded)
(own/'candidate-provenance.json').write_text(json.dumps({'source':str(source),'sourceBeforeSha256':hashlib.sha256(original).hexdigest(),'candidateSha256':hashlib.sha256(encoded).hexdigest(),'metaSha256':hashlib.sha256(source.with_suffix('.cs.meta').read_bytes()).hexdigest(),'restoredMethods':list(bodies),'fieldInitializer':'Encoding.UTF8'},indent=2),encoding='utf-8')
print('Prepared narrow candidate; production source unchanged')
