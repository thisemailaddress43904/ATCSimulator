using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace ATC2027.DataStructures
{
    public class ConcurrentPriorityQueue<T> : IEnumerable<T>, ICollection
    {
        private String itemsLock;
        private IList<Tuple<T, int>> items;
        public ConcurrentPriorityQueue(ICollection<Tuple<T, int>> collection)
        {
            lock (itemsLock)
            {
                items = [.. collection];
                items = items.OrderBy(x => x.Item2).ToList();
            }
        }

        public T Dequeue()
        {
            T item;
            lock (itemsLock)
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("The queue is empty.");
                }
                item = items[0].Item1;
                items.RemoveAt(0);
            }

            return item;
        }

        public void Enqueue(T item, int priority)
        {
            lock (itemsLock)
            {
                var tuple = new Tuple<T, int>(item, priority);
                items.Add(tuple);
                items = items.OrderBy(x => x.Item2).ToList();
            }
        }

        public int Count
        {
            get { lock (itemsLock) return items.Count; }
        }

        public bool IsSynchronized => false; //false for now as locking has not yet been implemented

        public object SyncRoot => itemsLock;

        public void CopyTo(Array array, int index)
        {
            ArgumentNullException.ThrowIfNull(array);

            ArgumentOutOfRangeException.ThrowIfNegative(index);

            //aquire list lock lock for thread safety
            lock (itemsLock)
            {
                for (int i = index; i < items.Count; i++)
                {
                    array.SetValue(items[i - index].Item1, i);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {


            IList<T> list = new List<T>();

            lock (itemsLock)
            {
                items.OrderBy(x => x.Item2);
                foreach (var item in items)
                {
                    list.Add(item.Item1);
                }
            }


            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

