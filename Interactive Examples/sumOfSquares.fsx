(*
    C# example https://fsharpforfunandprofit.com/posts/fvsc-sum-of-squares/
    
    public static class SumOfSquaresHelper
    {
        public static int Square(int i)
        {
           return i * i;
        }

        public static int SumOfSquares(int n)
        {
           int sum = 0;
           for (int i = 1; i <= n; i++)
           {
              sum += Square(i);
           }
           return sum;
        }
    }
*)

// define the square function
let square x = x * x

// define the sumOfSquares function
let sumOfSquares n = 
   [1..n] |> List.map square |> List.sum