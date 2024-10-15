using MapGenerationFolder.Tiles;
using System;
using System.Drawing;


namespace IdleGame.MapGenerationFolder.Tiles
{
    internal class Water : Tile
    {
        public override Color Color { get; set; }
        public override String Temperature { get; set; }


        public Water(String temperature) 
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
