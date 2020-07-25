using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsultaCEP
{
    using WebServiceCep;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o CEP que deseja bsucar: ");
            var cep = Console.ReadLine();

            if (!string.IsNullOrEmpty(cep))
            {
                ConsultaCep(cep);
            }
        }

        private static void ConsultaCep(string cep)
        {
            using (var ws = new AtendeClienteClient())
            {
                var resposta = ws.consultaCEP(cep);

                Console.Clear();
                Console.WriteLine(String.Format("Endereço : {0}", resposta.end));
                Console.WriteLine(String.Format("Bairro : {0}", resposta.bairro));
                Console.WriteLine(String.Format("Cidade : {0}", resposta.cidade));
                Console.WriteLine(String.Format("UF : {0}", resposta.uf));
                Console.WriteLine(String.Format("CEP : {0}", resposta.cep));
                Console.WriteLine("");
                Console.WriteLine("Pressione qualquer tecla para continuar");

                Console.ReadKey();

            }
        }
    }
}
