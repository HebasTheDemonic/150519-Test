using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueList
{
    class MyUniqueList
    {
        List<int> list = new List<int>();

        public MyUniqueList()
        {

        }

        public bool Add(int item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }

            throw new ItemAlreadyExistException();
        }

        public bool Remove(int item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }

            throw new ItemNotFoundException();
        }

        public int Peek(int index)
        {
            if (!list.Contains(index))
            {
                throw new IndexOutOfRangeException();
            }
            return list[index];
        }

        public int this[int index]
        {
            get
            {
                if (!list.Contains(index))
                {
                    throw new ItemNotFoundException();
                }
                return this.list[index];
            }
            set
            {
                if (list.Contains(value))
                {
                    throw new ItemAlreadyExistException();
                }
                if (list[index] == value)
                    return;
                if (list.Contains(value))
                    return;
                list[index] = value;
            }
        }
    }
}
