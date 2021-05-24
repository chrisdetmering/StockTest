using System;
namespace StockTest.Models
{
    public class WeatherForecast
    {
        public virtual int Wid { get; set; }
        public virtual int Tempurature { get; set; }
        public virtual DateTime Created_At { get; set; }

    }
}
