using System.Collections;
using System.Collections.Generic;

namespace ScoreboardBLL
{
    public class GameFouls : IEnumerable<Foul>, ICollection<Foul>
    {
        private ICollection<Foul> FoulList;

        int ICollection<Foul>.Count => FoulList.Count;

        bool ICollection<Foul>.IsReadOnly => FoulList.IsReadOnly;

        public GameFouls(ICollection<Foul> fouls)
        {
            this.FoulList = fouls;
        }

        public void Add(Foul foul)
        {
            FoulList.Add(foul);
        }

        public void Clear()
        {
            FoulList.Clear();
        }

        public bool Contains(Foul foul)
        {
            return FoulList.Contains(foul);
        }

        public void CopyTo(Foul[] array, int arrayIndex)
        {
            FoulList.CopyTo(array, arrayIndex);
        }

        public bool Remove(Foul foul)
        {
            return FoulList.Remove(foul);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Foul foul in FoulList)
            {
                yield return foul;
            }
        }

        IEnumerator<Foul> IEnumerable<Foul>.GetEnumerator()
        {
            foreach (Foul foul in FoulList)
            {
                yield return foul;
            }
        }
    }
}
