using MapGenerationFolder.Tiles;
using MapGenerationFolder.Noise;
using IdleGame.MapGenerationFolder.Tiles;


namespace IdleGame.MapGenerationFolder
{
    public class MapGeneration
    {
        public Tile[] GenerateMap(int size) 
        {
            double[][] elevationMap = NoiseMap(size, 0.07);
            double[][] moistureMap = NoiseMap(size, 0.005);
            Tile[] map = new Tile[size * size];
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    map[y * size + x] = FindBiome(elevationMap[y][x], moistureMap[y][x]);              
                }
            }
            return map;
        }

        private double[][] NoiseMap(int mapSize, double iResolution)
        {
            OpenSimplexNoise oSimplexNoise = new OpenSimplexNoise();
            double[][] elevation = new double[mapSize][];
            for (int i = 0; i < mapSize; i++)
            {
                elevation[i] = new double[mapSize];
            }
            for (int x = 0; x < mapSize; x++)
            {
                for (int y = 0; y < mapSize; y++)
                {
                    double e = 1 * TransformSimplex(oSimplexNoise.Evaluate((double)x * iResolution, (double)y * iResolution))
                             + 0.5 * TransformSimplex(oSimplexNoise.Evaluate((double)x * iResolution * 2, (double)y * iResolution * 2))
                             + 0.25 * TransformSimplex(oSimplexNoise.Evaluate((double)x * iResolution * 4, (double)y * iResolution * 4));


                    elevation[y][x] = e / (1 + 0.5 + 0.25);
                }
            }
            return elevation;
        }

        private double TransformSimplex(double value)
        {
            return (value + 1) / 2;
        }

        private Tile FindBiome(double elevation, double moisture)
        {
            //Low moisture = Hot
            double low = 0.4;
            //High moisture = Cold
            double high = 0.6;
            
            if (elevation < 0.3) //Water
            {
                if (moisture < low) return new Flat("Hot");
                if (moisture < high) return new Water("Normal");
                return new Water("Cold");
            }
            else if (elevation < 0.35) //Beach
            {
                if (moisture < low) return new Flat("Hot");
                if (moisture < high) return new Beach("Normal");
                return new Beach("Cold");
            }
            else if (elevation < 0.5) //Planes
            {
                if (moisture < low) return new Flat("Hot");
                if (moisture < high) return new Flat("Normal");
                return new Flat("Cold");
            }
            else if (elevation < 0.65) //Hill
            {
                if (moisture < low) return new Hilly("Hot");
                if (moisture < high) return new Hilly("Normal");
                return new Hilly("Cold");
            }
            else //Mountian
            {
                if (moisture < low) return new Mountian("Hot");
                if (moisture < high) return new Mountian("Normal");
                return new Mountian("Cold");
            }
        }
    }
}
