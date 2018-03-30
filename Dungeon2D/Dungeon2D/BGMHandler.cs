using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon2D
{
    class BGMHandler : Game1
    {
        /// <summary>
        /// This class loads up that lit background music fam
        /// The way this class is designed is to allow you to call the class once. After which you can
        /// Say you call this class as "BGM", from that moment on in the mainmodule you can do MediaPlayer.Play(BGM.SongName)
        /// </summary>

        public Song Dungeon2;

        public void LoadSong()
        {
 //           Dungeon2 = Content.Load<Song>("BGM/Dungeon2");
        }
    }
}
