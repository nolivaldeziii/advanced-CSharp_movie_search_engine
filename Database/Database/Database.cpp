

#include "Database.h"


using namespace std;

Database::Database()
{
	MainFolder = ".\\Database\\";
	MovieFolder = ".\\Database\\Movie\\";
	UserFolder = ".\\Database\\User\\";
	UserDataLocation = ".\\Database\\User\\AllUser.txt";
	MovieDataLocation = ".\\Database\\Movie\\AllMovie.txt";

	checkMovieLoc = ".\\checkMovie\\";
	checkUserLoc = ".\\checkUser\\";
	
	checkPath(MainFolder);
	checkPath(MovieFolder);
	checkPath(UserFolder);
	//checkPath(checkMovieLoc);
	//checkPath(checkUserLoc);
	
	AllMovieList = CheckDirectory(MovieFolder);
	AllUserList = CheckDirectory(UserFolder);

}

queue<char*> Database::SearchMovie(char* str)
{
	int test;
	string strTest;
	Search e;
	queue<char*> result;
	const int SUM_TABLE_SIZE = 100;
	Link<char*> SumTable[SUM_TABLE_SIZE];
	Link<int> subTableSum[SUM_TABLE_SIZE];

	for(int i=0;i < SUM_TABLE_SIZE;i++)
	{
		SumTable[i].Clear();
		subTableSum[i].Clear();
	}
	for(int i=0;i<AllMovieList.size();i++)
	{
		test = e.getSum(AllMovieList[i]) % SUM_TABLE_SIZE;
		SumTable[e.getSum(AllMovieList[i]) % SUM_TABLE_SIZE].Add(e.str2char(AllMovieList[i]));
		std::vector<char*> expl = e.ExplodeString(e.str2char(AllMovieList[i]));

		for(int j=0;j<expl.size(); j++)
		{
			test = e.getSum(AllMovieList[i]) % SUM_TABLE_SIZE;
			if(!subTableSum[e.getSum(AllMovieList[i]) % SUM_TABLE_SIZE].Existing(e.getSum(expl[j])))
			{
				subTableSum[e.getSum(AllMovieList[i]) % SUM_TABLE_SIZE].Add(e.getSum(expl[j]));
			}
		}
	}

	char* curr;
	vector<char*> expl = e.ExplodeString(str);
	vector<int> explData;
	int sum = e.getSum(str) % SUM_TABLE_SIZE;

	for(int i = 0; i< expl.size(); i++)
	{
		test = e.getSum(expl[i]);
		explData.push_back(e.getSum(expl[i]));
	}
	SumTable[sum].ReadReset(true);
	while(SumTable[sum].Good())
	{
		curr = SumTable[sum].Read();
		if(!strcmp(curr,str))//wtf? pumkapasok sya kapag di mag kaiba ung string pero kapag same nag ffalse? gago ba to?lalag yan ko ng "!"
		{
			result.push(curr);
		}
	}

	for(int i = 0 ; i < SUM_TABLE_SIZE; i++)
	{
		if(!SumTable[i].IsEmpty())
		{
			for(int j=0;j<explData.size();j++)
			{
				test = explData[j];
				if(subTableSum[i].Existing(explData[j]))
				{
					SumTable[i].ReadReset(true);
					while(SumTable[i].Good())
					{
						curr = SumTable[i].Read();
						vector<char*> expl2 = e.ExplodeString(curr);
						for(int k = 0; k < expl2.size();k++)
						{
							char* two = e.ToLower(expl2[k]);
							char* one = expl[j];
							if(!strcmp(one,two))
							{
								result.push(curr);
								break;
							}
							else
							{
								if(e.sumNear(two,one,125))
								{
									result.push(curr);
									break;
								}
							}
						}
					}
				}
			}
		}
	}



	return result;
}

std::vector <std::string> Database::CheckDirectory( char* path/*const std::string& path = std::string() */)
  {
	   DIR *dir;
  struct dirent *entry;
  vector<std::string> result;

  if ((dir = opendir(path)) == NULL)
  {
    //perror("opendir() error");
  }
  else 
  {
    //puts("contents of root:");
    while ((entry = readdir(dir)) != NULL)
	{
		if(entry->d_name[0] != '.')
		{
			char* tmp = (entry->d_name);
			string tmp2=tmp;
			tmp[tmp2.size()-4] = '\0'; 
		
			result.push_back(tmp);
		}
      //printf("  %s\n", entry->d_name);
	}
    closedir(dir);
	return result;
  }

  /*std::vector <std::string> result;
  dirent* de;
  DIR* dp;
  errno = 0;
  dp = opendir( path.c_str() );
  if (dp)
    {
    while (true)
      {
      errno = 0;
      de = readdir( dp );
      if (de == NULL) break;
	  if(!std::string( de->d_name )[0] == '.' || !std::string( de->d_name )[1] == '.')
	  {
		result.push_back( std::string( de->d_name ) );
	  }
      }
    closedir( dp );
    std::sort( result.begin(), result.end() );
    }
  return result;*/
  }

bool Database::checkPath(string strPath)
{
	if ( _access( strPath.c_str(), 0 ) == 0 )
   {
      struct stat status;
      stat( strPath.c_str(), &status );

      if ( status.st_mode & S_IFDIR )
      {
		  return true;
         //cout << "The directory exists." << endl;
      }
      else
      {
		  return false;
         //cout << "The path you entered is a file." << endl;
      }
   }
   else
   {
	   _mkdir(strPath.c_str());
	   return false;
      //cout << "Path doesn't exist." << endl;
   }
}

	double Database::refreshData()
	{
		clock_t t1, t2;
		t1 = clock();
		AllMovieList = CheckDirectory(MovieFolder);
		AllUserList = CheckDirectory(UserFolder);
		t2 = clock();
		TimeElapsed_GatherData = (double)(t2-t1)/CLOCKS_PER_SEC*1000;
		return TimeElapsed_GatherData;
	}

	char* Database::RetrieveMovie(char* pChar)
	{
		clock_t t1, t2;
		t1 = clock();
		//linear search
		//waiting for hash code
		for(int i = 0;i < AllMovieList.size(); i++)
		{
			if(pChar == AllMovieList[i])
			{	
				string str1(MovieFolder);
				string str2(pChar);
				string str3 = ".txt";
				string combine = str1 + str2 + str3;
				char* tmp = new char[combine.length()+1];

				//strcpy_s(tmp,strlen(combine.c_str()) ,combine.c_str());
				strcpy_s(tmp,combine.length()+1 ,combine.c_str());
				t2 = clock();
				TimeElapsed_Movie = (double)(t2-t1)/CLOCKS_PER_SEC*1000;
				return tmp;
			}
		}
		t2 = clock();
		TimeElapsed_Movie = (double)(t2-t1)/CLOCKS_PER_SEC*1000;

		throw exception("Movie Not Found");
		return NULL;
	}
	char* Database::RetrieveUser(char* pChar)
	{
		clock_t t1, t2;
		t1 = clock();
		//linear search
		//waiting for hash code
		for(int i = 0;i < AllUserList.size(); i++)
		{
			if(pChar == AllUserList[i])
			{
				string str1(UserFolder);
				string str2(pChar);
				string str3 = ".txt";
				string combine = str1 + str2 + str3;
				char* tmp = new char[combine.length()+1];
				for(int i = 0; i < combine.size(); i++)
				{
					tmp[i] = combine[i];
				}
				tmp[combine.size()] = '\0';
				t2 = clock();
				TimeElapsed_Movie = (double)(t2-t1)/CLOCKS_PER_SEC*1000;
				return tmp;
			}
		}
		t2 = clock();
		TimeElapsed_Movie = (double)(t2-t1)/CLOCKS_PER_SEC*1000;
		//throw exception("User Not Found");
		return NULL;
	}
	
	bool Database::DeleteData(char* filename,bool IsMovie)
	{
		if(IsMovie)
		{
			char* tmp = RetrieveMovie(filename);
			if(tmp != NULL)
			{
				if(remove(tmp) != 0)
					return false;
				else
					return true;
			}
		}
		else
		{
			char* tmp = RetrieveUser(filename);
			if(tmp != NULL)
			{
				if(remove(tmp) != 0)
					return false;
				else
					return true;
			}
			
		}
		return false;
	}

	bool Database::IsUpdate(char*)
	{
		return false;
	}
	void Database::checkFolder()
	{
		if(true/*there is a text file on user*/)
		{
			
			/*
			get username
			relocate the text file to database folder
			append username to AllUsers.txt
			*/
		}

		if(true/*there is a text file on movie*/)
		{
			/*
			get title
			relocate the text file to database folder
			append title to AllMovie.txt
			*/
		}

	}

