namespace ListaEncadeada
{
    public class Fila:Lista{
       public void enfileirar(string elemento){
            insere(elemento);
       }

       public void desenfileirar(){
            remove(0);
       }
    }
}