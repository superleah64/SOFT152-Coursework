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
        // alternative constructor for new districts
        public District(string inDistName)
        {
            distName = inDistName;
            distNumNbh = 0;
            distAllNbh = null;
        }

        public District()
        {
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
        public void setNewNbh(string nbhname)
        {
            Neighbourhood TempNBH = new Neighbourhood("laira");
            int newnbhSize = Arrays.NbhData.Length;
            Array.Resize(ref Arrays.NbhData, newnbhSize + 1);
            Arrays.NbhData[newnbhSize] = TempNBH;
            distNumNbh = distNumNbh + 1;
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