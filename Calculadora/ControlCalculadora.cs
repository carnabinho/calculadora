using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ControlCalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        public ControlCalculadora()
        {
            this.calculadora = new ModelCalculadora();
        }//fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetNum2= Convert.ToDouble(Console.ReadLine());
        }//fim do coletar

        public void ColetarBhaskara()
        {
            Console.WriteLine("Informe o 1 número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o 2 número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o 3 número: ");
            this.calculadora.GetSetNum3 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletarBhaskara

        public void ColetarRaiz()
        {
            Console.WriteLine("informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine()) ;
        }// fim do coletarRaiz

        public int Menu()
        {
            Console.WriteLine("---------------Menu---------------"          +
                                "\n0. Sair"                                 +
                                "\n1. Somar"                                +
                                "\n2. Subtrair"                             +
                                "\n3. Dividir"                              +
                                "\n4. Multiplicar"                          +
                                "\n5. Potência"                             +
                                "\n6. Raiz"                                 +
                                "\n7. Tabuada"                              +        
                                "\n8. Bhaskara"                             +
                                "\n9. Binário -> Decimal"                   +
                                "\n10. Decimal -> Binário"                  +
                                "\n11. Hexadecimal -> Decimal"              +
                                "\n\n--DAQUI PRA BAIXO SÃO EXERCICIOS--"    +
                                "\n\n12. Dobro e Triplo do seu número"      +
                                "\n13. Salário + 30%"                       +
                                "\n14. ImPar, positivos e negativos"        +
                                "\n15. Soma todos os numeros de 1 a 100"    +
                                "\n16. Tabuada de 1 à N"                    +
                                "\n17. Contador"                            +
                                "\n18. Impares de 100 a 200"                +
                                "\n19. soma 10 números inteiros! "          + 
                                "\n20. Ler números e parar quando inserir 0"+
                                "\n21. calcula media de numeros pares "     +
                                "\n\n Escolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//Fim do método Menu
         public void Operacao()
         {
            int opcao = -1;
            do
            {
                opcao = Menu();
                Console.Clear();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        ColetarRaiz();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;

                    case 8:
                        ColetarBhaskara();
                        Console.WriteLine("Conversão: " + this.calculadora.Bhaskara());
                        break;

                    case 9:
                        Console.WriteLine("Informe o numero binário:");
                        string valor = Console.ReadLine();
                        int resultado = Convert.ToInt32(ModelCalculadora.BinarioDecimal(valor));
                        Console.WriteLine($" O numero {valor} é igual a {resultado} ");
                        break;

                    case 10:
                        Console.WriteLine("Informe o numero decimal a converter");
                        string valor1 = Console.ReadLine();
                        string resultado1 = ModelCalculadora.DecimalBinario(valor1);
                        Console.WriteLine($" O numero {valor1} é igual a {resultado1} ");
                        break;

                    case 11:
                        Console.WriteLine("Digite um número hexadecimal:");
                        string hexInput = Console.ReadLine();
                        ModelCalculadora model3 = new ModelCalculadora();
                        try
                        {
                            int decimalNumber1 = model3.HexadecimalDecimal(hexInput);
                            Console.WriteLine($"O número decimal equivalente é: {decimalNumber1}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }



                        break;

                    case 12:
                        ColetarRaiz();
                        Console.WriteLine(this.calculadora.Dobrotriplo());
                        break;

                    case 13:
                        ColetarRaiz();
                        Console.WriteLine(this.calculadora.Salario30());
                        break;

                    case 14:
                        ColetarRaiz();
                        Console.WriteLine(this.calculadora.Imparpositivonegativo());
                        break;

                    case 15:
                        ModelCalculadora modelCalculadora = new ModelCalculadora();
                        int inicio = 1;
                        int fim = 100;
                        int soma = modelCalculadora.Soma1a100(inicio, fim);
                        Console.WriteLine(soma);
                       break;

                    case 16:
                        ColetarRaiz();
                        Console.WriteLine(this.calculadora.Tabuada1N());
                        break;

                    case 17:
                        Console.WriteLine("Informe o 1° numero: ");
                             int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o 2° número:");
                             int n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.calculadora.Contador(n1,n2));
                        break;

                    case 18:
                        Console.WriteLine(this.calculadora.Impares100200());
                        break;

                    case 19:
                        Console.WriteLine(this.calculadora.Soma10Inteiros());
                        break;

                    case 20:
                        Console.WriteLine("A soma dos seus números é: " + this.calculadora.SomaNumeros());
                        break;

                    case 21:
                        double media = this.calculadora.MediaPar();
                        if (media != 0)
                            Console.WriteLine("Média dos números pares: " + media);
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é valida");
                        break;

                }//fim do switch
            } while (opcao != 0);//fim do Do...while
        }// fim do operacao
    }//fim da classe
}//fim do projeto
