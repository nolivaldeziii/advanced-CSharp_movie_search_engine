#pragma once
#include <iostream>
#include <fstream>
#include <string>
using namespace std;
class User
{
private:
	char* fullname;
	char* username;
	char* password;
	char* email;
	char* verification;
	char* verified;

	char* UserFolderLocation;
	void readDataLoop(ifstream&,char*&);
public:
	User();
	void getFullname(char*);
	void getEmail(char*);
	void getName(char*);
	void getPass(char*);
	void getVerification(char*);
	void verify();

	void readFile(char*);
	void writeFile();
	void refresh();

	char* ret_fname();
	char* ret_user_n();
	char* ret_pass();
	char* ret_email();
	char* ret_verification();
	char* ret_IsVerified();

}info;
User::User()
{
	UserFolderLocation = ".\\Database\\User\\";
	refresh();
}
char* User::ret_fname()
{
	return fullname;
}

void User::verify()
{
	verified = "1";
}
void User::getVerification(char* var)
{
	verification = var;
}
void User::refresh()
{
	fullname = new char[1024];
	username = new char[1024];
	password = new char[1024];
	verification = new char[1024];
	verified = new char[2];
	verified[0] = '0';
	verified[1] = '\0';
	email = new char[1024];
}
void User :: getEmail(char* user)
{
	email = user;
}
void User ::getName(char* user)
{
	username= user;
}
void User::getPass(char* user)
{
	password=user;
}
void User::getFullname(char* pChar)
{
	fullname = pChar;
}

void User::readDataLoop(ifstream &in,char* &str)
{
	string tmp;
	getline(in, tmp);
	for(int i=0;i < tmp.size();i++)
	{
		str[i] = tmp[i];
	}str[tmp.size()] = '\0';
}

void User::readFile(char* pChar)
{
	ifstream myfile;
	//string tmp = UserFolderLocation;
	refresh();
	string tmp = pChar;
	//tmp += ".txt";

	myfile.open(tmp);	

	if(!myfile.is_open())
	{
		throw exception("cannot open file");
	}
	//readDataLoop(myfile,username);

	getline(myfile, tmp);
	for(int i=0;i < tmp.size();i++)
	{
		username[i] = tmp[i];
	}username[tmp.size()] = '\0';

	getline(myfile, tmp);
	for(int i=0;i < tmp.size();i++)
	{
		password[i] = tmp[i];
	}password[tmp.size()] = '\0';

	getline(myfile, tmp);
	for(int i=0;i < tmp.size();i++)
	{
		fullname[i] = tmp[i];
	}fullname[tmp.size()] = '\0';

	getline(myfile, tmp);
	for(int i=0;i < tmp.size();i++)
	{
		email[i] = tmp[i];
	}email[tmp.size()] = '\0';

	getline(myfile, tmp);
	for(int i=0;i < tmp.size();i++)
	{
		verification[i] = tmp[i];
	}verification[tmp.size()] = '\0';

	getline(myfile, tmp);
	for(int i=0;i < tmp.size();i++)
	{
		verified[i] = tmp[i];
	}verified[tmp.size()] = '\0';
	//cout << username << " "<<password<<" "<<email;
	myfile.close();
}
void User ::writeFile()
{
	ofstream myfile;
	int bufsize = strlen(UserFolderLocation)+strlen(username);
	string tmp = UserFolderLocation;
	tmp += username;
	tmp += ".txt";
	myfile.open(tmp);
	myfile << username << endl;
	myfile << password << endl;
	myfile << fullname << endl;
	myfile << email << endl;
	myfile << verification << endl;
	myfile << verified << endl;
	myfile.close();
}

char* User::ret_user_n()
{
	return username;
}
char* User::ret_pass()
{
	return password;
}
char* User::ret_email()
{
	return email;
}

char* User::ret_verification()
{
	return verification;
}

char* User::ret_IsVerified()
{
	return verified;
}