namespace ListaEncadeada
{
    public class No{
        private string _valor;
        public string valor
        {
            get{return _valor;}
            set {_valor = value;}
        }

        private No _proximo;
        public No proximo
        {
        get{return _proximo;}
        set{_proximo = value;}
        }
    }
}