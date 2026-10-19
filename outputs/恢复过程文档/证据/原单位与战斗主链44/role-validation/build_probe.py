from pathlib import Path
import sys,json,re
from restore_role import ROOT,WORK,DEST,extract
OWN=Path(__file__).resolve().parent
baseline='--baseline' in sys.argv
source=OWN/'source-before.cs' if baseline else DEST
members=extract(source.read_text(encoding='utf-8-sig'))
properties={0x3d7f7d0:('bool','HasSkill'),0x3d84470:('bool','WebGLNavigationIsValid'),0x3d844bc:('bool','WebGLNavigationCanMove'),0x3d84514:('bool','WebGLNavigationCanSoftSeparate'),0x3d84618:('TargetType','WebGLNavigationTargetType'),0x3d84620:('float','WebGLNavigationMoveSpeed'),0x3d84668:('float','WebGLNavigationRadius'),0x3d84688:('float','WebGLNavigationAttackRange')}
selected=set(int(x['rva'],16) for x in json.loads((OWN/'native-oracle.json').read_text()))
selected.update([0x3d81228,0x3d8d738,0x3d8d5a8,0x3d848f0,0x3d849c4,0x3d7ab7c,0x3d7eda8,0x3d8e1e4,0x3d81238,0x3d8d3f8,0x3d848e4,0x3d8237c,0x3d821a0,0x3d82110,0x3d81f00])
methods=[]
for rva in sorted(selected):
    m=members[rva]
    if rva in properties:
        typ,name=properties[rva];header=f'public {typ} {name}()'
    else:
        header=re.sub(r'\b(private|protected|internal)\b','public',m['declaration'])
        header=re.sub(r'\b(virtual|override)\b','',header)
    methods.append(header+'\n{'+m['body']+'\n}')
fieldtext='''
public bool hadInit, hadRecycle, destroying, Skilling, isFreeze, isDizzy, attacking, _isAttackingWall, _isBreakingWall;
public bool followerEntityCurrentCanMove, followerEntityCurrentEnableLocalAvoidance, followerEntityNeedSearchPath, firstSkill;
public bool isShocking,StealthIng;
public float followerEntityCurrentSpeed,followerEntityCurrentRadius,skillRequireCount,_bornScaleX;
public float followerEntityLastSearchPathTime,_followerEntityLastTargetSyncTime,_bornFollowerRadius,_lastFindTargetRange,_nextFindTargetTime;
public float _attackWallStateEnterTime,_lastWatchdogMoveTime,dizzyTime,freezeEndTime;
public int _instanceID,_lastRoleTargetHexDistance;
public TargetType TargetType;public AtkWayType AtkWayType;
public bool isEnemy;
public RolePropertyTemp PropertyTemp;
public RoleBehaviour _lastTrackedRoleTarget;public EntityBase _RoleBehaviour;
public HexBehaviour _currentHex;
public Pathfinding.FollowerEntity followerEntity;
public GameObject IceBall,stunEffect;
public List<float> attackDamageDelay,allPosLength;
public List<RoleBehaviour> linkRoleList,targetList;
public List<Vector3> allPos;
public readonly List<Vector3> _targetRemainingPathPoints;
public StringBuilder _damageTextBuilder;
public T GetComponent<T>() where T:new(){return new T();}
'''
text='''using System;using System.Collections.Generic;using System.Text;using System.Reflection;using System.Text.Json;using UnityEngine;using Pathfinding;using Object=UnityEngine.Object;
'''+(OWN/'ProbeAdapters.cs').read_text()+ '\npublic class RoleBehaviour:EntityBase\n{\n'+fieldtext+'\n'+'\n'.join(methods)+'\n}\n'+(OWN/'ProbeProgram.cs').read_text()
(OWN/'Program.generated.cs').write_text(text,encoding='utf-8')
(OWN/'RoleProbe.csproj').write_text('''<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework><EnableDefaultCompileItems>false</EnableDefaultCompileItems><Nullable>disable</Nullable><NoWarn>0649;0436</NoWarn></PropertyGroup><ItemGroup><Compile Include="Program.generated.cs" /></ItemGroup></Project>''',encoding='utf-8')
(OWN/('baseline-extraction.json' if baseline else 'candidate-extraction.json')).write_text(json.dumps({'source':str(source),'methods':len(selected),'rvas':[hex(x) for x in sorted(selected)]},indent=2),encoding='utf-8')
print('EXTRACTED',len(selected),'baseline' if baseline else 'candidate')
