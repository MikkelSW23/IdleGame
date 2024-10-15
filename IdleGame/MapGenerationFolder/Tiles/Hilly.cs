using MapGenerationFolder.Tiles;
using System;
using System.Drawing;


namespace IdleGame.MapGenerationFolder.Tiles
{
    internal class Hilly : Tile
    {
        public override Color Color { get; set; }
        public override String Temperature { get; set; }


        public Hilly(String temperature)
        {
            this.Temperature = temperature;
            switch (temperature)
            {
                case "Hot":
                    this.Color = Color.BurlyWood;
                    break;
                case "Normal":
                    this.Color = Color.DarkGreen;
                    break;
                case "Cold":
                    this.Color = Color.PowderBlue;
                    break;
                default:
                    this.Color = Color.Pink;
                    break;
            }
        }
    }
}
