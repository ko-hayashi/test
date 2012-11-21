#include	<stdio.h>


extern	int	func_a();
static	int	func_b();

int	main()
{
	int	i;
	
	printf("Hello world.\n");
	
	for(i = 0; i < 100; i ++){
		printf("loop %d\n", i);
	}
	
	return	0;
}

static	int	func_b()
{
	return	100;
}