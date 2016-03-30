// This is the main DLL file.

#include "stdafx.h"

#include "Database_wpr.h"
#include <vector>
#include <queue>
#include <string>

char* Str2Char(std::string str)
{
	char* c = new char[str.size()];
	for(int i = 0; i < str.size() ; i ++)
	{
		c[i] = str[i];
	}
	c[str.size()] = '\0';
	return c;
}

Database_wpr::Database_wpr::Database_wpr()
{
	CountData();
	MovieDataBase = new char*[MovieCount];
	UserDataBase = new char*[UserCount];

	RetrieveMovies();

}

char* Database_wpr::Database_wpr::RelativePath(char* pChar)
{
	Database getRelative;
	return getRelative.RetrieveMovie(pChar);
}
bool Database_wpr::Database_wpr::DeleteUser(char* Username)
{
	Database rmvuser;
	if(rmvuser.DeleteData(Username,false))
		return true;
	else
		return false;
}

void Database_wpr::Database_wpr::RetrieveMovies()
{
	Database storeData;
	std::vector<std::string> movtmp = storeData.AllMovieList;
	for(int i = 0; i < MovieCount ; i++)
	{
		MovieDataBase[i] = Str2Char( movtmp[i] );
	}
}

void Database_wpr::Database_wpr::CountData()
{
	Database peekData;
	MovieCount = peekData.AllMovieList.size();
	UserCount = peekData.AllUserList.size();
}

char** Database_wpr::Database_wpr::GetMovieData()
{
	return MovieDataBase;
}

char** Database_wpr::Database_wpr::GetUserData()
{
	return UserDataBase;
}
char** Database_wpr::Database_wpr::Search(char* pChar)
{
	Database search;
	queue<char*> result = search.SearchMovie(pChar);
	char** toreturn = new char*[result.size()];
	int i;
	for( i=0;!result.empty();i++)
	{
		toreturn[i] = new char[80];
		toreturn[i] = result.front();
		result.pop();
	}
	toreturn[i] = NULL;
	return toreturn;
}