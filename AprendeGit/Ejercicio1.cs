// See https://aka.ms/new-console-template for more information
//Ejercicio 1
byte edad = 0;
Console.WriteLine("Ejercicio 1: ");
Console.WriteLine("¿Cúal es tu edad?");
edad = byte.Parse(Console.ReadLine());
Console.WriteLine("¡Guau!, No aparentas "+ edad+ " años.");
//Ejercicio 2
byte dato1;
byte dato2;
ushort producto;
Console.WriteLine("Ejercicio 2:");
Console.WriteLine("Ingrese un número de 2 cifras.");
dato1 = byte.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro número de 2 cifras.");
dato2 = byte.Parse(Console.ReadLine());
producto = (ushort)(dato1 * dato2);
Console.WriteLine("El resultado es: " + producto);
//Ejercicio 3
long numero1;
long numero2;
int suma, resta, prod;
Console.WriteLine("Ejercicio 3: ");
Console.WriteLine("Ingrese un entero largo: ");
numero1=long.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo entero largo: ");
numero2=long.Parse(Console.ReadLine());
suma = (int)(numero1 + numero2);
resta = (int)(numero1 - numero2);
prod = (int)(numero1 * numero2);
Console.WriteLine("La suma es: " + suma);
Console.WriteLine("la resta es: "+ resta);
Console.WriteLine("El producto es: " + prod);