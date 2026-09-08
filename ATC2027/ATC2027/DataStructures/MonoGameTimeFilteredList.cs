using Microsoft.Xna.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ATC2027.DataStructures
{
    /// <summary>
    /// Represents a time-filtered collection of items, where each item is associated with a timestamp and automatically
    /// excluded when it exceeds a specified maximum age.
    /// </summary>
    /// <remarks>Could be made event based. This would probably be a major improvement.\nThis class is useful for scenarios where items need to be tracked and filtered based on their
    /// age, such as in game development for managing time-sensitive objects. The maximum age of stored items can be
    /// updated dynamically, but previously removed items are not restored. The collection provides methods to add items
    /// with timestamps, retrieve items, and update the internal state based on elapsed time.</remarks>
    /// <typeparam name="T">The type of items stored in the collection.</typeparam>
    public class MonogameTimeFilteredList<T>
    {
        
        private IList<Tuple<T, TimeSpan>> _items;

        private TimeSpan _lastUpdate;
        private TimeSpan _maximumAgeOfObjectsToBeStored;

        public MonogameTimeFilteredList(TimeSpan maximumAgeOfObjectsToBeStored, IList<T>? list = null, TimeSpan? ageOfItemsInList = null)
        {
            if (list == null ^ ageOfItemsInList == null)
            {
                //xor of list being null and ageOfItemsInList being null
                if (list == null)
                    throw new ArgumentNullException(nameof(list));
                if (ageOfItemsInList == null)
                    throw new ArgumentNullException(nameof(ageOfItemsInList));
            }

            _items = new List<Tuple<T,TimeSpan>>();

            if (list != null) {
                foreach (var item in list)
                    _items.Add(Tuple.Create(item, (TimeSpan)ageOfItemsInList));
            }

            _maximumAgeOfObjectsToBeStored = maximumAgeOfObjectsToBeStored;
        }
        /// <summary>
        /// Returns the first element in the collection.
        /// </summary>
        /// <remarks>If the collection is empty, this method returns the default value for <typeparamref
        /// name="T"/> instead of throwing an exception.</remarks>
        /// <returns>The first element of type <typeparamref name="T"/> if the collection contains any items; otherwise, the
        /// default value for <typeparamref name="T"/>.</returns>
        public T First()
        {
            try
            {
                return _items.First().Item1;
            }
            catch (InvalidOperationException ioe)
            {
                return default;
            }

        }
        /// <summary>
        /// Returns the last element in the collection, or the default value if the collection is empty.
        /// </summary>
        /// <remarks>If the collection is empty, this method returns the default value for the type
        /// <typeparamref name="T"/> instead of throwing an exception.</remarks>
        /// <returns>The last element of type <typeparamref name="T"/> in the collection, or <see langword="null"/> (for
        /// reference types) or the default value (for value types) if the collection contains no elements.</returns>
        public T? Last()
        {
            try
            {
                return _items.Last().Item1;
            }
            catch (InvalidOperationException ioe)
            {
                return default;
            }

        }
        public IList<Tuple<T,TimeSpan>> GetItems()
        {
            return _items.ToList();
        }
        ///<summary>Updates the data structure by removing items that have exceeded the maximum age based on the provided elapsed game time. If no elapsed time is provided, it defaults to zero, effectively removing all items that are older than the maximum age at the time of the update.
        ///</summary>
        ///<remarks>
        ///Could be made more efficient by searching from the back and removing items until 1 item no longer needs to be removed as the list is ordered
        ///</remarks>
        public void UpdateDataStructure(TimeSpan? gameTimeElapsedTime = null)
        {
            if (gameTimeElapsedTime == null)
                gameTimeElapsedTime = TimeSpan.Zero;


            _items = _items.Where(x => gameTimeElapsedTime - x.Item2 <= _maximumAgeOfObjectsToBeStored).ToList();

            _lastUpdate = (TimeSpan)gameTimeElapsedTime;
        }

        public void AddItem(T item, TimeSpan ts)
        {
            _items.Add(new Tuple<T, TimeSpan>(item, ts));
        }
        /*
         * Updates the maximum age of the objects stored within the data structure. The data structure does not currently recover previously deleted objets
         */
        public void UpdateMaximumAgeOfStoredObjects(TimeSpan age)
        {
            _maximumAgeOfObjectsToBeStored = age;
        }

        public IEnumerator<Tuple<T,TimeSpan>> GetEnumerator()
        {
            var enumeration = _items.GetEnumerator();

            return _items.GetEnumerator();
        }

        public TimeSpan GetLastUpdate()
        {
            return this._lastUpdate;
        }

        public Tuple<T,TimeSpan> this[int index] => _items[index];

        public int Count => _items.Count;
    }
}