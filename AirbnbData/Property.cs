using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbData
{
    class Property
    {
        private string propID;
        private string propName;
        private string hostID;
        private string hostName;
        private int numProp;
        private int lati;
        private int longi;
        private string roomType;
        private int price;
        private int minNights;
        private int days;


        public Property(string thePropID, string thePropName,
            string theHostID, string theHostName, string theNumProp, string theLati,
            string theLongi, string theRoomType, string thePrice, string theMinNights, string theDays)
        {
            propID = thePropID;
            propName = thePropName;
            hostID = theHostID;
            hostName = theHostName;
            setNumProp(theNumProp);
            setLati(theLati);
            setLongi(theLongi);
            roomType = theRoomType;
            setPrice(thePrice);
            setMinNights(theMinNights);
            setDays(theDays);
        }//end constructor

        //all getter methods
        public string getPropID()
        {
            return propID;
        }
        public string getPropName()
        {
            return propName;
        }
        public string getHostID()
        {
            return hostID;
        }
        public string getHostName()
        {
            return hostName;
        }
        public int getNumProp()
        {
            return numProp;
        }
        public int getLati()
        {
            return lati;
        }
        public int getLongi()
        {
            return longi;
        }
        public string getRoomType()
        {
            return roomType;
        }
        public int getPrice()
        {
            return price;
        }
        public int getMinNights()
        {
            return minNights;
        }
        public int getDays()
        {
            return days;
        }


        //all setter methods
        public void setPropID(string inPropID)
        {
            propID = inPropID;
        }
        public void setPropName(string inPropName)
        {
            propName = inPropName;
        }
        public void setHostID(string inHostID)
        {
            hostID = inHostID;
        }
        public void setHostName(string inHostName)
        {
            hostName = inHostName;
        }

        public void setNumProp(string inNumProp)
        {
            try
            {
                numProp = Convert.ToInt32(inNumProp);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error:" +
                        e.Message + " Please input a valid number.");
            }
        }
        public void setLati(string inLati)
        {
            try
            {
                lati = Convert.ToInt32(inLati);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error:" +
                        e.Message + " Please input a valid latitude.");
            }
        }

        public void setLongi(string inLongi)
        {
            try
            {
                longi = Convert.ToInt32(inLongi);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error:" +
                        e.Message + " Please input a valid longitude.");
            }
        }

        public void setRoomType(string inRoomType)
        {
            roomType = inRoomType;
        }
        public void setPrice(string inPrice)
        {
            try
            {
                price = Convert.ToInt32(inPrice);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error:" + e.Message
                                    + " Please input a valid price.");
            }
        }
        public void setMinNights(string inMinNights)
        {
            try
            {
                minNights = Convert.ToInt32(inMinNights);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error:" + e.Message
                                    + " Please input a valid number of nights.");
            }
        }

        public void setDays(string inDays)
        {
            try
            {
                days = Convert.ToInt32(inDays);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error:" + e.Message
                                    + " Please input a valid number of days.");
            }
        }

    }
}
