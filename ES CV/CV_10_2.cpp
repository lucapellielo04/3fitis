// Alessio Modonesi 3F 03/11/2020
#include <iostream>
using namespace std;

int main() {
	
  int a = 0; // numero in base 10
	string b = ""; // stringa che indica il valore nel sistama binario

	cout << "Inserisci un numero decimale \n";
	cin >> a;
	
	while (a > 0) { // verificare che a sia > 0

		if (a % 2 == 0) { // se il resto di a:2 è = 0
			b = '0'+ b; // aggiungi uno 0 alla stringa b
    }

    else { // se il resto di a:2 è != o
			b = '1' + b; // aggiungi un 1 alla stringa b
    }

		a = a / 2; // esegui a:2 
  
  }
   cout << "Il numero è \n" << b;	  
}	