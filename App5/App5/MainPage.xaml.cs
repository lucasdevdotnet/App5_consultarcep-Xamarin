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

            if (isValidarCep(cep))
            {
                try
                {
                    Endereco end = ViaCepServico.BuscarEnderecoViaCep(cep);
                    if (end != null)
                    {
                        RESULT.Text = string.Format("Endereco: {0},{1}{2},{3}", end.bairro, end.localidade, end.logradouro, end.uf);
                    }
                    else
                    {
                        DisplayAlert("ERRO", "O endereço nao foi encontrado para o cep informado", "OK");
                    }
                }
                catch (Exception e)
                {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
            }
        } 
            private bool isValidarCep( string cep)
            {
            bool valido = true;
            if (cep.Length != 8)
            {
                DisplayAlert("Erro", "CEP invalido o cep deve conter 8 caraceteres!", "OK");
                return false;

            }
            int NovoCEP = 0;
            if(!int.TryParse(cep, out NovoCEP))
            {
                //ERRO 
                DisplayAlert("Erro", "CEP deve ser composto apenas por numeros!", "OK");
                return false;
            }
        return valido;
    }
        }
    }
