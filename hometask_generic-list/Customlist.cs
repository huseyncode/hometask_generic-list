using System;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;

        public CustomList()
        {
            items = new T[10];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count++] = item;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    count--;
                    return;
                }
            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Any()
        {
            return count > 0;
        }

        public void Clear()
        {
            count = 0;
        }

        public T FirstOrDefault()
        {
            return count > 0 ? items[0] : default(T);
        }

        public T ElementAtOrDefault(int index)
        {
            return index >= 0 && index < count ? items[index] : default(T);
        }

        public T LastOrDefault()
        {
            return count > 0 ? items[count - 1] : default(T);
        }

        public T[] GetAll()
        {
            T[] result = new T[count];
            Array.Copy(items, result, count);
            return result;
        }
    }
}
