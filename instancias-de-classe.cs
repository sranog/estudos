using System;
using System.Collections.Generic;

class Funcionario
{
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public int Idade { get; set; }

    public Funcionario(string cargo, double salario, int idade)
    {
        Cargo = cargo;
        Salario = salario;
        Idade = idade;
    }
}

public class Program
{
    public static void Main()
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        funcionarios.Add(new Funcionario("Secretario", 1600.00, 28));
        funcionarios.Add(new Funcionario("Assistente", 1800.00, 35));
        funcionarios.Add(new Funcionario("Gestor    ", 30000.00, 78));

        foreach (Funcionario f in funcionarios)
        {
            Console.WriteLine($"Cargo: {f.Cargo} Salário: {f.Salario} Idade: {f.Idade}\n");
        }

        for (int i = 0; i < funcionarios.Count; i++)
        {
            Console.WriteLine($"[{i}] {funcionarios[i].Cargo}");
        }

        int indice;
        while (true)
        {
            Console.WriteLine("\nDigite o número do funcionário para remover:");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out indice) && indice >= 0 && indice < funcionarios.Count) // se a entrada for válida
            {
                funcionarios.RemoveAt(indice);
                Console.WriteLine("Funcionário removido!");
                break; // sai do loop após remover
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }
        }

        Console.WriteLine("\nLista atualizada:");
        foreach (Funcionario f in funcionarios)
        {
            Console.WriteLine($"Cargo: {f.Cargo}, Salário: {f.Salario}, Idade: {f.Idade}");
        }
    }
}

