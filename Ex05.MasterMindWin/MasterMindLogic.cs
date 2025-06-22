using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.MasterMindWin
{
    internal class MasterMindLogic<T>
    {
        private readonly List<T> r_RandomCode;
        private readonly int r_NumOfGuesses;
        private List<Guess<T>> m_UserGuesses;

        public MasterMindLogic(List<T> i_ListOfOptions, int i_CodeCount, int i_NumOfGuess)
        {
            r_RandomCode = CreatingCode(i_ListOfOptions, i_CodeCount);
            r_NumOfGuesses = i_NumOfGuess;
            m_UserGuesses = new List<Guess<T>>();

            for (int i = 0; i < r_NumOfGuesses; i++)
            {
                m_UserGuesses.Add(new Guess<T>(r_RandomCode.Count));
            }
        }

        public class Guess<T>
        {
            private List<T> m_UserGuess;
            private int m_BullCount;
            private int m_HitCount;

            public Guess(int i_CodeLength)
            {
                m_UserGuess = new List<T>();
                for (int i = 0; i < i_CodeLength; i++)
                {
                    m_UserGuess.Add(default(T));
                }

                m_BullCount = 0;
                m_HitCount = 0;
            }


            public List<T> UserGuess
            {
                get { return m_UserGuess; }
                set { m_UserGuess = value; }
            }

            public int BullCount
            {
                get { return m_BullCount; }
                set { m_BullCount = value; }
            }

            public int HitCount
            {
                get { return m_HitCount; }
                set { m_HitCount = value; }
            }
        }

        public List<Guess<T>> UserGuesses
        {
            get { return m_UserGuesses; }
            set { m_UserGuesses = value; }
        }

        public List<T> RandomCode
        {
            get { return r_RandomCode; }
        }

        public int NumOfGuesses
        {
            get { return r_NumOfGuesses; }
        }

        private List<T> CreatingCode(List<T> i_ListOfOptions, int i_CodeCount)
        {
            List<T> code = new List<T>();
            Random random = new Random();

            for (int i = 0; i < i_CodeCount; i++)
            {
                int index = random.Next(i_ListOfOptions.Count);
                code.Add(i_ListOfOptions[index]);
                i_ListOfOptions.RemoveAt(index);
            }

            return code;
        }

        public void CompareGuess(Guess<T> i_UserGuess)
        {

            for (int i = 0; i < r_RandomCode.Count; i++)
            {
                if (i_UserGuess.UserGuess[i].Equals(r_RandomCode[i]))
                {
                    i_UserGuess.BullCount++;
                }
            }

            for (int i = 0; i < r_RandomCode.Count; i++)
            {
                for (int j = 0; j < r_RandomCode.Count; j++)
                {
                    if (i_UserGuess.UserGuess[i].Equals(r_RandomCode[j]))
                    {
                        i_UserGuess.HitCount++;
                    }
                }
            }

            i_UserGuess.HitCount -= i_UserGuess.BullCount;
        }
    }
}
