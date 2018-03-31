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
    public enum states { WalkingLeft = 32, WalkingRight = 64, WalkingForward = 96, WalkingBackward = 0 };

    public class Animations
    {
        private Rectangle SourceRect;
        private Rectangle DestionRectangle;
        private Texture2D Texture;
        private Vector2 FrameSize;

        private int tempX;

        private int FrameTime;

        public Boolean idle = true;

        public Animations(Texture2D texture, Rectangle sourceRect, Vector2 frameSize)
        {
            Texture = texture;
            SourceRect = sourceRect;
            FrameSize = frameSize;

            DestionRectangle = new Rectangle(0, 0, (int)FrameSize.X, (int)FrameSize.Y);
            tempX = SourceRect.X;

        }

        public void ChangeState(states state)
        {
            DestionRectangle.Y = (int)state;
        }

        public void Animate(SpriteBatch spriteBatch)
        {
            int total = (int)SourceRect.Width * (int)SourceRect.Height;
            int frames = ((int)FrameSize.X * (int)FrameSize.Y) / total;

            if (!idle)
            {
                if (FrameTime == 15)
                {
                    FrameTime = 0;
                    if (DestionRectangle.X + (int)FrameSize.X == SourceRect.Width)
                        DestionRectangle.X = 0;
                    else
                        DestionRectangle.X += (int)FrameSize.X;
                }
                else
                    FrameTime++;
            }
            else
                DestionRectangle.X = 32;

            if (Keyboard.GetState().GetPressedKeys().Length > 0)
            {
                switch (Keyboard.GetState().GetPressedKeys()[0])
                {
                    case Keys.W:
                        {
                            ChangeState(states.WalkingForward);
                            SourceRect.Y -= 2;
                            break;
                        }
                    case Keys.A:
                        {
                            ChangeState(states.WalkingLeft);
                            SourceRect.X -= 2;
                            break;
                        }
                    case Keys.S:
                        {
                            ChangeState(states.WalkingBackward);
                            SourceRect.Y += 2;
                            break;
                        }
                    case Keys.D:
                        {
                            ChangeState(states.WalkingRight);
                            SourceRect.X += 2;
                            break;
                        }
                }
                idle = false;
            }
            else
            {
                idle = true;
            }

            spriteBatch.Draw(Texture, SourceRect, DestionRectangle, Color.White);
        }
    }
}
