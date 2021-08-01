using System;


namespace MyTask2
{
    // first of all, a queue->First in first out.we add to the bottom(Enqueue),and remove from the top (Dequeue)
    // while Stack-> Last in first out. Add to the top [Push], remove from the top[Pop].
    public class HospitalQueueLogic<T>
    {

        public static HLLNode<T> Head { get; set; }
        public static HLLNode<T> Tail { get; set; }
        public static int Count { get; set; }

        public static  HLLNode<T> Enqueue(T valueFirstName, T valueLastName, T valueEmail, T ValueList)
        {
            HLLNode<T> node = new HLLNode<T>(valueFirstName,valueLastName, valueEmail, ValueList );

            if (Head== null)
            {
               Head = Tail = node;
                Count++;
                return node;
            }

            // var temp = Last;
            // Last = node;
            // Last.Next = temp;
            Tail.Next = node;
            Tail = node;
            Count++;
            return node;
        }

        public T Dequeue()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Move to the next");
            }


            T value = Head.Value;
            Head = Head.Next;
            Count--;
            return value;
        }

        public void Print()
        {
            var temp = Head;
            while (temp != null)
            {
            Console.WriteLine("Enter Yourmail");
            Console.WriteLine("Enter Yourmail");
                System.Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }

    }
}