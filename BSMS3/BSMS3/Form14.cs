using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSMS3.DL;
namespace BSMS3
{
    public partial class Sorting : Form
    {
        public Sorting()
        {
            InitializeComponent();
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            BooksDL.bubbleSort(BooksDL.Booklist);
            this.Hide();
            Sorted s = new Sorted();
            s.ShowDialog();
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            BooksDL.selectionSort(BooksDL.Booklist);
            this.Hide();
            Sorted s = new Sorted();
            s.ShowDialog();
        }

        private void btnInser_Click(object sender, EventArgs e)
        {
            BooksDL.insertionsort(BooksDL.Booklist);
            this.Hide();
            Sorted s = new Sorted();
            s.ShowDialog();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            BooksDL.mergeSort(BooksDL.Booklist, 0, (BooksDL.Booklist.Count - 1));
            this.Hide();
            Sorted s = new Sorted();
            s.ShowDialog();
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            BooksDL.quickSort(BooksDL.Booklist, 0, (BooksDL.Booklist.Count - 1));
            this.Hide();
            Sorted s = new Sorted();
            s.ShowDialog();
        }
        private void btnHeap_Click(object sender, EventArgs e)
        {
            BooksDL.heapSort(BooksDL.Booklist,BooksDL.Booklist.Count);
            this.Hide();
            Sorted s = new Sorted();
            s.ShowDialog();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            BooksDL.countSort(BooksDL.Booklist);
            this.Hide();
            Sorted s = new Sorted();
            s.ShowDialog();
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {
            BooksDL.radixSort(BooksDL.Booklist);
            this.Hide();
            Sorted s = new Sorted();
            s.ShowDialog();
        }
    }
}
