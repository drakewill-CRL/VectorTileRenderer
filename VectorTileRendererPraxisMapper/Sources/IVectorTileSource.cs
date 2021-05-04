using System.Threading.Tasks;

namespace VectorTileRendererPraxisMapper.Sources
{
    public interface IVectorTileSource : ITileSource
    {
        Task<VectorTile> GetVectorTile(int x, int y, int zoom);
    }
}
