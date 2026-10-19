using System;
using System.Runtime.CompilerServices;

namespace GameFramework
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ModelRegister : Attribute
	{
		private string _00A3_00BBC_005E_00ABY;
		private bool zjH_005B_00A8_00B1;
		private bool _0060E_007FhjN;
		public bool CompressData
		{
			get
			{
    return _0060E_007FhjN;
}
		}
		public string GameName
		{
			get
			{
    return _00A3_00BBC_005E_00ABY;
}
		}
		public bool AutoSyn
		{
			get
			{
    return zjH_005B_00A8_00B1;
}
		}
		public ModelRegister(string _00A3_00A9h_007Fqn, bool _00B7_005D_00A7u_007CJ = true, bool _00A5_008Eg_008Cu_009D = false)
		{
    zjH_005B_00A8_00B1 = true;
    _00A3_00BBC_005E_00ABY = _00A3_00A9h_007Fqn;
    zjH_005B_00A8_00B1 = _00B7_005D_00A7u_007CJ;
    _0060E_007FhjN = _00A5_008Eg_008Cu_009D;
}
	}
}
