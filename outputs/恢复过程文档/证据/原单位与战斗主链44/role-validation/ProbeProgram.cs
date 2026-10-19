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
