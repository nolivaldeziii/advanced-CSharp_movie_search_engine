// This is the main DLL file.

#include "stdafx.h"

#include "User__wpr.h"

User__wpr::User_wpr::User_wpr()
{
	verified = new char[2];
	verified[0] = '0';
	verified[1] = '\0';
}

void User__wpr::User_wpr::GetEmail(char* e)
{
	email=e;
}

void User__wpr::User_wpr::GetFullname(char* fn)
{
	fullname=fn;
}

void User__wpr::User_wpr::GetPassword(char* pw)
{
	password=pw;
}

void User__wpr::User_wpr::GetUsername(char* usr)
{
	username=usr;
}
void User__wpr::User_wpr::SaveUser()
{
		User newUser;
		Database check;
		if(check.RetrieveUser(username)!=NULL)
		{
			throw exception("User Already Exist");
		}
		newUser.getName(username);
		newUser.getEmail(email);
		newUser.getPass(password);
		newUser.getFullname(fullname);
		newUser.getVerification(verification);
		if(verified[0] == '1')
		{
			newUser.verify();
		}
		try
		{
		newUser.writeFile();
		}
		catch(exception &err)
		{
			throw gcnew Exception(gcnew String(err.what()));
		}
}

void User__wpr::User_wpr::GetVerification(char* var)
{
	verification = var;
}

void User__wpr::User_wpr::GetUser(char* pChar)
{
	User getUser;
	Database check;
	char* user = check.RetrieveUser(pChar);
	if(user == NULL)
	{
		throw gcnew Exception("User does not exist");
	}
	else
	{
		getUser.readFile(user);
		username = getUser.ret_user_n();
		password = getUser.ret_pass();
		fullname = getUser.ret_fname();
		email = getUser.ret_email();
		verification = getUser.ret_verification();
		verified = getUser.ret_IsVerified();
	}
}

bool User__wpr::User_wpr::checkPassword(char* pChar)
{
	string tmp1 = pChar;
	string tmp2 = password;

	if(tmp1== tmp2)
		return true;
	else
		return false;
}