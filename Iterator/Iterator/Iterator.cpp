// Iterator.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

class Cont
{
	int *array = new int[];
	int iarr;
public:
	friend class ContIter;
	Cont()
	{
		iarr = -1;
	}
	void push(int in)
	{
		array[++iarr] = in;
	}
	int pop()
	{
		return array[iarr--];
	}
	bool isEmpty()
	{
		return (iarr == -1);
	}
};

class ContIter
{
	const Cont &cnt;
	int index;
public:
	ContIter(const Cont &s) : cnt(s)
	{
		index = 0;
	}
	void operator++()
	{
		index++;
	}
	bool operator()()
	{
		return index != cnt.iarr + 1;
	}
	int operator *()
	{
		return cnt.array[index];
	}
};

bool operator == (const Cont &f, const Cont &s)
{
	ContIter citf(f), cits(s);
	for (citf(); cits(); ++citf, ++cits)
		if (*citf != *cits)
			break;
	return !citf() && !cits();
}
bool operator != (const Cont &f, const Cont &s)
{
	ContIter citf(f), cits(s);
	for (citf(); cits(); ++citf, ++cits)
		if (*citf != *cits)
			break;
	return !(!citf() && !cits());
}

int main()
{
	Cont c1;
	cout << "Stack is empty? " << c1.isEmpty() << endl;
	int i;
	for (i = 1; i < 5; i++)
		c1.push(i);
	cout << "Stack is empty? " << c1.isEmpty() << endl;
	Cont c2(c1), c3(c1);
	c3.pop();
	cout << "1 == 2 is " << (c1 == c2) << endl;
	cout << "1 != 2 is " << (c1 != c2) << endl;
	cout << "1 == 3 is " << (c1 == c3) << endl;
	cout << "1 != 3 is " << (c1 != c3) << endl;
	system("pause");
}

