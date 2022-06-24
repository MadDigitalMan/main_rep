#include <iostream>
using namespace std;
int main() {
	setlocale(LC_ALL, "Russian");
	  long int a, b, n;
	cout << "Введите первое значение: " << endl;
	cin >> a;
	cout << "Введите второе значение: " << endl;
	cin >> b;
	cout << "Выберите операцию над значениями: \n1 - сложение \n2 - вычитание \n3 - произведение \n4 - деление" << endl;
	cin >> n;
	switch (n) {
	case 1:
		cout << "Результат сложения равен: " << a + b << endl;
		break;
	case 2:
		cout << "Результат вычитания равен: " << a - b << endl;
		break;
	case 3:
		cout << "Результат умножения равен: " << a * b << endl;
		break;
	case 4:
		cout << "Результат деления равен: " << a / b << endl;
		break;
	default:
		cout << "Упс..неизвестная операция" << endl;
		break;


	}
}
	