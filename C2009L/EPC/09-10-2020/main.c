#include <stdio.h>
#include <stdlib.h>
//stdio = standard input / output
//standard library, h = header
//int = integer = so nguyen

int sum2Numbers(int x, int y){
	//than ham = block	
	return x + y;
}
//check odd or even ?
void checkEvenNumber() {
	int numberA;//an integer variable
	printf("Enter an integer number:\n"); scanf("%d", &numberA);
	int remains = numberA % 2;
	if(remains == 0) {
		printf("This is even");
	} else {
		printf("This is odd");
	}
}
void chepPhat() {
	int count = 1;
	while(count <= 1000) {
		printf("I say hello - %d \n", count);
		count = count + 1;
	}
	printf("Chep phat xong");
}
int main(int argc, char *argv[]) {
	chepPhat();
	//Goi ham tinh tong hai so 
	printf("Chuong trinh tinh tong 2 so\n");//\n = returN
	int sum = sum2Numbers(1,4);
	//In ket qua ra man hinh
	printf("Tong 2 so la : %d", sum);
	//Lenh gan == assign
	int x = 100;
	int y = 200;
	x = x + 1;
	printf("Gia tri cua x = %d",x);
	checkEvenNumber();
	return 0;
	//Ham main, neu thanh cong thi return 0, nguoc lai thi khac 0
	/*
	Day la 1 chuong trinh don gian
	tinh tong hai  so
	*/
	
} 
