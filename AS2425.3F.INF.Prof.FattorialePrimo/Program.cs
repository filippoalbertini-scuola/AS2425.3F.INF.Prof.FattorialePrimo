using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AS2425._3F.INF.Prof.FattorialePrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;3F;21/12/24;Calcolo del fattoriale e verifica se un numero è primo");

            int scelta = 0;
            int numero = 0;

            do
            {
                scelta = Menu();

                switch (scelta)
                {
                    case 1: // Fattoriale di un numero

                        Console.WriteLine("Inserisci il numero su cui calcolare il fattoriale");

                        numero = Convert.ToInt32(Console.ReadLine());

                        int risultato = Fattoriale(numero);

                        Console.WriteLine($"Il fattoriale di {numero} è {risultato}");
                        
                        break;

                    case 2: // Dato un numero indicarne la radice quadrata

                        Console.WriteLine("Inserisci il numero da verificare se è primo");
                        numero = Convert.ToInt32(Console.ReadLine());

                        if (IsPrimo(numero))
                            Console.WriteLine($"Il numero {numero} è primo");
                        else
                            Console.WriteLine($"Il numero {numero} non è primo");

                        break;
                    case 9:
                        Console.WriteLine("Hai scelto di uscire.");
                        break;
                }

            } while (scelta != 9);

            Console.WriteLine("Programma terminato.");
        }

        /// <summary>
        /// Indica all'utente le possibili scelte
        /// </summary>
        static int Menu()
        {
            int scelta = 0;

            Console.WriteLine("Scelte operative :");
            Console.WriteLine("1) Calcola il fattoriale di numero");
            Console.WriteLine("2) Verifica se numero è primo");
            Console.WriteLine("9) Uscita");

            // TODO:  controlla i valori indicati dall'utente
            scelta = Convert.ToInt32(Console.ReadLine());

            return scelta;
        }

        /// <summary>
        /// Calcola il fattoriale di numero
        /// </summary>
        /// <returns></returns>
        static int Fattoriale(int numero)
        {
            int risultato = 1;
            for (int i = 2; i <= numero; i++)
            {
                risultato *= i;
            }
            return risultato;
        }

        /// <summary>
        /// Verifica se numero è primo
        ///     If the number is less than 2, it's not prime.
        ///     Loop from 2 to the square root of the number. For each value in this range, check if it 
        ///     divides the number evenly(remainder zero). If it does, the number is not prime.
        ///     If no divisors are found, the number is prime.
        ///    
        ///     In C#, you use the % sign to check the remainder. If number % divisor == 0, then the number 
        ///     is divisible by the divisor.
        /// </summary>
        /// <returns>True se primo</returns>
        static bool IsPrimo(int numero)
        {
            if (numero <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0) return false;
            }

            return true;
        }
    }
}
