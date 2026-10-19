// IL code: SingletonCompile
.class private auto ansi '<Module>'
{
} // end of class <Module>

.class public auto ansi beforefieldinit EventModule.EventManager
	extends class ToolModule.ManagerBase`1<class EventModule.EventManager>
{
	.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
		01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 32
		30 30 30 36 32 41
	)
	// Nested Types
	.class nested private auto ansi sealed beforefieldinit _003CInit_003Ed__2
		extends [netstandard]System.ValueType
		implements [netstandard]System.Runtime.CompilerServices.IAsyncStateMachine
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 32
			30 30 30 36 32 42
		)
		.custom instance void [netstandard]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public int32 _003C_003E1__state
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 34
			30 30 33 32 39 31
		)
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.FieldOffsetAttribute::.ctor() = (
			01 00 01 00 53 0e 06 4f 66 66 73 65 74 03 30 78 30
		)
		.field public valuetype [UniTask]Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder _003C_003Et__builder
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 34
			30 30 33 32 39 32
		)
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.FieldOffsetAttribute::.ctor() = (
			01 00 01 00 53 0e 06 4f 66 66 73 65 74 03 30 78 38
		)

		// Methods
		.method private final hidebysig newslot virtual 
			instance void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext () cil managed 
		{
			.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
				01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
				30 30 32 30 41 34
			)
			.custom instance void [Il2CppDummyDll]Il2CppDummyDll.AddressAttribute::.ctor() = (
				01 00 04 00 53 0e 03 52 56 41 09 30 78 33 46 31
				31 44 33 30 53 0e 06 4f 66 66 73 65 74 09 30 78
				33 46 30 44 44 33 30 53 0e 02 56 41 09 30 78 33
				46 31 31 44 33 30 53 0e 04 53 6c 6f 74 01 34
			)
			.override method instance void [netstandard]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext()
			// Method begins at RVA 0x229b
			// Header size: 1
			// Code size: 1 (0x1)
			.maxstack 8

			IL_0000: ret
		} // end of method _003CInit_003Ed__2::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext

		.method private final hidebysig newslot virtual 
			instance void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine (
				class [netstandard]System.Runtime.CompilerServices.IAsyncStateMachine stateMachine
			) cil managed 
		{
			.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
				01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
				30 30 32 30 41 35
			)
			.custom instance void [Il2CppDummyDll]Il2CppDummyDll.AddressAttribute::.ctor() = (
				01 00 04 00 53 0e 03 52 56 41 09 30 78 33 46 31
				31 44 45 34 53 0e 06 4f 66 66 73 65 74 09 30 78
				33 46 30 44 44 45 34 53 0e 02 56 41 09 30 78 33
				46 31 31 44 45 34 53 0e 04 53 6c 6f 74 01 35
			)
			.custom instance void [netstandard]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = (
				01 00 00 00
			)
			.override method instance void [netstandard]System.Runtime.CompilerServices.IAsyncStateMachine::SetStateMachine(class [netstandard]System.Runtime.CompilerServices.IAsyncStateMachine)
			// Method begins at RVA 0x229d
			// Header size: 1
			// Code size: 1 (0x1)
			.maxstack 8

			IL_0000: ret
		} // end of method _003CInit_003Ed__2::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine

	} // end of class _003CInit_003Ed__2


	// Fields
	.field private initonly class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> _eventWithObjectDictionary
	.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
		01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 34
		30 30 33 32 38 46
	)
	.custom instance void [Il2CppDummyDll]Il2CppDummyDll.FieldOffsetAttribute::.ctor() = (
		01 00 01 00 53 0e 06 4f 66 66 73 65 74 04 30 78
		32 30
	)
	.field private initonly class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> _eventOnceObjectDictionary
	.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
		01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 34
		30 30 33 32 39 30
	)
	.custom instance void [Il2CppDummyDll]Il2CppDummyDll.FieldOffsetAttribute::.ctor() = (
		01 00 01 00 53 0e 06 4f 66 66 73 65 74 04 30 78
		32 38
	)

	// Methods
	.method public hidebysig virtual 
		instance valuetype [UniTask]Cysharp.Threading.Tasks.UniTask Init () cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 32 30 39 44
		)
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.AddressAttribute::.ctor() = (
			01 00 04 00 53 0e 03 52 56 41 09 30 78 33 46 31
			31 39 33 34 53 0e 06 4f 66 66 73 65 74 09 30 78
			33 46 30 44 39 33 34 53 0e 02 56 41 09 30 78 33
			46 31 31 39 33 34 53 0e 04 53 6c 6f 74 01 34
		)
		// Method begins at RVA 0x2050
		// Header size: 1
		// Code size: 6 (0x6)
		.maxstack 8

		IL_0000: ldsfld valuetype [UniTask]Cysharp.Threading.Tasks.UniTask [UniTask]Cysharp.Threading.Tasks.UniTask::CompletedTask
		IL_0005: ret
	} // end of method EventManager::Init

	.method public hidebysig 
		instance void StartListening (
			string eventName,
			class [netstandard]System.Action`1<object> listener
		) cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 32 30 39 45
		)
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.AddressAttribute::.ctor() = (
			01 00 03 00 53 0e 03 52 56 41 09 30 78 33 46 30
			37 46 33 43 53 0e 06 4f 66 66 73 65 74 09 30 78
			33 46 30 33 46 33 43 53 0e 02 56 41 09 30 78 33
			46 30 37 46 33 43
		)
		// Method begins at RVA 0x2058
		// Header size: 12
		// Code size: 68 (0x44)
		.maxstack 4
		.locals init (
			[0] class [netstandard]System.Action`1<object>,
			[1] class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>,
			[2] string
		)

		IL_0000: ldarg.0
		IL_0001: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventWithObjectDictionary
		IL_0006: ldarg.1
		IL_0007: ldloca.s 0
		IL_0009: callvirt instance bool class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::TryGetValue(!0, !1&)
		IL_000e: brfalse.s IL_0036

		IL_0010: ldloc.0
		IL_0011: brfalse.s IL_0036

		IL_0013: ldarg.0
		IL_0014: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventWithObjectDictionary
		IL_0019: stloc.1
		IL_001a: ldarg.1
		IL_001b: stloc.2
		IL_001c: ldloc.1
		IL_001d: ldloc.2
		IL_001e: ldloc.1
		IL_001f: ldloc.2
		IL_0020: callvirt instance !1 class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::get_Item(!0)
		IL_0025: ldarg.2
		IL_0026: call class [netstandard]System.Delegate [netstandard]System.Delegate::Combine(class [netstandard]System.Delegate, class [netstandard]System.Delegate)
		IL_002b: castclass class [netstandard]System.Action`1<object>
		IL_0030: callvirt instance void class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::set_Item(!0, !1)
		IL_0035: ret

		IL_0036: ldarg.0
		IL_0037: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventWithObjectDictionary
		IL_003c: ldarg.1
		IL_003d: ldarg.2
		IL_003e: callvirt instance void class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::set_Item(!0, !1)
		IL_0043: ret
	} // end of method EventManager::StartListening

	.method public hidebysig 
		instance void StopListening (
			string eventName,
			class [netstandard]System.Action`1<object> listener
		) cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 32 30 39 46
		)
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.AddressAttribute::.ctor() = (
			01 00 03 00 53 0e 03 52 56 41 09 30 78 33 46 30
			35 44 39 34 53 0e 06 4f 66 66 73 65 74 09 30 78
			33 46 30 31 44 39 34 53 0e 02 56 41 09 30 78 33
			46 30 35 44 39 34
		)
		// Method begins at RVA 0x20a8
		// Header size: 12
		// Code size: 44 (0x2c)
		.maxstack 4
		.locals init (
			[0] class [netstandard]System.Action`1<object>
		)

		IL_0000: ldarg.0
		IL_0001: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventWithObjectDictionary
		IL_0006: ldarg.1
		IL_0007: ldloca.s 0
		IL_0009: callvirt instance bool class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::TryGetValue(!0, !1&)
		IL_000e: brfalse.s IL_002b

		IL_0010: ldloc.0
		IL_0011: brfalse.s IL_002b

		IL_0013: ldarg.0
		IL_0014: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventWithObjectDictionary
		IL_0019: ldarg.1
		IL_001a: ldloc.0
		IL_001b: ldarg.2
		IL_001c: call class [netstandard]System.Delegate [netstandard]System.Delegate::Remove(class [netstandard]System.Delegate, class [netstandard]System.Delegate)
		IL_0021: castclass class [netstandard]System.Action`1<object>
		IL_0026: callvirt instance void class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::set_Item(!0, !1)

		IL_002b: ret
	} // end of method EventManager::StopListening

	.method public hidebysig 
		instance void StartListeningOnce (
			string eventName,
			class [netstandard]System.Action`1<object> listener
		) cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 32 30 41 30
		)
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.AddressAttribute::.ctor() = (
			01 00 03 00 53 0e 03 52 56 41 09 30 78 33 46 31
			31 39 42 34 53 0e 06 4f 66 66 73 65 74 09 30 78
			33 46 30 44 39 42 34 53 0e 02 56 41 09 30 78 33
			46 31 31 39 42 34
		)
		// Method begins at RVA 0x20e0
		// Header size: 12
		// Code size: 68 (0x44)
		.maxstack 4
		.locals init (
			[0] class [netstandard]System.Action`1<object>,
			[1] class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>,
			[2] string
		)

		IL_0000: ldarg.0
		IL_0001: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventOnceObjectDictionary
		IL_0006: ldarg.1
		IL_0007: ldloca.s 0
		IL_0009: callvirt instance bool class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::TryGetValue(!0, !1&)
		IL_000e: brfalse.s IL_0036

		IL_0010: ldloc.0
		IL_0011: brfalse.s IL_0036

		IL_0013: ldarg.0
		IL_0014: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventOnceObjectDictionary
		IL_0019: stloc.1
		IL_001a: ldarg.1
		IL_001b: stloc.2
		IL_001c: ldloc.1
		IL_001d: ldloc.2
		IL_001e: ldloc.1
		IL_001f: ldloc.2
		IL_0020: callvirt instance !1 class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::get_Item(!0)
		IL_0025: ldarg.2
		IL_0026: call class [netstandard]System.Delegate [netstandard]System.Delegate::Combine(class [netstandard]System.Delegate, class [netstandard]System.Delegate)
		IL_002b: castclass class [netstandard]System.Action`1<object>
		IL_0030: callvirt instance void class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::set_Item(!0, !1)
		IL_0035: ret

		IL_0036: ldarg.0
		IL_0037: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventOnceObjectDictionary
		IL_003c: ldarg.1
		IL_003d: ldarg.2
		IL_003e: callvirt instance void class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::set_Item(!0, !1)
		IL_0043: ret
	} // end of method EventManager::StartListeningOnce

	.method public hidebysig 
		instance void StopListeningOnce (
			string eventName,
			class [netstandard]System.Action`1<object> listener
		) cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 32 30 41 31
		)
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.AddressAttribute::.ctor() = (
			01 00 03 00 53 0e 03 52 56 41 09 30 78 33 46 31
			31 42 34 38 53 0e 06 4f 66 66 73 65 74 09 30 78
			33 46 30 44 42 34 38 53 0e 02 56 41 09 30 78 33
			46 31 31 42 34 38
		)
		// Method begins at RVA 0x2130
		// Header size: 12
		// Code size: 44 (0x2c)
		.maxstack 4
		.locals init (
			[0] class [netstandard]System.Action`1<object>
		)

		IL_0000: ldarg.0
		IL_0001: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventOnceObjectDictionary
		IL_0006: ldarg.1
		IL_0007: ldloca.s 0
		IL_0009: callvirt instance bool class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::TryGetValue(!0, !1&)
		IL_000e: brfalse.s IL_002b

		IL_0010: ldloc.0
		IL_0011: brfalse.s IL_002b

		IL_0013: ldarg.0
		IL_0014: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventOnceObjectDictionary
		IL_0019: ldarg.1
		IL_001a: ldloc.0
		IL_001b: ldarg.2
		IL_001c: call class [netstandard]System.Delegate [netstandard]System.Delegate::Remove(class [netstandard]System.Delegate, class [netstandard]System.Delegate)
		IL_0021: castclass class [netstandard]System.Action`1<object>
		IL_0026: callvirt instance void class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::set_Item(!0, !1)

		IL_002b: ret
	} // end of method EventManager::StopListeningOnce

	.method public hidebysig 
		instance void TriggerEvent (
			string eventName,
			[opt] object parameter
		) cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 32 30 41 32
		)
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.AddressAttribute::.ctor() = (
			01 00 03 00 53 0e 03 52 56 41 09 30 78 33 46 30
			35 46 36 34 53 0e 06 4f 66 66 73 65 74 09 30 78
			33 46 30 31 46 36 34 53 0e 02 56 41 09 30 78 33
			46 30 35 46 36 34
		)
		.param [2] = nullref
		// Method begins at RVA 0x2168
		// Header size: 12
		// Code size: 66 (0x42)
		.maxstack 3
		.locals init (
			[0] class [netstandard]System.Action`1<object>,
			[1] class [netstandard]System.Action`1<object>
		)

		IL_0000: ldarg.0
		IL_0001: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventWithObjectDictionary
		IL_0006: ldarg.1
		IL_0007: ldloca.s 0
		IL_0009: callvirt instance bool class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::TryGetValue(!0, !1&)
		IL_000e: brfalse.s IL_001a

		IL_0010: ldloc.0
		IL_0011: brfalse.s IL_001a

		IL_0013: ldloc.0
		IL_0014: ldarg.2
		IL_0015: callvirt instance void class [netstandard]System.Action`1<object>::Invoke(!0)

		IL_001a: ldarg.0
		IL_001b: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventOnceObjectDictionary
		IL_0020: ldarg.1
		IL_0021: ldloca.s 1
		IL_0023: callvirt instance bool class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::TryGetValue(!0, !1&)
		IL_0028: brfalse.s IL_0041

		IL_002a: ldloc.1
		IL_002b: brfalse.s IL_0041

		IL_002d: ldarg.0
		IL_002e: ldfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventOnceObjectDictionary
		IL_0033: ldarg.1
		IL_0034: callvirt instance bool class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::Remove(!0)
		IL_0039: pop
		IL_003a: ldloc.1
		IL_003b: ldarg.2
		IL_003c: callvirt instance void class [netstandard]System.Action`1<object>::Invoke(!0)

		IL_0041: ret
	} // end of method EventManager::TriggerEvent

	.method public hidebysig specialname rtspecialname 
		instance void .ctor () cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 32 30 41 33
		)
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.AddressAttribute::.ctor() = (
			01 00 03 00 53 0e 03 52 56 41 09 30 78 33 46 31
			31 43 38 38 53 0e 06 4f 66 66 73 65 74 09 30 78
			33 46 30 44 43 38 38 53 0e 02 56 41 09 30 78 33
			46 31 31 43 38 38
		)
		// Method begins at RVA 0x21b6
		// Header size: 1
		// Code size: 29 (0x1d)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: newobj instance void class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::.ctor()
		IL_0006: stfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventWithObjectDictionary
		IL_000b: ldarg.0
		IL_000c: newobj instance void class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>>::.ctor()
		IL_0011: stfld class [netstandard]System.Collections.Generic.Dictionary`2<string, class [netstandard]System.Action`1<object>> EventModule.EventManager::_eventOnceObjectDictionary
		IL_0016: ldarg.0
		IL_0017: call instance void class ToolModule.ManagerBase`1<class EventModule.EventManager>::.ctor()
		IL_001c: ret
	} // end of method EventManager::.ctor

} // end of class EventModule.EventManager

.class public auto ansi abstract beforefieldinit ToolModule.ManagerBase`1<([UnityEngine.CoreModule]UnityEngine.MonoBehaviour) T>
	extends [UnityEngine.CoreModule]UnityEngine.MonoBehaviour
{
	.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
		01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 32
		30 30 30 31 38 44
	)
	// Fields
	.field private static !T _instance
	.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
		01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 34
		30 30 31 41 41 45
	)
	.custom instance void [Il2CppDummyDll]Il2CppDummyDll.FieldOffsetAttribute::.ctor() = (
		01 00 01 00 53 0e 06 4f 66 66 73 65 74 03 30 78 30
	)

	// Methods
	.method public hidebysig specialname static 
		!T get_Instance () cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 30 36 35 35
		)
		// Method begins at RVA 0x21d4
		// Header size: 12
		// Code size: 130 (0x82)
		.maxstack 2
		.locals init (
			[0] class [UnityEngine.CoreModule]UnityEngine.GameObject,
			[1] class ['Assembly-CSharp']CoreModule.GameLauncher
		)

		IL_0000: ldsfld !0 class ToolModule.ManagerBase`1<!T>::_instance
		IL_0005: box !T
		IL_000a: call bool [UnityEngine.CoreModule]UnityEngine.Object::op_Implicit(class [UnityEngine.CoreModule]UnityEngine.Object)
		IL_000f: brtrue.s IL_007c

		IL_0011: ldtoken !T
		IL_0016: call class [netstandard]System.Type [netstandard]System.Type::GetTypeFromHandle(valuetype [netstandard]System.RuntimeTypeHandle)
		IL_001b: call class [UnityEngine.CoreModule]UnityEngine.Object [UnityEngine.CoreModule]UnityEngine.Object::FindObjectOfType(class [netstandard]System.Type)
		IL_0020: unbox.any !T
		IL_0025: stsfld !0 class ToolModule.ManagerBase`1<!T>::_instance
		IL_002a: ldsfld !0 class ToolModule.ManagerBase`1<!T>::_instance
		IL_002f: box !T
		IL_0034: ldnull
		IL_0035: call bool [UnityEngine.CoreModule]UnityEngine.Object::op_Equality(class [UnityEngine.CoreModule]UnityEngine.Object, class [UnityEngine.CoreModule]UnityEngine.Object)
		IL_003a: brfalse.s IL_007c

		IL_003c: ldtoken !T
		IL_0041: call class [netstandard]System.Type [netstandard]System.Type::GetTypeFromHandle(valuetype [netstandard]System.RuntimeTypeHandle)
		IL_0046: callvirt instance string [netstandard]System.Reflection.MemberInfo::get_Name()
		IL_004b: newobj instance void [UnityEngine.CoreModule]UnityEngine.GameObject::.ctor(string)
		IL_0050: stloc.0
		IL_0051: ldloc.0
		IL_0052: callvirt instance !!0 [UnityEngine.CoreModule]UnityEngine.GameObject::AddComponent<!T>()
		IL_0057: stsfld !0 class ToolModule.ManagerBase`1<!T>::_instance
		IL_005c: call !!0 [UnityEngine.CoreModule]UnityEngine.Object::FindObjectOfType<class ['Assembly-CSharp']CoreModule.GameLauncher>()
		IL_0061: stloc.1
		IL_0062: ldloc.1
		IL_0063: ldnull
		IL_0064: call bool [UnityEngine.CoreModule]UnityEngine.Object::op_Inequality(class [UnityEngine.CoreModule]UnityEngine.Object, class [UnityEngine.CoreModule]UnityEngine.Object)
		IL_0069: brfalse.s IL_007c

		IL_006b: ldloc.0
		IL_006c: callvirt instance class [UnityEngine.CoreModule]UnityEngine.Transform [UnityEngine.CoreModule]UnityEngine.GameObject::get_transform()
		IL_0071: ldloc.1
		IL_0072: callvirt instance class [UnityEngine.CoreModule]UnityEngine.Transform [UnityEngine.CoreModule]UnityEngine.Component::get_transform()
		IL_0077: callvirt instance void [UnityEngine.CoreModule]UnityEngine.Transform::SetParent(class [UnityEngine.CoreModule]UnityEngine.Transform)

		IL_007c: ldsfld !0 class ToolModule.ManagerBase`1<!T>::_instance
		IL_0081: ret
	} // end of method ManagerBase`1::get_Instance

	.method public hidebysig newslot abstract virtual 
		instance valuetype [UniTask]Cysharp.Threading.Tasks.UniTask Init () cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 30 36 35 36
		)
	} // end of method ManagerBase`1::Init

	.method public hidebysig 
		instance !!T2 CreateSubController<([UnityEngine.CoreModule]UnityEngine.MonoBehaviour) T2> () cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 30 36 35 37
		)
		// Method begins at RVA 0x2262
		// Header size: 1
		// Code size: 48 (0x30)
		.maxstack 8

		IL_0000: ldtoken !!T2
		IL_0005: call class [netstandard]System.Type [netstandard]System.Type::GetTypeFromHandle(valuetype [netstandard]System.RuntimeTypeHandle)
		IL_000a: callvirt instance string [netstandard]System.Reflection.MemberInfo::get_Name()
		IL_000f: newobj instance void [UnityEngine.CoreModule]UnityEngine.GameObject::.ctor(string)
		IL_0014: callvirt instance !!0 [UnityEngine.CoreModule]UnityEngine.GameObject::AddComponent<!!T2>()
		IL_0019: dup
		IL_001a: box !!T2
		IL_001f: callvirt instance class [UnityEngine.CoreModule]UnityEngine.Transform [UnityEngine.CoreModule]UnityEngine.Component::get_transform()
		IL_0024: ldarg.0
		IL_0025: call instance class [UnityEngine.CoreModule]UnityEngine.Transform [UnityEngine.CoreModule]UnityEngine.Component::get_transform()
		IL_002a: callvirt instance void [UnityEngine.CoreModule]UnityEngine.Transform::SetParent(class [UnityEngine.CoreModule]UnityEngine.Transform)
		IL_002f: ret
	} // end of method ManagerBase`1::CreateSubController

	.method family hidebysig specialname rtspecialname 
		instance void .ctor () cil managed 
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 09 30 78 36
			30 30 30 36 35 38
		)
		// Method begins at RVA 0x2293
		// Header size: 1
		// Code size: 7 (0x7)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [UnityEngine.CoreModule]UnityEngine.MonoBehaviour::.ctor()
		IL_0006: ret
	} // end of method ManagerBase`1::.ctor

	// Properties
	.property !T Instance()
	{
		.custom instance void [Il2CppDummyDll]Il2CppDummyDll.TokenAttribute::.ctor() = (
			01 00 01 00 53 0e 05 54 6f 6b 65 6e 0a 30 78 31
			37 30 30 30 30 39 32
		)
		.get !0 ToolModule.ManagerBase`1::get_Instance()
	}

} // end of class ToolModule.ManagerBase`1

