#pragma once

#include <ctime>
#include <fstream>
#include <algorithm>
#include <iostream>
#include <vector>
#include <queue>

#include <conio.h>
#include <Windows.h>
#include <string>
#include <io.h>   // For access().
#include <sys/types.h>  // For stat().
#include <sys/stat.h>   // For stat().
#include <direct.h>
#include <sys/types.h>
#include <dirent.h>

#include "C:\\Users\\Noli\\Dropbox\\Programming\\Projects\\Movie Search Engine\\MovieClass\\MovieClass\\Movie_Class.h"
#include "SearchingTools.h"

class Database
{
private:
	char* MainFolder; // working directory is where the main.exe is
	char* MovieFolder;
	char* UserFolder;
	char* UserDataLocation;
	char* MovieDataLocation;

	char* checkMovieLoc;
	char* checkUserLoc;

	double TimeElapsed_Movie;
	double TimeElapsed_User;
	double TimeElapsed_GatherData;
	bool checkPath(string);

	//from cplus plus . com
	std::vector <std::string> CheckDirectory(/* const std::string&*/ char* path);

public:
	Database();
	vector<std::string> AllMovieList; //title only
	vector<std::string> AllUserList; // usernames only
	char* LastUpdate;

	bool DataFilled;

	//runs the check dir again
	double refreshData();
	//returns absolute path of movie if there is and return time
	//else return null..
	char* RetrieveMovie(char*);
	//returns absolute path of user if there is.
	//else return null..
	char* RetrieveUser(char*);
	//delete a file
	//write true if movie else user
	bool DeleteData(char*,bool IsMovie);
	bool IsUpdate(char*);
	void checkFolder();

	std::queue<char*> SearchMovie(char*);

};