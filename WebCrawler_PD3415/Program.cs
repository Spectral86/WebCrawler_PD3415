using System.Text.RegularExpressions;
using WebCrawler_PD3415.Models;

string websiteUrl = "https://uke.gov.pl";

HttpClient httpClient = new HttpClient();
HttpResponseMessage response = await httpClient.GetAsync(websiteUrl);

string content = await response.Content.ReadAsStringAsync();

//numery telefonów
MatchCollection result = Regex.Matches(content, "[[+][0-9]+ [0-9]+ [0-9]+ [0-9]+ [0-9]+");
foreach (var r in result)
{
    Console.WriteLine(r);

}
