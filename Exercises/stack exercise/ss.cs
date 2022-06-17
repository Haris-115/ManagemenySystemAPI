using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace stack_exercise
{
    class ss
    {
        private object _object;
        private List<object> list = new List<object>();


        public object Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Cannot use .Pop() if list count equals 0.");

            _object = list.FirstOrDefault();

            list.RemoveAt(0);

            return _object;
        }

        internal void Push(object obj)
        {
            _object = obj;

            if (_object == null)
                throw new InvalidOperationException("Cannot use .Push() if object is null.");

            list.Insert(0, _object);
        }

        internal void Clear()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Cannot use .Clear() if list is empty.");

            list.Clear();
        }

        public void Print()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
