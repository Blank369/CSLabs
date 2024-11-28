using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab4
{
    internal class FEFO<T> where T : IExpired
    {

        public class Element
        {
            private T _note;
            private Element _next;


            public Element(T value)
            {
                _next = null;
                _note = value;
            }
            public T Note
            {
                get { return _note; }
                set { _note = value; }
            }
            public Element Next
            {
                get { return _next; }
                set { _next = value; }
            }
        }
        public Element head;


        /// <summary>
        /// 
        /// </summary>
        public int Count
        {
            get {
                Element current = head;
                int count = 0;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        public FEFO()
        {
            head = null;
        }

        public void Add(T value)
        {
            if (value.GetExpireDays() <= 0)
            {
                MessageBox.Show("Срок годности данного продукта уже истек", "Продукт не был добавлен в список", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Element note = new Element(value);

                if (head != null)
                {
                    Element current = head;
                    Element previous = null;

                    while (current != null)
                    {
                        if (value.GetExpireDays() <= current.Note.GetExpireDays())
                        {
                            note.Next = current;

                            if (previous == null) head = note;
                            else previous.Next = note;

                            return;
                        }
                        previous = current;
                        current = current.Next;
                    }
                    current = note;
                    previous.Next = current;
                }
                else
                {
                    head = note;
                    head.Next = null;
                }
            }
        }
        public T Get(int index)
        {
            Element findElement = head;
            int n = 0;

            while (n != index - 1)
            {
                if (findElement == null)
                {
                    return findElement.Note;
                }
                findElement = findElement.Next;
                n++;
            }
            return findElement.Note;
        }

        public void RemoveAt(int index)
        {
            Element current = head;
            Element previous = null;

            int count = 0;
            while (current != null)
            {
                if (count == index)
                {
                    if (previous == null)
                    {
                        if (head.Next == null) head = null;
                        else head = head.Next;
                    }
                    else previous.Next = current.Next;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }

        public void Remove(Element item)
        {
            Element current = head;
            Element previous = null;

            int count = 0;
            while (current != null)
            {
                if (current == item)
                {
                    if (previous == null)
                    {
                        if (head.Next == null) head = null;
                        else head = head.Next;
                    }
                    else previous.Next = current.Next;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }

        public void RemoveBad(int daysLeft)
        {
            Element current = head;
            while (current != null)
            {
                if (current.Note.GetExpireDays() <= daysLeft) Remove(current);
                current = current.Next;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Element current = head;
            while (current != null)
            {
                yield return current.Note;
                current = current.Next;
            }
        }

        public T PopBad() => head.Note;

        public T PopFresh()
        {
            Element current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Note;
        }
    }
}
