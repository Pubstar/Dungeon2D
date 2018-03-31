using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Dungeon2D
{
    public class Bat
    {
        public Vector2 Pos;
        public Rectangle Rect;
        public Texture2D Texture;


        public Bat(Vector2 pos)
        {
            Pos = pos;
        }

        public void LoadContent(ContentManager content)
        {
            Texture = content.Load<Texture2D>("Sprites/Bat");
            Rect = new Rectangle((int)Pos.X, (int)Pos.Y, 64, 64);
        }

        public void Update(GameTime gameTime)
        {

        }
    }
}
