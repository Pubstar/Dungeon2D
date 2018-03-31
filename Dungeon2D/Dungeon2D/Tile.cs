using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon2D
{
    class Tile
    {
        public Vector2 Position;
        protected int Width;
        protected int Height;
        public Texture2D Texture;
        private Rectangle DrawBox;

        public Tile()
            : this(new Vector2(0, 0))
        {

        }

        public Tile(Vector2 position)
        {
            Position = position;
            Width = 64;
            Height = 64;
            DrawBox = new Rectangle((int)position.X, (int)Position.Y, Width, Height);
        }

        public void LoadTexture(Texture2D texture)
        {
            Texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Texture != null)
                spriteBatch.Draw(Texture, DrawBox, Color.White);
        }
    }
}
