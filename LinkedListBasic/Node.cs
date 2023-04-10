using System;
namespace LinkedListBasic
{
	public class Node
	{
		public int data { get; set; }		// data	변수 value {get; set;} 연산자로 다른 class에서 할당 및 참조 가능
		public Node nextNode { get; set; }	// 다음 노드의 링크 변수 nextNode

		public Node(int data_ )     // class 생성
        {
			data = data_;
			nextNode = null;		// 생성했으므로 다음노드 없음
		}
	}
}
 

