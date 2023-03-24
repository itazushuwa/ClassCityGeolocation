using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var city = new City();
            city.Name = "Екатеринбург";
            city.Location = new GeoLocation();
            city.Location.Latitude = 56.50;
            city.Location.Longitude = 60.35;
            Console.WriteLine("Ахахах {0} находится здесь - ({1}, {2})", city.Name,
            city.Location.Longitude.ToString(CultureInfo.InvariantCulture),
            city.Location.Latitude.ToString(CultureInfo.InvariantCulture));

        }
    }
}
