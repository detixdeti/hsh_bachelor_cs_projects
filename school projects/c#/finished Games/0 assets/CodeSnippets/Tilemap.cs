using System;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;
using System.Xml;
// Ersetze ProjectName mit dem Namen des Projekts
using ProjectName.framework;

namespace ProjectName.entities
{
    class Tilemap
    {

        const int TILE_EMPTY = 0;
        const int TILES_OFFSET = 1;

        Screen screen;
        Texture tileset;
        int[,,] layers;
        Sprite[] tiles;
        int tileWidth;
        int tileHeight;

        public Vector2f Position;
        float Rotation;
        public Vector2f Scale;
        public Vector2f Origin;

        public Vector2f Size
        {
            get
            {
                return new Vector2f(layers.GetLength(0) * tileWidth * Scale.X, layers.GetLength(1) * tileHeight * Scale.Y);
            }
        }

        /// <summary>
        /// Erstellt eine neue Tilemap mit einem Layer
        /// </summary>
        /// <param name="parentScreen">Der Screen in der die Tilemap gezeichnet wird, meistens 'this' </param>
        /// <param name="tileset">Eine Textur die ein Tileset enthält</param>
        /// <param name="tileWidth">Die Breite eines Tiles im Tileset</param>
        /// <param name="tileHeight">Die Höhe eines Tiles im Tileset</param>
        /// <param name="mapWidth">Die Anzahl der Tiles in der Breite, die die Map enthält</param>
        /// <param name="mapHeight">Die Anzahl der Tiles in der Höhe, die die Map enthält</param>
        public Tilemap(Screen parentScreen, Texture tileset, int tileWidth, int tileHeight, int mapWidth, int mapHeight)
        {
            this.screen = parentScreen;
            this.tileset = tileset;
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;

            this.Scale = new Vector2f(1, 1);
            this.Position = new Vector2f(0, 0);
            this.Origin = new Vector2f(0, 0);
            this.Rotation = 0;

            layers = new int[mapWidth, mapHeight, 1];
            

            int setCols = (int)tileset.Size.X / tileWidth;
            int setRows = (int)tileset.Size.Y / tileHeight;

            tiles = new Sprite[setCols*setRows];

            for (int y = 0; y < setRows; y++)
            {
                for (int x = 0; x < setCols; x++)
                {
                    tiles[y * setCols + x] = new Sprite(tileset, new IntRect(x*tileWidth, y*tileHeight, tileWidth, tileHeight));
                }
            }
        }

        /// <summary>
        /// Erstellt eine neue Tilemap mit mehreren Layern
        /// </summary>
        /// <param name="parentScreen">Der Screen in der die Tilemap gezeichnet wird, meistens 'this' </param>
        /// <param name="tileset">Eine Textur die ein Tileset enthält</param>
        /// <param name="tileWidth">Die Breite eines Tiles im Tileset</param>
        /// <param name="tileHeight">Die Höhe eines Tiles im Tileset</param>
        /// <param name="mapWidth">Die Anzahl der Tiles in der Breite, die die Map enthält</param>
        /// <param name="mapHeight">Die Anzahl der Tiles in der Höhe, die die Map enthält</param>
        /// <param name="layerCount">Die Anzahl der Schichten in der Tilemap</param>
        public Tilemap(Screen parentScreen, Texture tileset, int tileWidth, int tileHeight, int mapWidth, int mapHeight, int layerCount)
        {
            this.screen = parentScreen;
            this.tileset = tileset;
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;

            this.Scale = new Vector2f(1, 1);
            this.Position = new Vector2f(0, 0);
            this.Origin = new Vector2f(0, 0);
            this.Rotation = 0;

            layers = new int[mapWidth, mapHeight, layerCount];


            int setCols = (int)tileset.Size.X / tileWidth;
            int setRows = (int)tileset.Size.Y / tileHeight;

            tiles = new Sprite[setCols * setRows];

            for (int y = 0; y < setRows; y++)
            {
                for (int x = 0; x < setCols; x++)
                {
                    tiles[y * setCols + x] = new Sprite(tileset, new IntRect(x * tileWidth, y * tileHeight, tileWidth, tileHeight));
                }
            }
        }

        /// <summary>
        /// Erstellt eine Tilemap mit einem Tileset und einer Tiled tmx datei
        /// </summary>
        /// <param name="parentScreen">Auf welchen Screen die Tilemap gerendert wird </param>
        /// <param name="tileset">Eine Textur die alle Tiles enthält</param>
        /// <param name="tiledFilePath">Pfad zur Tiled Tilemap Datei(.tmx)</param>
        public Tilemap(Screen parentScreen, Texture tileset, String tiledFilePath)
        {
            this.screen = parentScreen;
            this.tileset = tileset;

            this.Scale = new Vector2f(1, 1);
            this.Position = new Vector2f(0, 0);
            this.Origin = new Vector2f(0, 0);
            this.Rotation = 0;

            int mapWidth = 0;
            int mapHeight = 0;

            List<int[]> mapValues = new List<int[]>();

            using (XmlReader reader = XmlReader.Create(tiledFilePath, new XmlReaderSettings()))
            {
                reader.Read();
                reader.ReadToFollowing("map");
                mapWidth = int.Parse(reader.GetAttribute("width"));
                mapHeight = int.Parse(reader.GetAttribute("height"));
            
                tileWidth = int.Parse(reader.GetAttribute("tilewidth"));
                tileHeight = int.Parse(reader.GetAttribute("tileheight"));



                while (reader.ReadToFollowing("layer"))
                {
                    reader.ReadToDescendant("data");
                    string mapdata = reader.ReadElementContentAsString();

                    //Remove newlines
                    mapdata = mapdata.Replace("\n", "");

                    string[] values = mapdata.Split(',');

                    int[] intValues = new int[values.Length];

                    for (int i = 0; i < values.Length; i++)
                    {
                        intValues[i] = int.Parse(values[i]);
                    }

                    mapValues.Add(intValues);
                }
            }


            layers = new int[mapWidth, mapHeight, mapValues.Count];
            for (int l = 0; l < mapValues.Count; l++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    for (int y = 0; y < mapHeight; y++)
                    {
                        layers[x, y, l] = mapValues[l][y * mapWidth + x];
                    }
                }
            }
           

            int setCols = (int)tileset.Size.X / tileWidth;
            int setRows = (int)tileset.Size.Y / tileHeight;

            tiles = new Sprite[setCols * setRows];

            for (int y = 0; y < setRows; y++)
            {
                for (int x = 0; x < setCols; x++)
                {
                    tiles[y * setCols + x] = new Sprite(tileset, new IntRect(x * tileWidth, y * tileHeight, tileWidth, tileHeight));
                }
            }
            
        }
        

        /// <summary>
        /// Setzt ein Tile in der Tilemap in der untersten Schicht
        /// </summary>
        /// <param name="x">Horizontale Position des Tiles</param>
        /// <param name="y">Vertikale Position des Tiles</param>
        /// <param name="id">Die ID des neuen Tiles</param>
        public void setTile(int x, int y, int id)
        {
            layers[x, y, 0] = id + TILES_OFFSET;
        }

        /// <summary>
        /// Setzt ein Tile in der Tilemap in der untersten Schicht
        /// </summary>
        /// <param name="x">Horizontale Position des Tiles</param>
        /// <param name="y">Vertikale Position des Tiles</param>
        /// <param name="layer">Die Schicht, die verändert wird</param>
        /// <param name="id">Die ID des neuen Tiles</param>
        public void setTile(int x, int y, int layer, int id)
        {
            layers[x, y, layer] = id + TILES_OFFSET;
        }

        /// <summary>
        /// Gibt die ID des Tiles an der Stelle zurück
        /// </summary>
        /// <param name="x">Horizontale Position des Tiles</param>
        /// <param name="y">Vertikale Position des Tiles</param>
        /// <returns>ID des Tiles</returns>
        public int getTile(int x, int y)
        {
            return layers[x, y, 0] - TILES_OFFSET;
        }

        /// <summary>
        /// Gibt die ID des Tiles an der Stelle zurück
        /// </summary>
        /// <param name="x">Horizontale Position des Tiles</param>
        /// <param name="y">Vertikale Position des Tiles</param>
        /// <param name="layer">Die Schicht des Tiles</param>
        /// <returns>ID des Tiles</returns>
        public int getTile(int x, int y, int layer)
        {
            return layers[x, y, layer] - TILES_OFFSET; ;
        }

        /// <summary>
        /// Gibt an, ob eine Hitbox mit irgendeinem der Tiles kollidiert
        /// </summary>
        /// <param name="hitbox">Die Hitbox, die auf Kollision überprüft wird</param>
        /// <returns>True wenn es eine Kollision gibt, sonst False</returns>
        public bool collideWith(FloatRect hitbox)
        {
            for (int x = 0; x < layers.GetLength(0); x++)
            {
                for (int y = 0; y < layers.GetLength(1); y++)
                {
                    for (int z = 0; z < layers.GetLength(2); z++)
                    {
                        if (layers[x, y, z] != TILE_EMPTY)
                        {
                            Sprite tile = tiles[layers[x, y, z] - TILES_OFFSET];

                            tile.Rotation = Rotation;
                            tile.Position = Position;
                            tile.Origin = new Vector2f(-tileWidth * x + Origin.X, -tileHeight * y + Origin.Y);
                            tile.Scale = Scale;

                            if(tile.GetGlobalBounds().Intersects(hitbox))
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Gibt an, ob eine Hitbox mit irgendeinem der Tiles kollidiert
        /// </summary>
        /// <param name="hitbox">Die Hitbox, die auf Kollision überprüft wird</param>
        /// <param name="collidingTiles">Ein Array der alle IDs angibt, mit der die Hitbox kollidieren soll</param>
        /// <returns>True wenn es eine Kollision gibt, sonst False</returns>
        public bool collideWith(FloatRect hitbox, int[] collidingTiles)
        {
            for (int x = 0; x < layers.GetLength(0); x++)
            {
                for (int y = 0; y < layers.GetLength(1); y++)
                {
                    for (int z = 0; z < layers.GetLength(2); z++)
                    {
                        for (int i = 0; i < collidingTiles.Length; i++)
                        {
                            if(layers[x, y, z] - TILES_OFFSET == collidingTiles[i])
                            {
                                Sprite tile = tiles[layers[x, y, z] - TILES_OFFSET];

                                tile.Rotation = Rotation;
                                tile.Position = Position;
                                tile.Origin = new Vector2f(-tileWidth * x + Origin.X, -tileHeight * y + Origin.Y);
                                tile.Scale = Scale;

                                if (tile.GetGlobalBounds().Intersects(hitbox))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Gibt an, ob eine Hitbox mit irgendeinem der Tiles aus einem Layer kollidiert
        /// </summary>
        /// <param name="hitbox">Die Hitbox, die auf Kollision überprüft wird</param>
        /// <param name="collidingLayer">Array enthält alle Layer, mit denen auf Kollision überprüft werde soll</param>
        /// <returns>True wenn es eine Kollision gibt, sonst False</returns>
        public bool collideWithLayers(FloatRect hitbox, int[] collidingLayers)
        {
            for (int x = 0; x < layers.GetLength(0); x++)
            {
                for (int y = 0; y < layers.GetLength(1); y++)
                {
                    for (int z = 0; z < layers.GetLength(2); z++)
                    {
                        for (int i = 0; i < collidingLayers.Length; i++)
                        {
                            if(z == collidingLayers[i])
                            {
                                Sprite tile = tiles[layers[x, y, z] - TILES_OFFSET];

                                tile.Rotation = Rotation;
                                tile.Position = Position;
                                tile.Origin = new Vector2f(-tileWidth * x + Origin.X, -tileHeight * y + Origin.Y);
                                tile.Scale = Scale;

                                if (tile.GetGlobalBounds().Intersects(hitbox))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Gibt an, ob eine Hitbox mit irgendeinem der Tiles aus einem Layer kollidiert
        /// </summary>
        /// <param name="hitbox">Die Hitbox, die auf Kollision überprüft wird</param>
        /// <param name="collidingLayer">Array enthält alle Layer, mit denen auf Kollision überprüft werde soll</param>
        /// <param name="collidingTiles">Ein Array der alle IDs angibt, mit der die Hitbox kollidieren soll</param>
        /// <returns>True wenn es eine Kollision gibt, sonst False</returns>
        public bool collideWithLayers(FloatRect hitbox, int[] collidingLayers, int[] collidingTiles)
        {
            for (int x = 0; x < layers.GetLength(0); x++)
            {
                for (int y = 0; y < layers.GetLength(1); y++)
                {
                    for (int z = 0; z < layers.GetLength(2); z++)
                    {
                        for (int i = 0; i < collidingLayers.Length; i++)
                        {
                            if (z == collidingLayers[i])
                            {
                                for (int k = 0; k < collidingTiles.Length; k++)
                                {
                                    if (layers[x, y, z] - TILES_OFFSET == collidingTiles[k])
                                    {
                                        Sprite tile = tiles[layers[x, y, z] - TILES_OFFSET];

                                        tile.Rotation = Rotation;
                                        tile.Position = Position;
                                        tile.Origin = new Vector2f(-tileWidth * x + Origin.X, -tileHeight * y + Origin.Y);
                                        tile.Scale = Scale;

                                        if (tile.GetGlobalBounds().Intersects(hitbox))
                                        {
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Gibt eine List zurück, mit allen Tile Koordinaten, an denen eine Kollision auftritt
        /// </summary>
        /// <param name="hitbox">Die Hitbox, die auf Kollision überprüft wird</param>
        /// <param name="collidingTiles">Ein Array der alle IDs angibt, mit der die Hitbox kollidieren soll</param>
        /// <param name="layer">Das Layer, für das die Kollision überprüft werden soll</param>
        /// <returns>Eine Liste mit integer Koordinaten, an denen Kollisionen auftraten</returns>
        public List<Vector2i> collideWhere(FloatRect hitbox, int[] collidingTiles, int layer)
        {
            List<Vector2i> list = new List<Vector2i>();

            for (int x = 0; x < layers.GetLength(0); x++)
            {
                for (int y = 0; y < layers.GetLength(1); y++)
                {
                    for (int z = 0; z < layers.GetLength(2); z++)
                    {
                       
                        if (z == layer)
                        {
                            for (int k = 0; k < collidingTiles.Length; k++)
                            {
                                if (layers[x, y, z] - TILES_OFFSET == collidingTiles[k])
                                {
                                    Sprite tile = tiles[layers[x, y, z] - TILES_OFFSET];

                                    tile.Rotation = Rotation;
                                    tile.Position = Position;
                                    tile.Origin = new Vector2f(-tileWidth * x + Origin.X, -tileHeight * y + Origin.Y);
                                    tile.Scale = Scale;

                                    if (tile.GetGlobalBounds().Intersects(hitbox))
                                    {
                                        list.Add(new Vector2i(x, y));
                                    }
                                }
                            }
                            
                        }
                    }
                }
            }

            return list;
        }

        public void loop()
        {

        }

        /// <summary>
        /// Zeichnet alle Tiles der Tilemap auf den Screen
        /// </summary>
        public void render()
        {
            for (int x = 0; x < layers.GetLength(0); x++)
            {
                for (int y = 0; y < layers.GetLength(1); y++)
                {
                    for (int z = 0; z < layers.GetLength(2); z++)
                    {
                        if(layers[x, y, z] != TILE_EMPTY)
                        {
                            Sprite tile = tiles[layers[x, y, z] - TILES_OFFSET];

                            tile.Rotation = Rotation;
                            tile.Position = Position;
                            tile.Origin = new Vector2f(-tileWidth * x + Origin.X, -tileHeight * y + Origin.Y);
                            tile.Scale = Scale;

                            screen.draw(tile);
                        }
                    }
                }
            }
        }
    }
}
