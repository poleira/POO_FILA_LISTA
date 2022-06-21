namespace ListaEncadeada
{
    public class Pilha:Lista{
       public void empilhar(string elemento){
        insere(elemento);
       }

       public void desempilhar(){
            remove(tamanho-1);
       }
    }
}