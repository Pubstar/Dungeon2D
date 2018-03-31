using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon2D
{
    class Player
    {
        Animations animations;

        Texture2D PlayerText;
        Rectangle PlayerRect;
        Vector2 FrameSize;

        Vector2 PlayerPos = new Vector2();

        public Player(float playerPosX, float playerPosY)
        {
            PlayerPos.X = playerPosX;
            PlayerPos.Y = playerPosY;
        }

        public void Update(GameTime gameTime)
        {

            PlayerRect = new Rectangle((int)PlayerPos.X, (int)PlayerPos.Y, PlayerText.Width, PlayerText.Height);
        }

        public void LoadContent(ContentManager content)
        {
            PlayerText = content.Load<Texture2D>("Sprites/player");

            FrameSize = new Vector2(32, 32);
            animations = new Animations(PlayerText, new Rectangle((int)PlayerPos.X, (int)PlayerPos.Y, PlayerText.Width, PlayerText.Height), FrameSize);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            animations.Animate(spriteBatch);
        }
    }
}
