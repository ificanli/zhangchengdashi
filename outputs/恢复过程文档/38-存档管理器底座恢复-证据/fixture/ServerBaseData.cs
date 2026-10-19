using System;

[Serializable]
public abstract class ServerBaseData
{
	public virtual void Init()
	{
	}
	public virtual void InitFromDefaults()
	{
	}
	protected ServerBaseData()
	{
	}
}
