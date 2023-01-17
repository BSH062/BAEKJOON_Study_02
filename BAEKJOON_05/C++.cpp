#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int a, b;
	scanf("%d %d", &a, &b);

	if (b >= 45)
	{
		b -= 45;
		a--;
	}
	
	else if (b < 45)
	{
		if (a == 0)
		{
			a += 23;
			b = b + (60 - 45);
		}
		else
		{
			a--;
			b = b + (60 - 45);
		}
	}
	printf("%d %d", a, b);
}