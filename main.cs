using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime data = new DateTime();
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Criar uma data");
            Console.WriteLine("2. Consultar");
            Console.WriteLine("3. Alterar");
            Console.WriteLine("4. Exibir a data completa");
            Console.WriteLine("5. Cálculos de Datas");
            Console.WriteLine("6. Terminar o programa");

            int opcao;
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 6.");
                continue;
            }

            try
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a data no formato d/m/a ou m/d/a:");
                        string entrada = Console.ReadLine();
                        data = new AmericanDateTime(entrada);
                        Console.WriteLine("Data criada com sucesso!");
                        break;
                    case 2:
                        if (data == null)
                        {
                            Console.WriteLine("Nenhuma data criada ainda.");
                            continue;
                        }
                        Console.WriteLine("Consultar:");
                        Console.WriteLine("1. Dia");
                        Console.WriteLine("2. Mês");
                        Console.WriteLine("3. Ano");
                        Console.WriteLine("4. Hora");
                        Console.WriteLine("5. Minuto");
                        Console.WriteLine("6. Segundo");
                        int opcaoConsulta;
                        if (!int.TryParse(Console.ReadLine(), out opcaoConsulta) || opcaoConsulta < 1 || opcaoConsulta > 6)
                        {
                            Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 6.");
                            continue;
                        }
                        switch (opcaoConsulta)
                        {
                            case 1:
                                Console.WriteLine($"Dia: {data.getDia()}");
                                break;
                            case 2:
                                Console.WriteLine($"Mês: {data.getMes()}");
                                break;
                            case 3:
                                Console.WriteLine($"Ano: {data.getAno()}");
                                break;
                            case 4:
                                Console.WriteLine($"Hora: {data.getHora()}");
                                break;
                            case 5:
                                Console.WriteLine($"Minuto: {data.getMinuto()}");
                                break;
                            case 6:
                                Console.WriteLine($"Segundo: {data.getSegundo()}");
                                break;
                        }
                        break;
                    case 3:
                        if (data == null)
                        {
                            Console.WriteLine("Nenhuma data criada ainda.");
                            continue;
                        }
                        Console.WriteLine("Alterar:");
                        Console.WriteLine("1. Dia");
                        Console.WriteLine("2. Mês");
                        Console.WriteLine("3. Ano");
                        Console.WriteLine("4. Hora");
                        Console.WriteLine("5. Minuto");
                        Console.WriteLine("6. Segundo");
                        int opcaoAlterar;
                        if (!int.TryParse(Console.ReadLine(), out opcaoAlterar) || opcaoAlterar < 1 || opcaoAlterar > 6)
                        {
                            Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 6.");
                            continue;
                        }
                        switch (opcaoAlterar)
                        {
                            case 1:
                                Console.WriteLine("Novo dia:");
                                int novoDia;
                                if (!int.TryParse(Console.ReadLine(), out novoDia))
                                {
                                    Console.WriteLine("Dia inválido.");
                                    continue;
                                }
                                data.setDia(novoDia);
                                break;
                            case 2:
                                Console.WriteLine("Novo mês:");
                                int novoMes;
                                if (!int.TryParse(Console.ReadLine(), out novoMes))
                                {
                                    Console.WriteLine("Mês inválido.");
                                    continue;
                                }
                                data.setMes(novoMes);
                                break;
                            case 3:
                                Console.WriteLine("Novo ano:");
                                int novoAno;
                                if (!int.TryParse(Console.ReadLine(), out novoAno))
                                {
                                    Console.WriteLine("Ano inválido.");
                                    continue;
                                }
                                data.setAno(novoAno);
                                break;
                            case 4:
                                Console.WriteLine("Nova hora:");
                                int novaHora;
                                if (!int.TryParse(Console.ReadLine(), out novaHora))
                                {
                                    Console.WriteLine("Hora inválida.");
                                    continue;
                                }
                                data.setHora(novaHora);
                                break;
                            case 5:
                                Console.WriteLine("Novo minuto:");
                                int novoMinuto;
                                if (!int.TryParse(Console.ReadLine(), out novoMinuto))
                                {
                                    Console.WriteLine("Minuto inválido.");
                                    continue;
                                }
                                data.setMinuto(novoMinuto);
                                break;
                            case 6:
                                Console.WriteLine("Novo segundo:");
                                int novoSegundo;
                                if (!int.TryParse(Console.ReadLine(), out novoSegundo))
                                {
                                    Console.WriteLine("Segundo inválido.");
                                    continue;
                                }
                                data.setSegundo(novoSegundo);
                                break;
                        }
                        Console.WriteLine("Data alterada com sucesso!");
                        break;
                    case 4:
                        if (data == null)
                        {
                            Console.WriteLine("Nenhuma data criada ainda.");
                            continue;
                        }
                        Console.WriteLine($"Data completa: {data}");
                        break;
                    case 5:
                        if (data == null)
                        {
                            Console.WriteLine("Nenhuma data criada ainda.");
                            continue;
                        }
                        Console.WriteLine("Cálculos de Datas:");
                        Console.WriteLine("1. Somar / subtrair dias à data");
                        Console.WriteLine("2. Diferença para outra data");
                        int opcaoCalculos;
                        if (!int.TryParse(Console.ReadLine(), out opcaoCalculos) || opcaoCalculos < 1 || opcaoCalculos > 2)
                        {
                            Console.WriteLine("Opção inválida. Por favor, escolha 1 ou 2.");
                            continue;
                        }
                        switch (opcaoCalculos)
                        {
                            case 1:
                                Console.WriteLine("Digite a quantidade de dias a serem somados ou subtraídos:");
                                int dias;
                                if (!int.TryParse(Console.ReadLine(), out dias))
                                {
                                    Console.WriteLine("Número de dias inválido.");
                                    continue;
                                }
                                try
                                {
                                    data = data.sumDateTime(dias);
                                    Console.WriteLine($"Nova data: {data}");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Erro: {ex.Message}");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Digite a data com a qual deseja calcular a diferença (no formato d/m/a):");
                                string entradaDiferenca = Console.ReadLine();
                                DateTime outraData = new AmericanDateTime(entradaDiferenca);
                                try
                                {
                                    DateTime diferenca = data.difDateTime(outraData);
                                    Console.WriteLine($"Diferença de datas: {diferenca.getDia()} dias, {diferenca.getHora()} horas, {diferenca.getMinuto()} minutos e {diferenca.getSegundo()} segundos.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Erro: {ex.Message}");
                                }
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 6.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}

public class DateTime
{
    private double totalDias;

    public DateTime()
    {
        this.totalDias = 0;
    }

    public DateTime(int dia, int mes)
    {
        ValidarData(dia, mes, 1900);
        this.totalDias = CalcularTotalDias(dia, mes, 1900);
    }

    public DateTime(int dia, int mes, int ano)
    {
        ValidarData(dia, mes, ano);
        this.totalDias = CalcularTotalDias(dia, mes, ano);
    }

    public DateTime(int dia, int mes, int hora, int minuto)
    {
        ValidarHora(hora, minuto);
        ValidarData(dia, mes, 1900);
        this.totalDias = CalcularTotalDias(dia, mes, 1900) + (hora / 24.0) + (minuto / (24.0 * 60.0));
    }

    public DateTime(string entrada)
    {
        ParseEntrada(entrada);
    }

    public DateTime(DateTime outroObj)
    {
        this.totalDias = outroObj.totalDias;
    }

    public void setDateTime(int dia, int mes, int ano, int hora, int minuto, int segundo = 0)
    {
        ValidarData(dia, mes, ano);
        ValidarHora(hora, minuto, segundo);
        this.totalDias = CalcularTotalDias(dia, mes, ano) + (hora / 24.0) + (minuto / (24.0 * 60.0)) + (segundo / (24.0 * 60.0 * 60.0));
    }

    public int getDia()
    {
        int totalDias = (int)this.totalDias;
        int ano = getAno();
        int mes = getMes();
        int dia = totalDias - (int)(CalcularTotalDias(1, mes, ano));
        return dia + 1; // Adiciona 1 para ajustar a contagem para iniciar em 1
    }

    public int getMes()
    {
        int totalDias = (int)this.totalDias;
        return (totalDias % 365) / 30 + 1;
    }

    public int getAno()
    {
        int totalDias = (int)this.totalDias;
        return totalDias / 365 + 1900;
    }

    public int getHora()
    {
        double fracaoDia = this.totalDias % 1;
        return (int)(fracaoDia * 24);
    }

    public int getMinuto()
    {
        double fracaoDia = this.totalDias % 1;
        return (int)((fracaoDia * 24 * 60) % 60);
    }

    public int getSegundo()
    {
        double fracaoDia = this.totalDias % 1;
        return (int)((fracaoDia * 24 * 60 * 60) % 60);
    }

    public void setDia(int dia)
    {
        ValidarData(dia, getMes(), getAno());
        double parteFracionaria = this.totalDias % 1;
        this.totalDias = CalcularTotalDias(dia, getMes(), getAno()) + parteFracionaria;
    }

    public void setMes(int mes)
    {
        ValidarData(getDia(), mes, getAno());
        int totalDias = (int)this.totalDias;
        int ano = totalDias / 365 + 1900;
        double parteFracionaria = this.totalDias % 1;
        this.totalDias = CalcularTotalDias(getDia(), mes, ano) + parteFracionaria;
    }

    public void setAno(int ano)
    {
        ValidarData(getDia(), getMes(), ano);
        int totalDias = (int)this.totalDias;
        double parteFracionaria = this.totalDias % 1;
        this.totalDias = CalcularTotalDias(getDia(), getMes(), ano) + parteFracionaria;
    }

    public void setHora(int hora)
    {
        ValidarHora(hora, getMinuto(), getSegundo());
        double parteInteira = Math.Floor(this.totalDias);
        double parteFracionaria = this.totalDias - parteInteira;
        this.totalDias = parteInteira + (hora / 24.0) + (parteFracionaria * 24.0);
    }

    public void setMinuto(int minuto)
    {
        ValidarHora(getHora(), minuto, getSegundo());
        double parteInteira = Math.Floor(this.totalDias);
        double parteFracionaria = this.totalDias - parteInteira;
        this.totalDias = parteInteira + (getHora() / 24.0) + (minuto / (24.0 * 60.0)) + (parteFracionaria * 24.0);
    }

    public void setSegundo(int segundo)
    {
        ValidarHora(getHora(), getMinuto(), segundo);
        double parteInteira = Math.Floor(this.totalDias);
        double parteFracionaria = this.totalDias - parteInteira;
        this.totalDias = parteInteira + (getHora() / 24.0) + (getMinuto() / (24.0 * 60.0)) + (segundo / (24.0 * 60.0 * 60.0)) + (parteFracionaria * 24.0);
    }

    public override string ToString()
    {
        return $"{(int)getDia()}/{(int)getMes()}/{getAno()} {(int)getHora():00}:{(int)getMinuto():00}:{(int)getSegundo():00}";
    }

    public DateTime sumDateTime(int dias)
    {
        double novosTotalDias = this.totalDias + dias;
        if (novosTotalDias < 0)
        {
            throw new Exception("Não é possível subtrair mais dias, a data mínima permitida é 01/01/1900.");
        }

        // Cria um novo objeto DateTime com os valores atualizados
        DateTime novaData = new DateTime();
        novaData.setDateTime((int)novosTotalDias, getMes(), getAno(), getHora(), getMinuto(), getSegundo());
        return novaData;
    }


    public DateTime difDateTime(DateTime outroObj)
    {
        double diferenca = this.totalDias - outroObj.totalDias;
        if (diferenca < 0)
        {
            diferenca *= -1;
        }

        // Cria um novo objeto DateTime com a diferença calculada
        DateTime difData = new DateTime();
        difData.setDateTime((int)diferenca, getMes(), getAno(), getHora(), getMinuto(), getSegundo());
        return difData;
    }


    private void ValidarData(int dia, int mes, int ano)
    {
        if (mes < 1 || mes > 12)
        {
            throw new Exception("Mês inválido.");
        }

        int diasNoMes = System.DateTime.DaysInMonth(ano, mes);
        if (dia < 1 || dia > diasNoMes)
        {
            throw new Exception("Dia inválido para o mês e ano fornecidos.");
        }

        if (ano < 1900)
        {
            throw new Exception("Ano fornecido é inferior a 1900.");
        }
    }

    private void ValidarHora(int hora, int minuto, int segundo = 0)
    {
        if (hora < 0 || hora > 23)
        {
            throw new Exception("Hora inválida. Deve estar entre 0 e 23.");
        }

        if (minuto < 0 || minuto > 59)
        {
            throw new Exception("Minuto inválido. Deve estar entre 0 e 59.");
        }

        if (segundo < 0 || segundo > 59)
        {
            throw new Exception("Segundo inválido. Deve estar entre 0 e 59.");
        }
    }

    private double CalcularTotalDias(int dia, int mes, int ano)
    {
        double totalDias = (ano - 1900) * 365;
        for (int i = 1; i < mes; i++)
        {
            totalDias += System.DateTime.DaysInMonth(ano, i);
        }
        totalDias += dia - 1; // Subtraindo 1 pois o primeiro dia é 0, não 1
        return totalDias;
    }

    private void ParseEntrada(string entrada)
    {
        string[] partes = entrada.Split(' ');
        if (partes.Length > 0)
        {
            string[] partesData = partes[0].Split('/');
            if (partesData.Length >= 2)
            {
                int dia = int.Parse(partesData[0]);
                int mes = int.Parse(partesData[1]);
                int ano = 1900;
                if (partesData.Length >= 3)
                {
                    ano = int.Parse(partesData[2]);
                }

                ValidarData(dia, mes, ano);

                double totalDias = CalcularTotalDias(dia, mes, ano);

                if (partes.Length > 1)
                {
                    string[] partesHora = partes[1].Split(':');
                    int hora = int.Parse(partesHora[0]);
                    int minuto = 0;
                    int segundo = 0;
                    if (partesHora.Length >= 2)
                    {
                        minuto = int.Parse(partesHora[1]);
                        if (partesHora.Length >= 3)
                        {
                            segundo = int.Parse(partesHora[2]);
                        }
                    }

                    ValidarHora(hora, minuto, segundo);

                    totalDias += (hora / 24.0) + (minuto / (24.0 * 60.0)) + (segundo / (24.0 * 60.0 * 60.0));
                }

                this.totalDias = totalDias;
            }
        }
    }

}


public class AmericanDateTime : DateTime
{
    public AmericanDateTime() : base() { }

    public AmericanDateTime(int dia, int mes) : base(dia, mes) { }

    public AmericanDateTime(int dia, int mes, int ano) : base(dia, mes, ano) { }

    public AmericanDateTime(int dia, int mes, int hora, int minuto) : base(dia, mes, hora, minuto) { }

    public AmericanDateTime(string entrada) : base(entrada) { }

    public AmericanDateTime(DateTime outroObj) : base(outroObj) { }

    public override string ToString()
    {
        return $"{getMes()}/{getDia()}/{getAno()} {getHora():00}:{getMinuto():00}:{getSegundo():00}";
    }
}

//Quais os erros ? Como corrigir esses erros ?
