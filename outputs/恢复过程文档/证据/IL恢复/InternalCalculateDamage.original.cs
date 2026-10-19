private int InternalCalculateDamage(int originalAttack, bool isEnemy, int fetterCount, int requiredCount)
{
	//IL_0041: Invalid comparison between F8 and I4
	//IL_0084: Unknown result type (might be due to invalid IL or missing references)
	//IL_0089: Expected I4, but got Unknown
	//IL_0065: Expected F8, but got I8
	bool flag = fetterCount < requiredCount;
	int result = originalAttack;
	if (!flag)
	{
		double num = (double)originalAttack * 0.5;
		double num2 = ((num != 2139095040.0) ? num : 2147483648.0);
		result = (int)(num2 + originalAttack);
	}
	return result;
}
