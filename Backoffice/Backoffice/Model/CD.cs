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
        private double price;

        /************************************************************************/
        /* Constructors                                                        */
        /************************************************************************/

        public CD()
        {
            this.name = "";
            this.musicList = new List<Music>();
            this.price = 0;
        }

        public CD(String _name, List<Music> _musicList)
        {
            this.name = _name;
            this.musicList = _musicList;
            this.price = 0;
            foreach (Music _music in this.musicList)
            {
                this.price = this.price + _music.getPrice();
            }
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

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(double _price)
        {
            this.price = _price;

        }





    }
}
