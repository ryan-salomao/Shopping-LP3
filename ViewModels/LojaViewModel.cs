namespace Av3Shopping.ViewModels;

public class LojaViewModel {
    public int Numero { get; }
    public int Piso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Categoria { get; set; }
    public string Email { get; set; }

    public LojaViewModel(int numero, int piso, string nome, string descricao, string categoria, string email)
    {   
        Numero = numero;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        Categoria = categoria;
        Email = email;
    }
}