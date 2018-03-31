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
        public Rectangle SourceRect;
        public Rectangle SpriteRectangle;
        private Rectangle DestionRectangle;
        private Texture2D Texture;
        private Vector2 FrameSize;

        private int tempX;

        private int FrameTime;

        public Boolean idle = true;

        public Animations(Texture2D texture, Rectangle sourceRect, Rectangle spriteRect, Vector2 frameSize)
        {
            Texture = texture;
            SourceRect = sourceRect;
            SpriteRectangle = spriteRect;
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
            int total = (int)SpriteRectangle.Width * (int)SpriteRectangle.Height;
            int frames = (int)SpriteRectangle.Width / (int)FrameSize.X;

            if (!idle)
            {
                if (FrameTime == Settings.FrameTime)
                {
                    FrameTime = 0;
                    if (DestionRectangle.X + (int)FrameSize.X == SpriteRectangle.Width)
                        DestionRectangle.X = 0;
                    else
                        DestionRectangle.X += (int)FrameSize.X;
                }
                else
                    FrameTime++;
            }
            else
                DestionRectangle.X = 32;

            spriteBatch.Draw(Texture, SourceRect, DestionRectangle, Color.White);
        }
    }
}
