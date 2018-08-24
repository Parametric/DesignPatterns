using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorRefactor
{
    public class IntegerBox
    {
        private int[] _data;

        public IntegerBox(int[] data)
        {
            _data = data;
        }

        public int[] GetData()
        {
            return _data;
        }

        public string IterateOverData()
        {
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < _data.Length; i++)
            {
                sb.Append(_data[i]);
            }

            return sb.ToString();
        }
    }

    public class CharacterList
    {
        private List<char> _list;

        public CharacterList(List<char> list)
        {
            _list = list;
        }

        public List<char> GetData()
        {
            return _list;
        }

        public string IterateOverData()
        {
            StringBuilder sb = new StringBuilder("");
            foreach (var item in _list)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
    }

    public class GlobalPrinter
    {
        public void PrintData(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
                Console.Write(data[i]);
            Console.WriteLine();
        }

        public void PrintData(List<char> data) 
        {
            for (int i = 0; i < data.Count; i++)
                Console.Write(data[i]);
            Console.WriteLine();
        }
    }
}


