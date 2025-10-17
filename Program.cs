using desafio_poo.Classes;

Imobiliaria imobiliaria = new Imobiliaria("Imóveis Carrilho");

string input = "";

Random random = new Random();

while (input != "7")
{
    if (input == "1")
    {
        Console.WriteLine("O que você deseja cadastrar? \n1. Casa \n2. Apartamento");
        string escolha = Console.ReadLine();
        bool finalizado = false;

        while (!finalizado)
        {
            if (escolha == "1")
            {

                Console.WriteLine("Digite o endereço da casa: ");
                string endereco = Console.ReadLine();

                Console.WriteLine("Digite o número da casa");
                string numero = Console.ReadLine();

                Console.WriteLine("Digite o nome do proprietário: ");
                string nomeProprietario = Console.ReadLine();

                Console.WriteLine("Digite o telefone do proprietário: ");
                string telefoneProprietario = Console.ReadLine();

                Console.WriteLine("Digite o CPF do proprietário: ");
                string cpfProprietario = Console.ReadLine();

                Proprietario proprietario = new Proprietario(nomeProprietario, telefoneProprietario, cpfProprietario);

                Casa casa = new Casa(random.Next(1000, 9999), endereco, int.Parse(numero), proprietario);

                imobiliaria.ListaImoveis.Add(casa);

                Console.WriteLine("Casa cadastrada com sucesso");
                finalizado = true;
            }
            else if (escolha == "2")
            {
                Console.WriteLine("Digite o endereço do prédio: ");
                string endereco = Console.ReadLine();

                Console.WriteLine("Digite o número do prédio");
                string numero = Console.ReadLine();

                Console.WriteLine("Digite o número do apartamento");
                string numeroApartamento = Console.ReadLine();

                Console.WriteLine("Digite o nome do proprietário: ");
                string nomeProprietario = Console.ReadLine();

                Console.WriteLine("Digite o telefone do proprietário: ");
                string telefoneProprietario = Console.ReadLine();

                Console.WriteLine("Digite o CPF do proprietário: ");
                string cpfProprietario = Console.ReadLine();

                Proprietario proprietario = new Proprietario(nomeProprietario, telefoneProprietario, cpfProprietario);

                Apartamento apartamento = new Apartamento(random.Next(1000, 9999), endereco, int.Parse(numero), proprietario, int.Parse(numeroApartamento));

                imobiliaria.ListaImoveis.Add(apartamento);

                Console.WriteLine("Apartamento cadastrado com sucesso");
                finalizado = true;
            }
            else Console.WriteLine("Escolha uma dessas opções: \n1. Casa \n2. Apartamento");
        }

    }
    else if (input == "2")
    {
        if (imobiliaria.ListaImoveis.Count() == 0)
        {
            Console.WriteLine("Não existem imóveis cadastrados");
        }
        else
        {
            imobiliaria.ListaImoveis.ForEach(imovel =>
            {
                Console.WriteLine($"Imóvel endereço: {imovel.puxarEndereco}, ");
            });
        }
    }

    Console.WriteLine("Selecione uma das nossas opções: \n1. Cadastrar Imóvel (casa/apartamento). \n2. Listar imóveis cadastrados. \n3. Alugar imóvel. \n4. Disponibilizar imóvel. \n5. Calcular valor do aluguel por período. \n6. Excluir Imovel. \n7. Sair.");


    input = Console.ReadLine();
}