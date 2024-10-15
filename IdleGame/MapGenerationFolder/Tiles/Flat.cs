using MapGenerationFolder.Tiles;
using System;
using System.Drawing;

namespace IdleGame.MapGenerationFolder.Tiles
{
    internal class Flat : Tile
    {
        public override Color Color { get; set; }
        public override String Temperature { get; set; }


        public Flat(String temperature)
        {
            this.Temperature = temperature;
            switch (temperature)
            {
                case "Hot":
                    this.Color = Color.Moccasin;
                    break;
                case "Normal":
                    this.Color = Color.Green;
                    break;
                case "Cold":
                    this.Color = Color.LightCyan;
                    break;
                default:
                    this.Color = Color.Pink;
                    break;
            }
        }
    }
}
