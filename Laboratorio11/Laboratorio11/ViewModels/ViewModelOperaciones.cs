using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Laboratorio11.ViewModels
{
    public class ViewModelOperaciones : ViewModelBase
    {
        int valorA;

        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }

        }

        int valorB;

        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }

        }
        int valorC;

        public int ValorC
        {
            get { return valorC; }
            set
            {
                if (valorC != value)
                {
                    valorC = value;
                    OnPropertyChanged();
                }
            }

        }
        int resultadoSuma;

        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }
        int resultadoMultiplica;
        public int ResultadoMultiplica
        {
            get { return resultadoMultiplica; }
            set
            {
                if (resultadoMultiplica != value)
                {
                    resultadoMultiplica = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand Sumar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }



        public ViewModelOperaciones()
        {
            Sumar = new Command(() =>
            {
                ResultadoSuma = ValorA + ValorB + ValorC;
            });

            Multiplicar = new Command(() =>
            {
                ResultadoMultiplica = ValorA * ValorB * ValorC;
            });

        }
    }
}
