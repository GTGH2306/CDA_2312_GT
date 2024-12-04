
namespace CLMemento
{
    public class History
    {
        private List<IMemento> itsMementos;
        public History()
        {
            this.itsMementos = new List<IMemento>();
        }

        public void Undo()
        {
            if (itsMementos.Count > 0)
            {
                itsMementos[itsMementos.Count - 1].Restore();
                itsMementos.RemoveAt(itsMementos.Count - 1);
            }
        }

        public void AddMemento(IMemento _mementoToAdd)
        {
            this.itsMementos.Add(_mementoToAdd);
        }
    }
}
