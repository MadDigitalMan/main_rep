#include <iostream>
using namespace std;
int main() {
	setlocale(LC_ALL, "Russian");
	  long int a, b, n;
	cout << "������� ������ ��������: " << endl;
	cin >> a;
	cout << "������� ������ ��������: " << endl;
	cin >> b;
	cout << "�������� �������� ��� ����������: \n1 - �������� \n2 - ��������� \n3 - ������������ \n4 - �������" << endl;
	cin >> n;
	switch (n) {
	case 1:
		cout << "��������� �������� �����: " << a + b << endl;
		break;
	case 2:
		cout << "��������� ��������� �����: " << a - b << endl;
		break;
	case 3:
		cout << "��������� ��������� �����: " << a * b << endl;
		break;
	case 4:
		cout << "��������� ������� �����: " << a / b << endl;
		break;
	default:
		cout << "���..����������� ��������" << endl;
		break;


	}
}
	