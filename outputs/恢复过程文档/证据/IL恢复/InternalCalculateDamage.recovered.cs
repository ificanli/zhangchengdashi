using System;

private int InternalCalculateDamage(int originalAttack, bool isEnemy, int fetterCount, int requiredCount)
{
	bool flag = fetterCount < requiredCount;
	int result = originalAttack;
	if (!flag)
	{
		float num = originalAttack;
		float num2 = num * 0.5f;
		float num3 = BitConverter.Int32BitsToSingle(2139095040);
		float num4 = num2;
		int num5 = ((num4 == num4) ? (((double)num4 >= 2147483648.0) ? int.MaxValue : (((double)num4 <= -2147483648.0) ? int.MinValue : ((int)num4))) : 0);
		if (num2 == num3)
		{
			num5 = int.MinValue;
		}
		result = num5 + originalAttack;
	}
	return result;
}
