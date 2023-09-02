using Microsoft.Maui.Controls;
using System;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        private Random random = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollDiceClicked(object sender, EventArgs e)
        {

            int selectedLados = GetSelectedLados();

            if (selectedLados > 0)
            {

                int resultado = random.Next(1, selectedLados + 1);


                DisplayAlert("Resultado", $"Você rolou um dado de {selectedLados} lados e obteve: {resultado}", "OK");
            }
            else
            {
                DisplayAlert("Erro", "Selecione a quantidade de lados do dado antes de rolar.", "OK");
            }
        }

        private int GetSelectedLados()
        {

            switch (dicePicker.SelectedItem.ToString())
            {
                case "4":
                    return 4;
                case "6":
                    return 6;
                case "10":
                    return 10;
                case "20":
                    return 20;
                case "100":
                    return 100;
                default:
                    return 0;
            }
        }
    }
}