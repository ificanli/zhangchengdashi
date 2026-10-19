using System.Reflection;
using GameFramework;

int failures = 0, scenarios = 0, checks = 0;
void Eq<T>(T expected, T actual) { checks++; if (!EqualityComparer<T>.Default.Equals(expected, actual)) throw new Exception($"Expected [{expected}], got [{actual}]"); }
void Same(object expected, object actual) { checks++; if (!ReferenceEquals(expected, actual)) throw new Exception("Expected original FullName reference"); }
void Throws<T>(Action action) where T : Exception { checks++; try { action(); } catch (T) { return; } throw new Exception("Expected " + typeof(T).Name); }
void Run(string name, Action action) { scenarios++; try { action(); Console.WriteLine("PASS " + name); } catch (Exception e) { failures++; Console.WriteLine("FAIL " + name + ": " + e.Message); } }
Run("typed null name returns original FullName reference", () => { var t = new InspectType("Owner.X"); Same(t.Value, Utility.Text.GetFullName(t, null)); Eq(1, t.Calls); });
Run("typed empty name returns original FullName reference", () => { var t = new InspectType("Owner.X"); Same(t.Value, Utility.Text.GetFullName(t, string.Empty)); Eq(1, t.Calls); });
Run("typed named keys retain exact punctuation whitespace unicode and format braces", () => { foreach (string name in new[] { "normal", "A.B", " name ", " ", "中文", "{0}", "." }) { var t = new InspectType("Owner.X"); Eq("Owner.X." + name, Utility.Text.GetFullName(t, name)); Eq(1, t.Calls); } });
Run("generic uses typeof T for value reference nested and constructed generic types", () => { Eq(typeof(int).FullName, Utility.Text.GetFullName<int>(null)); Eq(typeof(object).FullName, Utility.Text.GetFullName<object>("")); Eq(typeof(Dictionary<string, int>).FullName + ".named", Utility.Text.GetFullName<Dictionary<string, int>>("named")); Eq(typeof(InspectType).FullName + ".X", Utility.Text.GetFullName<InspectType>("X")); });
Run("generic parameter FullName null is returned for unnamed key", () => { Type parameter = typeof(List<>).GetGenericArguments()[0]; Eq<string>(null, Utility.Text.GetFullName(parameter, null)); Eq<string>(null, Utility.Text.GetFullName(parameter, "")); Eq(".named", Utility.Text.GetFullName(parameter, "named")); });
Run("FullName getter executes once before name branch", () => { foreach (string name in new[] { null, "", "X" }) { var t = new InspectType("T"); Eq(name is null or "" ? "T" : "T.X", Utility.Text.GetFullName(t, name)); Eq(1, t.Calls); } });
Run("null type throws original NullReferenceException even for unnamed key", () => { Throws<NullReferenceException>(() => Utility.Text.GetFullName(null, null)); Throws<NullReferenceException>(() => Utility.Text.GetFullName(null, "")); Throws<NullReferenceException>(() => Utility.Text.GetFullName(null, "X")); });
Run("FullName getter exception propagates before name branch", () => { foreach (string name in new[] { null, "", "X" }) { var t = new InspectType("T") { Fail = true }; Throws<ProbeException>(() => Utility.Text.GetFullName(t, name)); Eq(1, t.Calls); } });
Run("nonempty type with empty FullName preserves original period behavior", () => { var t = new InspectType(""); Same(t.Value, Utility.Text.GetFullName(t, null)); Eq(".X", Utility.Text.GetFullName(t, "X")); Eq(2, t.Calls); });
Console.WriteLine($"RESULT scenarios={scenarios} checks={checks} failures={failures}");
return failures == 0 ? 0 : 1;

sealed class ProbeException : Exception { }
sealed class InspectType : TypeDelegator
{
    public readonly string Value;
    public int Calls;
    public bool Fail;
    public InspectType(string value) : base(typeof(object)) { Value = new string(value.ToCharArray()); }
    public override string FullName { get { Calls++; if (Fail) throw new ProbeException(); return Value; } }
}
