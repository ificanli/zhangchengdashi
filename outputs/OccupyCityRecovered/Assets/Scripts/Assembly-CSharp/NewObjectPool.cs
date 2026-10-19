using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000022")]
public class NewObjectPool<T> where T : PoolObjectBase
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected Dictionary<int, NewGameObjectStack<T>> PoolDic;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected Dictionary<string, int> PoolRef;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<T> DelayReleaseObject;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected Transform transRoot;

	[Token(Token = "0x6000087")]
	public NewObjectPool(GameObject transRoot)
	{
	}

	[Token(Token = "0x6000088")]
	public Transform GetPoolRoot()
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x600008A")]
	public virtual T GetPoolObject(GameObject goPrefab, Vector3 pos, [Optional] Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	public virtual T GetPoolObject(GameObject goPrefab, Vector3 pos, Vector3 scale, [Optional] Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	public virtual T GetPoolObject(string path, Vector3 pos, Vector3 scale, [Optional] Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	protected virtual void SetPosScaleAndParent(PoolObjectBase poolObject, Vector3 pos, Vector3 scale, [Optional] Transform parent)
	{
	}

	[Token(Token = "0x600008E")]
	protected T GetPoolObject(int poolID, GameObject Prefab)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	protected virtual void OnGet(T go)
	{
	}

	[Token(Token = "0x6000090")]
	protected virtual void OnRelease(T go)
	{
	}

	[Token(Token = "0x6000091")]
	private void CreatePool(int poolID, GameObject prefab)
	{
	}

	[Token(Token = "0x6000092")]
	protected virtual T DefaultGetComponet(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	public void Release(T poolObject)
	{
	}

	[Token(Token = "0x6000094")]
	public void Release(T poolObject, float delayTime)
	{
	}

	[Token(Token = "0x6000095")]
	public void ClearAllPool()
	{
	}

	[Token(Token = "0x6000096")]
	public virtual void CustomClearAll()
	{
	}
}
