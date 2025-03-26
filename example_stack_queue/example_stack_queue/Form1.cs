using System.Runtime.CompilerServices;
using System.Collections.Generic;
namespace example_stack_queue
{
    public partial class Form1 : Form
    {
        Stack<int> MyStack = new Stack<int>();
        bool dattiUnaMossa = true;
        bool Svegliati = true;
        Queue<int> coda = new Queue<int>();
        public Form1()
        {

            InitializeComponent();
        }

        public void AddStack()
        {
            int num = 0;

            while (dattiUnaMossa)
            {
                MyStack.Push(num);
                num++;

                Thread.Sleep(1000);
            }
        }

        public void AddQueue()
        {
            int num = 0;

            while (Svegliati)
            {
                coda.Enqueue(num);
                num++;

                Thread.Sleep(1000);
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Thread trdStack = new Thread(AddStack);
            trdStack.Start();
            
        }

        private void buttonSt_Click(object sender, EventArgs e)
        {
            dattiUnaMossa = false;
            while (MyStack.Count > 0)
            {
                listBoxSt.Items.Add(MyStack.Pop());
            }
        }

        private void buttonStop_Qu_Click(object sender, EventArgs e)
        {
            Svegliati = false;
            while(coda.Count>0)
            {
                listBoxQu.Items.Add(coda.Dequeue());
            }
        }

        private void buttonStart_Qu_Click(object sender, EventArgs e)
        {
            Thread trdQueue = new Thread(AddQueue);
            trdQueue.Start();
        }
    }
}
