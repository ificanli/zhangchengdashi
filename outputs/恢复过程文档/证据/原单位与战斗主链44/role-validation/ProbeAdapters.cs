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
