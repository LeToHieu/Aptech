#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>
int x, y;

char getInputOneCharacter() {
	char choice;
	choice = getchar();
	while(choice == '\n') {
		choice = getchar();		
	}
	
	return choice;
}
void sum() {			
	printf("x = "); scanf("%d", &x);
	printf("y = "); scanf("%d", &y);
	printf("Tong = %d", x + y);
}
void minus() {			
	printf("x = "); scanf("%d", &x);
	printf("y = "); scanf("%d", &y);
	printf("Hieu = %d", abs(x - y)); //abs = absolute = lay gia tri tuyet doi
}
int main(){	
	//chua noi gi den tinh toan, hay lam menu da
	char choice;	
	while(choice != 'c' && choice != 'C' && choice != '3') {
		printf("1.Tinh tong\n");
		printf("2.Tinh hieu\n");			
		printf("3.Ket thuc\n");			
		printf("Moi ban chon 1,2,3:\n");
		choice = getInputOneCharacter();
		switch(choice) {
			case '1':
				printf("1.Tinh tong\n");
				sum();
				break;
			case '2':
				printf("2.Tinh hieu\n");	
				minus();		
				break;
			case '3':
				printf("3.Ket thuc\n");							
				break;
			default:
				break;
		}
		if(choice == '3'){
			continue;
		}
		printf("Ban co muon ket thuc(c,k) ?\n");
		choice = getInputOneCharacter();
		printf("haha");
	}
	printf("Chuong trinh da ket thuc\n");
	return 0;	
	
}

