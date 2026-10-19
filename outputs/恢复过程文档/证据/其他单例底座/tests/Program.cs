using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

static class Program
{
    static int scenarios,checks,failures;
    static void Check(bool condition,string note) {checks++;if(!condition)throw new Exception(note);}
    static void Run(string name,Action test) {scenarios++;try{test();Console.WriteLine("PASS "+name);}catch(Exception ex){failures++;Console.WriteLine("FAIL "+name+": "+ex.GetBaseException().Message);}}
    static void Main()
    {
        Run("L_Tools creates once and returns stable identity",()=>{var a=L_Tools.Singleton<One>.Instance;var b=L_Tools.Singleton<One>.Instance;Check(a!=null&&ReferenceEquals(a,b),"stable nonnull instance");Check(One.Count==1,"one constructor invocation");});
        Run("QuickTutor Lazy creates once and returns stable identity",()=>{var a=QuickTutor.Singleton<Two>.Instance;var b=QuickTutor.Singleton<Two>.Instance;Check(a!=null&&ReferenceEquals(a,b),"stable nonnull instance");Check(Two.Count==1,"one constructor invocation");});
        Run("separate closed generic arguments keep independent instances",()=>{var a=L_Tools.Singleton<Three>.Instance;var b=L_Tools.Singleton<Four>.Instance;Check(a!=null&&b!=null&&!ReferenceEquals(a,b),"separate L_Tools closures");var c=QuickTutor.Singleton<Three>.Instance;var d=QuickTutor.Singleton<Four>.Instance;Check(c!=null&&d!=null&&!ReferenceEquals(c,d),"separate QuickTutor closures");Check(!ReferenceEquals(a,c)&&Three.Count==2,"same argument independent across singleton owners");});
        Run("L_Tools parallel access creates one object",()=>{var found=new Five[256];Parallel.For(0,found.Length,i=>found[i]=L_Tools.Singleton<Five>.Instance);Check(found[0]!=null&&found.All(x=>ReferenceEquals(x,found[0])),"parallel access shares object");Check(Five.Count==1,"static initializer serialized");});
        Run("QuickTutor Lazy parallel access creates one object",()=>{var found=new Six[256];Parallel.For(0,found.Length,i=>found[i]=QuickTutor.Singleton<Six>.Instance);Check(found[0]!=null&&found.All(x=>ReferenceEquals(x,found[0])),"parallel access shares object");Check(Six.Count==1,"ExecutionAndPublication initializes once");});
        Run("type reflection does not eagerly run QuickTutor value factory",()=>{_ = typeof(QuickTutor.Singleton<Seven>).TypeHandle;Check(Seven.Count==0,"no eager value construction");var value=QuickTutor.Singleton<Seven>.Instance;Check(value!=null&&Seven.Count==1,"first Value access constructs");});
        Run("L_Tools static constructor failure is cached",()=>{Exception first=null,second=null;try{_ = L_Tools.Singleton<FailA>.Instance;}catch(Exception ex){first=ex;}try{_ = L_Tools.Singleton<FailA>.Instance;}catch(Exception ex){second=ex;}Check(first is TypeInitializationException&&second is TypeInitializationException,"static initializer failure shape");Check(FailA.Count==1,"failed initializer is not retried");Check(ReferenceEquals(first.GetBaseException(),FailA.Error)&&ReferenceEquals(second.GetBaseException(),FailA.Error),"original constructor error retained");});
        Run("QuickTutor Lazy caches value factory failure",()=>{Exception first=null,second=null;try{_ = QuickTutor.Singleton<FailB>.Instance;}catch(Exception ex){first=ex;}try{_ = QuickTutor.Singleton<FailB>.Instance;}catch(Exception ex){second=ex;}Check(first is TargetInvocationException&&ReferenceEquals(first,second),"Lazy caches same Activator exception");Check(FailB.Count==1,"factory not retried");Check(ReferenceEquals(first.GetBaseException(),FailB.Error),"original constructor failure retained");});
        Run("L_Tools supports value type under original new constraint",()=>{Check(L_Tools.Singleton<int>.Instance==0,"value default is zero");Check(L_Tools.Singleton<ValueItem>.Instance.Number==0,"struct default");});
        Run("QuickTutor supports value type under original new constraint",()=>{Check(QuickTutor.Singleton<int>.Instance==0,"value default is zero");Check(QuickTutor.Singleton<ValueItem>.Instance.Number==0,"struct default");});
        Run("original readonly fields and BeforeFieldInit remain",()=>{var quick=typeof(QuickTutor.Singleton<Eight>);var field=quick.GetField("instance",BindingFlags.NonPublic|BindingFlags.Static);Check(field!=null&&field.IsInitOnly,"QuickTutor field stays readonly");Check((quick.Attributes&TypeAttributes.BeforeFieldInit)!=0,"no explicit cctor changes type timing flags");var creator=typeof(L_Tools.Singleton<Eight>).GetNestedType("SingletonCreator",BindingFlags.NonPublic);Check((creator.Attributes&TypeAttributes.BeforeFieldInit)!=0&&creator.GetField("instance",BindingFlags.NonPublic|BindingFlags.Static).IsInitOnly,"Creator readonly field and flags retained");});
        Console.WriteLine($"RESULT scenarios={scenarios} checks={checks} failures={failures}");Environment.ExitCode=failures==0?0:1;
    }
    public class One{public static int Count;public One()=>Interlocked.Increment(ref Count);}
    public class Two{public static int Count;public Two()=>Interlocked.Increment(ref Count);}
    public class Three{public static int Count;public Three()=>Interlocked.Increment(ref Count);}
    public class Four{public Four(){}}
    public class Five{public static int Count;public Five()=>Interlocked.Increment(ref Count);}
    public class Six{public static int Count;public Six()=>Interlocked.Increment(ref Count);}
    public class Seven{public static int Count;public Seven()=>Interlocked.Increment(ref Count);}
    public class Eight{public Eight(){}}
    public class FailA{public static int Count;public static readonly Exception Error=new ApplicationException("FailA");public FailA(){Interlocked.Increment(ref Count);throw Error;}}
    public class FailB{public static int Count;public static readonly Exception Error=new ApplicationException("FailB");public FailB(){Interlocked.Increment(ref Count);throw Error;}}
    public struct ValueItem{public int Number;}
}
