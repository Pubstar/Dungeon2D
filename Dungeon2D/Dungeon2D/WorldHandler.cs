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
    class WorldHandler
    {
        public World World;

        public WorldHandler()
            : this(new World(1280, 720))
        {

        }
        
        public WorldHandler(World world)
        {
            World = world;
        }

        public void LoadTiles(ContentManager content)
        {
            World.LoadTiles(content);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            World.Draw(spriteBatch);
        }
    }
}
