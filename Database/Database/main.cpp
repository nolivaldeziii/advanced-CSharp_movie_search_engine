#include "Database.h"
#include <Windows.h>
#include <ctime>
#include <algorithm>
#include <iostream>
#include <chrono>

using namespace std;

int main()
{
	//system("pause");
	/*clock_t t1, t2;
	t1 = clock();
	Database my;
	t2 = clock();
	double time1 = (double)(t2-t1)/CLOCKS_PER_SEC*1000;

	cout << "\n cAll Movies:\n";
	for(int i = 0; i < my.AllMovieList.size();i++)
	{
	cout << my.AllMovieList[i] << endl;
	}
	cout << "All Users:\n";
	cout << time1 << " milisecons to gather data" << endl;
	enter:
	cout << "\nEnter Username: ";
	char* un = new char[1024];
	char a = 97;int i = 0;
	do
	{
	cin.get(a);
	un[i++]=a;
	}while (a != 10);

	un[--i] = '\0';

	t1 = clock();
	try
	{
	cout << endl << my.RetrieveMovie(un);
	}
	catch(exception e)
	{
	cout << e.what() << endl;
	goto enter;
	}
	t2 = clock();
	double time2 = (double)(t2-t1)/CLOCKS_PER_SEC*1000;

	cout << endl << "it took " << time2 << " miliseconds to search" << endl;
	cout << " and " <<  time1 << " milisecons to gather data" << endl;

	cout << "delete a file: ";
	i=0;
	do
	{
	cin.get(a);
	un[i++]=a;
	}while (a != 10);
	un[--i] = '\0';

	if(my.DeleteData(un,false))
	cout << "deleted!\n";
	else
	cout << "delete fail!";
	*/
	Database f;
	char* in = new char[80];
	do
	{
		cout <<" enter moovie: ";
		in = new char[80];
		char a;
		int i = 0;
		do
		{
			cin.get(a);
			in[i++]=a;
		}while (a != 10);
		in[--i] = '\0';
		Search e;
		cout << e.getSum(in)<<endl;
		queue<char*> result = f.SearchMovie(in);
		while(!result.empty())
		{
			cout << result.front() << endl;
			result.pop();
		}
	}
	while(in[0] != 0);

	return 0;
}