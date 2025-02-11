namespace DemoLinq;

public class Etudiant
{
    public int id { get; set; }
    public string nom { get; set; } =string.Empty;
    public string prenom { get; set; } = string.Empty;
    //public DateOnly DateNaissance { get; set; }
    public int note { get; set; }
    public string? ville { get; set; }
    public int _idGroup { get; set; }
}
