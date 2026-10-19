using System;using System.Collections.Generic;using System.Text;using System.Reflection;using System.Text.Json;using UnityEngine;using Pathfinding;using Object=UnityEngine.Object;
public enum TargetType { Architecture, Role }
public enum AtkWayType { Melee, Remote, Null }
public enum RareLevel { R,SR,SSR,SSSR,Null,N }
public class RolePropertyTemp { public float moveSpeed,atkRange;public RareLevel rareLevel; }
public class EntityBase { public bool isDead;public Transform transform=new Transform();public GameObject gameObject=new GameObject(); }
public static class Calls { public static List<string> Log=new List<string>(); }
namespace UnityEngine {
public class Object {
 public static void Destroy(Object o){Calls.Log.Add("destroy");}
}
public class GameObject:Object {
 public bool activeInHierarchy=true;
 public GameObject gameObject=>this;
 public void SetActive(bool value){activeInHierarchy=value;Calls.Log.Add("active:"+value);}
}
public class Transform { public Vector3 position;public Vector3 localScale=new Vector3(1,1,1); }
public struct Vector3 {
 public float x,y,z;public Vector3(float x,float y,float z){this.x=x;this.y=y;this.z=z;}
 public static Vector3 operator-(Vector3 a,Vector3 b)=>new Vector3(a.x-b.x,a.y-b.y,a.z-b.z);
 public float sqrMagnitude=>(x*x+y*y)+z*z;
 public Vector3 normalized { get{float m=MathF.Sqrt(sqrMagnitude);return m>0.00001f?new Vector3(x/m,y/m,z/m):new Vector3();} }
}
public static class Time { public static float time; }
public static class Mathf { public static float Abs(float f)=>MathF.Abs(f); }
}
namespace Pathfinding {
public static class AstarWebGLRuntimeConfig { public static bool UseWebGLNavigation; }
public class FollowerEntity {
 public bool enabled=true;bool can;float speed;
 public bool canMove {get=>can;set{can=value;Calls.Log.Add("can:"+value);}}
 public float maxSpeed {get=>speed;set{speed=value;Calls.Log.Add("speed:"+BitConverter.SingleToUInt32Bits(value));}}
 public void SearchPath(){Calls.Log.Add("search");}
}
}
public static class WebGLNavigationManager {
 public static void TryRegisterRole(RoleBehaviour role){Calls.Log.Add("register");}
}
public class HexBehaviour {
 public string name;public HexManager.HexCoord HexCoord;
 public void RemoveRole(int id,bool player,RoleBehaviour role){Calls.Log.Add("remove:"+name+":"+id+":"+player);}
 public void AddRole(int id,bool player,RoleBehaviour role){Calls.Log.Add("add:"+name+":"+id+":"+player);}
 public void RefreshRoleCamp(int id,bool player,RoleBehaviour role){Calls.Log.Add("camp:"+name+":"+id+":"+player);}
}
public static class HexManager {
 public struct HexCoord{public int q,r;}
 public static HexBehaviour resolved;public static bool succeeds=true;public static Func<Vector3,HexBehaviour> resolve;
 public static bool TryGetHexAt(Vector3 pos,out HexBehaviour hex){Calls.Log.Add("hex");hex=resolve!=null?resolve(pos):resolved;return succeeds;}
 public static int HexDistance(HexCoord a,HexCoord b){return (Math.Abs(a.q-b.q)+Math.Abs(a.r-b.r)+Math.Abs(a.q+a.r-b.q-b.r))/2;}
}

public class RoleBehaviour:EntityBase
{

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

public void SetAiCanMove(bool can)
{
			if (followerEntityCurrentCanMove == can)
			    return;
			followerEntityCurrentCanMove = can;
			if (AstarWebGLRuntimeConfig.UseWebGLNavigation)
			{
			    if (can)
			        WebGLNavigationManager.TryRegisterRole(this);
			}
			else if (followerEntity != null)
			    followerEntity.canMove = can;
		
}
public void SetAiSPeed(float s, bool isReduceSpeed = false)
{
			if (this == null)
			    return;
			if (AstarWebGLRuntimeConfig.UseWebGLNavigation)
			{
			    float speed = s * 0.8f;
			    if (Mathf.Abs(speed - followerEntityCurrentSpeed) > 0.01f)
			        followerEntityCurrentSpeed = speed;
			    return;
			}
			float nextSpeed = GetFollowerEntityMoveSpeed(s);
			if (followerEntity == null)
			    followerEntity = GetComponent<FollowerEntity>();
			if (followerEntity != null && Mathf.Abs(nextSpeed - followerEntityCurrentSpeed) > 0.01f)
			{
			    followerEntityCurrentSpeed = nextSpeed;
			    followerEntity.maxSpeed = nextSpeed;
			}
		
}
public bool HasSkill()
{
				return skillRequireCount > 0f;
			
}
public float GetScaledRadius(float baseRadius)
{
			if (!(baseRadius < 0f))
			    return (0.5f / transform.localScale.x) * baseRadius;
			return baseRadius;
		
}
public void ClearRoleTargetTracking()
{
			_lastTrackedRoleTarget = null;
			_lastRoleTargetHexDistance = -1;
		
}
public void ClearDizzyState()
{
			isDizzy = false;
			dizzyTime = 0f;
			if (stunEffect != null)
			{
			    Object.Destroy(stunEffect);
			    stunEffect = null;
			}
		
}
public static float GetAutoRepathPeriod(int roleCount)
{
			if (!AstarWebGLRuntimeConfig.UseWebGLNavigation)
			    return 1f;
			return roleCount > 79 ? 3f : 2f;
		
}
public float GetAiSPeed()
{
			if (AstarWebGLRuntimeConfig.UseWebGLNavigation && PropertyTemp != null)
			    return PropertyTemp.moveSpeed;
			return followerEntityCurrentSpeed;
		
}
public bool ShouldSkipFindTarget(float range)
{
			if (_RoleBehaviour != null)
			{
			    if (IsRoleTargetValidInRange(_RoleBehaviour, range))
			        return true;
			    _RoleBehaviour = null;
			    _nextFindTargetTime = 0f;
			    ClearRoleTargetTracking();
			}
			float now = Time.time;
			if (now < _nextFindTargetTime && Mathf.Abs(_lastFindTargetRange - range) <= 0.01f)
			    return true;
			_lastFindTargetRange = range;
			_nextFindTargetTime = now + GetFindTargetInterval();
			return false;
		
}
public void RecordCurrentRoleTargetDistance()
{
			RoleBehaviour roleTarget = _RoleBehaviour as RoleBehaviour;
			if (roleTarget != null)
			    UpdateRoleTargetHexDistance(roleTarget);
			else
			    ClearRoleTargetTracking();
		
}
public bool IsRoleTargetValidInRange(EntityBase target, float range)
{
			if (target == null || target == this || target.isDead)
			    return false;
			RoleBehaviour roleTarget = target as RoleBehaviour;
			if (roleTarget == null || roleTarget.StealthIng)
			    return false;
			float allowedRange = PropertyTemp != null ? PropertyTemp.atkRange : range;
			allowedRange = allowedRange >= range ? allowedRange : range;
			Vector3 delta = roleTarget.transform.position - transform.position;
			delta.y = 0f;
			return delta.sqrMagnitude <= allowedRange * allowedRange && UpdateRoleTargetHexDistance(roleTarget);
		
}
public float GetFindTargetInterval()
{
			if (AtkWayType == AtkWayType.Remote || skillRequireCount > 0f
			    || (PropertyTemp != null && PropertyTemp.rareLevel == RareLevel.SSSR))
			    return 0.15f;
			return 0.25f;
		
}
public bool UpdateRoleTargetHexDistance(RoleBehaviour roleTarget)
{
			if (roleTarget == null)
			{
			    ClearRoleTargetTracking();
			    return false;
			}
			HexBehaviour sourceHex;
			HexBehaviour targetHex;
			if (!HexManager.TryGetHexAt(transform.position, out sourceHex) || sourceHex == null
			    || !HexManager.TryGetHexAt(roleTarget.transform.position, out targetHex) || targetHex == null)
			{
			    _lastTrackedRoleTarget = roleTarget;
			    _lastRoleTargetHexDistance = -1;
			    return true;
			}
			int distance = HexManager.HexDistance(sourceHex.HexCoord, targetHex.HexCoord);
			if (_lastTrackedRoleTarget != roleTarget || _lastRoleTargetHexDistance < 0)
			{
			    _lastTrackedRoleTarget = roleTarget;
			    _lastRoleTargetHexDistance = distance;
			    return true;
			}
			if (distance > unchecked(_lastRoleTargetHexDistance + 1))
			    return false;
			if (distance < _lastRoleTargetHexDistance)
			    _lastRoleTargetHexDistance = distance;
			return true;
		
}
public bool WebGLNavigationIsValid()
{
				return hadInit && !hadRecycle && !destroying && !isDead && gameObject.activeInHierarchy;
			
}
public bool WebGLNavigationCanMove()
{
				return followerEntityCurrentCanMove && !attacking && !Skilling && !isFreeze && !isDizzy
				    && !_isAttackingWall && !_isBreakingWall && !isDead && !hadRecycle;
			
}
public bool WebGLNavigationCanSoftSeparate()
{
				return attacking && hadInit && !hadRecycle && !destroying && !isDead && gameObject.activeInHierarchy
				    && !Skilling && !isFreeze && !isDizzy && !_isAttackingWall && !_isBreakingWall;
			
}
public TargetType WebGLNavigationTargetType()
{
				return TargetType;
			
}
public float WebGLNavigationMoveSpeed()
{
				if (!(followerEntityCurrentSpeed > 0.01f))
				    return PropertyTemp != null ? GetWebGLNavigationMoveSpeed(PropertyTemp.moveSpeed) : 0f;
				return followerEntityCurrentSpeed;
			
}
public float GetWebGLNavigationMoveSpeed(float speed)
{
			return speed * 0.8f;
		
}
public float WebGLNavigationRadius()
{
				return followerEntityCurrentRadius > 0.01f ? followerEntityCurrentRadius : 0.35f;
			
}
public float WebGLNavigationAttackRange()
{
				return PropertyTemp != null ? PropertyTemp.atkRange : 0f;
			
}
public void RequestSearchPathRefresh()
{
			followerEntityNeedSearchPath = true;
		
}
public bool ShouldSyncPathfindingTargetPosition(bool sourceTargetChanged, Vector3 currentPosition, Vector3 targetPosition)
{
			if (!AstarWebGLRuntimeConfig.UseWebGLNavigation || sourceTargetChanged)
			    return true;
			float distanceSqr = (targetPosition - currentPosition).sqrMagnitude;
			if (distanceSqr <= 0.0001f)
			    return false;
			return distanceSqr >= 0.16f || Time.time - _followerEntityLastTargetSyncTime >= 0.15f;
		
}
public void TryRefreshSearchPath()
{
			if (!followerEntityNeedSearchPath)
			    return;
			if (AstarWebGLRuntimeConfig.UseWebGLNavigation)
			{
			    followerEntityNeedSearchPath = false;
			    followerEntityLastSearchPathTime = Time.time;
			    return;
			}
			if (followerEntity != null && followerEntity.enabled)
			{
			    followerEntityNeedSearchPath = false;
			    followerEntityLastSearchPathTime = Time.time;
			    followerEntity.SearchPath();
			}
		
}
public bool GetAiCanMove()
{
			return followerEntityCurrentCanMove;
		
}
public float GetFollowerEntityMoveSpeed(float speed)
{
			if (!(_bornScaleX <= 0.001f))
			    speed /= _bornScaleX;
			return speed * 0.8f;
		
}
public float GetAiRadius()
{
			return followerEntityCurrentRadius;
		
}
public bool GetAiEnableLocalAvoidance()
{
			return followerEntityCurrentEnableLocalAvoidance;
		
}
public void ClearFreezeState()
{
			isFreeze = false;
			freezeEndTime = 0f;
			if (IceBall != null)
			    IceBall.SetActive(false);
		
}
public void SyncCurrentHexCampRegistration(bool previousIsEnemy)
{
			HexBehaviour newHex;
			HexManager.TryGetHexAt(transform.position, out newHex);
			if (_currentHex != null && _currentHex != newHex)
			    _currentHex.RemoveRole(_instanceID, !previousIsEnemy, this);
			if (newHex != null)
			    newHex.RefreshRoleCamp(_instanceID, !isEnemy, this);
			_currentHex = newHex;
		
}
public void ApplyHexPosition(HexBehaviour newHex)
{
			if (newHex == null || newHex == _currentHex)
			    return;
			if (_currentHex != null)
			    _currentHex.RemoveRole(_instanceID, !isEnemy, this);
			newHex.AddRole(_instanceID, !isEnemy, this);
			_currentHex = newHex;
		
}
public RoleBehaviour()
{
			_bornFollowerRadius = -1f;
			_lastFindTargetRange = -1f;
			_lastRoleTargetHexDistance = -1;
			firstSkill = true;
			attackDamageDelay = new List<float>();
			linkRoleList = new List<RoleBehaviour>();
			followerEntityCurrentSpeed = -1f;
			followerEntityCurrentRadius = -1f;
			followerEntityLastSearchPathTime = -999f;
			_followerEntityLastTargetSyncTime = -999f;
			targetList = new List<RoleBehaviour>();
			allPos = new List<Vector3>();
			allPosLength = new List<float>();
			_targetRemainingPathPoints = new List<Vector3>(32);
			_damageTextBuilder = new StringBuilder(16);
			_attackWallStateEnterTime = -1f;
			_lastWatchdogMoveTime = -1f;
		
}
}
public static class Program {
static int checks,failed;static List<string> errors=new List<string>();
static void Check(bool ok,string text){checks++;if(!ok){failed++;if(errors.Count<30)errors.Add(text);}}
static float F(uint bits)=>BitConverter.UInt32BitsToSingle(bits);
static uint B(float f)=>BitConverter.SingleToUInt32Bits(f);
static bool Same(uint actual,uint expected)=>actual==expected || float.IsNaN(F(actual))&&float.IsNaN(F(expected));
static void Invoke(RoleBehaviour r,string name,params object[] args){typeof(RoleBehaviour).GetMethod(name).Invoke(r,args);}
public static int Main(string[] args){
 using var doc=JsonDocument.Parse(System.IO.File.ReadAllText(args[0]));
 foreach(var row in doc.RootElement.EnumerateArray()){
  var r=new RoleBehaviour();var sc=row.GetProperty("scenario");var name=row.GetProperty("method").GetString();
  AstarWebGLRuntimeConfig.UseWebGLNavigation=sc.GetProperty("webgl").GetBoolean();r.gameObject.activeInHierarchy=sc.GetProperty("active").GetBoolean();
  if(sc.GetProperty("property").GetBoolean())r.PropertyTemp=new RolePropertyTemp();
  foreach(var f in sc.GetProperty("fields").EnumerateObject()){
   bool prop=f.Name.StartsWith("PropertyTemp.");if(prop&&r.PropertyTemp==null)continue;
   object target=prop?(object)r.PropertyTemp:r;string fieldName=prop?f.Name.Substring(13):f.Name;
   var fi=target.GetType().GetField(fieldName);object value;
   if(fi.FieldType==typeof(float))value=F(f.Value.GetUInt32());else if(fi.FieldType==typeof(bool))value=f.Value.GetInt32()!=0;else if(fi.FieldType.IsEnum)value=Enum.ToObject(fi.FieldType,f.Value.GetInt32());else value=f.Value.GetInt32();
   fi.SetValue(target,value);
  }
  var scale=sc.GetProperty("scale");r.transform.localScale=new Vector3(F(scale[0].GetUInt32()),F(scale[1].GetUInt32()),F(scale[2].GetUInt32()));
  object[] input=sc.TryGetProperty("floatArg",out var fa)?new object[]{F(fa.GetUInt32())}:sc.TryGetProperty("intArg",out var ia)?new object[]{ia.GetInt32()}:Array.Empty<object>();
  var method=typeof(RoleBehaviour).GetMethod(name);object result=method.Invoke(method.IsStatic?null:r,input);
  uint actual=row.GetProperty("return").GetString()=="float"?B((float)result):result is bool bv?(bv?1u:0u):unchecked((uint)Convert.ToInt32(result));
  uint expected=row.GetProperty("expectedBits").GetUInt32();Check(Same(actual,expected),name+" actual="+actual.ToString("X8")+" native="+expected.ToString("X8"));
 }
 // Meaningful sequence assertions use actual candidate bodies and observable adapters.
 {
  var r=new RoleBehaviour();Check(r._bornFollowerRadius==-1&&r._lastFindTargetRange==-1&&r._lastRoleTargetHexDistance==-1&&r.firstSkill,"constructor sentinel fields");
  Check(r.attackDamageDelay!=null&&r.linkRoleList!=null&&r.targetList!=null&&r.allPos!=null&&r.allPosLength!=null,"constructor list ownership");
  Check(r._targetRemainingPathPoints!=null&&r._targetRemainingPathPoints.Capacity==32&&r._damageTextBuilder?.Capacity==16,"constructor capacities");
  Check(r.followerEntityCurrentSpeed==-1&&r.followerEntityCurrentRadius==-1&&r.followerEntityLastSearchPathTime==-999&&r._followerEntityLastTargetSyncTime==-999&&r._attackWallStateEnterTime==-1&&r._lastWatchdogMoveTime==-1,"constructor path timers");
 }
 {
  var r=new RoleBehaviour{_instanceID=7,isEnemy=true};var old=new HexBehaviour{name="old"};var next=new HexBehaviour{name="next"};r._currentHex=old;Calls.Log.Clear();
  Invoke(r,"ApplyHexPosition",next);Check(string.Join("|",Calls.Log)=="remove:old:7:False|add:next:7:False"&&r._currentHex==next,"hex remove-add-before-store");
  Calls.Log.Clear();Invoke(r,"ApplyHexPosition",next);Invoke(r,"ApplyHexPosition",new object[]{null});Check(Calls.Log.Count==0&&r._currentHex==next,"hex equal/null retain");
  HexManager.resolved=old;Calls.Log.Clear();Invoke(r,"SyncCurrentHexCampRegistration",false);Check(string.Join("|",Calls.Log)=="hex|remove:next:7:True|camp:old:7:False"&&r._currentHex==old,"camp uses previous camp for remove/current for refresh");
  HexManager.resolved=null;Calls.Log.Clear();Invoke(r,"SyncCurrentHexCampRegistration",true);Check(string.Join("|",Calls.Log)=="hex|remove:old:7:False"&&r._currentHex==null,"off-map camp removes previous and clears");
 }
 {
  AstarWebGLRuntimeConfig.UseWebGLNavigation=false;var r=new RoleBehaviour{followerEntity=new FollowerEntity()};Calls.Log.Clear();
  Invoke(r,"SetAiCanMove",true);Invoke(r,"SetAiCanMove",true);Invoke(r,"SetAiCanMove",false);Check(string.Join("|",Calls.Log)=="can:True|can:False"&&!r.followerEntityCurrentCanMove,"canMove idempotent native setter");
  AstarWebGLRuntimeConfig.UseWebGLNavigation=true;Calls.Log.Clear();Invoke(r,"SetAiCanMove",true);Invoke(r,"SetAiCanMove",false);Check(string.Join("|",Calls.Log)=="register","WebGL registers only on enable transition");
  Time.time=5;r.followerEntityNeedSearchPath=true;Calls.Log.Clear();Invoke(r,"TryRefreshSearchPath");Check(!r.followerEntityNeedSearchPath&&r.followerEntityLastSearchPathTime==5&&Calls.Log.Count==0,"WebGL consumes refresh without Astar");
  AstarWebGLRuntimeConfig.UseWebGLNavigation=false;r.followerEntityNeedSearchPath=true;r.followerEntity.enabled=false;Invoke(r,"TryRefreshSearchPath");Check(r.followerEntityNeedSearchPath,"disabled Follower retains request");
  r.followerEntity.enabled=true;Calls.Log.Clear();Invoke(r,"TryRefreshSearchPath");Check(!r.followerEntityNeedSearchPath&&string.Join("|",Calls.Log)=="search","enabled Follower consumes then searches");
 }
 {
  var r=new RoleBehaviour{isFreeze=true,freezeEndTime=8,IceBall=new GameObject(),isDizzy=true,dizzyTime=9,stunEffect=new GameObject()};Calls.Log.Clear();
  Invoke(r,"ClearDizzyState");Invoke(r,"ClearFreezeState");Check(!r.isFreeze&&r.freezeEndTime==0&&!r.isDizzy&&r.dizzyTime==0&&r.stunEffect==null&&r.IceBall!=null&&!r.IceBall.activeInHierarchy,"control clear preserves frozen object, destroys stun");
  Check(string.Join("|",Calls.Log)=="destroy|active:False","control side effect sequence");
 }
 {
  var r=new RoleBehaviour{_lastTrackedRoleTarget=new RoleBehaviour(),_lastRoleTargetHexDistance=4};Invoke(r,"ClearRoleTargetTracking");Check(r._lastTrackedRoleTarget==null&&r._lastRoleTargetHexDistance==-1,"tracking reset sentinel");
  r.transform.position=new Vector3(0,0,0);var t=new RoleBehaviour();t.transform.position=new Vector3(0,5,0);r.PropertyTemp=new RolePropertyTemp{atkRange=2};
  var from=new HexBehaviour{HexCoord=new HexManager.HexCoord{q=0,r=0}};var to=new HexBehaviour{HexCoord=new HexManager.HexCoord{q=1,r=0}};
  HexManager.succeeds=true;HexManager.resolve=p=>p.y==0?from:to;
  Check((bool)typeof(RoleBehaviour).GetMethod("IsRoleTargetValidInRange").Invoke(r,new object[]{t,1f}),"target uses planar range");
  to.HexCoord=new HexManager.HexCoord{q=3,r=0};Check(!(bool)typeof(RoleBehaviour).GetMethod("UpdateRoleTargetHexDistance").Invoke(r,new object[]{t})&&r._lastRoleTargetHexDistance==1,"target rejects escape beyond retained best plus one");
  to.HexCoord=new HexManager.HexCoord{q=2,r=0};Check((bool)typeof(RoleBehaviour).GetMethod("UpdateRoleTargetHexDistance").Invoke(r,new object[]{t})&&r._lastRoleTargetHexDistance==1,"target one-hex slack retains historical closest");
  to.HexCoord=new HexManager.HexCoord{q=0,r=0};Check((bool)typeof(RoleBehaviour).GetMethod("UpdateRoleTargetHexDistance").Invoke(r,new object[]{t})&&r._lastRoleTargetHexDistance==0,"target records closer distance");
  HexManager.succeeds=false;Check((bool)typeof(RoleBehaviour).GetMethod("UpdateRoleTargetHexDistance").Invoke(r,new object[]{t})&&r._lastRoleTargetHexDistance==-1,"missing hex retains target but invalidates distance");HexManager.succeeds=true;HexManager.resolve=null;
 }
 Console.WriteLine(JsonSerializer.Serialize(new{checks,failed,errors}));return failed==0?0:1;
}
}
