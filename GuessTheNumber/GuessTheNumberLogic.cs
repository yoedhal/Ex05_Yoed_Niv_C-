using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class GuessTheNumberLogic<T>
    {
        private readonly T r_SecretElement;
        private readonly int r_NumOfGuesses;

        public GuessTheNumberLogic(Func<T> i_randomGenerator, int i_NumOfGuesses) 
        {
            r_SecretElement = i_randomGenerator();
            r_NumOfGuesses = i_NumOfGuesses;
        }

        public T SecretElement
        {
            get { return r_SecretElement; }
        }

        public static int EvaluateGuess(T i_UserGuess, T i_SecretElement)
        {
           
                return Comparer<T>.Default.Compare(i_UserGuess, i_SecretElement);

        }
    }
}
