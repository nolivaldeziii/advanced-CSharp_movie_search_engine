// Database_wpr.h

#pragma once

#include "C:\\Users\Noli\\Dropbox\\Programming\\Projects\\Movie Search Engine\\Database\\Database\\Database.h"
#include "C:\\Users\Noli\\Dropbox\\Programming\\Projects\\Movie Search Engine\\Database\\Database\\Database.cpp"

using namespace System;

namespace Database_wpr {

	public ref class Database_wpr
	{
	private:
		int MovieCount;
		int UserCount;
		
		void CountData();
		void RetrieveMovies();

		char** MovieDataBase;
		char** UserDataBase;

		char** MovieHash;
	public:
		Database_wpr();
		char** GetMovieData();
		char** GetUserData();
		char** Search(char*);

		char* RelativePath(char*);

		bool DeleteUser(char* Username);
		
	};



}
