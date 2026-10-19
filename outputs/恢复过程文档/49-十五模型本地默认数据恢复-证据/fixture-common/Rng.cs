public static class ControlledRng
{
 public static Queue<int> Values=new();public static List<object> Draws=new();public static int Created;
 public static void Reset(string type){Values=new(type=="DataModule.PlayerCoreData"?new[]{0,79,80,99}:new[]{8,7,6,5,4,3});Draws.Clear();Created=0;}
 public static int Next(string kind,int min,int max){int value=Values.Dequeue();if(value<min||value>=max)throw new Exception("RNG contract");Draws.Add(new{kind,min,max,value});return value;}
}
namespace System{public class Random{public Random(){ControlledRng.Created++;}public int Next(int min,int max)=>ControlledRng.Next("System.Random.Next",min,max);}}
namespace UnityEngine{public static class Random{public static int Range(int min,int max)=>ControlledRng.Next("UnityEngine.Random$$Range",min,max);}}
