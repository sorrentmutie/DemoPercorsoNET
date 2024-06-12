namespace Cotrap.Core.Reqres;
public class Reqres
{
    public int page { get; set; }
    public int per_page { get; set; }
    public int total { get; set; }
    public int total_pages { get; set; }
    public Person[] data { get; set; }
    public Support support { get; set; }
}

public class Support
{
    public string url { get; set; }
    public string text { get; set; }
}


public class Person
{
    public int id { get; set; }
    public string email { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string avatar { get; set; }
}
