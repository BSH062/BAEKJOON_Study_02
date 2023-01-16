#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int a;

	scanf("%d", &a);

	if (a>=90)
	{
		printf("A");
	}
	else if (89 <= a || a>= 80)
	{
		printf("B");
	}
	else if (79 <= a|| a >= 70)
	{
		printf("C");
	}
	else if (69 <= a|| a >= 60)
	{
		printf("D");
	}
	else
	{
		printf("F");
	}
}