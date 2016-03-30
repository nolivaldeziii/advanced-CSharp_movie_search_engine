
#include <fstream>
#include <iostream>
#include "Movie_Class.h"

using namespace std;

Movie::Movie()
{
	Title = "</title>";
	Genre.Add("</genre>");
	Tags.Add("</tags>");
	Writers.Add("</writers>");
	StarActors.Add("</sActors>");
	Actors.Add("</actors>");
	Directors.Add("</directors>");
	Rating = 0;
	Country = " ";
	Language = " ";
	ReleaseDate = " ";
	Descriptions = "</descriptions>" ;

}

void Movie::GetData(char* movieTitle)
{
	//get movie data from filestream then save to the class
}

void Movie::GetTitle(char* pChar)
{
	Title = pChar;
	strcat(Title,"</title>");
}
void Movie::GetGenre(char* pChar)
{
	if(!Genre.IsEmpty())//clear link first
	{
		Genre.Clear();
	}

	char *tmp = new char[255];
	int j = 0;

	for(int i=0;pChar+i!=NULL;i++)
	{
		char _tmp = *(pChar+i);
		
		if( *(pChar+i) == ',' || *(pChar+i) == '\0' )//set comma as delimeter
		{
			*(tmp+(j))= ',';
			*(tmp+(j+1))= '\0';
			Genre.Add(tmp);
			tmp = new char[255];
			j = 0;

			if(*(pChar+i) == '\0')//break if char terminator is detected
				break;
		}
		if(_tmp != ',')
		{
			*(tmp+j) = _tmp;
			j++;
		}


	}
	Genre.Add("</genre>");

}


void Movie::GetTags(char* pChar)
{
	if(!Tags.IsEmpty())//clear link first
	{
		Tags.Clear();
	}

	char *tmp = new char[255];
	int j = 0;

	for(int i=0;pChar+i!=NULL;i++)
	{
		char _tmp = *(pChar+i);
		
		if( *(pChar+i) == ',' || *(pChar+i) == '\0' )//set comma as delimeter
		{
			*(tmp+(j))= ',';
			*(tmp+(j+1))= '\0';
			Tags.Add(tmp);
			tmp = new char[255];
			j = 0;

			if(*(pChar+i) == '\0')//break if char terminator is detected
				break;
		}
		if(_tmp != ',')
		{
			*(tmp+j) = _tmp;
			j++;
		}


	}
	Tags.Add("</tags>");
}
void Movie::GetWriters(char* pChar)
{
	if(!Writers.IsEmpty())//clear link first
	{
		Writers.Clear();
	}

	char *tmp = new char[255];
	int j = 0;

	for(int i=0;pChar+i!=NULL;i++)
	{
		char _tmp = *(pChar+i);
		
		if( *(pChar+i) == ',' || *(pChar+i) == '\0' )//set comma as delimeter
		{
			*(tmp+(j))= ',';
			*(tmp+(j+1))= '\0';
			Writers.Add(tmp);
			tmp = new char[255];
			j = 0;

			if(*(pChar+i) == '\0')//break if char terminator is detected
				break;
		}
		if(_tmp != ',')
		{
			*(tmp+j) = _tmp;
			j++;
		}


	}
	Writers.Add("</writer>");
}
void Movie::GetStarActors(char* pChar)
{
	if(!StarActors.IsEmpty())//clear link first
	{
		StarActors.Clear();
	}

	char *tmp = new char[255];
	int j = 0;

	for(int i=0;pChar+i!=NULL;i++)
	{
		char _tmp = *(pChar+i);
		
		if( *(pChar+i) == ',' || *(pChar+i) == '\0' )//set comma as delimeter
		{
			*(tmp+(j))= ',';
			*(tmp+(j+1))= '\0';
			StarActors.Add(tmp);
			tmp = new char[255];
			j = 0;

			if(*(pChar+i) == '\0')//break if char terminator is detected
				break;
		}
		if(_tmp != ',')
		{
			*(tmp+j) = _tmp;
			j++;
		}


	}
	StarActors.Add("</sActor>");
}
void Movie::GetActors(char* pChar)
{
	if(!Actors.IsEmpty())//clear link first
	{
		Actors.Clear();
	}

	char *tmp = new char[255];
	int j = 0;

	for(int i=0;pChar+i!=NULL;i++)
	{
		char _tmp = *(pChar+i);
		
		if( *(pChar+i) == ',' || *(pChar+i) == '\0' )//set comma as delimeter
		{
			*(tmp+(j))= ',';
			*(tmp+(j+1))= '\0';
			Actors.Add(tmp);
			tmp = new char[255];
			j = 0;

			if(*(pChar+i) == '\0')//break if char terminator is detected
				break;
		}
		if(_tmp != ',')
		{
			*(tmp+j) = _tmp;
			j++;
		}

	}
	Actors.Add("</actors>");
}
void Movie::GetDirectors(char* pChar)
{
	if(!Directors.IsEmpty())//clear link first
	{
		Directors.Clear();
	}

	char *tmp = new char[255];
	int j = 0;

	for(int i=0;pChar+i!=NULL;i++)
	{
		char _tmp = *(pChar+i);
		
		if( *(pChar+i) == ',' || *(pChar+i) == '\0' )//set comma as delimeter
		{
			*(tmp+(j))= ',';
			*(tmp+(j+1))= '\0';
			Directors.Add(tmp);
			tmp = new char[255];
			j = 0;

			if(*(pChar+i) == '\0')//break if char terminator is detected
				break;
		}
		if(_tmp != ',')
		{
			*(tmp+j) = _tmp;
			j++;
		}

	}
	Directors.Add("</director>");
}
void Movie::GetRating(int var)
{
	Rating = var;
}
void Movie::GetPrequel(char* pChar) // Wag nalang munang pansinin haha,, tangal muna pati sequel...
{
	Prequel = pChar;
} 
void Movie::GetSequel(char* pChar)
{
	Sequel = pChar;
}
void Movie::GetRuntime(int var)
{
	Runtime = var;
}
void Movie::GetCountry(char* pChar)
{
	Country = pChar;
}
void Movie::GetLanguage(char* pChar)
{
	Language = pChar;
}
void Movie::GetReleaseDate(char* pChar)
{
	ReleaseDate = pChar;
}
void Movie::GetDescriptions(char* pChar)
{
	Descriptions = pChar;
}

bool Movie::Writedata(char* Location)
{
	ofstream outdata(Location);//includeing filename and extension

	outdata << Title;

	LoopWrite(Genre,outdata);
	LoopWrite(Tags,outdata);
	LoopWrite(Writers,outdata);
	LoopWrite(StarActors,outdata);
	LoopWrite(Actors,outdata);
	LoopWrite(Directors,outdata);
	
	outdata << Rating << "</rating>";
	outdata << Runtime << "</runtime>";
	outdata << Country << "</country>";
	outdata << Language << "</language>";
	outdata << ReleaseDate << "</releaseDate>";
	outdata << Descriptions << "</descriptions>";

	outdata.close();
	return true;
}

void Movie::LoopWrite(Link<char*> &Node,ofstream &currStream)
{
	Node.ReadReset(true);
	while(Node.Good())
	{
		currStream << Node.Read();
	}
}

bool Movie::ReadData(char* location)
{

	ifstream readMovie(location);
	if(!readMovie.is_open())
	{
		return false;
	}
	int i;
	
		ReadOnce(Title,readMovie,i);
		LoopRead(Genre,readMovie,i);
		LoopRead(Tags,readMovie,i);
		LoopRead(Writers,readMovie,i);
		LoopRead(StarActors,readMovie,i);
		LoopRead(Actors,readMovie,i);
		LoopRead(Directors,readMovie,i);
		{
			//manual reading to kasi int ung data type
			//hindi pwedeng ipasok sa loopread function ^_^
			//read rating
			char *tmp = new char[32];
			tmp[0] = ' ';
			for(i = 0; readMovie.peek() != '<'; i++)
			{
				tmp[i] = readMovie.get();
			}
			tmp[i] = '\0'; 

			Rating = (int)tmp; // may probleama sa casting
			while(readMovie.peek() != '>')
			{
				readMovie.get();
			}readMovie.get();
			//read runtime
			tmp = new char[32];
			tmp[0] = ' ';
			for(i = 0; readMovie.peek() != '<'; i++)
			{
				tmp[i] = readMovie.get();
			}
			tmp[i] = '\0'; 
			Runtime = (int)tmp;
			while(readMovie.peek() != '>')
			{
				readMovie.get();
			}readMovie.get();
		}
		ReadOnce(Country,readMovie,i);
		ReadOnce(Language,readMovie,i);
		ReadOnce(ReleaseDate,readMovie,i);
		ReadOnce(Descriptions,readMovie,i);

	readMovie.close();
	return true;
}

void Movie::LoopRead(Link<char*> &Node,ifstream &currStream, int &i)
{
	//read data
		Node.Clear();
		char *tmp = new char[1024];
		tmp[0] = ' ';
		for(i = 0; currStream.peek() != '<'; i++)
		{
			if( currStream.peek() == ',')
			{
				currStream.get();
				tmp[i] = '\0';
				Node.Add(tmp);
				i = -1;
				tmp = new char[1024];
			}
			else
			{
				tmp[i] = currStream.get();
			}
			
		}
		while(currStream.peek() != '>')
		{
			currStream.get();
		}currStream.get();
}

void Movie::ReadOnce(char* &pChar,ifstream &currStream, int &i)
{
	char *tmp = new char[1024];
	
		//read title
		tmp[0] = ' ';
		for(i = 0; currStream.peek() != '<'; i++)
		{
			tmp[i] = currStream.get();
		}
		tmp[i] = '\0'; 
		pChar = tmp;
		while(currStream.peek() != '>')
		{
			currStream.get();
		}currStream.get();
}
