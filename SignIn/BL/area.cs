using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn.BL
{
    class area
    {
        private float Latitude;
        private float Longitude;
        public area(float latitude1, float longitude1)
        {
            Latitude1 = latitude1;
            Longitude1 = longitude1;
        }
        public float Latitude1 { get => Latitude; set => Latitude = value; }
        public float Longitude1 { get => Longitude; set => Longitude = value; }
    }
}
