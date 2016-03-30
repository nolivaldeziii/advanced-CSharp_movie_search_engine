//
//#pragma once
//
//template<class type>
//struct Node
//{
//	type Data;
//	Node *Next;
//};
//
//template<class type>
//class Link
//{
//private:
//	int Count;
//	Node<type> *Head,*Last,*Curr,*Trail;
//
//public:
//	Link()
//	{
//		Head = new Node<type>;
//		Head->Next = NULL;
//		Curr = Head;
//		Last = Head;
//
//		Count = 0;
//	}
//
//	void Add(type var)
//	{
//		if(Count == 0)
//		{
//			Head->Data = var;
//			Count++;
//		}
//		else
//		{
//			Curr = new Node<type>;
//			Curr->Data = var;
//			Curr->Next = NULL;
//
//			Last->Next = Curr;
//			Last = Curr;
//
//			Count++;
//		}
//	}
//
//	bool IsEmpty()
//	{
//		if(Count <= 0)
//			return true;
//		else
//			return false;
//	}
//
//	void Clear()
//	{
//		Last = Head;
//		Curr = Head->Next;
//
//		delete[] Curr;
//		Curr = Head;
//
//		Count = 0;
//	}
//
//	bool Delete(type var)
//	{
//		Curr = Head;
//		Trail = Curr;
//
//		while (Curr != NULL)
//		{
//			if(Curr->Data == var)
//			{
//				Trail->Next = Curr->Next;
//				Curr->Next = NULL;
//				delete Curr;
//
//				return true;//succeed
//			}
//
//			TrailNode = Curr;
//			Curr = Curr->Next;
//		}
//
//		return false;//no data deleted
//	}
//
//	int Size()// return size of list
//	{
//		return Count;
//	}
//
//	type GetData(int){}// get a data like a vector
//
//	type Read() // read
//	{
//		type tmp = Curr->Data;
//		Curr=Curr->Next;
//
//		return tmp;
//	}
//	bool Good() //good to read, end is not null
//	{
//		if(Count == 0 || Curr == NULL)
//			return false;
//		else
//			return true;
//	}
//	void ReadReset(bool) //reset to first
//	{
//		Curr = Head;
//	}
//
//};