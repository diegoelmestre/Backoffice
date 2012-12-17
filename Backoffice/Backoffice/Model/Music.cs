using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.Model
{
    class Music
    {
        private String name;
        private String artist;
        private double price;
        private int durationInSeconds;


        /************************************************************************/
        /* Constructors                                                        */
        /************************************************************************/

        public Music()
        {
            this.name = "";
            this.artist = "";
            this.price = 0;
            this.durationInSeconds = 0;
        }

        public Music(String _name, String _artist, double _price, int _durationInSeconds)
        {
            this.name = _name;
            this.artist = _artist;
            this.price = _price;
            this.durationInSeconds = _durationInSeconds;
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

        public String getArtist()
        {
            return this.artist;
        }

        public void setArtist(String _artist)
        {
            this.artist = _artist;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setName(double _price)
        {
            this.price = _price;
        }

        public int getDuration()
        {

            return this.durationInSeconds;
        }

        public void setDuration(int _duration)
        {
            this.durationInSeconds = _duration;
        }
    }
}
