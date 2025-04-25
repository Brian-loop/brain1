// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] clientes = { "maria", "jose", "cleyton", "keila", };
int[] idades = { 19, 15, 35, 15 };

Console.WriteLine("Nome" + clientes[1]);
Console.WriteLine("Idade: "+ idades[1]);

clientes[1] = "JOSÉ";

Console.WriteLine("Nome: " + clientes[1]);
Console.WriteLine("Idade" + idades[1]);

Console.WriteLine("Total de clientes: " + clientes.Length);

Console.WriteLine("LISTAGEM DE CLIENTES");
Console.WriteLine("ID\tNome\t\tIdade");
for (int i = 0; i < clientes.Length; i++)
{
    Console.Write(i);
    Console.Write("\t");
    Console.Write(clientes[i]);
    Console.Write("\t\t");
    Console.WriteLine(idades[i]);

}
