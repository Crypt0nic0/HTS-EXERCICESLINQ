using System;
using System.Collections;

namespace EXERCICESLINQ
{
    public class MaListe : IEnumerable<int>
    {
        private MaListeEnumerator enumerator;
        public MaListe(int taille)
        {
            enumerator = new MaListeEnumerator(taille);
        }
        public IEnumerator<int> GetEnumerator()
        {
            return enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
