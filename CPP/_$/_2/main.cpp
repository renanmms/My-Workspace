#include <iostream>

double pow(double x, int y);
void printSquare(double);

int main(){
	double x;
	std::cin >> x;
	printSquare(x);
	

	return 0;
}

void printSquare(double x){
	std::cout << pow(x,2) << std::endl;
}

double pow(double x, int y){
	if(y==0){
		return 1;
	}
	return x*pow(x, y-1);
}
