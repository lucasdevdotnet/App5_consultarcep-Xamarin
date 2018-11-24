using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App5.Servicos.Modelo;
using Newtonsoft;
using Newtonsoft.Json;

namespace App5.Servicos
{
   public  class ViaCepServico
    {
        public static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCep(string cep)
        {
            string NovoEnderecoUrl = string.Format(EnderecoURL, cep);
            WebClient wc =  new WebClient();
          string conteudo =  wc.DownloadString(NovoEnderecoUrl);
            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);
            return end;
        }

    }
}
