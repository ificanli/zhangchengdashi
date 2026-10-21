using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Serialization
{
	[Token(Token = "0x2000252")]
	public class TinyJsonDeserializer
	{
		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TextReader reader;

		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string fullTextDebug;

		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject contextRoot;

		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly NumberFormatInfo numberFormat = NumberFormatInfo.InvariantInfo;

		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private StringBuilder builder;

		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x4480D60", Offset = "0x447CD60", VA = "0x4480D60")]
		public static object Deserialize(string text, Type type, [Optional] object populate, [Optional] GameObject contextRoot)
		{
 var parser = new TinyJsonDeserializer { reader = new StringReader(text), fullTextDebug = text, contextRoot = contextRoot };
 return parser.Deserialize(type, populate);
}

		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x448488C", Offset = "0x448088C", VA = "0x448488C")]
		private object Deserialize(Type tp, [Optional] object populate)
		{
 if (tp.IsEnum) return Enum.Parse(tp, EatField());
 if (TryEat('n')) { Eat("ull"); TryEat(','); return null; }
 if (tp == typeof(float)) return float.Parse(EatField(), numberFormat);
 if (tp == typeof(int)) return int.Parse(EatField(), numberFormat);
 if (tp == typeof(uint)) return uint.Parse(EatField(), numberFormat);
 if (tp == typeof(bool)) return bool.Parse(EatField());
 if (tp == typeof(string)) return EatField();
 if (tp == typeof(Version)) return new Version(EatField());
 if (tp == typeof(Vector2)) {
  Eat("{"); EatField(); float x = float.Parse(EatField(), numberFormat); EatField(); float y = float.Parse(EatField(), numberFormat); Eat("}"); return new Vector2(x, y);
 }
 if (tp == typeof(Vector3)) {
  Eat("{"); EatField(); float x = float.Parse(EatField(), numberFormat); EatField(); float y = float.Parse(EatField(), numberFormat); EatField(); float z = float.Parse(EatField(), numberFormat); Eat("}"); return new Vector3(x, y, z);
 }
 if (tp == typeof(Pathfinding.Util.Guid)) {
  Eat("{"); EatField(); var guid = Pathfinding.Util.Guid.Parse(EatField()); Eat("}"); return guid;
 }
 if (tp == typeof(LayerMask)) {
  Eat("{"); EatField(); LayerMask mask = int.Parse(EatField()); Eat("}"); return mask;
 }
 if (tp.IsGenericType && tp.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.List<>)) {
  var list = (global::System.Collections.IList)Activator.CreateInstance(tp);
  Type element = tp.GetGenericArguments()[0];
  Eat("[");
  while (!TryEat(']')) { list.Add(Deserialize(element, null)); TryEat(','); }
  return list;
 }
 if (tp.IsArray) {
  var list = new global::System.Collections.Generic.List<object>();
  Eat("[");
  bool finished = TryEat(']'); Type element = tp.GetElementType();
  while (!finished) { list.Add(Deserialize(element, null)); TryEat(','); finished = TryEat(']'); element = tp.GetElementType(); }
  var array = Array.CreateInstance(element, list.Count); list.ToArray().CopyTo(array, 0); return array;
 }
 if (typeof(UnityEngine.Object).IsAssignableFrom(tp)) return DeserializeUnityObject();
 Eat("{");
 if (tp.GetCustomAttributes(typeof(JsonDynamicTypeAttribute), true).Length != 0) {
  string field = EatField();
  if (field != "@type") throw new Exception("Expected field '@type' but found '" + field + "'\n\nWhen trying to deserialize: " + fullTextDebug);
  string name = EatField();
  object[] aliases = tp.GetCustomAttributes(typeof(JsonDynamicTypeAliasAttribute), true);
  string shortName = name.Split(',')[0]; tp = null;
  foreach (JsonDynamicTypeAliasAttribute alias in aliases) if (alias.alias == shortName) tp = alias.type;
  if (tp == null) tp = Type.GetType(name);
  if (tp == null) throw new Exception("Could not find a type with the name '" + name + "'\n\nWhen trying to deserialize: " + fullTextDebug);
 }
 object result = populate ?? Activator.CreateInstance(tp);
 while (!TryEat('}')) {
  string name = EatField();
  global::System.Reflection.FieldInfo field = null;
  Type current = tp;
  while (field == null && current != null) { field = current.GetField(name, (global::System.Reflection.BindingFlags)52); current = current.BaseType; }
  if (field != null) field.SetValue(result, Deserialize(field.FieldType, null));
  else {
   global::System.Reflection.PropertyInfo property = null; current = tp;
   while (property == null && current != null) { property = current.GetProperty(name, (global::System.Reflection.BindingFlags)52); current = current.BaseType; }
   if (property != null) property.SetValue(result, Deserialize(property.PropertyType, null), null); else SkipFieldData();
  }
  TryEat(',');
 }
 return result;
}

		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x4485CFC", Offset = "0x4481CFC", VA = "0x4485CFC")]
		private UnityEngine.Object DeserializeUnityObject()
		{
			return null;
		}

		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x4485ED4", Offset = "0x4481ED4", VA = "0x4485ED4")]
		private UnityEngine.Object DeserializeUnityObjectInner()
		{
			return null;
		}

		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x44864A8", Offset = "0x44824A8", VA = "0x44864A8")]
		private void EatWhitespace()
		{
 while (char.IsWhiteSpace((char)reader.Peek())) reader.Read();
}

		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x4485AB0", Offset = "0x4481AB0", VA = "0x4485AB0")]
		private void Eat(string s)
		{
 EatWhitespace();
 for (int i = 0; i < s.Length; i++) {
  char found = (char)reader.Read();
  if (s[i] != found) throw new Exception("Expected '" + s[i] + "' found '" + found + "'\n\n..." + reader.ReadToEnd() + "\n\nWhen trying to deserialize: " + fullTextDebug);
 }
}

		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x4486544", Offset = "0x4482544", VA = "0x4486544")]
		private string EatUntil(string c, bool inString)
		{
 builder.Length = 0;
 bool escaped = false;
 while (true) {
  int next = reader.Peek();
  if (next == -1) throw new Exception("Unexpected EOF\n\nWhen trying to deserialize: " + fullTextDebug);
  char ch = (char)next;
  if (!escaped && ch == '"') inString = !inString;
  bool escape = !escaped && ch == '\\';
  if (!escape) {
   if (!inString && c.IndexOf(ch) != -1) return builder.ToString();
   builder.Append(ch);
  }
  reader.Read();
  escaped = escape;
 }
}

		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x4485A50", Offset = "0x4481A50", VA = "0x4485A50")]
		private bool TryEat(char c)
		{
 EatWhitespace();
 if ((char)reader.Peek() != c) return false;
 reader.Read();
 return true;
}

		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x44859C8", Offset = "0x44819C8", VA = "0x44859C8")]
		private string EatField()
		{
 bool quoted = TryEat('"');
 string result = EatUntil("\",}]", quoted);
 TryEat('"'); TryEat(':'); TryEat(',');
 return result;
}

		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x4485D80", Offset = "0x4481D80", VA = "0x4485D80")]
		private void SkipFieldData()
		{
 EatUntil(",{}[]", false);
 int depth = 0;
 while (true) {
  char next = (char)reader.Peek();
  if (next == '}' || next == ']') { if (--depth < 0) return; }
  else if (next == '{' || next == '[') depth++;
  else if (next == ',') { if (depth == 0) { reader.Read(); return; } }
  else throw new Exception("Should not reach this part");
  reader.Read();
  EatUntil(",{}[]", false);
 }
}

		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x448482C", Offset = "0x448082C", VA = "0x448482C")]
		public TinyJsonDeserializer()
		{ builder = new StringBuilder(); }
	}
}
