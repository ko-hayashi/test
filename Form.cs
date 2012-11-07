#include	<stdio.h>


static	int	func_a();

int	main()
{
	int	i;
	
	printf("Hello world.\n");
	
	for(i = 0; i < 100; i ++){
		printf("loop %d\n", i);
	}
	
	return	0;
}


static	int	func_a()
{
	return	0;
}