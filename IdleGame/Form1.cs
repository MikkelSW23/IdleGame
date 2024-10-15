using System;
using System.IO;
using System.Windows.Forms;
using IdleGame.MapGenerationFolder;
using MapGenerationFolder.Tiles;
using Newtonsoft.Json;

namespace IdleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MapGeneration map = new MapGeneration();
            ArrayToJson(map.GenerateMap(100), @"C:\Users\mikke\source\repos\IdleGame\IdleGame\Maps\Map1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ArrayToJson(Tile[] items, string outpath)
        {
            string jsonData = JsonConvert.SerializeObject(items);
            var myFile = File.Create(outpath);
            myFile.Close();
            File.WriteAllText(@"" + outpath, jsonData);
        }

        private void JsonToArray(Tile[] items, string outpath)
        {
            string jsonData = JsonConvert.SerializeObject(items);
            var myFile = File.Create(outpath);
            myFile.Close();
            File.WriteAllText(@"" + outpath, jsonData);

        }
    }
}
