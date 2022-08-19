using System;

namespace projeto1{
    class Program{
        static double calcularMedia(double[]numeros){
            double media = 0.0;
            double soma = 0.0;

            for(int i = 0; i < numeros.Length; i++){
              soma += numeros[i];
            };

            media = soma / numeros.Length;

            return media;

            // static double calcularMediana(double[]numeros){
            //     for(int i = 0; i< numeros.Length; i++){
            //          Array.Sort(numeros);
            //             int meio = numeros.Length /2;
            //     }
            //         return numeros[meio];   
            // }
            static async double calcularModa(double[]numeros){
                double j = 0.0;
                for(int i = 0; i < numeros.Length; i ++){
                    j = []
                }
            }
        }
        static void Main(string[] args){
            double[]numeros ={2, 6, 4, 8};
            double media = calcularMedia(numeros);
            double moda = calcularModa(numeros);
            // double mediana = calcularMediana(numeros);
            Console.WriteLine("a media é: " + media);
            // Console.WriteLine("a mediana é: " + numeros[meio]);
            Console.WriteLine("a moda é: " + moda);
        }
        }
    }
}
