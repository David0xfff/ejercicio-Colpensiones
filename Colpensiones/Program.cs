using System;

namespace Colpensiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cantidad de usuarios a valorar:");
            int num_usuarios = int.Parse(Console.ReadLine());

            string[] nombre = new string[num_usuarios];
            string[] genero = new string[num_usuarios];
            int[] edad = new int[num_usuarios];
            int jubilados = 0;
            int v2 = 0;
            string v1, v3;

            for (int x = 0; x <= num_usuarios-1; x++)
            {
                Console.WriteLine("Nombre usuario: ");
                v1 = Console.ReadLine();
                nombre[x] = v1;

                Console.WriteLine("Edad usuario");
                v2 = int.Parse(Console.ReadLine());
                edad[x] = v2;

                Console.WriteLine("Genero usuario");
                v3 = Console.ReadLine();
                genero[x] = v3;

                if(genero[x] == "masculino" && edad[x] >= 62) { jubilados++; }
                if(genero[x] == "femenino" && edad[x] >= 57) { jubilados++; }

            }

            Console.WriteLine("Numero de personas que SI pueden jubilarse: " + jubilados);
            Console.WriteLine("\n\nNumero de personas que NO pueden jubilarse: " + (num_usuarios-jubilados));
        }
    }
}
