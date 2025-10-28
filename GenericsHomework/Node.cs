namespace GenericsHomework;

public class Node<T>
{
    public T Data { get; set; }
    private Node<T> _next;
    public Node<T> Next
    {
        get => _next;
        private set => _next = value ?? this;
    }

    public Node(T data)
    {
        Data = data;
        _next = this;
    }

    public void Append(T value)
    {
        if (this.Exists(value))
        {
            throw new InvalidOperationException("Cannot Have Duplicates Appended");
        }
        Node<T> nextNode = new(value)
        {
            Next = this.Next
        };
        Next = nextNode;
    }

    public void Clear()
    {
        Next = this;
    }
    public void IterativeClear()
    {
        Node<T> cur = this.Next;
        while (cur != this)
        {
            Node<T> next = cur.Next;
            cur.Next = cur;
            cur = next;
        }
        this.Next = this;
    }

    public bool Exists(T value)
    {
        Node<T> cur = this;
        do
        {
            if (Equals(cur.Data, value))
            {
                return true;
            }
            cur = cur.Next;
        } while (cur.Next != this);
        return false;
    }
    public override string ToString()
    {
        if (Data is null)
        {
            return "null";
        }
        else
        {
            return Data.ToString() ?? "null";
        }
    }
}
