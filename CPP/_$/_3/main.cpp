#include <iostream>
#include <vector>

using namespace std;

int main(){
	
	vector<int> i(5);

	i.assign(5, 1);

	for(int j = 0; j < 5; j++){
		cout << i[j] << endl;
		
	}

	
	

		




	return 0;
}
