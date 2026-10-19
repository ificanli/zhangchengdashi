from pathlib import Path
import re,json,hashlib
r=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20');w=r/'work/parallel-44-battle/synergy-validation';s=(w/'SynergyEffectManager.source-before.cs').read_text(encoding='utf-8-sig')
bodies={
'Init':'''var stateMachine = new _003CInit_003Ed__1();
stateMachine._003C_003Et__builder = AsyncUniTaskMethodBuilder.Create();
stateMachine._003C_003E1__state = -1;
stateMachine._003C_003Et__builder.Start(ref stateMachine);
return stateMachine._003C_003Et__builder.Task;''',
'GetFetterCount':'''if (isEnemy)
{
    switch (fetterType)
    {
        case CardFettersType.Orcs: return AIBehaviourManager.Instance.OrcsCount;
        case CardFettersType.Undead: return AIBehaviourManager.Instance.UnDeadCount;
        case CardFettersType.Terran: return AIBehaviourManager.Instance.TerranCount;
        case CardFettersType.Machine: return AIBehaviourManager.Instance.MachineCount;
        default: return 0;
    }
}
switch (fetterType)
{
    case CardFettersType.Orcs: return EquipCardInfoManager.Instance.OrcsCount;
    case CardFettersType.Undead: return EquipCardInfoManager.Instance.UnDeadCount;
    case CardFettersType.Terran: return EquipCardInfoManager.Instance.TerranCount;
    case CardFettersType.Machine: return EquipCardInfoManager.Instance.MachineCount;
    default: return 0;
}''',
'GetAtkWayTypeCount':'''if (isEnemy)
{
    switch (atkWayType)
    {
        case AtkWayType.Melee: return AIBehaviourManager.Instance.MeleeCount;
        case AtkWayType.Remote: return AIBehaviourManager.Instance.RemoteCount;
        default: return 0;
    }
}
switch (atkWayType)
{
    case AtkWayType.Melee: return EquipCardInfoManager.Instance.MeleeCount;
    case AtkWayType.Remote: return EquipCardInfoManager.Instance.RemoteCount;
    default: return 0;
}''',
'InternalCalculateProductionSpeed':'''if (fetterCount < requiredCount)
    return originalSpawnTime;
float change = originalSpawnTime * -0.1f;
return originalSpawnTime + change;''',
'HumanFetter2':'''if (IsUseNewFetter)
    return originalSpawnTime;
return InternalCalculateProductionSpeed(originalSpawnTime, isEnemy, GetFetterCount(CardFettersType.Terran, isEnemy), 2);''',
'HumanFetter4':'''if (IsUseNewFetter)
    return originalAttack;
return InternalCalculateDamage(originalAttack, isEnemy, GetFetterCount(CardFettersType.Terran, isEnemy), 4);''',
'HumanFetter6':'''if (!IsUseNewFetter && GetFetterCount(CardFettersType.Terran, isEnemy) >= 6)
{
    float bonus = (float)originalOutput * 0.2f;
    return unchecked(originalOutput + (int)bonus);
}
return originalOutput;''',
'HumanFetter6_GoldPerSecond':'''return IsUseNewFetter && GetFetterCount(CardFettersType.Terran, isEnemy) >= 6;''',
'HumanFetter2_BuildingHp':'''if (!IsUseNewFetter)
    return originalHp;
return InternalCalculateDamage(originalHp, isEnemy, GetFetterCount(CardFettersType.Terran, isEnemy), 2);''',
'HumanFetter4_DamageReduction':'''if (IsUseNewFetter && target is RoleBehaviour role && role.CardFettersType == CardFettersType.Terran && GetFetterCount(CardFettersType.Terran, isEnemy) >= 4)
{
    var nearbyRoles = BattleGameSceneManager.Instance.GetNearRole(isEnemy, target, checkRange, -1);
    if (nearbyRoles != null && nearbyRoles.Count > 0)
    {
        float reduction = (float)damage * 0.2f;
        return unchecked(damage - (int)reduction);
    }
}
return damage;''',
'UndeadFetter2':'''if (GetFetterCount(CardFettersType.Undead, isEnemy) < 2)
    return originalSpawnTime;
float change = originalSpawnTime * (IsUseNewFetter ? -0.2f : -0.1f);
return originalSpawnTime + change;''',
'UndeadFetter4':'''if (IsUseNewFetter)
    return originalAttack;
return InternalCalculateDamage(originalAttack, isEnemy, GetFetterCount(CardFettersType.Undead, isEnemy), 4);''',
'UndeadFetter6':'''if (GetFetterCount(CardFettersType.Undead, isEnemy) < 6)
    return false;
return IsUseNewFetter || UnityEngine.Random.Range(0, 100) < 10;''',
'UndeadFetter4_Revive':'''return IsUseNewFetter && GetFetterCount(CardFettersType.Undead, isEnemy) >= 4 && UnityEngine.Random.Range(0, 100) < 10;''',
'UndeadFetter6_ExtraSpawn':'''return IsUseNewFetter && GetFetterCount(CardFettersType.Undead, isEnemy) >= 6;''',
'OrcsFetter2':'''if (IsUseNewFetter)
    return originalSpawnTime;
return InternalCalculateProductionSpeed(originalSpawnTime, isEnemy, GetFetterCount(CardFettersType.Orcs, isEnemy), 2);''',
'OrcsFetter4':'''if (IsUseNewFetter)
    return originalAttack;
return InternalCalculateDamage(originalAttack, isEnemy, GetFetterCount(CardFettersType.Orcs, isEnemy), 4);''',
'OrcsFetter6':'''if (!IsUseNewFetter && GetFetterCount(CardFettersType.Orcs, isEnemy) >= 6)
    return originalVampireObb + 0.2f;
return originalVampireObb;''',
'OrcsFetter2_MoveSpeed':'''if (IsUseNewFetter && GetFetterCount(CardFettersType.Orcs, isEnemy) >= 2)
{
    float bonus = originalMoveSpeed * 0.2f;
    return bonus + originalMoveSpeed;
}
return originalMoveSpeed;''',
'OrcsFetter4_AttackSpeed':'''if (!IsUseNewFetter)
    return false;
int fetterCount = GetFetterCount(CardFettersType.Orcs, isEnemy);
return maxHp > 0 && fetterCount >= 4 && (float)currentHp / (float)maxHp < 0.5f;''',
'OrcsFetter6_BuildingDamage':'''if (IsUseNewFetter && isBuilding && GetFetterCount(CardFettersType.Orcs, isEnemy) >= 6)
{
    float bonus = (float)originalDamage * 0.75f;
    return unchecked(originalDamage + (int)bonus);
}
return originalDamage;''',
'MachineFetter2':'''if (IsUseNewFetter)
    return originalSpawnTime;
return InternalCalculateProductionSpeed(originalSpawnTime, isEnemy, GetFetterCount(CardFettersType.Machine, isEnemy), 2);''',
'MachineFetter4':'''return InternalCalculateDamage(originalAttack, isEnemy, GetFetterCount(CardFettersType.Machine, isEnemy), 4);''',
'MachineFetter6':'''if (!IsUseNewFetter && isBuilding)
    return InternalCalculateDamage(originalDamage, isEnemy, GetFetterCount(CardFettersType.Machine, isEnemy), 6);
return originalDamage;''',
'MeleeFetter3':'''return InternalCalculateProductionSpeed(originalSpawnTime, isEnemy, GetAtkWayTypeCount(AtkWayType.Melee, isEnemy), 3);''',
'MeleeFetter5':'''return InternalCalculateDamage(originalAttack, isEnemy, GetAtkWayTypeCount(AtkWayType.Melee, isEnemy), 5);''',
'MeleeFetter7':'''if (GetAtkWayTypeCount(AtkWayType.Melee, isEnemy) >= 7)
{
    float bonus = (float)originalHp * 0.2f;
    return unchecked(originalHp + (int)bonus);
}
return originalHp;''',
'RemoteFetter3':'''return InternalCalculateProductionSpeed(originalSpawnTime, isEnemy, GetAtkWayTypeCount(AtkWayType.Remote, isEnemy), 3);''',
'RemoteFetter5':'''return InternalCalculateDamage(originalAttack, isEnemy, GetAtkWayTypeCount(AtkWayType.Remote, isEnemy), 5);''',
'RemoteFetter7':'''if (GetAtkWayTypeCount(AtkWayType.Remote, isEnemy) >= 7)
{
    float bonus = originalRange * 0.1f;
    return bonus + originalRange;
}
return originalRange;''',
'MachineFetter2_Range':'''if (IsUseNewFetter && GetFetterCount(CardFettersType.Machine, isEnemy) >= 2)
{
    float bonus = originalRange * 0.2f;
    return bonus + originalRange;
}
return originalRange;''',
'MachineFetter6_RemoteDamageReduction':'''if (atkWayType != AtkWayType.Remote || !IsUseNewFetter)
    return damage;
bool isMachine = (target is RoleBehaviour role && role.CardFettersType == CardFettersType.Machine)
    || (target is ArchitectureBehaviour architecture && architecture.CardFettersType == CardFettersType.Machine);
if (isMachine && GetFetterCount(CardFettersType.Machine, isEnemy) >= 6)
{
    float reduction = (float)damage * 0.5f;
    return unchecked(damage - (int)reduction);
}
return damage;''',
}
for name,body in bodies.items():
 m=re.search(r'\b'+name+r'\([^\{]*\)\s*\{',s)
 if not m:raise Exception(name)
 start=m.end();i=start;n=1
 while n:
  if s[i]=='{':n+=1
  if s[i]=='}':n-=1
  i+=1
 s=s[:start]+'\n'+''.join('\t\t\t'+line+'\n' for line in body.splitlines())+'\t\t'+s[i-1:]
s=s.replace('private bool IsUseNewFetter;','private bool IsUseNewFetter = SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest;')
s=s.replace('void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()\n\t\t\t{\n\t\t\t}', 'void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()\n\t\t\t{\n\t\t\t\t_003C_003E1__state = -2;\n\t\t\t\t_003C_003Et__builder.SetResult();\n\t\t\t}')
s=s.replace('void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)\n\t\t\t{\n\t\t\t}', 'void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)\n\t\t\t{\n\t\t\t\t_003C_003Et__builder.SetStateMachine(stateMachine);\n\t\t\t}')
out=r/'work/parallel-44-battle/candidate/Assets/Scripts/Assembly-CSharp/GameModule/SynergyEffectManager.cs';out.parent.mkdir(parents=True,exist_ok=True);out.write_bytes(s.replace('\n','\r\n').encode('utf-8'))
(w/'recovery-methods.json').write_text(json.dumps({'methods':list(bodies)+['IAsyncStateMachine.MoveNext','IAsyncStateMachine.SetStateMachine'],'fieldInitializer':'IsUseNewFetter','constructor':'Implicit original base invocation retained; initializer executes before base','protected':'InternalCalculateDamage'},ensure_ascii=False,indent=2),encoding='utf-8')
print(len(bodies),'regular methods restored, 2 state-machine methods, initializer restored')


