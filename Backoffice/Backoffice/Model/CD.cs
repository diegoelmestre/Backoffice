using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.Model
{
    class CD
    {
        private String name;
        private List<Music> musicList;

        /************************************************************************/
        /* Constructors                                                        */
        /************************************************************************/

        public CD()
        {
            this.name = "";
            this.musicList = new List<Music>();
        }

        public CD(String _name, List<Music> _music)
        {
            this.name = _name;
            this.musicList = _music;
        }

        /************************************************************************/
        /* Modifiers                                                            */
        /************************************************************************/

        public String getName()
        {
            return this.name;
        }

        public void setName(String _name)
        {
            this.name = _name;
        }

        public void addMusic(Music _music)
        {
            this.musicList.Add(_music);
        }

        public void removeMusic(Music _music)
        {
            this.musicList.Remove(_music);
        }





    }
}
