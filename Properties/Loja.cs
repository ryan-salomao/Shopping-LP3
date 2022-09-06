class Loja {
    public int Numero { get; }
    public string Piso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Categoria { get; set; }
    public string Email { get; set; }

    public Loja(int numero, string piso, string nome, string descricao, string categoria, string email)
    {   
        Numero = numero;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        Categoria = categoria;
        Email = email;
    }
}