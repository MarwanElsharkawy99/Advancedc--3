using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancedc__3
{
    internal class CustomList<T> : List<T>
    {
        private List<T> items;
        public CustomList()
        {
            items = new List<T>();
        }

        public bool Exists(Predicate<T> match)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (match(items[i]))
                    return true;
            }
            return false;
        }


        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < items.Count; i++)
            {
                action(items[i]);
            }
        }


        public List<T> FindAll(Predicate<T> match)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < items.Count; i++)
            {
                if (match(items[i]))
                    result.Add(items[i]);
            }
            return result;
        }


        public T Find(Predicate<T> match)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (match(items[i]))
                    return items[i];
            }
            return default(T);
        }


        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (match(items[i]))
                    return i;
            }
            return -1;
        }



        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (match(items[i]))
                    return i;
            }
            return -1;
        }



        public T FindLast(Predicate<T> match)
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (match(items[i]))
                    return items[i];
            }
            return default(T);
        }

        // true for all

        public bool TrueForAll(Predicate<T> match)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (!match(items[i]))
                    return false;
            }
            return true;
        }







    }

}