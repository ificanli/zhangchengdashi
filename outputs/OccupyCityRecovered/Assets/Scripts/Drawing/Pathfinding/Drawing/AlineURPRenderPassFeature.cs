using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Pathfinding.Drawing
{
	[Token(Token = "0x2000006")]
	public class AlineURPRenderPassFeature : ScriptableRendererFeature
	{
		[Token(Token = "0x2000007")]
		public class AlineURPRenderPass : ScriptableRenderPass
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x46C699C", Offset = "0x46C299C", VA = "0x46C699C", Slot = "6")]
			public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
			}

			[Token(Token = "0x600000A")]
			[Address(RVA = "0x46C69A0", Offset = "0x46C29A0", VA = "0x46C69A0", Slot = "9")]
			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}

			[Token(Token = "0x600000B")]
			[Address(RVA = "0x46C68AC", Offset = "0x46C28AC", VA = "0x46C68AC")]
			public AlineURPRenderPass()
			{
			}

			[Token(Token = "0x600000C")]
			[Address(RVA = "0x46C6A18", Offset = "0x46C2A18", VA = "0x46C6A18", Slot = "4")]
			public override void FrameCleanup(CommandBuffer cmd)
			{
			}
		}

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		private AlineURPRenderPass m_ScriptablePass;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x46C6848", Offset = "0x46C2848", VA = "0x46C6848", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x46C694C", Offset = "0x46C294C", VA = "0x46C694C", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x46C6970", Offset = "0x46C2970", VA = "0x46C6970")]
		public void AddRenderPasses(ScriptableRenderer renderer)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x46C6994", Offset = "0x46C2994", VA = "0x46C6994")]
		public AlineURPRenderPassFeature()
		{
		}
	}
}
