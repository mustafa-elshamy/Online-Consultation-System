#include<iostream>
#include<stack>
#include<queue>
using namespace std;

	queue<int>q;

void revk( int k)
{
	stack<int>st;
	queue<int>temp;
	for (int i = 0; !q.empty(); i++)
	{
		if (i < k)
			st.push(q.front());
		else
			temp.push(q.front());
		q.pop();
	}
	while (!st.empty())
	{
		q.push(st.top());
		st.pop();
	}

	while (!temp.empty())
	{
		q.push(temp.front());
		temp.pop();
	}

}

int main()
{
	int n, k;
	cin >> n >> k;
	for (int i = 0; i < n; i++)
	{
		int x;
		cin >> x;
		q.push(x);

	}

	revk( k);
	for (; !q.empty();)
	{
		cout << q.front() << " ";
		q.pop();


	}
	system("pause");
	return 0;
}