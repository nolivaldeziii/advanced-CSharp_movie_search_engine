#include "Search.h"

Search::Search()
{
	InitializeTable();
}

int Search::getSum(char* c)
{
	int x = 0;
	for(int i=0; c[i] != '\0'; i++)
		x+= (int(c[i]));
	return x;
}

bool Search::isAlphabet(char c)
{
	if( (c <= 'z' && c >= 'a' ) || (c <= '9' && c >= '0'))
		return true;
	else 
		return false;
}

int Search::getSum(std::string c)
{
	int x = 0;
	for(int i=0; c[i] != '\0'; i++)
		x+= (int(c[i]));
	return x;
}


std::queue<char*> Search::SearchMovie(char* str)
{
	int sum = getSum(str);
	char* curr;
	queue<char*> result;
	vector<char*> expl = ExplodeString(str);
	vector<int> explData;

	for(int i = 0; i< expl.size(); i++)
	{
		explData.push_back(getSum(expl[i]));
	}

	while(SumTable[sum].Good())
	{
		curr = SumTable[sum].Read();
		if(curr == str)
			result.push(curr);
	}

	for(int i = 0 ; i < SUM_TABLE_SIZE; i++)
	{
		if(!SumTable[i].IsEmpty())
		{
			for(int j=0;j<explData.size();j++)
			{
				if(subTableSum[i].Existing(explData[j]))
				{
					SumTable[i].ReadReset(true);
					while(SumTable[i].Good())
					{
						curr = SumTable[i].Read();
						vector<char*> expl2 = ExplodeString(curr);
						for(int k = 0; k < expl2.size();k++)
						{
							if(expl2[k]==expl[j])
							{
								result.push(curr);
							}
						}
					}
				}
			}
		}
	}
	return result;
}

vector<char*> Search::ExplodeString(char* c)
{
	vector<char*> vtmp;
	char* stmp = new char[80];
	int j = 0;
	for(int i = 0; c != '\0';i++)
	{
		if(c[i] == ' ')
		{
			stmp[j] = '\0';
			vtmp.push_back(stmp);
			stmp = new char[80];
		}
		stmp[j++] = c[i];
	}
	return vtmp;
}

char* str2char(string str)
{
    char* tmp = new char[1024];
    for(int i=0;i < str.size();i++)
    {
          tmp[i] = str[i];
    }
	tmp[str.size()] = '\0';

	return tmp;
}

void Search::getMovie()
{
	char* path = ".\\Database\\Movie\\";
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
		result = movieData;
	}

}
void Search::InitializeTable()
{
	
	getMovie();
	std::vector<std::string> AllMovieList = movieData;
	for(int i=0;i<AllMovieList.size();i++)
	{
		SumTable[getSum(AllMovieList[i]) % SUM_TABLE_SIZE].Add(str2char(AllMovieList[i]));
		std::vector<char*> expl = ExplodeString(str2char(AllMovieList[i]));

		for(int j=0;j<expl.size(); j++)
		{
			if(!subTableSum[getSum(AllMovieList[i]) % SUM_TABLE_SIZE].Existing(getSum(str2char(expl[j]))))
			{
				subTableSum[getSum(AllMovieList[i]) % SUM_TABLE_SIZE].Add(getSum(str2char(expl[j])));
			}
		}
	}
}