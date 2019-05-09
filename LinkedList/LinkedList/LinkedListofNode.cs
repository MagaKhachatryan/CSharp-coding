using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// the class is about linked list,which consists of nodes.
    /// The principal idea is that every node keeps its next nodes reference
    /// the last nodes next field is null
    /// the class is enumerable
    /// </summary>
    public class LinkedListofNode:IEnumerable<Node> 
    {

        // the very first element of our linked list
        public Node head ;

        /// <summary>
        /// parapetrless ctor
        /// </summary>
        public LinkedListofNode()
        {

        }

        /// <summary>
        /// inserts the node at the given position
        /// paramets
        /// nmb is the position
        /// data is the data of the node that is inserted
        /// </summary>
        /// <param name="nmb"></param>
        public void InsertAtNumber(int nmb,int dt)
        {
            if (this.head == null)
            {
                head = new Node(dt);
            }
            else
            {
                var item = new Node(this.head.data);
                item = this.head;
                for (int i = 0; i < nmb - 2; ++i)
                {
                    item = item.next;
                }
                InsertAfterReference(item, dt);
            }
        }

        /// <summary>
        /// Inserts node in the linked list after the given reference
        /// parametrs
        /// nd is thge referenc eafter which node must be inserted
        /// dt is the data of the insertes node
        /// </summary>
        /// <param name="nd"></param>
        /// <param name="data"></param>
        public void InsertAfterReference(Node nd, int dt)
        {
            
            if(nd==null)
            {
                throw new ArgumentNullException("Your argument is InvalidOperationException");
            }
            if (this.head == null)
            {
                head = new Node(dt);

            }
            else
            {
                var term = new Node(this.head.data);
                term = this.head;
                while (term != nd)
                {
                    term = term.next;
                }
                var insertedItem = new Node(dt);
                insertedItem.next = term.next;
                term.next = insertedItem;
            }
        }

        /// <summary>
        /// method adds new node at the end of the list
        /// </summary>
        /// <param name="dt"></param>
        public void Add(int dt)
        {
            if (head == null)
            {
                head = new Node(dt);
            }
            else
            {
                var term = new Node(this.head.data);
                term = this.head;
                while (term.next != null)
                {
                    term = term.next;
                }
                InsertAfterReference(term, dt);
            }
        }
        /// <summary>
        /// the method returns the length of our linked list
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            var item = new Node(this.head.data);
            item = this.head;
            int ln = 0;
            while(item!=null)
            {
                ++ln;
                item = item.next;
            }
            return ln;
        }
        /// <summary>
        /// Prints the given linked list items datas
        /// </summary>
      /*  public void Print()
        {
            var item = new Node(this.head.data);
            item = this.head;
            while(item!=null)
            {
                Console.WriteLine(item.data);
            }
        }*/

        public IEnumerator<Node> GetEnumerator()
        {
            return new LinkedListEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

      
     
        
    }

    /// <summary>
    /// the class for operatiing linked list enumeration process
    /// it implements the ienumerator interface
    /// </summary>
    public class LinkedListEnumerator : IEnumerator<Node>
    {
        private LinkedListofNode lst;
        int position = -1;

        /// <summary>
        /// ctor thet takes the list that must be enumerated as a parametr
        /// </summary>
        /// <param name="list"></param>
        public LinkedListEnumerator(LinkedListofNode list)
        {
            this.lst = list;
        }

        //property that returns the current position of the linked list
        public Node Current
        {
            get
            {
                if(position==-1)
                {
                    throw new LinkedListisEmptyException("Your list is empty");
                }
                if(position> lst.Length() -1)
                {
                    throw new ArgumentOutOfRangeException("the current position is out of range");
                }
                var it = new Node(lst.head.data);
                it = lst.head;
                for(int i=0;i<position;++i)
                {
                    it = it.next;
                }
                return it;
            }
        }

       
        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        /// <summary>
        /// the method is for  dispoing  the unmanaged resources
        /// in this situation for reseting the position
        /// </summary>
        public void Dispose()
        {
            position = -1;
        }

        /// <summary>
        /// Moves the current position ahead
        /// if there is no position left it  returns false
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            ++position;
            if(position>lst.Length()-1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// recovers the starting position
        /// </summary>
        public void Reset()
        {
            position = -1;
        }
    }
}
