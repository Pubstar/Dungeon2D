using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon2D
{
    class Room
    {
        public int Width;
        public int Height;
        public Vector2 Position;
        public Tile[,] Tiles;

        public Room()
            : this(new Vector2(0, 0), Settings.ChunkSize, Settings.ChunkSize)
        {

        }

        public Room(Vector2 position, int width, int height)
        {
            Position = position;
            Width = width;
            Height = height;
            Tiles = new Tile[Width, Height];
        }

        public void LoadTiles(ContentManager content)
        {
            Texture2D texture = content.Load<Texture2D>("Textures/grass");
            Texture2D wall = content.Load<Texture2D>("Textures/wall");

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Tiles[x, y] = new Tile(new Vector2(x * Settings.TileSize + (Position.X * Settings.ChunkSize * Settings.TileSize), y * Settings.TileSize + (Position.Y * Settings.ChunkSize * Settings.TileSize)));

                    if ((x < Settings.ChunkSize / 5 && y < Settings.ChunkSize / 5) || (x >= Settings.ChunkSize / 1.25 && y >= Settings.ChunkSize / 1.25) || (x < Settings.ChunkSize / 5 && y >= Settings.ChunkSize / 1.25) || (x >= Settings.ChunkSize / 1.25 && y < Settings.ChunkSize / 5))
                    {
                        Tiles[x, y].LoadTexture(wall);
                    }
                    else
                        Tiles[x, y].LoadTexture(texture);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Tiles[x, y].Draw(spriteBatch);
                }
            }
        }
    }
}
