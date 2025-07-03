using System;

public class Palindromo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("------------ Verificador de palabras palíndromos -----------");
        Console.Write("Escribe una palabra o frase para reconocer si es una palabra palindromo: ");
        string palabraIngresada = Console.ReadLine();

        if (EsPalindromo(palabraIngresada))
        {
            Console.WriteLine($"Esta palabra: '{palabraIngresada}' si es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"Lamentablente la palabra: '{palabraIngresada}' no es un palíndromo.");
        }
        Console.ReadKey();
    }
    public static bool EsPalindromo(string textoOriginal)
    {
        string textoSinEspacios = textoOriginal.Replace(" ", "");

        int izquierda = 0;
        int derecha = textoSinEspacios.Length - 1;

        while (izquierda < derecha)
        {
            if (textoSinEspacios[izquierda] != textoSinEspacios[derecha])
            {
                return false;
            }
            izquierda++;
            derecha--;
        }

        return true;
    }
}
// tengo que decir que me parecio algo bastante bueno, y gracias al ultimo trabajo que hizo el profe, pude hacer la variable "derecha", ya que no sabia como hacer para arrancar desde la derecha  o desde la ultima letra 
// de la palabra que ingresaba el usuario, no estuvo mal, estuve leyendo los otros dos desafios y el tercero no tengo idea como podre hacerlo, voy a buscar informacion e intentare hacerlo.
// aaa por cierto, si el usuario ingresa una mayúscula al principio de la palabra no lo toma como iguales, en ese caso tendria que hacer otra cosa, pero bueno andar anda, y con espacios tampoco funciona.
// ahora, lo que hice fue preguntar como hacer para verificar los espacios en respuesta la IA me dio este codigo " string textoSinEspacios = textoOriginal.Replace(" ", "");"... que lo que hace es eliminar los espacios 
// y juntar las frases en una palabra, ahora si puede verificar con los espacios, 