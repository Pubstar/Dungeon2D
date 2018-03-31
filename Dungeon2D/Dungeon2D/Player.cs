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

        public Vector2 PlayerPos = new Vector2();

        public Player(float playerPosX, float playerPosY)
        {
            PlayerPos.X = playerPosX;
            PlayerPos.Y = playerPosY;
            PlayerRect = new Rectangle((int)PlayerPos.X, (int)PlayerPos.Y, 64, 64);
        }

        public void Update(GameTime gameTime)
        {

            PlayerRect = new Rectangle((int)PlayerPos.X, (int)PlayerPos.Y, PlayerText.Width, PlayerText.Height);
            PlayerPos = new Vector2(animations.SourceRect.X, animations.SourceRect.Y);

            if (Keyboard.GetState().GetPressedKeys().Length > 0)
            {
                switch (Keyboard.GetState().GetPressedKeys()[0])
                {
                    case Keys.W:
                        {
                            animations.ChangeState(states.WalkingForward);
                            animations.SourceRect.Y -= (int)Settings.PlayerMoveSpeed;
                            break;
                        }
                    case Keys.A:
                        {
                            animations.ChangeState(states.WalkingLeft);
                            animations.SourceRect.X -= (int)Settings.PlayerMoveSpeed;
                            break;
                        }
                    case Keys.S:
                        {
                            animations.ChangeState(states.WalkingBackward);
                            animations.SourceRect.Y += (int)Settings.PlayerMoveSpeed;
                            break;
                        }
                    case Keys.D:
                        {
                            animations.ChangeState(states.WalkingRight);
                            animations.SourceRect.X += (int)Settings.PlayerMoveSpeed;
                            break;
                        }
                }
                animations.idle = false;
            }
            else
            {
                animations.idle = true;
            }

        }

        public void LoadContent(ContentManager content)
        {
            PlayerText = content.Load<Texture2D>("Sprites/player");

            FrameSize = new Vector2(32, 32);
            animations = new Animations(PlayerText, PlayerRect, new Rectangle((int)PlayerPos.X, (int)PlayerPos.Y, 96, 128), FrameSize);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            animations.Animate(spriteBatch);
        }
    }
}
