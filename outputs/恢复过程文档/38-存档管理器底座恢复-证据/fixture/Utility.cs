using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace GameFramework
{
	public static class Utility
	{
		public static class AssemblyUtility
		{
			private static Dictionary<string, Assembly> _00A2_0090qª_009Bº;
			public static Assembly LoadAssembly(string _008DtSh_005Dq)
			{
    Assembly assembly;
    if (!_00A2_0090qª_009Bº.TryGetValue(_008DtSh_005Dq, out assembly))
    {
        assembly = Assembly.Load(_008DtSh_005Dq);
        if (assembly != null)
            _00A2_0090qª_009Bº.Add(_008DtSh_005Dq, assembly);
    }

    return assembly;
}
			public static Assembly LoadCSharpAssembly()
			{
    Assembly assembly = LoadAssembly("Assembly-CSharp");
    if (assembly == null)
    {
        UnityEngine.Debug.LogError("加载C#程序集错误");
        return null;
    }

    return assembly;
}
static AssemblyUtility()
{
    _00A2_0090qª_009Bº = new Dictionary<string, Assembly>();
}		}
	}
}
