namespace MyTask2
{
    public class HLLNode<T>
    {
        public T ValueFName { get; set; }
        public T ValueLName { get; set; }
        public T ValueEmail { get; set; }
        public T ValueList { get; set; }

        

        public HLLNode(T value)
        {
            this.Value = value;

        }
        
       public HLLNode(T firstname, T lastname, T email, T list)
       {
           this.ValueFName = firstname;
            this.ValueLName = lastname;
            this.ValueEmail = email;
            this.ValueList= list;

        }
        public T Value { get; set; }
        public HLLNode<T> Next { get; set; }
        
    }
}