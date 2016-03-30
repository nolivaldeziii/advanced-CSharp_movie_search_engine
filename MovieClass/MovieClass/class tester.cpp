#include "Movie_Class.h"
#include <iostream>

void outall(Link<char*> Node);

int main()
 {

	 Movie test;
	 test.ReadData(".\\sampletest.txt");
	 std::cout << test.Title << endl;
	 outall(test.Genre);
	 outall(test.Tags);
	 outall(test.Writers);
	 outall(test.StarActors);
	 outall(test.Actors);
	 outall(test.Directors);
	 std::cout << test.Rating << endl
		 << test.Runtime << endl << test.Descriptions << endl;
	 

	 return 0;
 }

static void outall(Link<char*> Node)
{
	int i = 0;
	Node.ReadReset(true);
	while(Node.Good())
	{
		std::cout << Node.Read() << "|| ";
	}
	std::cout<<endl;
}