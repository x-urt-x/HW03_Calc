
namespace PrimeCalcNS
{
    public class PrimeCalc
    {
        public bool IsPrime(double num)
        {

            if (num <= 0 || Math.Abs(num % 1) > 1E-10) return false;

            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;

            }

            return true;
        }
    }
}
