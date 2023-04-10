using System;

namespace LinkedListBasic
{
    class Program
    {
        static void Main( string[] args )
        {
            LinkedList list = new LinkedList( );
            list.FirstNode(1);
            list.AddLast(2);
            list.ReadNode( );

            list.FirstNode(3);
            list.AddLast(4);
            list.ReadNode( );
        }
    }

}

