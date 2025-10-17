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
                string tipo = imovel is Casa ? "Casa" : imovel is Apartamento ? "Apartamento" : "Imóvel";
                int id = imovel.puxarId();
                string endereco = imovel.puxarEndereco();
                int numero = imovel.puxarNumero();
                string status = imovel.ObterStatusAluguel();
                string contato = imovel.puxarProprietario().contatoProprietario();
                string extra = "";
                if (imovel is Apartamento apt)
                {
                    extra = $" (Apto nº {(apt.GetType().GetProperty("NumeroApartamento", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.GetValue(apt) ?? "N/A")})";
                }

                Console.WriteLine($"ID: {id} | Tipo: {tipo}{extra} | Endereço: {endereco}, {numero} | Status: {status}");
                Console.WriteLine($"  {contato}");
            });
        }
    }
    else if (input == "3")
    {
        Console.WriteLine("Digite o ID do imóvel que deseja alugar:");
        if (int.TryParse(Console.ReadLine(), out int idParaAlugar))
        {
            var imovel = imobiliaria.ListaImoveis.FirstOrDefault(i => i.puxarId() == idParaAlugar);
            if (imovel == null)
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
            else
            {
                imovel.Alugar();
                Console.WriteLine(imovel.ObterStatusAluguel());
            }
        }
        else Console.WriteLine("ID inválido.");
    }
    else if (input == "4")
    {
        Console.WriteLine("Digite o ID do imóvel que deseja disponibilizar:");
        if (int.TryParse(Console.ReadLine(), out int idParaDisp))
        {
            var imovel = imobiliaria.ListaImoveis.FirstOrDefault(i => i.puxarId() == idParaDisp);
            if (imovel == null)
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
            else
            {
                imovel.Disponibilizar();
                Console.WriteLine(imovel.ObterStatusAluguel());
            }
        }
        else Console.WriteLine("ID inválido.");
    }
    else if (input == "5")
    {
        Console.WriteLine("Digite o ID do imóvel para calcular o aluguel:");
        if (int.TryParse(Console.ReadLine(), out int idCalc))
        {
            var imovel = imobiliaria.ListaImoveis.FirstOrDefault(i => i.puxarId() == idCalc);
            if (imovel == null)
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
            else
            {
                Console.WriteLine("Digite a quantidade de dias:");
                if (int.TryParse(Console.ReadLine(), out int dias))
                {
                    decimal valor = imovel.CalcularAluguel(dias);
                    Console.WriteLine($"Valor do aluguel para {dias} dia(s): R$ {valor}");
                }
                else Console.WriteLine("Número de dias inválido.");
            }
        }
        else Console.WriteLine("ID inválido.");
    }
    else if (input == "6")
    {
        Console.WriteLine("Digite o ID do imóvel que deseja excluir:");
        if (int.TryParse(Console.ReadLine(), out int idExcluir))
        {
            var imovel = imobiliaria.ListaImoveis.FirstOrDefault(i => i.puxarId() == idExcluir);
            if (imovel == null)
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
            else
            {
                imobiliaria.ListaImoveis.Remove(imovel);
                Console.WriteLine("Imóvel excluído com sucesso.");
            }
        }
        else Console.WriteLine("ID inválido.");
    }

    Console.WriteLine("Selecione uma das nossas opções: \n1. Cadastrar Imóvel (casa/apartamento). \n2. Listar imóveis cadastrados. \n3. Alugar imóvel. \n4. Disponibilizar imóvel. \n5. Calcular valor do aluguel por período. \n6. Excluir Imovel. \n7. Sair.");


    input = Console.ReadLine();
}
