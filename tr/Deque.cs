using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tr
{
    public class Deque<T>
    {
        public int Count;
        public int Capacity;
        private const int defaultCapacity = 16;

        private T[] items;
        //public int Count
        //{
        //    get { return this.count; }
        //    set { this.count = value; }
        //}
        //public int Capacity
        //{
        //    get { return this.capacity; }
        //    set { this.capacity = value; }
        //}

        // First Constructoin
        public Deque() : this(defaultCapacity) { }
        //Second
        public Deque(int capacity)
        {
            this.Capacity = capacity;
            items = new T[this.Capacity];
        }
        public Deque(IEnumerable<T> collection)

            : this(collection.Count())
        {
            items = collection.ToArray();
            this.Count = collection.Count();
            //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека

        }

        public void AddFront(T item)
        {
            if (this.Count == this.Capacity)
            {
                Resize();
            }
            this.RightMoving(0);
            items[0] = item;
            this.Count++;
            //добавя елемент отпред

        }

        public void AddBack(T item)
        {
            if (Count == Capacity)
            {
                Resize();
            }
            this.items[Count] = item;
            this.Count++;
            //добавя елемент отзад

        }

        public T RemoveFront()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("There are not any trains!");
            }
            T element = this.items[0];
            items[0] = default(T);            
            LeftMoving(0);
            this.Count--;
            return element;
            //връща и премахва елемента отпред

        }

        public T RemoveBack()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("There are not any trains!");
            }
            T element = this.items[this.items.Count() - 1];
            items[this.items.Count() - 1] = default(T);
            this.Count--; //And here we don't need an operation, because we  are in the end of the array
            return element;
            //връща и премахва елемента отзад

        }

        public T GetFront()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("There are no trains!");
            }
            T element = this.items[0];
            return element;
            //връща, без да премахва, елемента отпред

        }

        public T GetBack()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("there are no trains left");
            }
            T element = this.items[this.items.Count() - 1]; //we also can do it without variable
            return element;
            //връща, без да премахва, елемента отзад

        }
        public void Resize()
        {
            T[] copy = new T[this.Capacity *= 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            items = copy;
        }
        private void RightMoving(int index)
        {
            if (this.Count >= this.items.Length)
            {
                this.Resize();
            }
            for (int i = this.Count; i >= index; i--)
            {
                this.items[i + 1] = this.items[i];
            }
        }
        private void LeftMoving(int index)
        {
            //if (this.Count >= this.items.Length )
            //{
            //    this.Resize();         we do not need it, 'cause it is on the left
            //}
            for (int i = index; i < Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }
    }
    //public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public int Count => throw new NotImplementedException();

    //    public bool IsReadOnly => throw new NotImplementedException();

    //    public void Add(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Clear()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool Contains(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void CopyTo(T[] array, int arrayIndex)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int IndexOf(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Insert(int index, T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public bool Remove(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void RemoveAt(int index)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }
}

