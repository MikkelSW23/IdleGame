using MapGenerationFolder.Tiles;
using System;
using System.Drawing;


namespace IdleGame.MapGenerationFolder.Tiles
{
    internal class Mountian : Tile
    {
        public override Color Color { get; set; }
        public override String Temperature { get; set; }


        public Mountian(String temperature)
        {
            this.Temperature = temperature;
            switch (temperature)
            {
                case "Hot":
                    this.Color = Color.Peru;
                    break;
                case "Normal":
                    this.Color = Color.Gray;
                    break;
                case "Cold":
                    this.Color = Color.LightBlue;
                    break;
                default:
                    this.Color = Color.Pink;
                    break;
            }
        }
    }
}
