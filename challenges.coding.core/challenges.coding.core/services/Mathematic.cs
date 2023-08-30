namespace challenges.coding.core.services;

public class Mathematic
{
    /// <summary>
    /// Given  and , what's the minimum number of packages that Luke must drop to supply all of his bases?
    /// Packages can be dropped at the corner between cells (0, 0), (0, 1), (1, 0) and (1, 1) to supply  bases. Another package can be dropped at a border between (0, 2) and (1, 2). This supplies all bases using  packages.
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public int GameWithCells(int n, int m)
    {
        //Conjunto Dominante Mínimo

        return (n / 2 + n % 2) * (m / 2 + m % 2); ;
    }

    /// <summary>
    /// return de quantity primes numbers multipled is less than n
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int primeCount(long n)
    {
        int final = 0, sum = 1;
        bool doing = true;
        for (int i = 0; i <= n && doing; i++)
        {
            if (!int.TryParse(Math.Sqrt(i).ToString(), out int result))
            {
                sum = sum * i;
                if (sum >= n)
                    doing = false;
                else
                    final++;
            }
        }

        return final;
    }
}
