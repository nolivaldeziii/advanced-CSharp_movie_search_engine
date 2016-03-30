
#pragma once
#include <string>
#include "LinkList.cpp"

using namespace std;

class Movie
{
public:
	char *Title;
	Link<char*> Genre;
	Link<char*>  Tags;
	Link<char*>  Writers;
	Link<char*>  StarActors;
	Link<char*>  Actors;
	Link<char*> Directors;

	int Rating;
	int Runtime;
	char* Country;
	char* ReleaseDate;
	char* Language;
	char* Prequel; // movie title
	char* Sequel; // movie title

	char* Descriptions; // plot, descriptions, trivia

	char* Serial; //baka kailanganin sa search algorithm

	void LoopRead(Link<char*> &Node,ifstream &currStream, int &i);
	void LoopWrite(Link<char*> &Node,ofstream &currStream);
	void ReadOnce(char* &pChar,ifstream &currStream, int &i);

public:
	Movie();
	void GetTitle(char*);
	void GetGenre(char*);
	void GetTags(char*);
	void GetWriters(char*);
	void GetStarActors(char*);
	void GetActors(char*);
	void GetDirectors(char*);

	void GetRating(int);
	void GetRuntime(int);

	void GetReleaseDate(char*);
	void GetCountry(char*);
	void GetLanguage(char*);
	void GetPrequel(char*); // movie title
	void GetSequel(char*); // movie title

	void GetDescriptions(char*); // plot, descriptions, trivia

	void GetSerial(char*); //baka kailanganin sa search algorithm

	void GetData(char*);
	bool Writedata(char*);

	bool ReadData(char*);
};