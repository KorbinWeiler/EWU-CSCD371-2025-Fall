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
    public void ItterativeClear()
    {
        Node<T> cur = this;
        Node<T>? prev = null;
        while (cur.Next != this)
        {
            cur = cur.Next;
            prev = cur;
            prev.Next = prev;
        }
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
