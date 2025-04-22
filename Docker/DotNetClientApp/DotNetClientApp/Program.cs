// make an web API call to the backend
HttpClient client = new();
string url = "http://localhost:3000/api";

string json = client.GetStringAsync(url).Result;
Console.WriteLine(json);
