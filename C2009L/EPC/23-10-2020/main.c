#include <stdio.h>
#include <stdlib.h>
#include "calculation.h"
int someIntegers[5];
int N;

void printResult() {
	int i;
	for(i = 0; i < N; i++){
		printf("Element %d is %d\n", i, someIntegers[i]);
	}
}
void sortAnArray() {
	printf("Sorting an array\n");
}
void createMenu() {
	int choice;
	do {
		printf("Enter your choice: \n"); scanf("%d", &choice);
		switch(choice) {
			case 1: 
				sortAnArray();
				break;
			default:
				break;
		}		
	}while(choice != 3);

}
int main() {
	//Test of moduling in C
	/*
	printf("Test of \"sum\" function");
	printf("Sum 2 and 3 is : %d\n", sum(2,3));
	doNothing();
	*/	
	createMenu();
}
