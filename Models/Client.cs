namespace GoWeb.Models;
public class Client : Personne
{
    public string? NumeroClient { get; set; }
    public List<Email>? Emails { get; set; }
}