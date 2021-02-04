using System; 

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-||| Bem vindo ao registro de pedidos! |||-");

            pedido lista = new pedido();

            string resposta = "s";

           do {

               ItemPedido Pedido = new ItemPedido();

               Console.WriteLine("-Informe a descrição do pedido:");
               Pedido.descricao = Console.ReadLine();

               Console.WriteLine("-Informe o valor da unidade:");
               Pedido.valor_unitario = int.Parse(Console.ReadLine());
               Console.WriteLine("O valor da unidade de "+Pedido.descricao+" é: R$"+Pedido.valor_unitario+",00");

               Console.WriteLine("-Informe a quantidade de itens:");
               Pedido.quantidade = int.Parse(Console.ReadLine());

               lista.adicionar(Pedido);

               Console.WriteLine("-Deseja inserir um novo pedido? (s/n)");
               resposta = Console.ReadLine();

               if (resposta == "n") {

                   Console.WriteLine("|| O seu pedido totalizou o valor de: R$"+lista.totalizar()+",00 ||");
               }

           } while (resposta == "s");
           
        }
    }
}
