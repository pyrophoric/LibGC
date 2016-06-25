﻿
namespace LibGC.ModelRenderer
{
    /// <summary>Interface to be implemented by each renderable object.</summary>
    public interface IRenderable
    {
        /// <summary>Render this object using the given model renderer.</summary>
        /// <param name="renderer">The instance of the renderer to use to render this object.</param>
        void Render(IRenderer renderer);
    }
}
