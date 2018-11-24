using System;

using Xamarin.Forms;
using App5.Servicos.Modelo;
using App5.Servicos;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BOTAO.Clicked += BuscarCep;
        }

        private void BuscarCep(object sender, EventArgs args)
        {

            // Todo logica do programa.

            //  validações 
            string cep = CEP.Text.Trim(); //  trim  remove os espaçoes 




















            Endereco end =  ViaCepServico.BuscarEnderecoViaCep(cep);
            RESULT.Text =  string.("Endereco {0} " + end.bairro); 



        }
    }
}
