// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Globalization;
using System.Linq;using System.Security.Principal;

const string address = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_confirmed_global.csv";

 static async Task<string> GetDataStream()
{
    
    var _client = new HttpClient();
    var res =  await _client.GetAsync(address, HttpCompletionOption.ResponseHeadersRead);
    return await res.Content.ReadAsStringAsync();

}

static  IEnumerable<String> GetDataLines()
{ 
   var dataStream =  GetDataStream().Result;
    using var dataReader = new StreamReader(dataStream);

    while (!dataReader.EndOfStream)
    {
        var lines =  dataReader.ReadLine();
        if (String.IsNullOrWhiteSpace(lines)) continue;
        
        yield return lines.Replace("Korea", "Korea -");
    }
}

static DateTime[] GetDates() => GetDataLines().First().Split(',').Skip(5)
    .Select(s => DateTime.Parse(s, CultureInfo.InvariantCulture)).ToArray();

static IEnumerable<(string Country, string Provice, int[] Counts)> GetData()
{
    var lines = GetDataLines().Skip(1).Select(x => x.Split(','));

    foreach (var l in lines)
    {
        var province = l[0].Trim();
        var country = l[1].Trim(' ','"');
        var counts = l.Skip(4).Select(int.Parse).ToArray();
        yield return (country, province, counts);
    }
    
    
}

var russia_data = GetData().First(x => x.Country.Equals("Russia", StringComparison.OrdinalIgnoreCase));
Console.WriteLine(string.Join("\r\n", GetDates().Zip(russia_data.Counts,(date, count) => $"{date:yy-MM-dd} - {count}")));
Console.ReadLine();

// var dates = GetDates();
// Console.WriteLine(string.Join("\r\n", dates));
