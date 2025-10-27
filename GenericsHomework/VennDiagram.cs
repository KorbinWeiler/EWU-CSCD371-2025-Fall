namespace GenericsHomework
{
    public record struct VennDiagram<T> where T : class
    {
        private Dictionary<int, Circle<T>> _sets;
        public VennDiagram(int numSets)
        {
            _sets = new Dictionary<int, Circle<T>>();
            for (int i = 0; i < numSets; i++)
            {
                _sets.Add(i + 1, new Circle<T>());
            }
        }

        public void Add(int setNumber, T newValue)
        {
            _sets[setNumber].Add(newValue);
        }
    }
}