using System;
using System.Drawing;

namespace WpfApp1.Models
{
    
    internal class PlaceInfo
    {
        public string Name { get; set; }
        
        public Point Location { get; set; }
        
        public IEquatable<ConfirmedCount> Counts { get; set; }

    }

    internal class ConfirmedCount
    {
        public DateTime Date { get; set; }
        
        public int Count { get; set; }
    }

    internal class CountryInfo : PlaceInfo
    {
        public IEquatable<ProvinceInfo> ProvinceCounts { get; set; }
    }
    internal class ProvinceInfo : PlaceInfo
    {
        
    }


    public struct DataPoints
    {
        public double XValue { get; set; }
        public double YValue { get; set; }
        
    }
    
    
}
