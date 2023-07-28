using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ModelCalculadora
    {
        //declarando variaveis
        private double num1;
        private double num2;
        private double num3;

        public ModelCalculadora()
        {
            GetSetNum1 = 0;
            GetSetNum2 = 0;
            GetSetNum2 = 0;
        }//fim do construtor

        //Métodos gets e sets
        public double GetSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//fim do GetSetNum1

        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//fim do GetSetNum2

        public double GetSetNum3
        {
            get { return this.num3; }
            set { this.num3 = value; }
        }

        //Métodos
        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;
        }//fim do método Somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }//fim do método Subtrair

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }
        }//fim do método Dividir

        public double Multiplicar()
        {
            return GetSetNum1 * GetSetNum2;
        }//fim do método Multiplicar

        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2);
        }//fim da potencia

        public string Raiz()
        {
            string msg = "\nRaíz do primeiro número: " + Math.Sqrt(GetSetNum1);
            return msg;
        }//fim do método raiz

        public string TabuadaNum1()
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i);
            }//fim do método for

            return resultado;
        }//fim do método 

        public string TabuadaNum2()
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum2 + " * " + i + " = " + (GetSetNum2 * i);
            }//fim do método for

            return resultado;
        }//fim do método 

        public double Bhaskara()
        {
            return (GetSetNum2 * GetSetNum2) - (4) * (GetSetNum1 * GetSetNum3);
        }//Fim do método Delta



        //Método X1
        public double X1()
        {
            return (GetSetNum2 + Math.Sqrt(Bhaskara())) / (2 * GetSetNum1);
        }//Fim do método X1



        //Método X1
        public double X2()
        {
            return (-GetSetNum2 - Math.Sqrt(Bhaskara())) / (2 * GetSetNum1);
        }//Fim do método X2

        public static string ReverteString(string str)
        {
            return new string(str.Reverse().ToArray());
        }//fim do reverte string

        public static int BinarioDecimal(string numeroBinario)
        {
            int expoente = 0;
            int numero;
            int soma = 0;
            string numeroInvertido = ReverteString(numeroBinario);
            for (int i = 0; i < numeroInvertido.Length; i++)
            {
                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                soma += numero * (int)Math.Pow(2, expoente);
                expoente++;
            }//fim do for
            return soma;
        }//fim do binario para decimal

        public static string DecimalBinario(string numeroDecimal)
        {
            string valor1 = "";
            int dividendo = Convert.ToInt32(numeroDecimal);
            if (dividendo == 0 || dividendo == 1)
            {
                return Convert.ToString(dividendo);
            }
            else
            {
                while (dividendo > 0)
                {
                    valor1 += Convert.ToString(dividendo % 2);
                    dividendo = dividendo / 2;
                }//fim do while
                return ReverteString(valor1);
            }//fim do if/else
        }//fim do decimal para binario

        public int HexadecimalDecimal(string hexNumber)
        {
            int decimalNumber1;
            try
            {
                decimalNumber1 = Convert.ToInt32(hexNumber, 16);
            }
            catch (FormatException)
            {
                throw new ArgumentException("O número hexadecimal inserido é inválido.");
            }
            return decimalNumber1;


        }//fim da classe

        public string Dobrotriplo()
        {
            return "O dobro e o triplo do seu número são: " + (GetSetNum1 * 2) + " e " + (GetSetNum1 * 3);
        }

        public string Salario30()
        {
            return "O seu salário aumentado em 30% é de: " + (GetSetNum1 * 30 / 100 + GetSetNum1);
        }

        public string Imparpositivonegativo()
        {
            string resultado = "";
            string ResultadoParImpar = "";

            if (GetSetNum1 > 0)
                resultado += "Este número é um positivo";
            else
                resultado += "Este número é um negativo";

            if (GetSetNum1 % 2 == 0)
                ResultadoParImpar += " par!";
            else
                ResultadoParImpar += " impar!";

            return resultado + ResultadoParImpar;
        }


        public int Soma1a100(int inicio, int fim)
        {
            int soma = 0;
            for (int i = inicio; i <= fim; i++)
            {
                soma += i;
            }
            return soma;
        }// fim do Exercicio 4

        public string Tabuada1N()
        {
            string resultado = "";

            for (int i = 1; i <= GetSetNum1; i++)
            {
                resultado += "\n" + 1 + " * " + i + " = " + (1 * i);
            }//fim do método for

            return resultado;
        }// fim tabuada de 1 para N

        public string Contador(int n1, int n2)
        {
            string resultado = "";

            for (int i = n1; i <= n2; i++)
            {
                resultado += "\n" + (n1 + (1 * i - n1));
            }//fim do método for

            return resultado;
        }// fim contador

        public string Impares100200()
        {
            string ResultadoImpar = "";

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 1)
                    ResultadoImpar += i;
                else;
                    ResultadoImpar+= "\n";
                    
            }

            return ResultadoImpar;
        }//fim Impares100200

        public string Deznumerosesoma()
        {
            string resultado = "";
            for (int i = 1; i <= 10; i++)
            {
                
            }

            return resultado;
        }
    }// fim ModelCalculadora
}//fim do projeto
