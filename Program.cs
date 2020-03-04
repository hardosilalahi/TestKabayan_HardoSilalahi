using System;
using System.Numerics;
using System.Text;

namespace test_kabayan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(8);
            Factorials(7);

            int[] numbers = {2, 1, 5, 7, 4, -8, -3, -1};
            tigaAngka(numbers);

            CountLengthC(0, 4, 2, 6);
            CountLengthC(2, 8, 2, 10);
            CountLengthC(1, 10, 4, 7);
            CountLengthC(5, 7, 0, 11);
            CountLengthC(1, 5, 5, 10);
            

        }

        static void Fibonacci(int n){
            int num1 = 0;
            int num2 = 1;
            int num3 = 0;

            Console.Write($"Fibonacci sampai {n}: {num1} {num2} ");

            for(int i = 2; i < n; i++){
                num3 = num1 + num2;
                Console.Write($"{num3} ");
                num1 = num2;
                num2 = num3;
            }
            Console.WriteLine();
        }

        static void Factorials(int n){
            BigInteger nFactorial = n;

            for(int i = n-1; i >= 1; i--){
                nFactorial = nFactorial * i;
            }
            Console.WriteLine($"Faktorial {n}: {nFactorial}");
        }

        static void tigaAngka(int[] arrNum){
            var found = true;
            var n = arrNum.Length;
            
            for(int i = 0; i < n-2; i++){
                for(int j = i+1; i < n-1; i++){
                    for (int k = j+1; k < n; k++){
                        if(arrNum[i] + arrNum[j] + arrNum[k] == 0){
                            Console.WriteLine($"( {arrNum[i]}, {arrNum[j]}, {arrNum[k]} )");
                            found = true;
                        }
                        else{
                            if(found == false){
                                Console.WriteLine("Not Found");
                            }
                        }
                    }
                }
            }
        }

        static void CountLengthC(int XB1, int XB2, int Xb1, int Xb2){
            var panjangC = 0;
            if(XB2 < Xb1){
                Console.WriteLine("Kedua garis tidak saling berhimpit");
            }
            else if(XB2 == Xb1){ panjangC = 0;}
            else{
                if(XB2 > Xb2){
                    if(XB1 > Xb1){ panjangC = (int)Math.Abs(XB1 - Xb2); }
                    else{ panjangC = (int)Math.Abs(Xb1 - Xb2); }
                }
                else{
                    if(XB1 > Xb1){ panjangC = (int)Math.Abs(XB1 - XB2); }
                    else{ panjangC = Math.Abs(Xb1 - XB2); }
                }
            }
            Console.WriteLine($"panjang sumbu C = {panjangC}");
        }
    }
}
