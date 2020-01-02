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
        private int numPropH;
        private string lati;
        private string longi;
        private string roomType;
        private int price;
        private int minNights;
        private int days;


        public Property(string thePropID, string thePropName,
            string theHostID, string theHostName, int theNumPropH, string theLati,
            string theLongi, string theRoomType, int thePrice, int theMinNights, int theDays)
        {
            propID = thePropID;
            propName = thePropName;
            hostID = theHostID;
            hostName = theHostName;
            numPropH = theNumPropH;
            lati = theLati;
            longi = theLongi;
            roomType = theRoomType;
            price = thePrice;
            minNights = theMinNights;
            days = theDays;

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
        public int getNumPropH()
        {
            return numPropH;
        }
        public string getLati()
        {
            return lati;
        }
        public string getLongi()
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

        public void setNumPropH(string inNumPropH)
        {
            try
            {
                numPropH = Convert.ToInt32(inNumPropH);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("Error:" +
                        e.Message + " Please input a valid number.");
            }
        }
        public void setLati(string inLati)
        {
            lati = inLati;
        }

        public void setLongi(string inLongi)
        {
            longi = inLongi;
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