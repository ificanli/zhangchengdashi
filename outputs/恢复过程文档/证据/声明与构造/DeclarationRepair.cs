using System.Text.Json;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

if (args.Length != 3) throw new ArgumentException("project-root backup-root report-path");
var project = Path.GetFullPath(args[0]);
var backupRoot = Path.GetFullPath(args[1]);
var scopes = new[] { "MeshBakerCore", "GPUInstancer", "Whinarn.UnityMeshSimplifier.Runtime", "DebugSystem.RuntimeInspector", "DebugSystem", "Poco", "AllIn1VfxDemoScriptAssemblies", "ToonyColorsPro2.Demo", "WG.EpicTween.Runtime", "Clipper2Lib", "NCalc", "Drawing", "Pathfinding.Ionic.Zip.Reduced" };
var records = new List<object>();
foreach (var scope in scopes)
foreach (var path in Directory.EnumerateFiles(Path.Combine(project, "Assets", "Scripts", scope), "*.cs", SearchOption.AllDirectories))
{
    var original = File.ReadAllText(path);
    var tree = CSharpSyntaxTree.ParseText(original);
    if (tree.GetDiagnostics().Any(x => x.Severity == DiagnosticSeverity.Error)) continue;
    var rewriter = new InterfaceIdentityRewriter();
    var rewritten = rewriter.Visit(tree.GetRoot())!;
    if (rewriter.Edits.Count == 0) continue;
    var updated = rewritten.ToFullString();
    var reparse = CSharpSyntaxTree.ParseText(updated);
    if (reparse.GetDiagnostics().Any(x => x.Severity == DiagnosticSeverity.Error)) throw new InvalidOperationException("Introduced syntax error: " + path);
    // Bodies are evidence and future recovery inputs. This pass changes declaration identity only.
    var beforeBodies = Bodies(tree.GetRoot());
    var afterBodies = Bodies(reparse.GetRoot());
    if (!beforeBodies.SequenceEqual(afterBodies)) throw new InvalidOperationException("Method/accessor body changed: " + path);
    var relative = Path.GetRelativePath(project, path);
    var backup = Path.GetFullPath(Path.Combine(backupRoot, relative));
    if (!backup.StartsWith(backupRoot + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase)) throw new InvalidOperationException("Backup escaped root");
    Directory.CreateDirectory(Path.GetDirectoryName(backup)!);
    if (File.Exists(backup)) throw new InvalidOperationException("Backup already exists: " + backup);
    File.Copy(path, backup);
    File.WriteAllText(path, updated, new System.Text.UTF8Encoding(false));
    records.Add(new { file = relative, edits = rewriter.Edits, bodiesUnchanged = true, beforeSha256 = Hash(original), afterSha256 = Hash(updated) });
}
Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(args[2]))!);
File.WriteAllText(args[2], JsonSerializer.Serialize(new { scope = "C# explicit-interface identity restoration only; no method implementation recovered", files = records }, new JsonSerializerOptions { WriteIndented = true }));
Console.WriteLine($"declaration files repaired={records.Count}; all method/accessor bodies unchanged");

static string Hash(string value) => Convert.ToHexString(SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(value)));
static string[] Bodies(SyntaxNode root) => root.DescendantNodes().Where(n => n is BaseMethodDeclarationSyntax or AccessorDeclarationSyntax).Select(n => n switch { BaseMethodDeclarationSyntax m => m.Body?.ToFullString() ?? m.ExpressionBody?.ToFullString() ?? "", AccessorDeclarationSyntax a => a.Body?.ToFullString() ?? a.ExpressionBody?.ToFullString() ?? "", _ => "" }).ToArray();

sealed class InterfaceIdentityRewriter : CSharpSyntaxRewriter
{
    public List<string> Edits { get; } = [];
    static string Decode(string value) => Regex.Replace(value, "_([0-9A-Fa-f]{4})", m => ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString());
    static SyntaxTokenList ExplicitModifiers(SyntaxTokenList tokens) => new(tokens.Where(t => t.Kind() is not (SyntaxKind.PublicKeyword or SyntaxKind.PrivateKeyword or SyntaxKind.ProtectedKeyword or SyntaxKind.InternalKeyword or SyntaxKind.VirtualKeyword or SyntaxKind.OverrideKeyword or SyntaxKind.SealedKeyword)));
    static bool InterfaceMember(string encoded, out string iface, out string member)
    {
        iface = member = "";
        if (!encoded.Contains("_002E")) return false;
        var decoded = Decode(encoded);
        if (!decoded.StartsWith("System.", StringComparison.Ordinal)) return false;
        int dot = decoded.LastIndexOf('.');
        if (dot < 0) return false;
        iface = decoded[..dot]; member = decoded[(dot + 1)..];
        return !member.StartsWith("get_") && !member.StartsWith("set_");
    }
    public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        if (node.ExplicitInterfaceSpecifier == null && InterfaceMember(node.Identifier.ValueText, out var iface, out var member))
        {
            Edits.Add(node.Identifier.ValueText + " => " + iface + "." + member);
            return node.WithModifiers(ExplicitModifiers(node.Modifiers)).WithExplicitInterfaceSpecifier(SyntaxFactory.ExplicitInterfaceSpecifier(SyntaxFactory.ParseName(iface))).WithIdentifier(SyntaxFactory.Identifier(node.Identifier.LeadingTrivia, member, node.Identifier.TrailingTrivia));
        }
        return base.VisitPropertyDeclaration(node);
    }
    public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        if (node.ExplicitInterfaceSpecifier != null) return base.VisitMethodDeclaration(node);
        string iface, member;
        bool encoded = InterfaceMember(node.Identifier.ValueText, out iface, out member);
        if (!encoded && node.Modifiers.Any(t => t.IsKind(SyntaxKind.PrivateKeyword)))
        {
            var owner = node.Ancestors().OfType<TypeDeclarationSyntax>().FirstOrDefault();
            var bases = owner?.BaseList?.Types.Select(t => t.Type.ToString()).ToArray() ?? [];
            if (node.Identifier.ValueText == "MoveNext" && bases.Any(t => t == "IEnumerator" || t.EndsWith(".IEnumerator"))) { iface = "System.Collections.IEnumerator"; member = "MoveNext"; encoded = true; }
            else if (node.Identifier.ValueText is "MoveNext" or "SetStateMachine" && bases.Any(t => t == "IAsyncStateMachine" || t.EndsWith(".IAsyncStateMachine"))) { iface = "System.Runtime.CompilerServices.IAsyncStateMachine"; member = node.Identifier.ValueText; encoded = true; }
        }
        if (!encoded) return base.VisitMethodDeclaration(node);
        Edits.Add(node.Identifier.ValueText + " => " + iface + "." + member);
        return node.WithModifiers(ExplicitModifiers(node.Modifiers)).WithExplicitInterfaceSpecifier(SyntaxFactory.ExplicitInterfaceSpecifier(SyntaxFactory.ParseName(iface))).WithIdentifier(SyntaxFactory.Identifier(node.Identifier.LeadingTrivia, member, node.Identifier.TrailingTrivia));
    }
}
