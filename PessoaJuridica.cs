public class PessoaJuridica : Pessoa
{
    public string Cnpj { get; set; }
    public void Inserir(PessoaJuridica pj)
    {
        Console.WriteLine($"Pessoa Jurídica {pj.Nome} com CNPJ {pj.Cnpj} inserida com sucesso.");
    }
}