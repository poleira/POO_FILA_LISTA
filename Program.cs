using System;

namespace ListaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Teste da lista encadeada
            /*Lista l = new Lista();

            l.insere("7");
            l.insere("5");
            l.insere("2");

            l.remove(2);
            l.remove(0);*/

            //Teste da fila
            /*Fila f = new Fila();
            f.enfileirar("1");
            f.enfileirar("2");
            f.enfileirar("3");

            f.desenfileirar();*/

            //Teste da pilha
            Pilha p = new Pilha();
            p.empilhar("1");
            p.empilhar("2");
            p.empilhar("3");

            p.desempilhar();
        }
    }
}
