// Adapter.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

class CScale
{
public:
	float getCTemp() {
		float t = 0;
		std::cout << "Введите температуру в Цельсиях: ";
		std::cin >> t;
		return t;
	}
};

class Scale
{
public:
	virtual ~Scale() {}
	virtual float getTemp() = 0;
};

class Adapter : public Scale
{
private:
	CScale* ptr_cscale;

public:
	Adapter(CScale* ptr) : ptr_cscale(ptr) {
	}
	~Adapter() {
		delete ptr_cscale;
	}
	float getTemp() {
		float buf = ptr_cscale->getCTemp() * 9.0 / 5.0 + 32;
		return buf;
	}
};

int main()
{
	setlocale(LC_ALL, "Russian");
	Scale* ptr = new Adapter(new CScale);
	std::cout << "Температура в Фаренгейтах = " << ptr->getTemp() << endl;
	delete ptr;
	system("pause");
	return 0;
}

