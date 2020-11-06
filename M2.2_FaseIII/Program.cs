using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2._2_FaseIII
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lettersName = { 'j', 'o', 'a', 'q', 'u', 'i', 'n', 'a' }; //declaramos una array de char con las letras que contiene el nombre 
            List<char> lName = new List<char>(); // declaramos una lista de chars donde almacenaremos las letras del nombre 

            for (int i = 0; i < lettersName.Length; i++) // bucle que irá rellenando la lista con las letras contenidas en el array lettersName 
            {
                lName.Add(lettersName[i]);
            }

            Dictionary<char, int> dictName = new Dictionary<char, int>(); // Declaramos un diccionario de chars y enteros 

            foreach (var nme in lName)  // Con este bucle iremos rellenando el diccionario de valores 
            {
                if (!dictName.ContainsKey(nme))
                    dictName.Add(nme, 1);
                else
                {
                    dictName[nme]++;
                }
            }

            foreach (var nme in dictName)
            {
                Console.WriteLine(nme);
            }
            Console.Read();
        }
    }
}



