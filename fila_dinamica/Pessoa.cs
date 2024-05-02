namespace fila_dinamica
{
    internal class Pessoa
    {
        string nome;
        Pessoa? proximo;

        public Pessoa(string nome)
        {
            this.nome = nome;
            this.proximo = null;
        }

        public void SetNext(Pessoa aux)
        {
            this.proximo = aux;
        }

        public Pessoa? GetNext() 
        {
            return this.proximo;
        }

        public string Print() 
        {
            return $"Nome: {this.nome} ";
        }
    }
}
