// This is the main DLL file.

#include "stdafx.h"

#include "MovieClass_wpr.h"
#include "C:\Users\Noli\Dropbox\Programming\Projects\Movie Search Engine\MovieClass\MovieClass\Movie_Class.h"
#include "C:\Users\Noli\Dropbox\Programming\Projects\Movie Search Engine\MovieClass\MovieClass\LinkedList.h"


void MovieClass_wpr::Movie_wpr::GetTitle(char* pChar)
{
	title = pChar;
}
void MovieClass_wpr::Movie_wpr::GetGenre(char* pChar)
{
	genre = pChar;
}
void MovieClass_wpr::Movie_wpr::GetTags(char* pChar)
{
	tags = pChar;
}
void MovieClass_wpr::Movie_wpr::GetWriters(char* pChar)
{
	writers = pChar;
}
void MovieClass_wpr::Movie_wpr::GetS_Actors(char* pChar)
{
	sActors = pChar;
}
void MovieClass_wpr::Movie_wpr::GetActors(char* pChar)
{
	actors = pChar;
}
void MovieClass_wpr::Movie_wpr::GetDirectors(char* pChar)
{
	directors = pChar;
}
void MovieClass_wpr::Movie_wpr::GetRating(int var)
{
	rating = var;
}
void MovieClass_wpr::Movie_wpr::GetRuntime(int var)
{
	runtime = var;
}
void MovieClass_wpr::Movie_wpr::GetCountry(char* pChar)
{
	country = pChar;
}
void MovieClass_wpr::Movie_wpr::GetLanguage(char* pChar)
{
	language = pChar;
}
void MovieClass_wpr::Movie_wpr::GetReleaseDate(char* pChar)
{
	releasedate = pChar;
}
void MovieClass_wpr::Movie_wpr::GetDescriptions(char* pChar)
{
	descriptions = pChar;
}
char* tmp;
void MovieClass_wpr::Movie_wpr::Save(char* Location)
{
	Movie newMovie;//ipasa dito ung mga data na save sa wrapper papuntang unmanaged
	newMovie.GetTitle(title);
	newMovie.GetGenre(genre);
	newMovie.GetTags(tags);
	newMovie.GetWriters(writers);
	newMovie.GetActors(actors);

	newMovie.GetStarActors(sActors);// nakalimutan kong ilagay ^_^ ngayon ko lang nakita sorry haha

	newMovie.GetDirectors(directors);
	newMovie.GetRating(rating);
	newMovie.GetRuntime(runtime);
	newMovie.GetCountry(country);
	newMovie.GetLanguage(language);
	newMovie.GetReleaseDate(releasedate);
	newMovie.GetDescriptions(descriptions);

	newMovie.Writedata(Location);

}

void MovieClass_wpr::Movie_wpr::Read(char* location)
{
	Movie readMovie;
	readMovie.ReadData(location);
	int i = 0;

	title = readMovie.Title;
	rating = readMovie.Rating;
	runtime = readMovie.Runtime;
	country = readMovie.Country;
	language = readMovie.Language;
	releasedate = readMovie.ReleaseDate;
	descriptions = readMovie.Descriptions;

	directors = new char[128];i=0;
	readMovie.Directors.ReadReset(true);
	while(readMovie.Directors.Good())
	{
		char* tmp = readMovie.Directors.Read();
		for(int j = 0; tmp[j] != NULL;j++)
		{
			directors[i++] = tmp[j];
		}
		directors[i++] = ',';
	}
	directors[i] = '\0';

	sActors = new char[128];i=0;
	readMovie.StarActors.ReadReset(true);
	while(readMovie.StarActors.Good())
	{
		char* tmp = readMovie.StarActors.Read();
		for(int j = 0; tmp[j] != NULL;j++)
		{
			sActors[i++] = tmp[j];
		}
		sActors[i++] = ',';
	}
	sActors[i] = '\0';

	actors = new char[128];i=0;
	readMovie.Actors.ReadReset(true);
	while(readMovie.Actors.Good())
	{
		char* tmp = readMovie.Actors.Read();
		for(int j = 0; tmp[j] != NULL;j++)
		{
			actors[i++] = tmp[j];
		}
		actors[i++] = ',';
	}
	actors[i] = '\0';

	writers = new char[128];i=0;
	readMovie.Writers.ReadReset(true);
	while(readMovie.Writers.Good())
	{
		char* tmp = readMovie.Writers.Read();
		for(int j = 0; tmp[j] != NULL;j++)
		{
			writers[i++] = tmp[j];
		}
		writers[i++] = ',';
	}
	writers[i] = '\0';

	tags = new char[128];i=0;
	readMovie.Tags.ReadReset(true);
	while(readMovie.Tags.Good())
	{
		char* tmp = readMovie.Tags.Read();
		for(int j = 0; tmp[j] != NULL;j++)
		{
			tags[i++] = tmp[j];
		}
		tags[i++] = ',';
	}
	tags[i] = '\0';

	genre = new char[128];i=0;
	readMovie.Genre.ReadReset(true);
	while(readMovie.Genre.Good())
	{
		char* tmp = readMovie.Genre.Read();
		for(int j = 0; tmp[j] != NULL;j++)
		{
			genre[i++] = tmp[j];
		}
		genre[i++] = ',';
	}
	genre[i] = '\0';

}

