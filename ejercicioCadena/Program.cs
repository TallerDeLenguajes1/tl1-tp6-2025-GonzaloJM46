string cadena = "hola mundo";


string nueva;
int longitud = cadena.Length;

Console.WriteLine("longitud de la cadena es " + longitud);

Console.WriteLine("\ningrese una nueva cadena: ");
nueva = Console.ReadLine();

string resultado = cadena + " " + nueva;
Console.WriteLine("\nla concatenacion es: " + resultado);

string subcadena = nueva.Substring(0, 4);
Console.WriteLine("\nsubcadena: " + subcadena);

foreach (char letra in nueva)
{
    Console.WriteLine(letra);
}

Console.WriteLine("\ningrese la palabra que quiere saber si esta dentro de la cadena: ");
string palabra = Console.ReadLine();

Console.WriteLine("\nla palabra fue encontrada en la posicion: " + cadena.IndexOf(palabra));

Console.WriteLine("cadena en mayusculas: " + cadena.ToUpper());
Console.WriteLine("cadena en minusculas: " + cadena.ToLower());

