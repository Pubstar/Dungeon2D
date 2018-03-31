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
    class World
    {
        public int Width;
        public int Height;
        public Chunk[,] Chunks;

        public World()
            : this(1280, 720)
        {

        }

        public World(int width, int height)
        {
            Width = width;
            Height = height;
            Chunks = new Chunk[2, 2];
            Chunks[0, 0] = new Chunk();
            Chunks[1, 0] = new Chunk(new Vector2(1, 0));
            Chunks[0, 1] = new Chunk(new Vector2(0, 1));
            Chunks[1, 1] = new Chunk(new Vector2(1, 1));
        }

        public void LoadTiles(ContentManager content)
        {
            for (int x = 0; x < Chunks.GetLength(0); x++)
            {
                for (int y = 0; y < Chunks.GetLength(1); y++)
                {
                    Chunks[x, y].LoadTiles(content);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int x = 0; x < Chunks.GetLength(0); x++)
            {
                for (int y = 0; y < Chunks.GetLength(1); y++)
                {
                    Chunks[x, y].Draw(spriteBatch);
                }
            }
        }
    }
}
