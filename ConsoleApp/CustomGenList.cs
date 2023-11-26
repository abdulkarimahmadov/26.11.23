namespace MyCustomNamespace
{
    public class CustomGenList<T>
    {
        private List<T> items;
        private int capacity;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity; }
        }

        public CustomGenList()
        {
            items = new List<T>();
            capacity = 0;
        }

        public void Add(T item)
        {
            items.Add(item);

            if (items.Count >= capacity)
            {
                if (capacity == 0)
                {
                    capacity = 4;
                }
                else
                {
                    capacity *= 2;
                }
            }
            count++;
        }

        public T Find(Predicate<T> match)
        {
            return items.Find(match);
        }

        public List<T> FindAll(Predicate<T> match)
        {
            return items.FindAll(match);
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public bool Exists(Predicate<T> match)
        {
            return items.Exists(match);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }
    }
}
