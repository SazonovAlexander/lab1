using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1

{
    public partial class Form1 : Form
    {
        private Queue myQueue = new Queue();

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            myQueue = new Queue();

            UpdateStackInformation();
        }

        private void UpdateStackInformation()
        {
            textBoxCurrentElement.Text = myQueue.IsEmpty ? "N/A" : myQueue.Peek().ToString();
            labelCount.Text = $"Число элементов: {myQueue.Count}";
            labelIsEmpty.Text = $"Пусто?: {myQueue.IsEmpty}";
        }
        

        private void buttonPop_Click_Click(object sender, EventArgs e)
        {
            if (!myQueue.IsEmpty)
            {
                int poppedItem = myQueue.Pop();
                MessageBox.Show($"Удаленный элемент: {poppedItem}");
                UpdateStackInformation();
            }
            else
            {
                MessageBox.Show("Очередь пуста.");
            }
        }

        private void buttonClear_Click_Click(object sender, EventArgs e)
        {
            myQueue.Clear();
            UpdateStackInformation();
        }

        class Queue
        {
            private List<int> elements = new List<int>();

            public void Push(int item)
            {
                elements.Add(item);
            }

            public int Pop()
            {
                if (elements.Count == 0)
                {
                    throw new InvalidOperationException("Нельзя удалить из пустой очереди.");
                }

                int poppedItem = elements[0];
                elements.RemoveAt(0);
                return poppedItem;
            }

            public int Peek()
            {
                if (elements.Count == 0)
                {
                    throw new InvalidOperationException("Cannot peek an empty queue.");
                }

                return elements[elements.Count - 1];
            }

            public void Clear()
            {
                elements.Clear();
            }

            public bool IsEmpty
            {
                get { return elements.Count == 0; }
            }

            public int Count
            {
                get { return elements.Count; }
            }

            public IEnumerable<int> GetAllItems()
            {
                return elements;
            }
        }

        private void buttonShowItems_Click_Click(object sender, EventArgs e)
        {
            string allItems = GetAllItemsInStack();
            MessageBox.Show("All Items in Queue: \n" + allItems);
        }
        private string GetAllItemsInStack()
        {
            return string.Join(", ", myQueue.GetAllItems());
        }

        private void buttonPush_Click_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCurrentElement.Text, out int newItem))
            {
                myQueue.Push(newItem);
                UpdateStackInformation();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value in the text box.");
            }
        }
    }
}
