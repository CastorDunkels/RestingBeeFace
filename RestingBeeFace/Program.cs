using RestSharp;
using System.Net;
using System.Text.Json;

RestClient client = new("https://swapi.py4e.com/api/");

RestRequest request = new("people/63");

RestResponse response = client.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{

    Character c = JsonSerializer.Deserialize<Character>(response.Content);
    Console.WriteLine(c.name);
    Console.WriteLine(c.birthYear);
    Console.WriteLine(c.gender);
    Console.WriteLine(c.height);
    Console.WriteLine(c.mass);
    Console.WriteLine(c.hairColor);
    Console.WriteLine(c.eyeColor);

}
else
{
    Console.WriteLine("Something went wrong :(");
}


Console.ReadLine();