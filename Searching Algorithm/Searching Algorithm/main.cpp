#include "Search.h"

int main()
{
	Search movSearch;
	char* epic = new char[80];
	do
	{
		cin>>epic;
		queue<char*>wew = movSearch.SearchMovie(epic);
		for(int i = 0 ; i < wew.size();i++)
		{
			cout << wew.front() << endl;
			wew.pop();
		}
	}while(epic[0] != '0');
	system("pause<0");
	return 0;
}