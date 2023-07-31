partial class Program
{
    static void _puts_recursion(string s, int iter = 0)
    {
        if (iter == s.Length)
        {
            Write('\n');
            return;
        }
        Write(s[iter]);
        _puts_recursion(s, iter + 1);
    }

    static void _print_rev_recursion(string s, int iter = 0)
    {
        if (iter == s.Length)
        {
            Write('\n');
            return;
        }
        Write(s[s.Length-iter-1]);
        _print_rev_recursion(s, iter + 1);
    }

    static int _strlen_recursion(string s, int iter = 0)
    {
        if (iter == s.Length)
            return (0);

        return 1 + _strlen_recursion(s, iter + 1);
    }

    static int factorial(int d)
    {
        if (d < 0)
        {
            return -1;
        }
        else if (d == 0)
        {
            return 1;
        }
        checked  // for overflow
        {
            return d * factorial(d - 1);
        }
    }

    static int _pow_recursion(int x, int y)
    {
        if (y < 0)
        {
            return -1;
        }
        else if (y == 0)
        {
            return 1;
        }
        return x * _pow_recursion(x, y - 1);
    }

    static int _sqrt_recursion(int n, int iter = 0)
    {
        if (n <= 1 || iter >= n / 2)
        {
            return -1;
        }
        else if (iter * iter != n)
        {
            if ((n % 2) == 1 && iter == 0)
            {
                iter++;
            }
            return _sqrt_recursion(n, iter + 2);
        }
        return iter;
    }

    static int is_prime_number(int n, int max = 0)
    {
        if (n <= 1)
        {
            return 0;
        }
        else if (max == 0)
        {
            max = n / 2;
        }
        else if (max == 1)
        {
            return 1;
        }
        if ((n % max == 0 && max > 0) || max <= 0)
        {
            return 0;
        }
        return is_prime_number(n, max - 1);
    }

    static int is_palindrome(string s, int iter = 0)
    {
        int len = _strlen_recursion(s);
        if (iter >= len/2)
        {
            return 1;
        }
        else if (s[iter] != s[len-iter-1])
        {
            return 0;
        }
        return is_palindrome(s, iter + 1);
    }
}