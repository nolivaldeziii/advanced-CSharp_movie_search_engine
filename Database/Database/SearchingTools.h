#include <string>
#include <vector>
using std::string;
using std::vector;

class Search
{
public:
	static int getSum(char* c)
	{
		if(c == "Caribbean")
		{
			if(true){}
		}
		int x = 0;
		for(int i=0; c[i] != '\0'; i++)
		{
			if(c[i] == '(')
				break;
			if((c[i] <= 'Z' && c[i] >= 'A' ))
				c[i]+=32;
			if(isAlphabet(c[i]))
				x+= (int(c[i]));
		}
		return x;
	}
	static bool isAlphabet(char c)
	{
		if( (c <= 'z' && c >= 'a' ) || (c <= '9' && c >= '0'))
			return true;
		else 
			return false;
	}
	static char* ToLower(char* c)
	{
		char* c2 = new char[80];
		int i;
		for(i = 0; c[i]!='\0';i++)
		{
			if((c[i] <= 'Z' && c[i] >= 'A' ))
				c[i]+=32;
			c2[i] = c[i];
		}
		c2[i] = '\0';
		return c2;
	}
	static int getSum(std::string c)
	{
		if(c == "Caribbean")
		{
			if(true){}
		}
		int x = 0;
		for(int i=0; c[i] != '\0'; i++)
		{
			if(c[i] == '(')
				break;
			if((c[i] <= 'Z' && c[i] >= 'A' ))
				c[i]+=32;
			if(isAlphabet(c[i]))
				x+= (int(c[i]));
		}
		return x;
	}
	static vector<char*> ExplodeString(char* c)
	{
		vector<char*> vtmp;
		char* stmp = new char[80];
		int j = 0;
		for(int i = 0; c[i] != '\0';i++)
		{
			if(c[i] == ' ')
			{
				stmp[j] = '\0';
				vtmp.push_back(stmp);
				stmp = new char[80];
				j=0;
			}
			stmp[j++] = c[i];
		}
		stmp[j] = '\0';
		vtmp.push_back(stmp);
		return vtmp;
	}

	static char* str2char(string str)
	{
		char* tmp = new char[1024];
		for(int i=0;i < str.size();i++)
		{
			tmp[i] = str[i];
		}
		tmp[str.size()] = '\0';

		return tmp;
	}
	static bool sumNear(char* x,char* y,int tolerance)
	{
		int percent_right = 0;
		if(getSum(x) <= getSum(y)+tolerance && getSum(x) >= getSum(y)-tolerance)
		{
			string one ="",two = "";
			int j=0,i;
			for(i = 0; x[i]!='\0';i++)
			{
				one = x[j];one+=x[j+1]; 
				two = y[i];two+=y[i+1];
				if(x[j] == y[i] && x[j+1]==y[i+1])
				{
					if(x[j] != -51)
						percent_right++;
					j++;
				}
				if(x[i]== -51)
					break;
				if(x[i+1]=='\0' || x[i] ==-51 || y[i] ==-51)
				{
					if(percent_right >=3)
						break;
					if(x[j] == '\0')
						break;
					j++;i=-1;
				}
			}
			if(percent_right >= 3 /*&& ( (percent_right*2) / i ) *100 > 50 */)
			{
				return true;
			}
			return false;
		}
		else
			return false;
	}

};