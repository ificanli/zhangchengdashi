using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x200011C")]
	[AddComponentMenu("Pathfinding/Modifiers/Funnel Modifier")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/funnelmodifier.html")]
	public class FunnelModifier : MonoModifier
	{
		[Token(Token = "0x200011D")]
		public enum FunnelQuality
		{
			[Token(Token = "0x4000619")]
			Medium = 0,
			[Token(Token = "0x400061A")]
			High = 1
		}

		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x30")]
		public FunnelQuality quality;

		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x34")]
		public bool splitAtEveryPortal;

		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x35")]
		public bool accountForGridPenalties;

		[Token(Token = "0x170001C1")]
		public override int Order
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x4553DE4", Offset = "0x454FDE4", VA = "0x4553DE4", Slot = "20")]
			get
			{ return 10; }
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x4553DEC", Offset = "0x454FDEC", VA = "0x4553DEC", Slot = "22")]
		public override void Apply(Path p)
		{
            if (p.path == null || p.path.Count == 0 || p.vectorPath == null || p.vectorPath.Count == 0) return;
            System.Collections.Generic.List<Vector3> result = Pathfinding.Pooling.ListPool<Vector3>.Claim();
            System.Collections.Generic.List<Funnel.PathPart> parts = Funnel.SplitIntoParts(p);
            if (parts.Count == 0) return;
            if (quality == FunnelQuality.High)
                Funnel.Simplify(parts, ref p.path, ref p.traversalCosts, ref p.traversalConstraint);
            for (int i = 0; i < parts.Count; i = unchecked(i + 1))
            {
                Funnel.PathPart part = parts[i];
                if (part.type == Funnel.PartType.NodeSequence)
                {
                    NavGraph graph = p.path[part.startIndex].Graph;
                    GridGraph grid = graph as GridGraph;
                    if (grid != null && grid.neighbours != NumNeighbours.Six)
                    {
                        TraversalCosts traversalCosts = accountForGridPenalties ? p.traversalCosts : default;
                        System.Collections.Generic.List<Vector3> route = GridStringPulling.Calculate(p.path, part.startIndex, part.endIndex,
                            part.startPoint, part.endPoint, ref traversalCosts, ref p.traversalConstraint, int.MaxValue);
                        result.AddRange(route);
                        Pathfinding.Pooling.ListPool<Vector3>.Release(ref route);
                    }
                    else
                    {
                        Funnel.FunnelPortals portals = Funnel.ConstructFunnelPortals(p.path, part);
                        System.Collections.Generic.List<Vector3> route = Funnel.Calculate(portals, splitAtEveryPortal);
                        result.AddRange(route);
                        Pathfinding.Pooling.ListPool<Vector3>.Release(ref portals.left);
                        Pathfinding.Pooling.ListPool<Vector3>.Release(ref portals.right);
                        Pathfinding.Pooling.ListPool<Vector3>.Release(ref route);
                    }
                }
                else
                {
                    if (i == 0 || parts[unchecked(i - 1)].type == Funnel.PartType.OffMeshLink) result.Add(part.startPoint);
                    if (i == unchecked(parts.Count - 1) || parts[unchecked(i + 1)].type == Funnel.PartType.OffMeshLink) result.Add(part.endPoint);
                }
            }
            Pathfinding.Pooling.ListPool<Funnel.PathPart>.Release(ref parts);
            Pathfinding.Pooling.ListPool<Vector3>.Release(ref p.vectorPath);
            p.vectorPath = result;
        }

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x4554374", Offset = "0x4550374", VA = "0x4554374")]
		public FunnelModifier()
		{
		}
	}
}
