using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC2027.DataStructures
{
    public class EventBasedList<T> : IList<T>
    {
        private readonly List<T> _list;

        public event EventHandler<EventArgs> ItemAdded;
        public event EventHandler<EventArgs> ItemRemoved;
        public event EventHandler<EventArgs> ItemHasBeenSetByIndexAccess;

        public EventBasedList() {
            this._list = [];
        }

        public EventBasedList(ICollection<T> collection)
        {
            this._list = [.. collection];
        }

        public T this[int index]
        {
            get => _list[index];
            set
            {
                value = _list[index];
                ItemHasBeenSetByIndexAccess.Invoke(this, EventArgs.Empty);
            }
        }

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            _list.Add(item);
            ItemAdded?.Invoke(this, EventArgs.Empty);
        }

        public void Clear()
        {
            _list.Clear();
            this.ItemRemoved?.Invoke(this, EventArgs.Empty);
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _list.Insert(index, item);
            this.ItemAdded?.Invoke(this, EventArgs.Empty);
        }

        public bool Remove(T item)
        {
            bool itemHasBeenRemoved = _list.Remove(item);
            
            if (itemHasBeenRemoved)
            {
                this.ItemRemoved?.Invoke(this, EventArgs.Empty);
            }
            return itemHasBeenRemoved;
            
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
            this.ItemRemoved.Invoke(this, EventArgs.Empty);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
