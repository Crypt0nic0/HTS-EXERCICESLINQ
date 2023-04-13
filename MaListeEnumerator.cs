using System;
using System.Collections;

namespace EXERCICESLINQ
{
    public class MaListeEnumerator : IEnumerator<int>
    {
        private readonly int taille;
        private int[] tableau;
        private int index = -1;
        public MaListeEnumerator(int taille)
        {
            this.taille = taille;
            tableau = new int[taille];
            for (int i = 0; i < taille; i++)
            {
                tableau[i] = i + 1;
            }
        }
        public int Current => tableau[index];

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (index >= taille - 1)
            {
                return false;
            }
            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
