using Ryujinx.Graphics.GAL;
using Ryujinx.Graphics.Gpu.Engine.Threed;

namespace Ryujinx.Graphics.Gpu.Shader
{
    /// <summary>
    /// State used by the <see cref="GpuAccessor"/>.
    /// </summary>
    struct GpuChannelGraphicsState
    {
        // New fields should be added to the end of the struct to keep disk shader cache compatibility.

        /// <summary>
        /// Early Z force enable.
        /// </summary>
        public readonly bool EarlyZForce;

        /// <summary>
        /// Primitive topology of current draw.
        /// </summary>
        public readonly PrimitiveTopology Topology;

        /// <summary>
        /// Tessellation mode.
        /// </summary>
        public readonly TessMode TessellationMode;

        /// <summary>
        /// Depth mode zero to one or minus one to one.
        /// </summary>
        public readonly bool DepthMode;

        /// <summary>
        /// Indicates if the point size is set on the shader or is fixed.
        /// </summary>
        public readonly bool ProgramPointSizeEnable;

        /// <summary>
        /// Point size if not set from shader.
        /// </summary>
        public readonly float PointSize;

        /// <summary>
        /// Creates a new GPU graphics state.
        /// </summary>
        /// <param name="earlyZForce">Early Z force enable</param>
        /// <param name="topology">Primitive topology</param>
        /// <param name="tessellationMode">Tessellation mode</param>
        /// <param name="depthMode">Depth mode zero to one or minus one to one</param>
        /// <param name="programPointSizeEnable">Indicates if the point size is set on the shader or is fixed</param>
        /// <param name="pointSize">Point size if not set from shader</param>
        public GpuChannelGraphicsState(
            bool earlyZForce,
            PrimitiveTopology topology,
            TessMode tessellationMode,
            bool depthMode,
            bool programPointSizeEnable,
            float pointSize)
        {
            EarlyZForce = earlyZForce;
            Topology = topology;
            TessellationMode = tessellationMode;
            DepthMode = depthMode;
            ProgramPointSizeEnable = programPointSizeEnable;
            PointSize = pointSize;
        }
    }
}