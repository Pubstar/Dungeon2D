using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon2D
{
    public class AI
    {
        List<Bat> Bats = new List<Bat>();
        List<Animations> Animations = new List<Animations>();

        Animations animations;
        Bat bat;

        private int Timer;

        public AI()
        {

        }

        public void LoadContent(ContentManager Content)
        {
            /*//////////
             * Spawn AI 
             *//////////

            //Bat
            bat = new Bat(new Vector2(200,100));
            Bats.Add(bat);
            bat = new Bat(new Vector2(500, 300));
            Bats.Add(bat);

            for (int i = 0; i < Bats.Count; i++)
            {
                Bats[i].LoadContent(Content);
                animations = new Animations(Bats[i].Texture, Bats[i].Rect, new Rectangle((int)Bats[i].Pos.X, (int)Bats[i].Pos.Y, 96, 128));
                Animations.Add(animations);
            }
        }

        public void Update(GameTime gameTime)
        {
            for (int i = 0; i < Bats.Count; i++)
            {
                Bats[i].Rect = new Rectangle((int)Bats[i].Pos.X, (int)Bats[i].Pos.Y, Bats[i].Texture.Width, Bats[i].Texture.Height);
                Bats[i].Pos = new Vector2(animations.SourceRect.X, animations.SourceRect.Y);

                // Bat Movement
                if (Timer < 200)
                {
                    Animations[i].ChangeState(states.WalkingRight);
                    Animations[i].SourceRect.X += 1;
                }
                else if (Timer < 400)
                {
                    Animations[i].ChangeState(states.WalkingBackward);
                    Animations[i].SourceRect.Y += 1;
                }
                else if (Timer < 600)
                {
                    Animations[i].ChangeState(states.WalkingLeft);
                    Animations[i].SourceRect.X -= 1;
                }
                else if (Timer < 800)
                {
                    Animations[i].ChangeState(states.WalkingForward);
                    Animations[i].SourceRect.Y -= 1;
                }
                else if(Timer < 1000)
                    Timer = 0;

                Bats[i].Update(gameTime);
                Timer++;
            }

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < Animations.Count; i++)
            {
                Animations[i].Animate(spriteBatch);
            }
        }
    }
}
