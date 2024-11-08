// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Net;
using Consumidor;
using Flurl;
using Flurl.Http;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string url = "https://localhost:5000";

        Item tarefa1 = new Item();
        Item tarefa2 = new Item();
        Item tarefa3 = new Item();

        tarefa1.Id = 1;
        tarefa1.Nome = "Pagar cartão de crédito";
        tarefa1.Finalizado = true;

        tarefa2.Id = 2;
        tarefa2.Nome = "Pesquisar conta de telefone mãe";
        tarefa2.Finalizado = false;

        tarefa3.Id = 3;
        tarefa3.Nome = "Buscar as Crianças na escola";
        tarefa3.Finalizado = true;

        // gerar tarefa
        string endpoint = url + "/api/TarefaItems";

        //flurl
        await endpoint.PostJsonAsync(tarefa1);
        await endpoint.PostJsonAsync(tarefa2);
        await endpoint.PostJsonAsync(tarefa3);

        // ler a lista
        Console.WriteLine ("Gravou na lista");
        Thread.Sleep(new TimeSpan(0,0,5));
        Listar(endpoint);
        Thread.Sleep(new TimeSpan(0,0,15));

        // alterar
        string endpoint_alt = url + "/api/TarefaItems/1";

        tarefa1.Id = 1;
        tarefa1.Nome = "Alteração 1";
//        tarefa1.Finalizado = false;
        await endpoint_alt.PutJsonAsync(tarefa1);

        endpoint_alt = url + "/api/TarefaItems/2";
        tarefa2.Id = 2;
        tarefa2.Nome = "Alteração 2";
//        tarefa2.Finalizado = true;
        await endpoint_alt.PutJsonAsync(tarefa2);

        endpoint_alt = url + "/api/TarefaItems/3";
        tarefa3.Id = 3;
        tarefa3.Nome = "Alteração 3";
//        tarefa3.Finalizado = false;
        await endpoint_alt.PutJsonAsync(tarefa3);

        // ler a lista
        Console.WriteLine ("Alterou a lista");
        Thread.Sleep(new TimeSpan(0,0,5));
        Listar(endpoint);
        Thread.Sleep(new TimeSpan(0,0,10));

        // deletar um item da lista
        IEnumerable<Item> ListTarefas = await endpoint.GetJsonAsync<IEnumerable<Item>>(); 

        Console.WriteLine();
        int id = 0;
        foreach (var item in ListTarefas)
        {
           if (item.Finalizado)
           {
                id = (int)item.Id;     
                endpoint_alt = url + $"/api/TarefaItems/{id}";
                await endpoint_alt.DeleteAsync();
            }
        }

        // ler a lista
        Console.WriteLine ("Apagou da lista");
        Thread.Sleep(new TimeSpan(0,0,5));
        Listar(endpoint);
        Thread.Sleep(new TimeSpan(0,0,10));

        Console.WriteLine("Aperte qquer tecla para finalizar a aplicação");
        Thread.Sleep(new TimeSpan(0,0,10));
//        Console.Read(");
        Console.WriteLine("Finalizou o Consumidor");
    }

    static async void Listar(string endpoints){
        
        IEnumerable<Item> ListTarefas = await endpoints.GetJsonAsync<IEnumerable<Item>>(); 

        Console.WriteLine();
        string status = "";
        foreach (var item in ListTarefas)
        {
           if (item.Finalizado){
                status = "está finalizado(a)";
            } else {
            status = "não esta finalizado(a)";
            } 
           Console.WriteLine($"A tarefa {item.Nome} {status}"); 
        }
        Console.WriteLine();

    }
}