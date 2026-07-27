using System;
using System.ComponentModel;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }
        
        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    // List of Object
    public class ObjectList
    {
        public void Add(object value)
        {

        }

        public object this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }


    // Generic List
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    // Multiple parameter Generic list
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
}
