#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
using namespace std;

//tinh chu vi
float getPerimeter(float radius) {
	return 2 * M_PI * radius;	
}

float getArea(float radius) {
	return pow(radius, 2) * M_PI; //pow = power
}
float convertCelciusToFarenheit(float celcius)  {
	return celcius * (9.00/5.00) + 32.0;
}
int main(int argc, char *argv[]) {
	float celcius, farenheit;
	cout<<"Enter celcius :"<<endl;
	cin>>celcius;
	farenheit = convertCelciusToFarenheit(celcius);
	cout<<"Farenheit = "<<farenheit;
	
	float radius;//gia tri la 0.0
	printf("Enter radius : "); scanf("%f", &radius);
	//Goi ham va tinh toan
	float perimeter = getPerimeter(radius);
	//Hien thi chu vi	
	float area = getArea(radius);
	printf("Perimeter is : %0.2f, \n Area is : %0.2f", perimeter, area);
	//string format/interpolation/template
	float age, salary;
	printf("Enter your age : "); scanf("%f", &age);
	printf("Enter your salary : "); scanf("%f", &salary);
	printf("Your salary is : %0.2f, your age is: %0.2f\n", salary, age);
	cout<<"Your salary is "<<salary<<", your age is: "<<age<<endl;
	
	
	return 0;
}
