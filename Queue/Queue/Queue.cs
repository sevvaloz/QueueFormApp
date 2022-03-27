using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Queue
    {
        Node front; // en öndeki düğüm
        Node rear; // en sondaki düğüm
        public Queue()
        {
            this.front = null;
            this.rear = null;
        }

        public void Enqueue(int data) // kuyruğa ekleme
        {
            Node eleman = new Node(data);
            if(front == null)
            {
                front = rear = eleman;
            }
            else
            {
                rear.next = eleman;
                rear = eleman;
            }
        }

        public void Dequeue() // kuyruktan silme
        {
            front = front.next;
        }

        string mesaj;
        public string elemanlariYazdir()
        {
            mesaj = "";
            Node temp = front;
            while(temp != null)
            {
                mesaj += temp.data.ToString() + " <- ";
                temp = temp.next;
            }
            return mesaj + "son";
        }
    }
}
