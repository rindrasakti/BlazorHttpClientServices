namespace MyBlazorApp.Models;

public class AuthResponse
{
    public int status { get; set; }
    public string pesan { get; set; } = "";
    public string token { get; set; } = "";
}