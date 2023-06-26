using System.Reflection.Metadata.Ecma335;

Console.Write("Número: ");
int num = int.Parse(Console.ReadLine());

int resultado = Fatorial(num);

Console.Write(resultado);

int Fatorial(int n)
{
        if (n == 0){return 1;}
    return n * Fatorial(n - 2);
}