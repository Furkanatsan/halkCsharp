using System.Collections;

namespace BuiltinInterface
{
    public class Announce : IComparable
    {
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public int CompareTo(object? obj)
        {
            Announce another = (Announce)obj;
            if (this.CreatedDate < another.CreatedDate)
            {
                return -1;
            }
            else if (CreatedDate > another.CreatedDate)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class AnnounceList : IEnumerable<Announce>
    {
        private List<Announce> announces = new List<Announce>();
        public void AddAnnounce(Announce announce)
        {
            announces.Add(announce);
        }

        public void ClearAllList()
        {
            announces.Clear();
        }

        public void RemoveAnnounce(Announce announce)
        {
            announces.Remove(announce);
        }

        public List<Announce> OrderAnnounce()
        {
            announces.Sort();
            return announces;
        }

        public IEnumerator<Announce> GetEnumerator()
        {
            foreach (var announceInList in announces)
            {
                yield return announceInList;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
