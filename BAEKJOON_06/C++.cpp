#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int a, b, c,d;
	scanf("%d %d", &a, &b);
	scanf("%d", &c);

	if (b+c >=60)
	{
		d = b + c;
		a += d / 60;
		b = d % 60;
		if (a>=24)
		{
			a -= 24;
		}

	}
	else if (b+c<60)
	{
		d = b + c;
		b = d;
	}
	printf("%d %d", a, b);

}