using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace IngameDebugConsole
{
	[Token(Token = "0x200006C")]
	public static class RuntimeInspectorUtils
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, MemberInfo[]> typeToVariables;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, ExposedMethod[]> typeToExposedMethods;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly HashSet<Type> commonSerializableTypes;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<MemberInfo> validVariablesList;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly List<Type> typesToSearchForVariablesList;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly List<string> propertyNamesInVariablesList;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly List<ExposedMethod> exposedMethodsList;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly List<ExposedExtensionMethodHolder> exposedExtensionMethods;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Dictionary<Type, Type> customEditors;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly List<RuntimeInspectorCustomEditorAttribute> customEditorAttributes;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly HashSet<Transform> IgnoredTransformsInHierarchy;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static Canvas popupCanvas;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static Canvas popupReferenceCanvas;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static Tooltip tooltipPopup;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly Stack<DraggedReferenceItem> draggedReferenceItemsPool;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal static readonly NumberFormatInfo numberFormat;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal static readonly StringBuilder stringBuilder;

		[Token(Token = "0x170000BB")]
		public static Type ExposedExtensionMethodsHolder
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x46746AC", Offset = "0x46706AC", VA = "0x46746AC")]
			set
			{
			}
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x4674A4C", Offset = "0x4670A4C", VA = "0x4674A4C")]
		public static bool IsNull(this object obj)
		{
			return default;
		}

		[Token(Token = "0x600039C")]
		public static bool IsEmpty<T>(this IList<T> objects)
		{
			return default;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x4674AE0", Offset = "0x4670AE0", VA = "0x4674AE0")]
		public static string ToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x4674F0C", Offset = "0x4670F0C", VA = "0x4674F0C")]
		public static string GetNameWithType(this object obj, [Optional] Type defaultType)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x4675100", Offset = "0x4671100", VA = "0x4675100")]
		public static Texture GetTexture(this UnityEngine.Object obj)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x46751EC", Offset = "0x46711EC", VA = "0x46751EC")]
		public static Color Tint(this Color color, float tintAmount)
		{
			return default;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x4675220", Offset = "0x4671220", VA = "0x4675220")]
		public static void ShowTooltip(string tooltip, PointerEventData pointer, [Optional] UISkin skin, [Optional] Canvas referenceCanvas)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x4675908", Offset = "0x4671908", VA = "0x4675908")]
		public static void HideTooltip()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x4675A14", Offset = "0x4671A14", VA = "0x4675A14")]
		public static DraggedReferenceItem CreateDraggedReferenceItem(UnityEngine.Object reference, PointerEventData draggingPointer, [Optional] UISkin skin, [Optional] Canvas referenceCanvas)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x4675AF4", Offset = "0x4671AF4", VA = "0x4675AF4")]
		public static DraggedReferenceItem CreateDraggedReferenceItem(UnityEngine.Object[] references, PointerEventData draggingPointer, [Optional] UISkin skin, [Optional] Canvas referenceCanvas, [Optional] DraggedReferenceItem prefab)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x4675D34", Offset = "0x4671D34", VA = "0x4675D34")]
		public static void PoolDraggedReferenceItem(DraggedReferenceItem item)
		{
		}

		[Token(Token = "0x60003A6")]
		public static T GetAssignableObjectFromDraggedReferenceItem<T>(PointerEventData draggingPointer)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RuntimeInspectorUtils.GetAssignableObjectFromDraggedReferenceItem RVA= Token=0x60003A6");
}

		[Token(Token = "0x60003A7")]
		public static T[] GetAssignableObjectsFromDraggedReferenceItem<T>(PointerEventData draggingPointer)
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x4675DFC", Offset = "0x4671DFC", VA = "0x4675DFC")]
		public static object GetAssignableObjectFromDraggedReferenceItem(PointerEventData draggingPointer, Type assignableType)
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x46762EC", Offset = "0x46722EC", VA = "0x46762EC")]
		public static object[] GetAssignableObjectsFromDraggedReferenceItem(PointerEventData draggingPointer, Type assignableType)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x4675E64", Offset = "0x4671E64", VA = "0x4675E64")]
		private static object GetAssignableObjectsFromDraggedReferenceItemInternal(PointerEventData draggingPointer, Type assignableType, bool returnFirstObject)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x4676390", Offset = "0x4672390", VA = "0x4676390")]
		public static void CopyValuesFrom(this Canvas canvas, Canvas referenceCanvas)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x4675474", Offset = "0x4671474", VA = "0x4675474")]
		private static bool CreatePopupCanvas(Canvas referenceCanvas)
		{
			return default;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x46767C0", Offset = "0x46727C0", VA = "0x46767C0")]
		private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x46768E4", Offset = "0x46728E4", VA = "0x46768E4")]
		public static bool IsPointerValid(this PointerEventData eventData)
		{
			return default;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x4676984", Offset = "0x4672984", VA = "0x4676984")]
		public static MemberInfo[] GetAllVariables(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x4677730", Offset = "0x4673730", VA = "0x4677730")]
		public static ExposedMethod[] GetExposedMethods(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x46774A0", Offset = "0x46734A0", VA = "0x46774A0")]
		private static bool IsSerializable(this Type type)
		{
			return default;
		}

		[Token(Token = "0x60003B2")]
		public static bool HasAttribute<T>(this MemberInfo variable) where T : Attribute
		{
			return default;
		}

		[Token(Token = "0x60003B3")]
		public static T GetAttribute<T>(this MemberInfo variable) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		public static T[] GetAttributes<T>(this MemberInfo variable) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x4677CB0", Offset = "0x4673CB0", VA = "0x4677CB0")]
		public static object Instantiate(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x4677EB8", Offset = "0x4673EB8", VA = "0x4677EB8")]
		public static Type GetType(string typeName)
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x4674700", Offset = "0x4670700", VA = "0x4674700")]
		private static void GetExposedExtensionMethods(Type type)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x467826C", Offset = "0x467426C", VA = "0x467826C")]
		public static void AddCustomEditor(Type customEditorType)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x46782C4", Offset = "0x46742C4", VA = "0x46782C4")]
		private static void AddCustomEditorInternal(Type customEditorType, bool showWarnings)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x46786A8", Offset = "0x46746A8", VA = "0x46786A8")]
		public static IRuntimeInspectorCustomEditor GetCustomEditor(Type type)
		{
			return null;
		}
	}
}
