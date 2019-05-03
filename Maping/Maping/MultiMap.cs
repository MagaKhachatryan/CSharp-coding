using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maping
{
    /// <summary>
    /// This class is about multimap, That is a dictionary in which every member consists of one key and a number  of values.
    /// the class implements Idictionary interface.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class MultiMap<TKey, TValue> : IDictionary<TKey, HashSet<TValue>>
    { 
       //private property .
        private Dictionary<TKey, HashSet<TValue>> MultiDictionary { get; set;}

        //parametrless constructor 
        public MultiMap()
        {
            MultiDictionary = new Dictionary<TKey, HashSet<TValue>>();
        }

        //indexer(parametrful property)
        public HashSet<TValue> this[TKey key]
        {
            get
            {
                return this.MultiDictionary[key];
            }

            set
            {
                MultiDictionary[key]= value;
            }
        }

        //property, tthe count of members in the dictionary
        public int Count
        {
            get
            {
                return this.Count();
            }
        }

        //checks if dictionary is redaonly,that is we cant addd or remove new members in it
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        //property,keys in the dictionary
        public ICollection<TKey> Keys
        {
            get
            {
                return MultiDictionary.Keys;
            }
        }

        //propertvalues in the dictionary
        public ICollection<HashSet<TValue>> Values
        {
            get
            {
               return MultiDictionary.Values ;
            }
        }

        //Addd method adds the given item 
        //item is the parametr that has key and  hashset  values 
        public void Add(KeyValuePair<TKey, HashSet<TValue>> item)
        {
            if (item.Key == null)
            {
                throw new ArgumentNullException();
            }
            else if (MultiDictionary.Keys.Contains(item.Key))
            {
                throw new ArgumentException();
            }
            else
            {
                MultiDictionary.Add(item.Key, item.Value);

            }
           
        }

        //methot adds a new item in the dictionary with the given key and values in the parametr
        public void Add(TKey key, HashSet<TValue> value)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }
            else if (MultiDictionary.Keys.Contains(key))
            {
                throw new ArgumentException();
            }
            else
            {
                MultiDictionary.Add(key, value);

            }

        }

        //Clears all items in the dictionary
        public void Clear()
        {
            if (this.IsReadOnly == true)
                throw new NotSupportedException();
            else
                MultiDictionary.Clear();

        }

        //cheks if the dictionary contains the given item
        public bool Contains(KeyValuePair<TKey, HashSet<TValue>> item)
        {
            if(MultiDictionary.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //cheks if the dictionary contains an  item with the given key
        public bool ContainsKey(TKey key)
        {
            if (MultiDictionary.ContainsKey(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //copies the items in the dictionary into the array
        public void CopyTo(KeyValuePair<TKey, HashSet<TValue>>[] array, int arrayIndex)
        {
            if(array == null)
            {
                throw new ArgumentNullException();
            }
            if(arrayIndex<0 || arrayIndex > array.Count())
            {
                throw new ArgumentOutOfRangeException();
            }
            if(( array.Count()-arrayIndex) < MultiDictionary.Count()  )
            {
                throw new ArgumentException();
            }
           foreach(var pair in MultiDictionary)
            {
                array[arrayIndex] = pair;
                ++arrayIndex;
            }
        }

        //makes the dictionary enumerable
        public IEnumerator<KeyValuePair<TKey, HashSet<TValue>>> GetEnumerator()
        {
            return MultiDictionary.GetEnumerator();
        }

        //removes the given item
        public bool Remove(KeyValuePair<TKey, HashSet<TValue>> item)
        {
            if (item.Key == null)
            {
                throw new ArgumentNullException();
            }
            if (!MultiDictionary.ContainsKey(item.Key))
            {
                return false;
            }
            MultiDictionary.Remove(item.Key);
            return true;
        }


        //removes the item with the given key
        public bool Remove(TKey key)
        {
            if(key == null)
            {
                throw new ArgumentNullException();
            }
            if(!MultiDictionary.ContainsKey(key))
            {
                return false;
            }
            MultiDictionary.Remove(key);
            return true;
        }

        //checks if dictionary contains the given key
        //if yes method sets the second parametr equal to the appropriate value  and returns true
        //if no,it sets the second parametr null and returns false
        public bool TryGetValue(TKey key, out HashSet<TValue> value)
        {
            if(key== null)
            {
                throw new ArgumentNullException();
            }
            if(MultiDictionary.Keys.Contains(key))
            {
                value = MultiDictionary[key];
                return true;
            }
            else
            {
                value = null;
                return false;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return MultiDictionary.GetEnumerator();
        }
        public HashSet<TValue> GetValues(TKey key)
        {
            HashSet<TValue> toReturn = null;
            TryGetValue(key, out toReturn);
            
            return toReturn;
        }

    }
}
