using fila_dinamica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("FILA:");

        FilaPessoa filaPessoa = new ();

        filaPessoa.Push(new("Odair"));
        filaPessoa.Push(new("Gustavo"));

        filaPessoa.RunOver();
        Console.WriteLine();

        filaPessoa.Push(new("Guilherme"));
        filaPessoa.Push(new("Tio Paulo"));

        filaPessoa.RunOver();
        Console.WriteLine();

        filaPessoa.Pop();
        filaPessoa.Pop();

        filaPessoa.RunOver();
        Console.WriteLine();

        filaPessoa.Pop();
        filaPessoa.Pop();

        filaPessoa.RunOver();
        Console.WriteLine();
    }
}