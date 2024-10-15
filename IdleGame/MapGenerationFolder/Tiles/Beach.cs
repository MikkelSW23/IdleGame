using MapGenerationFolder.Tiles;
using System;
using System.Drawing;

namespace IdleGame.MapGenerationFolder.Tiles
{
    internal class Beach : Tile
    {
        public override Color Color { get; set; }
        public override String Temperature{ get; set; }

    public Beach(String temperature)
        {
            this.Temperature = temperature;
            switch (temperature)
            {
                case "Normal":
                    this.Color = Color.Blue;
                    break;
                case "Cold":
                    this.Color = Color.CornflowerBlue;
                    break;
                default:
                    this.Color = Color.Pink;
                    break;
            }
        }
    }
}
