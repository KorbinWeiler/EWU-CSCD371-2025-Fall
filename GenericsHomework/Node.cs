namespace GenericsHomework
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next {
            get;
            
            //Idk if this actually works or not
            private set
            {
                if (value is not null)
                {
                    Next = value;
                }
                else
                {
                    Next = this;
                }
            } }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        public override string ToString()
        {
            return Data.ToString() ?? "null";
        }
    }
}
