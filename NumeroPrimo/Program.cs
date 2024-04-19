// 1- Faça um programa que leia um numero (a vontade o tipo) em informe se este numero é primo

int numero = 0;
int nroDivisores = 0;


Console.WriteLine("=====Calculadora=====");

Console.Write("Digite um numero: ");
numero = int.Parse(Console.ReadLine());

for(int i = 1; i <= numero; i++)
{
    if(numero % i == 0)
    {
        nroDivisores++;
    }
}


Console.WriteLine("=============================");

if(nroDivisores == 2)
    Console.WriteLine($"O numero {numero} é primo!");
else
    Console.WriteLine($"O numero {numero} NÃO é primo!");

Console.WriteLine("=============================");


Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();
