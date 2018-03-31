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
    class Chunk
    {
        public int Width;
        public int Height;
        public Vector2 Position;
        public Room Room;

        public Chunk()
            : this(new Vector2(0, 0))
        {

        }

        public Chunk(Vector2 position)
            : this(position, Settings.ChunkSize, Settings.ChunkSize)
        {

        }

        public Chunk(Vector2 position, int width, int height)
        {
            Width = width;
            Height = height;
            Position = position;
            Room = new Room(position, width, height);
        }

        public Chunk(Vector2 position, int width, int height, Room room)
        {
            Width = width;
            Height = height;
            Position = position;
            Room = room;
        }

        public void LoadTiles(ContentManager content)
        {
            Room.LoadTiles(content);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Room.Draw(spriteBatch);
        }
    }
}
