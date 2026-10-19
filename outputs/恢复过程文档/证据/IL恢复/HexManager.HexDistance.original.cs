using System;
using System.Runtime.CompilerServices;

public static int HexDistance(HexCoord a, HexCoord b)
{
	//IL_000e: Expected Obj, but got VT
	//IL_001c: Expected Obj, but got VT
	//IL_0029: Unknown result type (might be due to invalid IL or missing references)
	//IL_002e: Expected Obj, but got Unknown
	//IL_003b: Expected Obj, but got VT
	//IL_0043: Unknown result type (might be due to invalid IL or missing references)
	//IL_0048: Expected Obj, but got Unknown
	//IL_006b: Unsupported input type for neg.
	//IL_006b: Unknown result type (might be due to invalid IL or missing references)
	//IL_0070: Expected Obj, but got Unknown
	//IL_016c: Expected Obj, but got I4
	//IL_0079: Unsupported input type for neg.
	//IL_0079: Unknown result type (might be due to invalid IL or missing references)
	//IL_007e: Expected Obj, but got Unknown
	//IL_0191: Expected I4, but got Obj
	//IL_0087: Unsupported input type for neg.
	//IL_0087: Unknown result type (might be due to invalid IL or missing references)
	//IL_008c: Expected Obj, but got Unknown
	//IL_009a: Unknown result type (might be due to invalid IL or missing references)
	//IL_009f: Expected Obj, but got Unknown
	object obj = a >> 32;
	object obj2 = b >> 32;
	object obj3 = obj + a;
	object obj4 = a - b;
	object obj5 = obj3 - b;
	if (a < b)
	{
		obj4 = 0 - obj4;
	}
	object obj6 = obj5 - obj2;
	if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
	{
		obj6 = 0 - obj6;
	}
	object obj7 = obj - obj2;
	if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
	{
		obj7 = 0 - obj7;
	}
	object obj8 = obj7 + obj4;
	object obj9 = obj8 + obj6;
	bool flag = (nint)obj9 < 0;
	object obj10 = obj9 ^ obj9;
	object obj11 = obj9 & obj10;
	bool flag2 = (nint)obj11 < 0;
	bool flag3 = flag == flag2;
	object obj12 = !flag3;
	object obj13 = ~obj12;
	if (obj13 == null)
	{
		obj9++;
	}
	return obj9 >> 1;
}
