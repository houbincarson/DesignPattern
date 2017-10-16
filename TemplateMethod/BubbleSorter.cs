using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class BubbleSorter
    {
        private int _operations = 0;
        protected int Length = 0;

        protected int DoSort()
        {
            _operations = 0;
            if (Length<=1)
            {
                return _operations;
            }
            for (int nextToLast = Length - 2; nextToLast >= 0; nextToLast --)
            {
                for (int index = 0; index <= nextToLast; index++)
                {
                    if (OutOfOrder(index))
                    {
                        Swap(index);
                    }
                    _operations ++;
                }
            }
            return _operations;
        }

        protected abstract void Swap(int index);
        protected abstract bool OutOfOrder(int index);
    }

    public class IntBubbleSorter : BubbleSorter
    {
        private int[] _array = null;
        public int Sort(int[] theArray)
        {
            _array = theArray;
            Length = _array.Length;
            return DoSort();
        }
        protected override void Swap(int index)
        {
            var temp = _array[index];
            _array[index] = _array[index + 1];
            _array[index + 1] = temp;
        }

        protected override bool OutOfOrder(int index)
        {
            Console.WriteLine(" ");
            foreach (var item in _array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            return (_array[index] > _array[index + 1]);
        }
    }

    public class FloatBubbleSorter : BubbleSorter
    {
        private float[] array = null;

        public int Sort(float[] theArray)
        {
            array = theArray;
            Length = array.Length;
            return DoSort();
        }

        protected override void Swap(int index)
        {
            var temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }

        protected override bool OutOfOrder(int index)
        {
            return (array[index] > array[index + 1]);
        }
    }


}
