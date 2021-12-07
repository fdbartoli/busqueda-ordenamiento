//Realizar un programa para administrar el alquiler de 70 películas de un local. Por cada película se conoce el
//código de la misma, el precio de alquiler y un caracter verificador (S o N) para conocer si es estreno o no.
//Luego, se pide el código de película de aquella que dejará de ser estreno teniendo en cuenta que las
//modificaciones terminarán cuando se ingrese código de película igual a 0 (inexistente).
//Se pide:
//a) Generar un vector con los códigos de las películas que son estreno. Mostrarlo en pantalla, si existe.
//b) Cuando una película deja de ser estreno, además de cambiar el carácter verificador, se realiza un 20% de
//descuento al precio de alquiler. Actualizar estos valores.
//c) Mostrar los vectores actualizados.

using System;

namespace arraybusquedayordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] codigo = new int[]{20, 40, 1, 5, 12 };
            float[] precio = new float[] { 100, 300, 189, 192, 329 };
            char[] estreno = new char[] { 's', 'n', 's', 'n', 'n' };
            int[] codigoEstreno = new int[5];
            int c = 0;
            int pivote, buscado;
            int min = 0;
            int max = 4 ;
            int pos = -1;



            Console.WriteLine("Indicar el código de la película que deja de ser estreno ");
            buscado = int.Parse(Console.ReadLine());
            while ((min <= max) && (pos < 0))
            {
                pivote = (min + max) / 2;
                if (codigo[pivote] == buscado)
                    pos = pivote;
                if (codigo[pivote] < buscado)
                    min = pivote + 1;
                else
                    max = pivote - 1;

            }
            if (pos >= 0)
            {

                Console.WriteLine("exite");
            }
            else
            {
                Console.WriteLine("no existe!!");
            }



            for (int i = 0; i<5; i++)//busco los estrenos
            {
                if (estreno [i] == 's')
                {
                    codigoEstreno[c] = codigo[i];//genero el vector con estrenos
                    c++;
                }
                else
                {

                }
            }

            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Códigos de péliculas estreno: " + codigoEstreno[i]);
            }


        }
    }
}
