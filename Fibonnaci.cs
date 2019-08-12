//Fibonacci (as example of Dynamic Programming)
//The typical solution is using recursion, but uses a lot of space and time
int fib(int n) 
{ 
	if (n <= 1) 
		return n; 
	return fib(n-1) + fib(n-2); 
}
	
//A better solution uses dynamic programming 
//Also we only store the latest value
static int Fibonacci(int n)
{
	var fib0 = 0;
	var fib1 = 1;
	var fib = 0;
	for (int i = 2; i <= n; i++)
	{
		fib = fib0 + fib1;
		fib0 = fib1;
		fib1 = fib;
	}

	return n == 0 ? 0 : fib1;
}