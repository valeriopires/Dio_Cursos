using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pessoa person = new Pessoa();
            // person.Nome = "Bob";
            // person.Idade = 20;

            // person.Apresentar();
            
            //Encapsulamento - Teste C/ Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //Teste C/ Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Nota = 8.0;  
            // p1.Documento = "1234568";
            // p1.Apresentar(); 

            // Professor p2 = new Professor();
            // p2.Idade = 40;
            // p2.Nome = "Draúzio";
            // p2.Salario = 5000;
            // p2.Documento = "CPF";
            // p2.Apresentar(); 

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: ", calc.Somar(10, 10));

            // System.Console.WriteLine("Resultado da sugunda soma: " + calc.Somar(10, 10, 5));

            // Corrente c1 = new Corrente();
            // c1.Creditar(100);
            // c1.ExibirSaldo();

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10, 20));

            // Calculadora calc2 = new Calculadora();
            // calc2.Somar(10, 20);
            // calc2.Dividir(10, 5);
            
             var caminho = "C:\\TrabalhandoComArquivos";
             var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
             var caminhoArquivo =  Path.Combine(caminho, "arquivo-teste-stream.txt");

             var listaString = new List<string>{"Linha 1", "Linha 2", "Linha 3"};
             var listaStringContinuacao = new List<string>{"Linha 4", "Linha 5", "Linha 6"};

             FileHelper helper = new FileHelper();
             
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);

            //System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);

            // System.Console.WriteLine("Deletando diretório: " + caminhoPathCombine);
            // helper.ApagarDiretorio(caminhoPathCombine, true);

            // System.Console.WriteLine("Criando arquivo no diretório: " + caminho);
            // helper.CriarArquivoTexto(caminhoArquivo, "Olá, este é um teste de criação e escrita de arquivo com o C#");

            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);

            //helper.LerArquivo(caminhoArquivo);
            //helper.LerArquivoStream(caminhoArquivo);


        }
    }
}
