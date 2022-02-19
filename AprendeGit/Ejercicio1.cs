// See https://aka.ms/new-console-template for more information
//Ejercicio 1
byte edad = 0;

Console.WriteLine("¿Cúal es tu edad?");
edad = byte.Parse(Console.ReadLine());
Console.WriteLine("¡Guau!, No aparentas "+ edad+ " años.");
//Ejercicio 2
byte dato1;
byte dato2;
ushort producto;

Console.WriteLine("Ingrese un número de 2 cifras.");
dato1 = byte.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro número de 2 cifras.");
dato2 = byte.Parse(Console.ReadLine());
producto = (ushort)(dato1 * dato2);
Console.WriteLine("El resultado es: " + producto);
//Ejercicio 3
