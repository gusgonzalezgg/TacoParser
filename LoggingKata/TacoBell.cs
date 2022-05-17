using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    internal class TacoBell : ITrackable
    {
        public TacoBell(double latitude, double longitude, string name)
        {
            Name = name;
            var point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;
            Location = point;
        }

        public string Name { get; set; }
        public Point Location { get; set; }
    }
}
