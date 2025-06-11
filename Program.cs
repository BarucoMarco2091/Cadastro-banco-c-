using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite 1 para pessoa jurídica ou 2 para pessoa física");
        string escolha = Console.ReadLine();
        if (escolha == "1")
        {
            Console.WriteLine("Digite o nome da pessoa jurídica: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o CNPJ da pessoa jurídica: ");
            string cnpj = Console.ReadLine();
            Console.WriteLine("Digite o rendimento da pessoa jurídica: ");
            float rendimento = float.Parse(Console.ReadLine());
            PessoaJuridica pj = new PessoaJuridica
            {
                Nome = nome,
                Cnpj = cnpj,
                Rendimento = rendimento
            };
            pj.Inserir(pj);
            Console.WriteLine($"Pessoa Jurídica {pj.Nome} com CNPJ {pj.Cnpj} e rendimento {pj.Rendimento} inserida com sucesso.");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Digite o nome da pessoa física: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF da pessoa física: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite o rendimento da pessoa física: ");
            float rendimento = float.Parse(Console.ReadLine());
            PessoaFisica pf = new PessoaFisica
            {
                Nome = nome,
                Cpf = cpf,
                Rendimento = rendimento
            };
            pf.Inserir(pf);
            Console.WriteLine($"Pessoa Física {pf.Nome} com CPF {pf.Cpf} e rendimento {pf.Rendimento} inserida com sucesso.");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}