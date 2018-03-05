using System;


namespace conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            //numero que vamos a introducir
            int numero = int.Parse(args[0]);
            //base a la que queremos convertir,en este caso la base 36
            int elevado = 36;
            //Caracteres que utiliza la base 36
            string caracteres = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //El numero decimal no puede ser negativo
            if ((numero < 0))
            {
                Console.WriteLine("error, escriba un numero valido");
            }
            else
            {

                int resto;
                string numero2 = "";


                //utilizamos el while para dividir el numero decimal que queremos convertir entre la base (la base del alfanumerico es base 36) hasta que la base sea mayor al numero a convertir
                while (numero >= elevado)
                {
                    //necesitamos el resto del cociente dividido entre el elevado
                    resto = numero % elevado;
                    //utilizamos el numero 2 para convertirlo en un caracter alfanumerico


                    numero2 = caracteres[resto] + numero2;
                    //primero dividiremos el numero a convertir entre la base 36
                    numero = numero / elevado;











                }
                //si el numero era mayor a la base en esta linea se sumara el resto al numero convertido, si no era mayor entonces solo se mostrara el numero convertido ya que numero 2 no valdria nada
                numero2 = caracteres[numero] + numero2;
                Console.WriteLine("el numero en alfanumérico es: " + numero2);


            }

        }
    }
}