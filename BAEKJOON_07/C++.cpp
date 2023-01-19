#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int a[4];
	int total;
	scanf("%d %d %d", &a[0], &a[1], &a[2]);
	if (a[0] == a[1] && a[1] == a[2])
	{
		total = 10000 + (a[0] * 1000);
	}
	else if (a[0] == a[1] || a[1] == a[2] || a[0] == a[2])
	{
		if (a[0] == a[1] || a[0] == a[2])
		{
			a[3] = a[0];
		}
		else
		{
			a[3] = a[1];
		}
		total = 1000 + (a[3] * 100);
	}
	else
	{
		for (int i = 0; i < 4; i++)
		{
			if (a[i]>a[3])
			{
				a[3] = a[i];
			}
		}
		total = a[3] * 100;
	}
	printf("%d", total);
}