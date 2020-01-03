using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbData
{
    class Neighbourhood
    {
        string nbhName;
        int nbhNumProp;
        Property[] nbhAllProp;

        //constructor
        // Neighbourhood Order = nbhName nbhNumProp 
        public Neighbourhood(string inNbhName, int inNbhNumProp, Property[] inNbhProp)
        {
            nbhName = inNbhName;
            nbhNumProp = inNbhNumProp;
            nbhAllProp = inNbhProp;//pass all properties in
        }

        // constructor for new neighbourhood 
        public Neighbourhood(string inNbhName)
        {
            nbhName = inNbhName;
            nbhNumProp = 0;
            nbhAllProp = null;
        }

        //setters
        public void setNbhName(string inNbhName)
        {
            nbhName = inNbhName;
        }
        public void setNbhNumProp(int inNbhNumProp)
        {
            nbhNumProp = inNbhNumProp;
        }

        //getters
        public string getNbhName()
        {
            return nbhName;
        }
        public int getNbhNumProp()
        {
            return nbhNumProp;
        }
        public Property[] getNbhAllProp()
        {
            return nbhAllProp;
        }

    }
}