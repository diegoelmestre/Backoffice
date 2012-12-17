using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.Model
{
    class Client
    {
        private int id;
        private string name;
        private string address;

        /************************************************************************/
        /* Constructors                                                        */
        /************************************************************************/

        public Client()
        {
            this.id = 0;
            this.name = "";
            this.address = "";
        }

        public Client(int _id, String _name, String _address)
        {
            this.id = _id;
            this.name = _name;
            this.address = _address;
        }

        /************************************************************************/
        /* Modifiers                                                            */
        /************************************************************************/
        public int getId()
        {
            return this.id;
        }

        public void setId(int _id)
        {
            this.id = _id;
        }
    }
}
