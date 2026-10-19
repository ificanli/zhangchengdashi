// Test boundaries only. No FSM / Procedure algorithm is reimplemented here.
// Utility and module acquisition remain production integration dependencies.
using System.Reflection;

namespace GameFramework
{
    internal static class BoundaryMode
    {
        internal static bool KeysAreAvailable = true;
        internal static readonly List<string> Calls = new();
    }
    public static class Utility
    {
        public static class Text
        {
            public static string Format(string format, params object[] args) => string.Format(format, args);
            public static string GetFullName<T>(string name) => GetFullName(typeof(T), name);
            public static string GetFullName(Type type, string name)
            {
                BoundaryMode.Calls.Add("Utility.Text.GetFullName:" + type.FullName + ":" + name);
                if (!BoundaryMode.KeysAreAvailable) return null;
                return string.IsNullOrEmpty(name) ? type.FullName : type.FullName + "." + name;
            }
        }
        public static class Assembly
        {
            public static Type[] GetTypes() => System.Reflection.Assembly.GetExecutingAssembly().GetTypes();
        }
    }
    public static class GameFrameEntry
    {
        public static object Module;
        public static T GetModule<T>() where T : class
        {
            BoundaryMode.Calls.Add("GameFrameEntry.GetModule:" + typeof(T).FullName);
            return Module as T;
        }
    }
    public static class AssemblyUtility
    {
        public static Type[] GetTypes() => System.Reflection.Assembly.GetExecutingAssembly().GetTypes();
        public static Type[] GetTypes(string _) => GetTypes();
        public static List<Type> GetSubClasses(Type parent) => GetTypes().Where(t => t.IsSubclassOf(parent)).ToList();
    }
    public static class CLog
    {
        public static void LogProcedure(params object[] args) => BoundaryMode.Calls.Add("CLog.LogProcedure:" + string.Join("|", args.Select(x => x?.ToString())));
    }
}
