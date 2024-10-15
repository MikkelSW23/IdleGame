using System.Drawing;


namespace MapGenerationFolder.Tiles
{
    public abstract class Tile
    {
        public abstract Color Color { get; set; }
        public abstract string Temperature { get; set; }

        
    }
}
