//2019.10.7
using UnityEngine;
using UnityEngine.Rendering;

namespace KumaSRP
{
    public class KumaCameraRenderer
    {
        private ScriptableRenderContext context;
        private Camera camera = null;

        public void Render(ScriptableRenderContext context, Camera camera)
        {
            this.context = context;
            this.camera = camera;
            DrawVisibleGeometry();
            Submit();
        }

        void DrawVisibleGeometry()
        {
            context.DrawSkybox(camera);

        }

        void Submit()
        {
            context.Submit();
        }
    }
}