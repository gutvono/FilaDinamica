namespace fila_dinamica
{
    internal class FilaPessoa
    {
        Pessoa? head;
        Pessoa? tail;

        public FilaPessoa()
        {
            this.head = null;
            this.tail = null;
        }

        public void Push(Pessoa aux)
        {
            if (IsEmpty()) head = tail = aux;
            else
                tail.SetNext(aux);
            tail = aux;
        }

        public void Pop()
        {
            if (!IsEmpty())
                if (head == tail) head = tail = null;
                else this.head = this.head.GetNext();
        }

        bool IsEmpty()
        {
            return head == null && tail == null;
        }

        public void RunOver()
        {
            Pessoa aux = this.head;
            if (aux == null) Console.WriteLine("Fila vazia.");
            while (aux != null) {
                Console.WriteLine(aux.Print());
                aux = aux.GetNext();
            }
        }
    }
}
