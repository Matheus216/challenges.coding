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
        if (n == 1) return 0;

        int final = 0;
        long sum = 1;
        bool doing = true;
        var num = new List<int>() { };

        for (int i = 2; (i <= n && doing); i++)
        {
            if (!num.Exists(x => (i % x) == 0 && x != i))
            {
                if ((sum * i) >= n || sum == n  )
                    doing = false;
                else
                {
                    sum = sum * i;
                    final++;
                }
            }

            num.Add(i);
        }

        return final;
    }

    /// <summary>
    /// Complete the 'connectingTowns' function below.
    ///
    /// The function is expected to return an INTEGER.
    /// The function accepts following parameters:
    /// 1. INTEGER n
    /// 2. INTEGER_ARRAY route
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int ConnectionTowns(int n, List<int> routes)
    {
        return routes.Multi();
    }
}

public static class MathematicExtend
{
    public static int Multi(this List<int> input)
    {
        int a = 1;
        Callback _showMeTheName = Control.ShowMeTheName;

        for (int i = 0; i < input.Count(); i++)
        {
            _showMeTheName("Matheus");
            a += input[i];
        }
        return a;
    }
}
