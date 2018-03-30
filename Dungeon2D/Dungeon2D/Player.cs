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
    class Player
    {
        Texture2D PlayerText;
        Rectangle PlayerRect;

        Vector2 PlayerPos = new Vector2();

        public Player(float playerPosX, float playerPosY)
        {
            PlayerPos.X = playerPosX;
            PlayerPos.Y = playerPosY;
        }

        public void LoadContent(ContentManager content)
        {
            PlayerText = content.Load<Texture2D>("Sprites/player");
        }

        public void Update(GameTime gameTime)
        {
            PlayerRect = new Rectangle((int)PlayerPos.X, (int)PlayerPos.Y, PlayerText.Width, PlayerText.Height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(PlayerText, PlayerRect, Color.White);
            spriteBatch.End();
        }
    }
}
