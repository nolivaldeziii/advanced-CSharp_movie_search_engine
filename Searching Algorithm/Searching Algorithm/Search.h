#pragma once

//#//include "C:\\Users\\Noli\\Dropbox\\Programming\\Projects\\Movie Search Engine\\Database\\Database\\Database.h"
#include "LinkList.h"
#include <ctime>
#include <fstream>
#include <algorithm>
#include <iostream>
#include <vector>
#include <conio.h>
#include <Windows.h>
#include <string>
#include <io.h>   // For access().
#include <sys/types.h>  // For stat().
#include <sys/stat.h>   // For stat().
#include <direct.h>
#include <sys/types.h>
#include <dirent.h>
#include <queue>
#include "C:\\Users\\Noli\\Dropbox\\Programming\\Projects\\Movie Search Engine\\MovieClass\\MovieClass\\Movie_Class.h"

using namespace std;

const int SUM_TABLE_SIZE = 100;
const int ALPHABETICAL_TABLE_SIZE = 27;

class Search
{
private:	
	vector<std::string> movieData;
	Link<char*> SumTable[SUM_TABLE_SIZE];
	Link<char*> AlphaTable[ALPHABETICAL_TABLE_SIZE];
	
	Link<int> subTableSum[SUM_TABLE_SIZE];
	Link<int> subAlphaSum[ALPHABETICAL_TABLE_SIZE];

	bool isAlphabet(char c);
	int getSum(char*);
	int getSum(std::string);
	vector<char*> ExplodeString(char*);
	void getMovie();

public:
	Search();
	void InitializeTable();
	std::queue<char*> SearchMovie(char*);
};