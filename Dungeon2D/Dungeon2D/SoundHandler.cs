using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

namespace Dungeon2D
{
    class SoundHandler : Game1
    {
        /// <summary>
        /// This class loads the sound effects to be used in game.
        /// </summary>

        public SoundEffect explosion1;

        public void LoadSoundFX()
        {
            //Example code
            //explosion1 = Content.Load<SoundEffect>("SoundFX/Explosion1");
        }

    }

}