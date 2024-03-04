using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App05
{
    public class StackInt
    {
        List<int> values = new List<int>();

        public void Push(int val)
        {
            values.Add(val);
        }
        public int Pop()
        {
            int val = values[values.Count - 1];
            values.RemoveAt(values.Count - 1);
            return val;
        }
    }

    public class StackString
    {
        List<string> values = new List<string>();

        public void Push(string val)
        {
            values.Add(val);
        }
        public string Pop()
        {
            string val = values[values.Count - 1];
            values.RemoveAt(values.Count - 1);
            return val;
        }
    }


    public class StackGenric<T>
    {
        List<T> values = new List<T>();

        public void Push(T val)
        {
            values.Add(val);
        }
        public T Pop()
        {
            T val = values[values.Count - 1];
            values.RemoveAt(values.Count - 1);
            return val;
        }
    }
}
