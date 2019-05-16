using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Queue.Model
{
    public class EasyDeque<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count;
        public EasyDeque() { }
        public EasyDeque(T data)
        {
            items.Add(data);
        }
        public void Pushback(T data)
        {
            items.Insert(0, data);
        }
        public void PushFront(T data)
        {
            items.Add(data);
        }
        public T Popback()
        {
            var item = Tail;
            items.Remove(item);
            return item;
        }
        public T Popfront()
        {
            var item = Head;
            items.Remove(item);
            return item;
        }
        public T PeekBack()
        {
            return Tail;
        }
        public T PeekFront()
        {
            return Head;
        }
    }
}
