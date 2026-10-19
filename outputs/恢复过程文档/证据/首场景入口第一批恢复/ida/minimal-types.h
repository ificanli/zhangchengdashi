/*
 * Occupy-City / ZhanChengDaShi: minimal ARM64 IL2CPP types for IDA.
 * Static reconstruction from the supplied Il2CppDumper export only.
 * Original exports are unchanged. This header has NOT been parsed in IDA.
 * The current IDA analysis attempt was blocked by its license check.
 *
 * Target assumptions: 64-bit pointers, 32-bit signed int, 1-byte managed bool,
 * maximum normal member alignment 8. Do not use this layout for armeabi-v7a.
 * Unknown bytes are deliberately opaque; they do not denote absent fields.
 * These are partial structure views. In particular, sizeof the scene-manager
 * view is a modeled prefix (0x210), NOT the allocation size of the real class.
 * Import into a database without conflicting complete definitions, or declare
 * only the types that are still missing. Do not replace complete types blindly.
 *
 * Source paths, relative to outputs/IDA analysis material:
 *   Il2Cpp export/il2cpp.h and Il2Cpp export/dump.cs
 * Exact source line evidence is recorded beside each modeled member.
 */
#ifndef ZCDS_MINIMAL_ARM64_TYPES_H
#define ZCDS_MINIMAL_ARM64_TYPES_H

typedef signed int ZCDS_Int32;       /* exact width: 4 bytes */
typedef unsigned char ZCDS_Bool;    /* managed/native bool storage: 1 byte */

/* Opaque metadata: no MethodInfo layout is needed for these prototypes.
 * il2cpp.h line 3 forward-declares MethodInfo; lines 117-142 define it.
 */
typedef struct MethodInfo MethodInfo;

typedef struct GameModule_BattleGameSceneManager_c GameModule_BattleGameSceneManager_c;
typedef struct GameModule_HexBehaviour_c GameModule_HexBehaviour_c;
typedef struct System_Collections_Generic_List_RoleBehaviour__o
    System_Collections_Generic_List_RoleBehaviour__o;

#pragma pack(push, 8)

/*
 * VALUE TYPE: no klass/monitor header.
 * il2cpp.h 6085-6088 and 6104-6106; dump.cs 5127-5131.
 */
typedef struct HexManager_HexCoord_Fields {
    ZCDS_Int32 q; /* fields/o +0x00; dump.cs 5130; il2cpp.h 6086 */
    ZCDS_Int32 r; /* fields/o +0x04; dump.cs 5131; il2cpp.h 6087 */
} HexManager_HexCoord_Fields;

typedef struct HexManager_HexCoord_o {
    HexManager_HexCoord_Fields fields;
} HexManager_HexCoord_o; /* size 0x08, alignment 4 */

/*
 * The original Fields inherits ToolModule_ManagerBase_BattleGameSceneManager__Fields
 * (il2cpp.h 33604). Its inherited/earlier state is preserved as opaque bytes.
 * All dump.cs offsets below are from the OBJECT start, not Fields start.
 */
typedef struct GameModule_BattleGameSceneManager_Fields {
    unsigned char _unknown_object_0010_to_01FF[0x1F0];
    ZCDS_Int32 _playerRoleCount;     /* object +0x200; fields +0x1F0; dump 37305; h 33674 */
    ZCDS_Int32 _enemyRoleCount;      /* object +0x204; fields +0x1F4; dump 37306; h 33675 */
    ZCDS_Int32 _playerReservedCount; /* object +0x208; fields +0x1F8; dump 37308; h 33676 */
    ZCDS_Int32 _enemyReservedCount;  /* object +0x20C; fields +0x1FC; dump 37309; h 33677 */
    /* Deliberately stop here. Real fields continue from object +0x210. */
} GameModule_BattleGameSceneManager_Fields;

typedef struct GameModule_BattleGameSceneManager_o {
    GameModule_BattleGameSceneManager_c* klass; /* +0x00; h 33706 */
    void* monitor;                             /* +0x08; h 33707 */
    GameModule_BattleGameSceneManager_Fields fields; /* +0x10; h 33708 */
} GameModule_BattleGameSceneManager_o;

/*
 * The original Fields inherits UnityEngine_MonoBehaviour_Fields (h 21283).
 * Preserve all unrequested/inherited members as padding at their real offsets.
 */
typedef struct GameModule_HexBehaviour_Fields {
    unsigned char _unknown_object_0010_to_009F[0x90];
    ZCDS_Bool isEnemyHex; /* object +0xA0; fields +0x90; dump 24796; h 21304 */
    ZCDS_Bool isOpened;   /* object +0xA1; fields +0x91; dump 24797; h 21305 */
    unsigned char _unknown_object_00A2_to_01D7[0x136];
    System_Collections_Generic_List_RoleBehaviour__o* _roleEnemyList;
        /* object +0x1D8; fields +0x1C8; dump 24848; h 21356 */
    System_Collections_Generic_List_RoleBehaviour__o* _rolePlayerList;
        /* object +0x1E0; fields +0x1D0; dump 24849; h 21357 */
} GameModule_HexBehaviour_Fields;

typedef struct GameModule_HexBehaviour_o {
    GameModule_HexBehaviour_c* klass; /* +0x00; h 21374 */
    void* monitor;                   /* +0x08; h 21375 */
    GameModule_HexBehaviour_Fields fields; /* +0x10; h 21376 */
} GameModule_HexBehaviour_o;

#pragma pack(pop)

/*
 * ABI prototypes, verified against script.json and dump.cs.
 * The final const MethodInfo* is an IL2CPP hidden argument. It must not be
 * removed just because the visible C# declaration has no such parameter.
 * Static HexDistance has NO __this and passes BOTH HexCoord structs by VALUE.
 * Instance methods have __this first, then explicit arguments, then method.
 * ZCDS_Bool is the explicit 1-byte bool equivalent for this minimal C header.
 * These are declarations only, not reconstructed implementations.
 */

/* RVA 0x3D2A600; dump.cs 5446; script.json Signature line 5088 */
ZCDS_Int32 HexManager__HexDistance(
    HexManager_HexCoord_o a,
    HexManager_HexCoord_o b,
    const MethodInfo* method);

/* RVA 0x3DED9AC; dump.cs 37402; script.json Signature line 30606 */
ZCDS_Int32 GameModule_BattleGameSceneManager__GetAvailableSlots(
    GameModule_BattleGameSceneManager_o* __this,
    ZCDS_Bool isEnemy,
    const MethodInfo* method);

/* RVA 0x44298EC; dump.cs 25163; script.json Signature line 18144 */
void GameModule_HexBehaviour__DetermineHexCamp(
    GameModule_HexBehaviour_o* __this,
    const MethodInfo* method);

/* RVA 0x4424D5C; dump.cs 25015; script.json Signature line 17880 */
void GameModule_HexBehaviour__OpenHex(
    GameModule_HexBehaviour_o* __this,
    ZCDS_Bool isEnemy,
    ZCDS_Bool isHard,
    const MethodInfo* method);

#endif
