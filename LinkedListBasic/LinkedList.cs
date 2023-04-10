
using System;
namespace LinkedListBasic
{
	public class LinkedList
	{
		public Node headNode { get; set;}		// Node class의 Node형식을 가진 headNode변수 할당, 연산자를 통한 데이터 할당 및 참조 가능

		public LinkedList()						// class 생성
		{
			headNode = null;					// 초기화
		}

		public void FirstNode( int data )		// 제일 앞의 노드(Head)를 설정하기 위한 메서드, int data를 인자값으로 받	
		{
			Node newNode = new Node(data );     // data에 인자값과 함수를 실행하면 Node class의 새로운 Node 생성
			newNode.nextNode = headNode;        // newNode의	nextNode를 제일 앞의 노드(Head)로 햘당
            headNode = newNode;					// 새로운 Node는 처음노드위치에 할당 
        }

		public void AddLast(int data)			// 마지막 노드 추가
		{
			Node newNode = new Node(data);		// 새로운 노드 설정

			if(headNode == null)				// 처음 노드가 없을 때
			{
				headNode = newNode;				// 새 노드를 처음 노드로 설정
			}
			else
			{
				Node curNode = headNode;			// 현재 노드 변수 설정
				while(curNode.nextNode != null)	// 현재 노드의 다음 노드가 없지 않을 때 (있을 때)
				{
					curNode = curNode.nextNode;	// 현제 노드를 다음 노드로 설정
				}
				curNode.nextNode = newNode;
			}
		}

		public bool Remove(int data)			// 노드 제거
		{
			if(headNode == null)				// 제일 앞에 노드(헤드)가 null일때
			{
				return false;					// 노드가 존재 하지 않아서 false 반환
			}
			if(headNode.data == data)			// 헤드의 데이터가 지울 데이터일때
			{
				headNode = headNode.nextNode;	// 헤드를 헤드 다음 노드로 옮김
				return true;
			}

			Node curNode = headNode;			// 현재 노드를 헤드노드로 설정
			while(curNode.data == data)			// 현재 노드의 데이터가 지울 데이터일때
			{
				if(curNode.nextNode.data == data)// 현재 노드의 다음노드의 데이터가 지울 데이터일때
				{
					curNode.nextNode.data = curNode.nextNode.nextNode.data;	// 현재노드의 다음노드의 데이터를 그 다음 노드로 옮김
					return true;
				}
				curNode = curNode.nextNode;		// 현재 노드를 다음 노드로 옮김
			}
			return false;
		}

		public void ReadNode()					// 노드 읽음
		{
			Node curNode = headNode;			// 헤드부터 읽기 때문에 현재 노드를 헤드노드로 설정
			while(curNode != null)				// 현재 노드가 없지 않을 때 (데이터가 있을 때)
			{
				Console.Write($"{curNode.data}  ");	// 현재노드 출력
				curNode = curNode.nextNode;			// 현재 노드를 다음 노드로 옮김
			}
			Console.WriteLine();
		}
	}
}

