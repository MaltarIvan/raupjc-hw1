using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raupjchw1
{
    class IntegerList : IIntegerList
    {
        private int[] _internalStorage;

        public IntegerList()
        {
            Count = 0;
            _internalStorage = new int[4];
        }

        public IntegerList(int initialSize)
        {
            Count = 0;
            if (initialSize <= 0)
            {
                throw new ArgumentException("IntegerList initial size must be higher than 0.");
            }
            _internalStorage = new int[initialSize];
        }

        public int Count { get; private set; }

        public void Add(int item)
        {
            if (Count >= _internalStorage.Length)
            {
                Array.Resize(ref _internalStorage, _internalStorage.Length * 2);
            }
            _internalStorage[Count++] = item;
        }

        public void Clear()
        {
            Count = 0;
            _internalStorage = new int[4];
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetElement(int index)
        {
            if (index >= 0 && index < Count)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(int item)
        {
            while (this.Contains(item))
            {
                for (int i = 0; i < Count; i++)
                {
                    if (_internalStorage[i] == item)
                    {
                        for (int j = i; j < Count - 1; j++)
                        {
                            _internalStorage[j] = _internalStorage[j + 1];
                        }
                        Count--;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _internalStorage[i] = _internalStorage[i + 1];
                }
                Count--;
                return true;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
