using System;using System.Collections.Generic;using System.Text;using System.Text.Json;using UnityEngine;using Object=UnityEngine.Object;
public enum AtkWayType {Melee,Remote,Null}public enum CardFettersType {Orcs,Undead,Terran,Machine,Null}public enum DeadType {Common,HellFire}
public static class State {public static List<string> Trace=new();public static int HurtDamage,Roll,Synergy,Heal;public static float HurtMiss;public static bool Hell;}
namespace UnityEngine {
public class Object{}public class Transform {public Vector3 position;}
public struct Vector3 {public float x,y,z;}
public struct Color {public float r,g,b,a;public Color(float r,float g,float b,float a){this.r=r;this.g=g;this.b=b;this.a=a;}}
public static class Random {public static int Range(int min,int max){if(min!=0||max!=101)throw new Exception("range");State.Trace.Add("random");return State.Roll;}}
public static class Time {public static float time=9;}
}
public class EntityBase:UnityEngine.Object{public bool isDead;public Transform transform=new();}
public class Props {public string id;public int hp;public float missObb,damageReduceObb;}
public static class CoreGameManager {public static bool Gaming;}
public class SynergyEffectManager {
public static SynergyEffectManager Instance=new();
public int HumanFetter4_DamageReduction(int damage,EntityBase target,bool enemy,float range){State.Trace.Add("human:"+damage);return State.Synergy;}
public int MachineFetter6_RemoteDamageReduction(int damage,EntityBase target,bool enemy,AtkWayType way){State.Trace.Add("machine:"+damage);return State.Synergy;}
}
public class BattleGameManager {public static BattleGameManager Instance=new();public void RecordDamage(string id,int damage){State.Trace.Add("record:"+damage);}public void RecordBuildDamage(string id,int damage){State.Trace.Add("record-build:"+damage);}}
public class FloatingTextManager {public static FloatingTextManager Instance=new();public Color GetDamageTextColor(bool enemy,bool heal){State.Trace.Add("color");return new Color(1,.5f,.25f,1);}}
namespace AssetsModule {public class EffectManager {public static EffectManager Instance=new();public void ShowEffect(string path,Vector3 pos,Vector3 scale,float delay){if(path!="Assets/_Res/Addressable/EffectsBundle/Effects/BloodExplosionSpiky.prefab"||delay!=1)throw new Exception("fx contract");State.Trace.Add("fx");}}}
public class AudioManager {public static AudioManager Instance=new();public void PlaySFX(string path,Transform target,float pitch,int priority){if(path!="Assets/_Res/Addressable/AudiosBundle/SFX/Hit1.mp3"||pitch!=1||priority!=0)throw new Exception("audio contract");State.Trace.Add("audio");}}
public class RoleBehaviour:EntityBase {
public Props PropertyTemp;public bool Skilling,isEnemy;public EntityBase AttackObj;public CardFettersType CardFettersType;public float frontWoundTime,linkNum;
public List<RoleBehaviour> linkRoleList;public StringBuilder _damageTextBuilder=new(16);
public (int,float) OnHurtTalentTrigger(int damage){State.Trace.Add("hurt:"+damage);return(State.HurtDamage,State.HurtMiss);}
public void ShowDamageText(string text,Color color){State.Trace.Add("text:"+text);}
public void OnHealthChangeTalentTrigger(){State.Trace.Add("health");PropertyTemp.hp=unchecked(PropertyTemp.hp+State.Heal);}
public void UpdateHpBar(){State.Trace.Add("hpbar");}
public void Dead(DeadType type){State.Trace.Add("dead:"+(int)type);isDead=true;}
public bool GetIsHellFireAtk(object link){State.Trace.Add("hell");return State.Hell;}
public void OnKillTalentTrigger(){State.Trace.Add("kill");}
public virtual void Wound(int damage,string id,bool isBuild,EntityBase target,bool isLandRole,AtkWayType atkWayType,CardFettersType fetterType,Object linkAttackObj)
{
			if (this == null || !CoreGameManager.Gaming || isDead || PropertyTemp == null)
			    return;
			if (damage == 0 || (PropertyTemp.id == "1012" && Skilling))
			    return;
			AttackObj = target;
			var hurt = OnHurtTalentTrigger(damage);
			int remaining = hurt.Item1;
			float dodge = (hurt.Item2 + PropertyTemp.missObb) * 100f;
			if (dodge > UnityEngine.Random.Range(0, 101))
			{
			    ShowDamageText("闪避", new Color(0f, 0f, 1f, 1f));
			    return;
			}
			frontWoundTime = Time.time;
			float reductionValue = PropertyTemp.damageReduceObb * (float)remaining;
			int reduction = float.IsPositiveInfinity(reductionValue) ? int.MinValue
			    : float.IsNaN(reductionValue) ? 0
			    : reductionValue >= 2147483648f ? int.MaxValue
			    : reductionValue <= -2147483648f ? int.MinValue : (int)reductionValue;
			remaining = unchecked(remaining - reduction);
			if (CardFettersType == CardFettersType.Terran)
			    remaining = SynergyEffectManager.Instance.HumanFetter4_DamageReduction(remaining, this, isEnemy, 1f);
			if (CardFettersType == CardFettersType.Machine)
			    remaining = SynergyEffectManager.Instance.MachineFetter6_RemoteDamageReduction(remaining, this, isEnemy, atkWayType);
			if (remaining <= 0)
			    return;
			if (linkRoleList != null)
			{
			    for (int i = 0; i < linkRoleList.Count; i++)
			    {
			        if (linkRoleList[i] == null)
			            continue;
			        float linkedValue = linkNum * (float)remaining;
			        int linkedDamage = float.IsPositiveInfinity(linkedValue) ? int.MinValue
			            : float.IsNaN(linkedValue) ? 0
			            : linkedValue >= 2147483648f ? int.MaxValue
			            : linkedValue <= -2147483648f ? int.MinValue : (int)linkedValue;
			        linkRoleList[i].Wound(linkedDamage, id, isBuild, target, isLandRole, atkWayType, fetterType, null);
			        remaining = unchecked(remaining - linkedDamage);
			        if (remaining <= 0)
			            return;
			    }
			}
			_damageTextBuilder.Clear();
			_damageTextBuilder.Append("-");
			_damageTextBuilder.Append(remaining);
			ShowDamageText(_damageTextBuilder.ToString(), FloatingTextManager.Instance.GetDamageTextColor(isEnemy, false));
			PropertyTemp.hp = unchecked(PropertyTemp.hp - remaining);
			global::AssetsModule.EffectManager.Instance.ShowEffect(
			    "Assets/_Res/Addressable/EffectsBundle/Effects/BloodExplosionSpiky.prefab", transform.position, default, 1f);
			if (isEnemy)
			{
			    if (isBuild)
			        BattleGameManager.Instance.RecordBuildDamage(id, remaining);
			    else
			        BattleGameManager.Instance.RecordDamage(id, remaining);
			}
			OnHealthChangeTalentTrigger();
			if (PropertyTemp.hp <= 0)
			{
			    PropertyTemp.hp = 0;
			    Dead(linkAttackObj != null && GetIsHellFireAtk(linkAttackObj) ? DeadType.HellFire : DeadType.Common);
			    UpdateHpBar();
			    if (!isBuild && target is RoleBehaviour attacker && !attacker.isDead)
			        attacker.OnKillTalentTrigger();
			}
			else
			{
			    UpdateHpBar();
			    global::AudioManager.Instance.PlaySFX("Assets/_Res/Addressable/AudiosBundle/SFX/Hit1.mp3", transform, 1f, 0);
			}
		
}}
public class LinkedRole:RoleBehaviour {
public override void Wound(int damage,string id,bool build,EntityBase target,bool land,AtkWayType way,CardFettersType fetter,Object link){if(link!=null)throw new Exception("linked attack link must reset");State.Trace.Add("link:"+damage+":"+build.ToString().ToLowerInvariant()+":"+land.ToString().ToLowerInvariant()+":"+(int)way+":"+(int)fetter);}
}
public static class Program {
public static int Main(string[] args){int checks=0,failed=0;List<string> errors=new();
using var doc=JsonDocument.Parse(System.IO.File.ReadAllText(args[0]));int index=0;
foreach(var row in doc.RootElement.EnumerateArray()){
var sc=row.GetProperty("scenario");int I(string key)=>sc.GetProperty(key).GetInt32();bool V(string key)=>sc.GetProperty(key).GetBoolean();float F(string key)=>BitConverter.UInt32BitsToSingle(sc.GetProperty(key).GetUInt32());
var props=new Props{id=V("special")?"1012":"other",hp=I("hp"),missObb=F("missBits"),damageReduceObb=F("reduceBits")};
var r=new RoleBehaviour{PropertyTemp=V("property")?props:null,isDead=V("dead"),Skilling=V("skilling"),isEnemy=V("enemy"),CardFettersType=(CardFettersType)I("fetter"),linkNum=F("linkBits")};
if(row.GetProperty("linkCount").GetInt32()>0)r.linkRoleList=new List<RoleBehaviour>{new LinkedRole(),null,new LinkedRole()};
EntityBase target=I("attacker")==0?null:I("attacker")==1?new RoleBehaviour{isDead=V("attackerDead")}:new EntityBase();
CoreGameManager.Gaming=V("gaming");State.Trace.Clear();State.HurtDamage=I("hurtDamage");State.HurtMiss=F("hurtMissBits");State.Roll=I("roll");State.Synergy=I("synergy");State.Heal=I("heal");State.Hell=V("hell");
r.Wound(I("damage"),"id",V("build"),target,V("land"),(AtkWayType)I("way"),CardFettersType.Null,V("linkObj")?new Object():null);
var exp=new List<string>();foreach(var t in row.GetProperty("trace").EnumerateArray())exp.Add(t.GetString());
// Native link trace stores integer bool in its land argument; normalize that representation only.
for(int t=0;t<exp.Count;t++){if(exp[t].StartsWith("link:")){var p=exp[t].Split(':');p[3]=p[3]=="1"?"true":"false";exp[t]=string.Join(":",p);}}
void Check(bool ok,string detail){checks++;if(!ok){failed++;if(errors.Count<12)errors.Add("case "+index+" "+detail);}}
Check(string.Join("|",State.Trace)==string.Join("|",exp),"trace actual="+string.Join("|",State.Trace)+" native="+string.Join("|",exp));
Check(props.hp==row.GetProperty("hp").GetInt32(),"hp");Check(r.isDead==row.GetProperty("dead").GetBoolean(),"dead");
Check(BitConverter.SingleToUInt32Bits(r.frontWoundTime)==row.GetProperty("frontTimeBits").GetUInt32(),"frontTime");
Check((r.AttackObj==target)==row.GetProperty("attackObj").GetBoolean(),"attackObj");index++;
}
Console.WriteLine(JsonSerializer.Serialize(new{cases=index,checks,failed,errors}));return failed==0?0:1;
}}
