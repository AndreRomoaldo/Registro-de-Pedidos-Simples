using System; 

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {

            pedido lista = new pedido();

            string resposta = "s";

           do {

               ItemPedido Pedido = new ItemPedido();

               Console.WriteLine("Informe a descrição do pedido:");
               Pedido.descricao = Console.ReadLine();

               Console.WriteLine("Informe o valor da unidade:");
               Pedido.valor_unitario = int.Parse(Console.ReadLine());

               Console.WriteLine("Informe a quantidade de itens:");
               Pedido.quantidade = int.Parse(Console.ReadLine());

               lista.adicionar(Pedido);

               Console.WriteLine("Deseja inserir um novo pedido? (s/n)");
               resposta = Console.ReadLine();

               if (resposta == "n") {

                   Console.WriteLine(lista.totalizar());
               }

           } while (resposta == "s");
           
        }
    }
}
