#include	<stdio.h>


#define	APL_S_SUCCESS	0x00000000


extern	int	func_a();
static	int	func_b();

int	main()
{
	int	i;
	
	printf("Hello world.\n");
	
	for(i = 0; i < 100; i ++){
		printf("loop %d\n", i);
	}
	
	return	APL_S_SUCCESS;
}

static	int	func_b()
{
	return	100;
}