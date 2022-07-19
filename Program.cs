using Newtonsoft.Json;

Console.WriteLine("enter ticker");
string a= Console.ReadLine();

string link1 ="https://data.nasdaq.com/api/v3/datasets/WIKI/";

string link2 = ".json?api_key=bozHUC3yis9Ayq76k1hc";
 string link = link1 + a + link2;
HttpClient client=new();
HttpResponseMessage response= await client.GetAsync(link);
string json= await response.Content.ReadAsStringAsync();
dynamic tmp = JsonConvert.DeserializeObject(json);
Console.WriteLine(tmp.dataset.data[0][2]);


 