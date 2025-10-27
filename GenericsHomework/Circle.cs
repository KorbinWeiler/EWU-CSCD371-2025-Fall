namespace GenericsHomework
{
    public class Circle<T>
    {
        private List<T> _elements;

        public Circle()
        {
            _elements = new List<T>();
        }

        public void Add(T newValue)
        {
            _elements.Add(newValue);
        }
    }
}