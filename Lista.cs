namespace ListaEncadeada
{
    public class Lista{
        private No _cabeca,_cauda;

        public int tamanho{get;set;}
      
       public No buscaNo(int indice){
            No busca = _cabeca;
            int pos = 0;
            while (busca != null)
            {
                if (pos == indice){
                    return busca;
                }
                busca = busca.proximo;
                pos++;
            }
            
            return null;
       }

       public void insere(string elemento){
           //Criar um No
           No novoNo = new No();
           novoNo.valor = elemento;
           //1 passo: verificar se é o primeiro elemento
           if(_cabeca == null){
               _cabeca = novoNo;
           }
           else
           {
               _cauda.proximo = novoNo;
           }
           _cauda = novoNo;
           tamanho++;
       }

       public void remove(int idx){
            No noParaRemover = this.buscaNo(idx);

            if (noParaRemover == null) return;

            //teste de remoção
            if(noParaRemover == _cabeca){
                _cabeca = _cabeca.proximo;
                noParaRemover.proximo = null;
                tamanho--;
                return;
            }     

            No noAnterior = this.buscaNo(idx - 1);
            
            // refazendo encadeamento
            noAnterior.proximo = noParaRemover.proximo;

            //remoçao do ultimo elemento     
            if(noParaRemover.proximo == null){
                _cauda = noAnterior;
                tamanho--;
            }

            noParaRemover.proximo = null;
       }
    }
}