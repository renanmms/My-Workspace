#include <iostream>
#include <cstdio>

int main(void){

	int a,b;
	FILE * pFile;

	pFile = fopen("arquivo.txt","w+");
	

	fscanf(pFile, "%d", &a);
	fscanf(pFile, "%d", &b);
	std::dec;
	printf("%d", a);
	printf("%d", b);
	fclose(pFile);

	return 0;
}
