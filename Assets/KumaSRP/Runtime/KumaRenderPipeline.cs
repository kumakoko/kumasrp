// 2019.10.7
using UnityEngine;
using UnityEngine.Rendering;

namespace KumaSRP
{
    public class KumaRenderPipeline : RenderPipeline
    {
        KumaCameraRenderer renderer = new KumaCameraRenderer();

        protected override void Render(ScriptableRenderContext context, Camera[] cameras)
        {
            foreach (Camera camera in cameras)
            {
                renderer.Render(context, camera);
            }
        }
    }
}