using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace thrid_project
{
    public class Atributes
    {
        public int Country_ID;
        public string Country_Name;
        public int TownFrom;
        public int TownTo;
        public bool License;
        public int Place1;
        public int Place2;
        public string TownName;
        public int TicketType;
        public int TicketPrice;
        public int TypeOfHouse;
        public int HousePrice;
        public string HouseName;
        public int Distance;
        public string TiketTransportTypeLocation;
        public int TypeOfTransport;
        public string CertainTransportName;
        public int CertainTransportPrice;
        public List<int> EatingPlaceType = new List<int>();
        public List<string> EatingPlaceName = new List<string>();
        public List<int> EatingPlacePrice = new List<int>();
        public List<string> EatingPlaceInfo = new List<string>();
        public double LatitudeTownTo;
        public double LongitudeTownTo;
        public double LatitudeTownFrom;
        public double LongitudeTownFrom;
        public double LatitudeTownPlace1;
        public double LongitudeTownPlace1;
    }
}
