// 2019.10.16
using UnityEngine;
using UnityEngine.Rendering;

namespace KumaSRP
{
    [CreateAssetMenu(menuName = "Rendering/Custom Render Pipeline")]
    public class KumaRenderPipelineAsset : RenderPipelineAsset
    {
        protected override RenderPipeline CreatePipeline()
        {
            return new KumaRenderPipeline();
        }
    }
}