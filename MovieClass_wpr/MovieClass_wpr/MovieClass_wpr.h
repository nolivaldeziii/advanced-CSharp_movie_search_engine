// MovieClass_wpr.h

#pragma once

#include "C:\Users\Noli\Dropbox\Programming\Projects\Movie Search Engine\MovieClass\MovieClass\Movie_Class.h"
#include "C:\Users\Noli\Dropbox\Programming\Projects\Movie Search Engine\MovieClass\MovieClass\Movie_Class.cpp"
using namespace System;

namespace MovieClass_wpr {

	public ref class Movie_wpr
	{
	public:
		// TODO: Add your methods for this class here.

		void GetTitle(char*);//pang kuha ng data para mamaya ipasa sa managed papuntang unmanage
		void GetGenre(char*);
		
		void GetTags(char*);
		void GetWriters(char*);
		void GetS_Actors(char*);
		void GetActors(char*);
		void GetDirectors(char*);
		void GetRating(int);
		void GetRuntime(int);
		void GetCountry(char*);
		void GetLanguage(char*);
		void GetReleaseDate(char*);
		void GetDescriptions(char*);
		
		void Save(char*);

		void Read(char*);

	public:
		char* title;
		char* genre;
		char* tags;
		char* writers;
		char* sActors;
		char* actors;
		char* directors;
		int rating;
		int runtime;
		char* country;
		char* language;
		char* releasedate;
		char* descriptions;


	};
}
