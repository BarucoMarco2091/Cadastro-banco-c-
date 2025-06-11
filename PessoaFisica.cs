public class PessoaFisica : Pessoa
{
    public string Cpf { get; set; }
    public void Inserir(PessoaFisica pf)
    {
        Console.WriteLine($"Pessoa Física {pf.Nome} com CPF {pf.Cpf} inserida com sucesso.");
    }
}
