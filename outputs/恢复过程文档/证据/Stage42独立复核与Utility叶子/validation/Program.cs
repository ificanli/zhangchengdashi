using System.Text.Json;
using GameFramework;
using GameFramework.Fsm;
using GameFramework.Procedure;

internal static class Program
{
    private static readonly List<object> Results = new();
    internal static readonly List<string> Trace = new();
    private static int Failures;

    public static int Main(string[] args)
    {
        Run("construct_retains_owner_and_initializes_states_in_input_order", () =>
        {
            var owner = new Owner(); var a = new A(); var b = new B();
            a.Init = f => { Same(owner, f.Owner); Eq(1, f.FsmStateCount); False(f.IsRunning); };
            b.Init = f => Eq(2, f.FsmStateCount);
            var fsm = New(owner, a, b);
            Same(owner, fsm.Owner); Eq(typeof(Owner), fsm.OwnerType); Eq("named", fsm.Name);
            Eq(2, fsm.FsmStateCount); False(fsm.IsDestroyed); Eq<string>(null, fsm.CurrentStateName);
            Sequence("A.init", "B.init");
        });
        Run("null_owner_rejected", () => Throws<GameFrameworkException>(() => New(null, new A())));
        Run("null_states_rejected", () => Throws<GameFrameworkException>(() => new Fsm<Owner>("x", new Owner(), null)));
        Run("empty_states_rejected", () => Throws<GameFrameworkException>(() => New(new Owner())));
        Run("null_state_rejected_after_previous_state_init", () =>
        { Throws<GameFrameworkException>(() => New(new Owner(), new A(), null)); Sequence("A.init"); });
        Run("duplicate_state_rejected_after_first_state_init", () =>
        { Throws<GameFrameworkException>(() => New(new Owner(), new A(), new A())); Sequence("A.init"); });
        Run("start_without_args_uses_noargs_overload_and_sets_current_first", () =>
        {
            var a = new A(); var f = New(new Owner(), a); Trace.Clear();
            a.Enter = x => { Same(a, x.CurrentState); Eq(0f, x.CurrentStateTime); True(x.IsRunning); };
            f.Start<A>(); Same(a, f.CurrentState); Eq(typeof(A).FullName, f.CurrentStateName); Sequence("A.enter");
        });
        Run("start_nonempty_args_preserves_original_array_identity", () =>
        {
            var a = new A(); var f = New(new Owner(), a); Trace.Clear();
            object[] payload = { "alpha", 42 }; f.Start(typeof(A), payload); Same(payload, a.Args); Sequence("A.enterArgs");
        });
        Run("start_null_args_uses_noargs_overload", () =>
        { var f = New(new Owner(), new A()); Trace.Clear(); f.Start(typeof(A), null); Sequence("A.enter"); });
        Run("start_empty_args_uses_noargs_overload", () =>
        { var f = New(new Owner(), new A()); Trace.Clear(); f.Start(typeof(A), Array.Empty<object>()); Sequence("A.enter"); });
        Run("start_twice_throws_without_extra_enter", () =>
        { var f = New(new Owner(), new A()); f.Start<A>(); Trace.Clear(); Throws<GameFrameworkException>(() => f.Start<A>()); Sequence(); });
        Run("unknown_start_state_throws_and_stays_not_running", () =>
        { var f = New(new Owner(), new A()); Throws<GameFrameworkException>(() => f.Start<B>()); False(f.IsRunning); });
        Run("state_queries_and_null_type_contract", () =>
        {
            var a = new A(); var f = New(new Owner(), a); True(f.HasState<A>()); False(f.HasState<B>());
            Same(a, f.GetState<A>()); Same(a, f.GetState(typeof(A))); Eq<Probe>(null, f.GetState<B>());
            Throws<NullReferenceException>(() => f.GetState((Type)null)); Throws<NullReferenceException>(() => f.HasState((Type)null));
        });
        Run("update_increments_scaled_time_before_callback_and_preserves_both_deltas", () =>
        {
            var a = new A(); var f = New(new Owner(), a); f.Update(8f, 9f); Eq(0f, f.CurrentStateTime);
            f.Start<A>(); Trace.Clear(); a.Update = (x, d, r) => { Eq(1.25f, x.CurrentStateTime); Eq(1.25f, d); Eq(2.5f, r); };
            f.Update(1.25f, 2.5f); Sequence("A.update");
        });
        Run("change_before_start_rejected", () =>
        { var f = New(new Owner(), new A(), new B()); Throws<GameFrameworkException>(() => f.ChangeState<B>()); });
        Run("change_leaves_old_before_setting_new_and_entering_new", () =>
        {
            var a = new A(); var b = new B(); var f = New(new Owner(), a, b); f.Start<A>(); f.Update(3f, 4f); Trace.Clear();
            a.Leave = (x, shutdown) => { Same(a, x.CurrentState); Eq(3f, x.CurrentStateTime); False(shutdown); };
            b.Enter = x => { Same(b, x.CurrentState); Eq(0f, x.CurrentStateTime); };
            a.Route<B>(f); Sequence("A.leave:False", "B.enter"); Same(b, f.CurrentState);
        });
        Run("change_type_nonempty_args_preserves_identity", () =>
        {
            var a = new A(); var b = new B(); var f = New(new Owner(), a, b); f.Start<A>(); Trace.Clear();
            object[] payload = { 7 }; a.Route(f, typeof(B), payload); Same(payload, b.Args); Sequence("A.leave:False", "B.enterArgs");
        });
        Run("same_state_change_runs_leave_and_enter", () =>
        { var a = new A(); var f = New(new Owner(), a); f.Start<A>(); Trace.Clear(); a.Route<A>(f); Sequence("A.leave:False", "A.enter"); });
        Run("missing_change_target_does_not_leave_or_reset_time", () =>
        {
            var a = new A(); var f = New(new Owner(), a); f.Start<A>(); f.Update(3f, 4f); Trace.Clear();
            Throws<GameFrameworkException>(() => a.Route<B>(f)); Same(a, f.CurrentState); Eq(3f, f.CurrentStateTime); Sequence();
        });
        Run("enter_reentrancy_completes_nested_change_synchronously", () =>
        {
            var a = new A(); var b = new B(); var f = New(new Owner(), a, b); Trace.Clear();
            a.Enter = x => { a.Route<B>(x); Same(b, x.CurrentState); Trace.Add("A.enter.afterNested"); };
            f.Start<A>(); Same(b, f.CurrentState); Sequence("A.enter", "A.leave:False", "B.enter", "A.enter.afterNested");
        });
        Run("leave_reentrancy_retains_original_outer_target", () =>
        {
            var a = new A(); var b = new B(); var c = new C(); var f = New(new Owner(), a, b, c); f.Start<A>(); Trace.Clear();
            bool guard = false; a.Leave = (x, _) => { if (!guard) { guard = true; a.Route<C>(x); Trace.Add("A.leave.afterNested"); } };
            a.Route<B>(f); Same(b, f.CurrentState); Sequence("A.leave:False", "A.leave:False", "C.enter", "A.leave.afterNested", "B.enter");
        });
        Run("leave_exception_keeps_old_current_and_time", () =>
        {
            var a = new A(); var f = New(new Owner(), a, new B()); f.Start<A>(); f.Update(3f, 4f);
            a.Leave = (_, _) => throw new ProbeException(); Throws<ProbeException>(() => a.Route<B>(f)); Same(a, f.CurrentState); Eq(3f, f.CurrentStateTime);
        });
        Run("enter_exception_keeps_assigned_target_and_zero_time", () =>
        {
            var a = new A(); var b = new B(); var f = New(new Owner(), a, b); f.Start<A>(); f.Update(3f, 4f);
            b.Enter = _ => throw new ProbeException(); Throws<ProbeException>(() => a.Route<B>(f)); Same(b, f.CurrentState); Eq(0f, f.CurrentStateTime);
        });
        Run("shutdown_leaves_then_destroys_all_states_and_clears_storage", () =>
        {
            var a = new A(); var b = new B(); var f = New(new Owner(), a, b); f.SetData("v", new ProbeVariable()); f.Start<A>(); f.Update(3f, 4f); Trace.Clear();
            a.Leave = (x, shutdown) => { True(shutdown); Same(a, x.CurrentState); Eq(3f, x.CurrentStateTime); };
            a.Destroy = x => { Eq<FsmState<Owner>>(null, x.CurrentState); Eq(0f, x.CurrentStateTime); Eq(2, x.FsmStateCount); };
            f.Shutdown(); True(f.IsDestroyed); False(f.IsRunning); Eq(0, f.FsmStateCount); False(f.HasData("v"));
            Sequence("A.leave:True", "A.destroy", "B.destroy");
        });
        Run("data_roundtrip_replace_remove_and_invalid_names", () =>
        {
            var f = New(new Owner(), new A()); var v = new ProbeVariable(); False(f.HasData("x")); Eq<Variable>(null, f.GetData("x"));
            f.SetData("x", v); True(f.HasData("x")); Same(v, f.GetData("x")); Same(v, f.GetData<ProbeVariable>("x"));
            f.SetData<Variable>("x", null); True(f.HasData("x")); Eq<Variable>(null, f.GetData("x")); True(f.RemoveData("x")); False(f.RemoveData("x"));
            Throws<GameFrameworkException>(() => f.HasData("")); Throws<GameFrameworkException>(() => f.GetData(null));
            Throws<GameFrameworkException>(() => f.SetData("", v)); Throws<GameFrameworkException>(() => f.RemoveData(null));
        });
        Run("events_multicast_current_state_only_and_unsubscribe", () =>
        {
            var a = new A(); var b = new B(); var f = New(new Owner(), a, b); var sender = new object(); var data = new object();
            FsmEventHandler<Owner> h1 = (x, s, d) => { Same(f, x); Same(sender, s); Same(data, d); Trace.Add("h1"); };
            FsmEventHandler<Owner> h2 = (_, _, _) => Trace.Add("h2"); a.Subscribe(5, h1); a.Subscribe(5, h2); b.Subscribe(5, h2);
            f.Start<A>(); Trace.Clear(); f.FireEvent(sender, 5, data); Sequence("h1", "h2");
            a.Unsubscribe(5, h1); Trace.Clear(); f.FireEvent(sender, 5, data); Sequence("h2");
            Throws<GameFrameworkException>(() => a.Subscribe(1, null)); Throws<GameFrameworkException>(() => a.Unsubscribe(1, null));
        });
        Run("manager_initialization_sets_ready_before_saved_callback", () =>
        {
            var m = new FsmManager(); bool called = false;
            SetCallback(m, () => { True(IsReady(m)); called = true; }); m.Initialize(); True(called); True(IsReady(m)); Eq(80, m.Priority);
        });
        Run("manager_named_create_lookup_duplicate_destroy", () =>
        {
            var m = new FsmManager(); Eq(0, m.Count); var a = new A(); var f = m.CreateFsm("one", new Owner(), a);
            Eq(1, m.Count); Same(f, m.GetFsm<Owner>("one")); True(m.HasFsm<Owner>("one")); False(m.HasFsm<Owner>());
            Same(f, m.GetAllFsms().Single()); Throws<GameFrameworkException>(() => m.CreateFsm("one", new Owner(), new B()));
            f.Start<A>(); True(m.DestroyFsm(f)); True(f.IsDestroyed); Eq(0, m.Count); False(m.DestroyFsm<Owner>("one"));
            Throws<GameFrameworkException>(() => m.DestroyFsm<Owner>((IFsm<Owner>)null));
        });
        Run("manager_self_removal_skips_shifted_next_entry_native_contract", () =>
        {
            var m = new FsmManager(); var a = new A(); var b = new A(); var c = new A();
            var fa = m.CreateFsm("a", new Owner(), a); var fb = m.CreateFsm("b", new Owner(), b); var fc = m.CreateFsm("c", new Owner(), c);
            fa.Start<A>(); fb.Start<A>(); fc.Start<A>(); a.Update = (_, _, _) => m.DestroyFsm(fa); b.Update = (_, _, _) => Trace.Add("b.updated"); c.Update = (_, _, _) => Trace.Add("c.updated");
            Trace.Clear(); m.Update(1f, 2f); False(Trace.Contains("b.updated")); True(Trace.Contains("c.updated")); Eq(2, m.Count);
        });
        Run("manager_new_entry_updates_in_same_frame_native_contract", () =>
        {
            var m = new FsmManager(); var a = new A(); var f = m.CreateFsm("a", new Owner(), a); f.Start<A>();
            a.Update = (_, _, _) => { var b = new B(); b.Update = (_, _, _) => Trace.Add("new.updated"); var fb = m.CreateFsm("new", new Owner(), b); fb.Start<B>(); };
            Trace.Clear(); m.Update(1f, 2f); True(Trace.Contains("new.updated"));
        });
        Run("manager_shutdown_destroys_all_and_clears_ready", () =>
        {
            var m = new FsmManager(); m.Initialize(); var a = m.CreateFsm("a", new Owner(), new A()); var b = m.CreateFsm("b", new Owner(), new A());
            a.Start<A>(); b.Start<A>(); m.Shutdown(); True(a.IsDestroyed); True(b.IsDestroyed); Eq(0, m.Count); False(IsReady(m));
        });
        Run("procedure_initialize_does_not_register_or_enter", () =>
        {
            var m = new ProcedureManager(); bool called = false; SetCallback(m, () => { True(IsReady(m)); called = true; });
            m.Initialize(); True(called); True(IsReady(m)); False(BoundaryMode.Calls.Any(x => x.StartsWith("GameFrameEntry.GetModule"))); Eq(90, m.Priority);
        });
        Run("procedure_register_and_start_uses_real_fsm_and_updates_once", () =>
        {
            var fm = new FsmManager(); GameFrameEntry.Module = fm; var pm = new ProcedureManager(); var a = new ProcA(); var b = new ProcB();
            pm.Register(a, b); True(pm.HasProcedure<ProcA>()); Same(a, pm.GetProcedure<ProcA>()); Same(b, pm.GetProcedure(typeof(ProcB)));
            pm.StartProcedure(typeof(ProcA)); Same(a, pm.CurrentProcedure); fm.Update(2f, 3f); Eq(2f, pm.CurrentProcedureTime); Eq(1, a.Updates);
            pm.Update(5f, 6f); Eq(1, a.Updates); pm.Shutdown(); Eq(0, fm.Count);
        });
        Run("procedure_enter_changes_state_through_original_generic_bridge", () =>
        {
            var fm = new FsmManager(); GameFrameEntry.Module = fm; var pm = new ProcedureManager(); var a = new ProcA(); var b = new ProcB();
            a.Enter = owner => a.Route<ProcB>(owner); pm.Register(a, b); Trace.Clear(); pm.StartProcedure<ProcA>();
            Same(b, pm.CurrentProcedure); Sequence("ProcA.enter", "ProcA.leave:False", "ProcB.enter");
        });
        Run("procedure_missing_fsm_manager_is_real_error", () =>
        { GameFrameEntry.Module = null; var pm = new ProcedureManager(); Throws<GameFrameworkException>(() => pm.Register(new ProcA())); });
        Run("production_empty_Utility_key_is_explicit_integration_blocker", () =>
        {
            BoundaryMode.KeysAreAvailable = false;
            try { var m = new FsmManager(); Throws<ArgumentNullException>(() => m.CreateFsm("blocked", new Owner(), new A())); }
            finally { BoundaryMode.KeysAreAvailable = true; }
        });

        Run("default_FsmBase_constructor_normalizes_name_to_empty", () =>
        { var f = new DefaultFsmBase(); Eq("", f.Name); f.FullName = "assigned"; Eq("assigned", f.FullName); });
        Run("FsmState_args_enter_does_not_forward_to_noargs_overload", () =>
        {
            var state = new NoArgsOnly(); var f = new Fsm<Owner>(null, new Owner(), state);
            f.Start<NoArgsOnly>(new object[] { "payload" }); True(f.IsRunning); Eq(0, state.Entries);
            f.ChangeState<NoArgsOnly>(Array.Empty<object>()); Eq(1, state.Entries);
        });
        Run("constructor_init_may_start_and_reenter_but_finally_resets_current", () =>
        {
            var a = new A(); var b = new B(); a.Init = f => f.Start<A>(); b.Init = f => a.Route<B>(f);
            var fsm = New(new Owner(), a, b); False(fsm.IsRunning); Eq<FsmState<Owner>>(null, fsm.CurrentState); Eq(0f, fsm.CurrentStateTime);
            Sequence("A.init", "A.enter", "B.init", "A.leave:False", "B.enter");
        });
        Run("state_change_bridge_rejects_null_and_foreign_Ifsm", () =>
        {
            var a = new A(); Throws<GameFrameworkException>(() => a.Route<B>(null)); Throws<GameFrameworkException>(() => a.Route(null, typeof(B)));
            var foreign = new ForeignFsm(); Throws<InvalidCastException>(() => a.Route<B>(foreign)); Throws<InvalidCastException>(() => a.Route(foreign, typeof(B)));
        });
        Run("shutdown_leave_exception_retains_current_time_storage_and_manager_entry", () =>
        {
            var m = new FsmManager(); var a = new A(); var b = new B(); var f = (Fsm<Owner>)m.CreateFsm("throwLeave", new Owner(), a, b);
            f.SetData("key", new ProbeVariable()); f.Start<A>(); f.Update(3f, 4f); a.Leave = (_, _) => throw new ProbeException(); Trace.Clear();
            Throws<ProbeException>(() => m.DestroyFsm(f)); Same(a, f.CurrentState); Eq(3f, f.CurrentStateTime); False(f.IsDestroyed); Eq(2, f.FsmStateCount);
            True(f.HasData("key")); Eq(1, m.Count); Same(f, m.GetFsm<Owner>("throwLeave")); Sequence("A.leave:True");
        });
        Run("shutdown_destroy_exception_has_cleared_current_but_keeps_storage_and_flag", () =>
        {
            var m = new FsmManager(); var a = new A(); var b = new B(); var f = (Fsm<Owner>)m.CreateFsm("throwDestroy", new Owner(), a, b);
            f.SetData("key", new ProbeVariable()); f.Start<A>(); f.Update(3f, 4f); a.Destroy = _ => throw new ProbeException(); Trace.Clear();
            Throws<ProbeException>(() => m.DestroyFsm(f)); Eq<FsmState<Owner>>(null, f.CurrentState); Eq(0f, f.CurrentStateTime); False(f.IsDestroyed);
            Eq(2, f.FsmStateCount); True(f.HasData("key")); Eq(1, m.Count); Sequence("A.leave:True", "A.destroy");
        });
        Run("unregistered_procedure_CurrentProcedure_throws", () => Throws<GameFrameworkException>(() => { _ = new ProcedureManager().CurrentProcedure; }));
        Run("unregistered_procedure_CurrentProcedureTime_throws", () => Throws<GameFrameworkException>(() => { _ = new ProcedureManager().CurrentProcedureTime; }));
        Run("unregistered_procedure_Start_generic_throws", () => Throws<GameFrameworkException>(() => new ProcedureManager().StartProcedure<ProcA>()));
        Run("unregistered_procedure_Start_type_throws", () => Throws<GameFrameworkException>(() => new ProcedureManager().StartProcedure(typeof(ProcA))));
        Run("unregistered_procedure_Has_generic_throws", () => Throws<GameFrameworkException>(() => new ProcedureManager().HasProcedure<ProcA>()));
        Run("unregistered_procedure_Has_type_throws", () => Throws<GameFrameworkException>(() => new ProcedureManager().HasProcedure(typeof(ProcA))));
        Run("unregistered_procedure_Get_generic_throws", () => Throws<GameFrameworkException>(() => new ProcedureManager().GetProcedure<ProcA>()));
        Run("unregistered_procedure_Get_type_throws", () => Throws<GameFrameworkException>(() => new ProcedureManager().GetProcedure(typeof(ProcA))));
        Run("duplicate_register_reacquires_manager_but_retains_previous_fsm_on_error", () =>
        {
            var pm = new ProcedureManager(); var firstManager = new FsmManager(); GameFrameEntry.Module = firstManager; var first = new ProcA(); pm.Register(first);
            var previousFsm = GetPrivate(pm, "m_ProcedureFsm"); var secondManager = new FsmManager(); secondManager.CreateFsm<IProcedureManager>(pm, new ProcB());
            GameFrameEntry.Module = secondManager; Throws<GameFrameworkException>(() => pm.Register(new ProcB()));
            Same(secondManager, GetPrivate(pm, "m_FsmManager")); Same(previousFsm, GetPrivate(pm, "m_ProcedureFsm")); Same(first, pm.GetProcedure<ProcA>());
            Eq(1, firstManager.Count); Eq(1, secondManager.Count);
        });
        Run("procedure_shutdown_destroy_error_retains_fields_ready_and_current", () =>
        {
            var pm = new ProcedureManager(); pm.Initialize(); var fm = new FsmManager(); GameFrameEntry.Module = fm; var a = new ProcA(); pm.Register(a); pm.StartProcedure<ProcA>();
            var procedureFsm = GetPrivate(pm, "m_ProcedureFsm"); a.Leave = (_, _) => throw new ProbeException();
            Throws<ProbeException>(() => pm.Shutdown()); Same(fm, GetPrivate(pm, "m_FsmManager")); Same(procedureFsm, GetPrivate(pm, "m_ProcedureFsm"));
            True(IsReady(pm)); Same(a, pm.CurrentProcedure); Eq(1, fm.Count);
        });

        var output = new { mode = args.ElementAtOrDefault(1), testCount = Results.Count, passed = Results.Count - Failures, failed = Failures,
            sourcePolicy = "Actual byte-identical baseline or candidate files compiled; no duplicated FSM/Procedure business implementation",
            level = "Independent CLR lifecycle semantics with explicit Utility/GameFrameEntry/CLog test boundaries; not Unity/native runtime acceptance", tests = Results };
        File.WriteAllText(args[0], JsonSerializer.Serialize(output, new JsonSerializerOptions { WriteIndented = true }));
        Console.WriteLine($"RESULT tests={Results.Count} passed={Results.Count - Failures} failed={Failures}");
        return Failures == 0 ? 0 : 1;
    }
    private static Fsm<Owner> New(Owner owner, params FsmState<Owner>[] states) => new("named", owner, states);
    private static object GetPrivate(object instance, string field) => instance.GetType().GetField(field, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(instance);
    private static bool IsReady(GameFrameModule module) => (bool)typeof(GameFrameModule).GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Single(x => x.FieldType == typeof(bool)).GetValue(module);
    private static void SetCallback(GameFrameModule module, Action callback) => typeof(GameFrameModule).GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Single(x => x.FieldType == typeof(Action)).SetValue(module, callback);
    private static void Run(string name, Action action)
    {
        Trace.Clear(); BoundaryMode.Calls.Clear(); BoundaryMode.KeysAreAvailable = true; GameFrameEntry.Module = null;
        try { action(); Results.Add(new { name, passed = true, trace = Trace.ToArray(), boundaryTrace = BoundaryMode.Calls.ToArray() }); Console.WriteLine("PASS " + name); }
        catch (Exception e) { Failures++; Results.Add(new { name, passed = false, error = e.ToString(), trace = Trace.ToArray(), boundaryTrace = BoundaryMode.Calls.ToArray() }); Console.WriteLine("FAIL " + name + " " + e.GetType().Name + ": " + e.Message); }
    }
    internal static void True(bool value) { if (!value) throw new Exception("Expected true"); }
    private static void False(bool value) => True(!value);
    internal static void Same(object expected, object actual) { if (!ReferenceEquals(expected, actual)) throw new Exception("Expected same instance"); }
    internal static void Eq<T>(T expected, T actual) { if (!EqualityComparer<T>.Default.Equals(expected, actual)) throw new Exception($"Expected {expected}, actual {actual}"); }
    private static void Sequence(params string[] expected) { if (!Trace.SequenceEqual(expected)) throw new Exception("Expected trace " + string.Join(",", expected) + "; actual " + string.Join(",", Trace)); }
    private static void Throws<T>(Action action) where T : Exception
    { try { action(); } catch (T) { return; } throw new Exception("Expected exception " + typeof(T).Name); }
}
internal sealed class Owner { }
internal sealed class ProbeException : Exception { }
internal class Probe : FsmState<Owner>
{
    public Action<IFsm<Owner>> Init, Enter, Destroy;
    public Action<IFsm<Owner>, bool> Leave;
    public Action<IFsm<Owner>, float, float> Update;
    public object[] Args;
    private string Label => GetType().Name;
    public override void OnInit(IFsm<Owner> f) { Program.Trace.Add(Label + ".init"); Init?.Invoke(f); }
    public override void OnEnter(IFsm<Owner> f) { Program.Trace.Add(Label + ".enter"); Enter?.Invoke(f); }
    public override void OnEnter(IFsm<Owner> f, params object[] args) { Args = args; Program.Trace.Add(Label + ".enterArgs"); Enter?.Invoke(f); }
    public override void OnLeave(IFsm<Owner> f, bool shutdown) { Program.Trace.Add(Label + ".leave:" + shutdown); Leave?.Invoke(f, shutdown); }
    public override void OnUpdate(IFsm<Owner> f, float d, float r) { Program.Trace.Add(Label + ".update"); Update?.Invoke(f, d, r); }
    public override void OnDestroy(IFsm<Owner> f) { Program.Trace.Add(Label + ".destroy"); Destroy?.Invoke(f); base.OnDestroy(f); }
    public void Route<T>(IFsm<Owner> f, params object[] args) where T : FsmState<Owner> => ChangeState<T>(f, args);
    public void Route(IFsm<Owner> f, Type type, params object[] args) => ChangeState(f, type, args);
    public void Subscribe(int id, FsmEventHandler<Owner> handler) => SubscribeEvent(id, handler);
    public void Unsubscribe(int id, FsmEventHandler<Owner> handler) => UnsubscribeEvent(id, handler);
}
internal sealed class A : Probe { }
internal sealed class B : Probe { }
internal sealed class C : Probe { }
internal sealed class ProbeVariable : Variable
{
    public override Type Type => typeof(object);
    public override object GetValue() => null;
    public override void SetValue(object _) { }
    public override void Reset() { }
}
internal class Proc : ProcedureBase
{
    public Action<IFsm<IProcedureManager>> Enter;
    public Action<IFsm<IProcedureManager>, bool> Leave;
    public int Updates;
    public override void OnEnter(IFsm<IProcedureManager> f) { Program.Trace.Add(GetType().Name + ".enter"); base.OnEnter(f); Enter?.Invoke(f); }
    public override void OnLeave(IFsm<IProcedureManager> f, bool shutdown) { Program.Trace.Add(GetType().Name + ".leave:" + shutdown); base.OnLeave(f, shutdown); Leave?.Invoke(f, shutdown); }
    public override void OnUpdate(IFsm<IProcedureManager> f, float d, float r) { Updates++; base.OnUpdate(f, d, r); }
    public void Route<T>(IFsm<IProcedureManager> f) where T : ProcedureBase => ChangeState<T>(f);
}
internal sealed class ProcA : Proc { }
internal sealed class ProcB : Proc { }
internal sealed class NoArgsOnly : FsmState<Owner>
{
    public int Entries;
    public override void OnEnter(IFsm<Owner> f) { Entries++; }
}
internal sealed class DefaultFsmBase : FsmBase
{
    public override Type OwnerType => typeof(Owner);
    public override int FsmStateCount => 0;
    public override bool IsRunning => false;
    public override bool IsDestroyed => false;
    public override string CurrentStateName => null;
    public override float CurrentStateTime => 0;
    internal override void Update(float d, float r) { }
    internal override void Shutdown() { }
}
internal sealed class ForeignFsm : IFsm<Owner>
{
    public string Name => throw new NotSupportedException();
    public string FullName => throw new NotSupportedException();
    public Owner Owner => throw new NotSupportedException();
    public int FsmStateCount => throw new NotSupportedException();
    public bool IsRunning => throw new NotSupportedException();
    public bool IsDestroyed => throw new NotSupportedException();
    public FsmState<Owner> CurrentState => throw new NotSupportedException();
    public float CurrentStateTime => throw new NotSupportedException();
    public void Start<T>(params object[] args) where T : FsmState<Owner> => throw new NotSupportedException();
    public void Start(Type type, params object[] args) => throw new NotSupportedException();
    public bool HasState<T>() where T : FsmState<Owner> => throw new NotSupportedException();
    public bool HasState(Type type) => throw new NotSupportedException();
    public T GetState<T>() where T : FsmState<Owner> => throw new NotSupportedException();
    public FsmState<Owner> GetState(Type type) => throw new NotSupportedException();
    public void FireEvent(object sender, int id) => throw new NotSupportedException();
    public void FireEvent(object sender, int id, object data) => throw new NotSupportedException();
    public bool HasData(string name) => throw new NotSupportedException();
    public Variable GetData(string name) => throw new NotSupportedException();
    public T GetData<T>(string name) where T : Variable => throw new NotSupportedException();
    public void SetData<T>(string name, T data) where T : Variable => throw new NotSupportedException();
    public bool RemoveData(string name) => throw new NotSupportedException();
}
