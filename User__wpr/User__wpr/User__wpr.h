// User__wpr.h

#pragma once
#include "C:\\Users\\Noli\\Dropbox\\Programming\\Projects\\Movie Search Engine\\UserClass_Unmanaged\\User.h"
//#include "C:\\Users\\Noli\\Dropbox\\Programming\\Projects\\Movie Search Engine\\UserClass_Unmanaged\\FilestreamMP.cpp"
#include "C:\\Users\\Noli\\Dropbox\\Programming\\Projects\\Movie Search Engine\\Database\\Database\\Database.h"
#include "C:\\Users\\Noli\\Dropbox\\Programming\\Projects\\Movie Search Engine\\Database\\Database\\Database.cpp"

using namespace System;

namespace User__wpr {

	public ref class User_wpr
	{

	public:
		char* username;
		char* fullname;
		char* password;
		char* email;
		char* verification;
		char* verified;


	public:
		User_wpr();

		void GetUsername(char*);
		void GetFullname(char*);
		void GetPassword(char*);
		void GetEmail(char*);
		void GetVerification(char*);

		bool checkPassword(char*);

		void GetUser(char*);
		void SaveUser();
	};
	
}
