using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbData
{
    class District
    {
        string distName;
        int distNumNbh;
        Neighbourhood[] distAllNbh;

        //constructor
        // DISTRICT ORDER = distName distNumNbh
        public District(string inDistName, int inDistNumNbh, Neighbourhood[] inDistNbh)
        {
            distName = inDistName;
            distNumNbh = inDistNumNbh;
            distAllNbh = inDistNbh; //pass all neighbourhoods in
        }


        //setters
        public void setDistName(string inDistName)
        {
            distName = inDistName;
        }
        public void setDistNumNbh(int inDistNumNbh)
        {
            distNumNbh = inDistNumNbh;
        }

        //getters
        public string getDistName()
        {
            return distName;
        }
        public int getDistNumNbh()
        {
            return distNumNbh;
        }

        public Neighbourhood[] getDistAllNbh()
        {
            return distAllNbh;
        }
    }
}

