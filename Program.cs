using System;

namespace HeroLevelClassifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita o nome do herói
            Console.Write("Digite o nome do herói: ");
            string nome = Console.ReadLine();

            // Solicita a quantidade de experiência do herói
            Console.Write("Digite a quantidade de XP do herói: ");
            int xp;
            while (!int.TryParse(Console.ReadLine(), out xp) || xp < 0)
            {
                Console.WriteLine("Por favor, insira um valor válido para XP (número inteiro positivo).");
                Console.Write("Digite a quantidade de XP do herói: ");
            }

            // Determina o nível do herói com base na quantidade de XP
            string nivel;
            if (xp < 1000)
            {
                nivel = "Ferro";
            }
            else if (xp <= 2000)
            {
                nivel = "Bronze";
            }
            else if (xp <= 5000)
            {
                nivel = "Prata";
            }
            else if (xp <= 7000)
            {
                nivel = "Ouro";
            }
            else if (xp <= 8000)
            {
                nivel = "Platina";
            }
            else if (xp <= 9000)
            {
                nivel = "Ascendente";
            }
            else if (xp <= 10000)
            {
                nivel = "Imortal";
            }
            else
            {
                nivel = "Radiante";
            }

            // Exibe a mensagem com o nível do herói
            Console.WriteLine($"O Herói de nome {nome} está no nível de {nivel}");
        }
    }
}

