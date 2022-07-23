int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(2, 10));

static int S(int n, int m)
{
    if ((n == 1) && (m == 1))
        return 1;
    else if (n > 1)
        return S(n - 1, m) + m;
    else
        return S(n, m - 1) + 1;
}

Console.WriteLine(S(3, 11));
