using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace AnimationInstancing
{
	[Token(Token = "0x2000F61")]
	public class AnimationManager : SingletonAnimation<AnimationManager>
	{
		[Token(Token = "0x2000F62")]
		private struct CreateAnimationRequest
		{
			[Token(Token = "0x4006A57")]
			[FieldOffset(Offset = "0x0")]
			public GameObject prefab;

			[Token(Token = "0x4006A58")]
			[FieldOffset(Offset = "0x8")]
			public AnimationInstancing instance;
		}

		[Token(Token = "0x2000F63")]
		public class InstanceAnimationInfo
		{
			[Token(Token = "0x4006A59")]
			[FieldOffset(Offset = "0x10")]
			public List<AnimationInfo> listAniInfo;

			[Token(Token = "0x4006A5A")]
			[FieldOffset(Offset = "0x18")]
			public ExtraBoneInfo extraBoneInfo;

			[Token(Token = "0x6005C72")]
			[Address(RVA = "0x43AE408", Offset = "0x43AA408", VA = "0x43AE408")]
			public InstanceAnimationInfo()
			{
			}
		}

		[Token(Token = "0x2000F64")]
		[CompilerGenerated]
		private sealed class _003CLoadAnimationAssetBundle_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006A5B")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006A5C")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006A5D")]
			[FieldOffset(Offset = "0x20")]
			public AnimationManager _003C_003E4__this;

			[Token(Token = "0x4006A5E")]
			[FieldOffset(Offset = "0x28")]
			public string path;

			[Token(Token = "0x4006A5F")]
			[FieldOffset(Offset = "0x30")]
			private AssetBundleCreateRequest _003Crequest_003E5__2;

			[Token(Token = "0x17000F82")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005C76")]
				[Address(RVA = "0x43AFF74", Offset = "0x43ABF74", VA = "0x43AFF74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F83")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005C78")]
				[Address(RVA = "0x43AFFB4", Offset = "0x43ABFB4", VA = "0x43AFFB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005C73")]
			[Address(RVA = "0x43AF158", Offset = "0x43AB158", VA = "0x43AF158")]
			[DebuggerHidden]
			public _003CLoadAnimationAssetBundle_003Ed__25(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005C74")]
			[Address(RVA = "0x43AFD98", Offset = "0x43ABD98", VA = "0x43AFD98", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005C75")]
			[Address(RVA = "0x43AFD9C", Offset = "0x43ABD9C", VA = "0x43AFD9C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005C76")]
			[Address(RVA = "0x43AFF74", Offset = "0x43ABF74", VA = "0x43AFF74", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005C77")]
			[Address(RVA = "0x43AFF7C", Offset = "0x43ABF7C", VA = "0x43AFF7C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005C78")]
			[Address(RVA = "0x43AFFB4", Offset = "0x43ABFB4", VA = "0x43AFFB4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000F65")]
		[CompilerGenerated]
		private sealed class _003CLoadAnimationInfoFromAssetBundle_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006A60")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006A61")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006A62")]
			[FieldOffset(Offset = "0x20")]
			public AnimationManager _003C_003E4__this;

			[Token(Token = "0x4006A63")]
			[FieldOffset(Offset = "0x28")]
			public CreateAnimationRequest request;

			[Token(Token = "0x4006A64")]
			[FieldOffset(Offset = "0x38")]
			private AssetBundleRequest _003CabRequest_003E5__2;

			[Token(Token = "0x17000F84")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005C7C")]
				[Address(RVA = "0x43B02B0", Offset = "0x43AC2B0", VA = "0x43B02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000F85")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005C7E")]
				[Address(RVA = "0x43B02F0", Offset = "0x43AC2F0", VA = "0x43B02F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005C79")]
			[Address(RVA = "0x43AF208", Offset = "0x43AB208", VA = "0x43AF208")]
			[DebuggerHidden]
			public _003CLoadAnimationInfoFromAssetBundle_003Ed__27(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005C7A")]
			[Address(RVA = "0x43AFFBC", Offset = "0x43ABFBC", VA = "0x43AFFBC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005C7B")]
			[Address(RVA = "0x43AFFC0", Offset = "0x43ABFC0", VA = "0x43AFFC0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005C7C")]
			[Address(RVA = "0x43B02B0", Offset = "0x43AC2B0", VA = "0x43B02B0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005C7D")]
			[Address(RVA = "0x43B02B8", Offset = "0x43AC2B8", VA = "0x43B02B8", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005C7E")]
			[Address(RVA = "0x43B02F0", Offset = "0x43AC2F0", VA = "0x43B02F0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006A4F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] EditorAnimationTextureRoots;

		[Token(Token = "0x4006A50")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] StreamingAssetsAnimationTextureRoots;

		[Token(Token = "0x4006A51")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] RawAnimationTextureRoots;

		[Token(Token = "0x4006A52")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string[] AndroidAnimationTextureRoots;

		[Token(Token = "0x4006A53")]
		[FieldOffset(Offset = "0x20")]
		private List<CreateAnimationRequest> m_requestList;

		[Token(Token = "0x4006A54")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<GameObject, InstanceAnimationInfo> m_animationInfo;

		[Token(Token = "0x4006A55")]
		[FieldOffset(Offset = "0x30")]
		private AssetBundle m_mainBundle;

		[Token(Token = "0x4006A56")]
		[FieldOffset(Offset = "0x38")]
		private bool m_useBundle;

		[Token(Token = "0x6005C55")]
		[Address(RVA = "0x43ACF28", Offset = "0x43A8F28", VA = "0x43ACF28")]
		private void FallbackToAnimationFiles(string reason)
		{
		}

		[Token(Token = "0x6005C56")]
		[Address(RVA = "0x43AD0D8", Offset = "0x43A90D8", VA = "0x43AD0D8")]
		private InstanceAnimationInfo GetAnimationInfoFromFile(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6005C57")]
		[Address(RVA = "0x43AD3F4", Offset = "0x43A93F4", VA = "0x43AD3F4")]
		public static AnimationManager GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6005C58")]
		[Address(RVA = "0x43AD458", Offset = "0x43A9458", VA = "0x43AD458")]
		public static void ClearRuntimeAnimationInfoIfExists()
		{
		}

		[Token(Token = "0x6005C59")]
		[Address(RVA = "0x43AD850", Offset = "0x43A9850", VA = "0x43AD850")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005C5A")]
		[Address(RVA = "0x43AD90C", Offset = "0x43A990C", VA = "0x43AD90C")]
		public void RemoveRuntimeAnimationInfo(GameObject prefab)
		{
		}

		[Token(Token = "0x6005C5B")]
		[Address(RVA = "0x43AD4EC", Offset = "0x43A94EC", VA = "0x43AD4EC")]
		public void ClearRuntimeAnimationInfo()
		{
		}

		[Token(Token = "0x6005C5C")]
		[Address(RVA = "0x43AD9B4", Offset = "0x43A99B4", VA = "0x43AD9B4")]
		private static bool IsRuntimePrefab(GameObject prefab)
		{
			return default;
		}

		[Token(Token = "0x6005C5D")]
		[Address(RVA = "0x43ADA50", Offset = "0x43A9A50", VA = "0x43ADA50")]
		private void RemoveRequests(GameObject runtimePrefab)
		{
		}

		[Token(Token = "0x6005C5E")]
		[Address(RVA = "0x43ADC18", Offset = "0x43A9C18", VA = "0x43ADC18")]
		private TextAsset GetBakeData(GameObject prefab, AnimationInstancing instance)
		{
			return null;
		}

		[Token(Token = "0x6005C5F")]
		[Address(RVA = "0x43ADD4C", Offset = "0x43A9D4C", VA = "0x43ADD4C")]
		private Texture2D[] GetBakeTexture(GameObject prefab, AnimationInstancing instance)
		{
			return null;
		}

		[Token(Token = "0x6005C60")]
		[Address(RVA = "0x43ADE60", Offset = "0x43A9E60", VA = "0x43ADE60")]
		private bool ImportBakeTexture(GameObject prefab, AnimationInstancing instance, BinaryReader reader)
		{
			return default;
		}

		[Token(Token = "0x6005C61")]
		[Address(RVA = "0x43AE1A4", Offset = "0x43AA1A4", VA = "0x43AE1A4")]
		private InstanceAnimationInfo CreateAnimationInfoFromTextAsset(GameObject prefab, AnimationInstancing instance, TextAsset bakeData)
		{
			return null;
		}

		[Token(Token = "0x6005C62")]
		[Address(RVA = "0x43AECA8", Offset = "0x43AACA8", VA = "0x43AECA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C63")]
		[Address(RVA = "0x43AEE40", Offset = "0x43AAE40", VA = "0x43AEE40")]
		public InstanceAnimationInfo FindAnimationInfo(GameObject prefab, AnimationInstancing instance)
		{
			return null;
		}

		[Token(Token = "0x6005C64")]
		[Address(RVA = "0x43AF0EC", Offset = "0x43AB0EC", VA = "0x43AF0EC")]
		[IteratorStateMachine(typeof(_003CLoadAnimationAssetBundle_003Ed__25))]
		public IEnumerator LoadAnimationAssetBundle(string path)
		{
			return null;
		}

		[Token(Token = "0x6005C65")]
		[Address(RVA = "0x43AF180", Offset = "0x43AB180", VA = "0x43AF180")]
		public void UnloadAnimationAssetBundle()
		{
		}

		[Token(Token = "0x6005C66")]
		[Address(RVA = "0x43AEDCC", Offset = "0x43AADCC", VA = "0x43AEDCC")]
		[IteratorStateMachine(typeof(_003CLoadAnimationInfoFromAssetBundle_003Ed__27))]
		private IEnumerator LoadAnimationInfoFromAssetBundle(CreateAnimationRequest request)
		{
			return null;
		}

		[Token(Token = "0x6005C67")]
		[Address(RVA = "0x43AF230", Offset = "0x43AB230", VA = "0x43AF230")]
		private static string[] GetEditorAnimationInfoSearchPaths(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x6005C68")]
		[Address(RVA = "0x43AF3BC", Offset = "0x43AB3BC", VA = "0x43AF3BC")]
		private static string[] GetStreamingAssetsAnimationInfoSearchPaths(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x6005C69")]
		[Address(RVA = "0x43AF548", Offset = "0x43AB548", VA = "0x43AF548")]
		private static string[] GetRawAnimationInfoSearchPaths(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x6005C6A")]
		[Address(RVA = "0x43AF740", Offset = "0x43AB740", VA = "0x43AF740")]
		private static string[] GetAndroidAnimationInfoSearchPaths(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x6005C6B")]
		[Address(RVA = "0x43AF900", Offset = "0x43AB900", VA = "0x43AF900")]
		private static string[] GetWebglAnimationInfoSearchPaths(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x6005C6C")]
		[Address(RVA = "0x43AFACC", Offset = "0x43ABACC", VA = "0x43AFACC")]
		private static byte[] LoadBytesFromUrls(string[] searchPaths)
		{
			return null;
		}

		[Token(Token = "0x6005C6D")]
		[Address(RVA = "0x43AD19C", Offset = "0x43A919C", VA = "0x43AD19C")]
		private InstanceAnimationInfo CreateAnimationInfoFromFile(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6005C6E")]
		[Address(RVA = "0x43AE410", Offset = "0x43AA410", VA = "0x43AE410")]
		private List<AnimationInfo> ReadAnimationInfo(BinaryReader reader)
		{
			return null;
		}

		[Token(Token = "0x6005C6F")]
		[Address(RVA = "0x43AEAE8", Offset = "0x43AAAE8", VA = "0x43AEAE8")]
		private ExtraBoneInfo ReadExtraBoneInfo(BinaryReader reader)
		{
			return null;
		}

		[Token(Token = "0x6005C70")]
		[Address(RVA = "0x43AFBD4", Offset = "0x43ABBD4", VA = "0x43AFBD4")]
		public AnimationManager()
		{
		}
	}
}
