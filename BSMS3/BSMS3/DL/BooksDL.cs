using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSMS3.BL;
using System.IO;
namespace BSMS3.DL
{
    class BooksDL
    {
        private static List<BooksBL> booklist = new List<BooksBL>();

        internal static List<BooksBL> Booklist { get => booklist; set => booklist = value; }

        public AllBooks AllBooks
        {
            get => default;
            set
            {
            }
        }

        public Update Update
        {
            get => default;
            set
            {
            }
        }

        public DeleteItem DeleteItem
        {
            get => default;
            set
            {
            }
        }

        public AdminViewBook AdminViewBook
        {
            get => default;
            set
            {
            }
        }

        public AllBooks AllBooks1
        {
            get => default;
            set
            {
            }
        }

        public static void AddIntoBooksList(BooksBL book)
        {
            Booklist.Add(book);
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            String item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool readFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string bname = parseData(record, 1);
                    string authr = parseData(record, 2);
                    string ctg = parseData(record, 3);
                    int qty = int.Parse(parseData(record, 4));
                    int price = int.Parse(parseData(record, 5));
                    BooksBL book = new BooksBL(bname, authr, ctg, qty, price);
                    AddIntoBooksList(book);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeIntoFile(BooksBL book, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(book.Bname1 + "," + book.Author + "," + book.Ctg + "," + book.Stock + "," + book.Price);
            file.Flush();
            file.Close();
        }
        public static void deleteBookFromList(BooksBL book)
        {
            for (int index = 0; index < booklist.Count; index++)
            {
                if (booklist[index].Bname1 == book.Bname1 && booklist[index].Author == book.Author && booklist[index].Ctg == book.Ctg)
                {
                    booklist.RemoveAt(index);
                }
            }

        }
        public static void EditBookFromList(BooksBL previous, BooksBL updated)
        {
            foreach (BooksBL book in booklist)
            {
                if (book.Bname1 == previous.Bname1 && book.Author == previous.Author && book.Ctg == previous.Ctg)
                {
                    book.Bname1 = updated.Bname1;
                    book.Author = updated.Author;
                    book.Ctg = updated.Ctg;
                    book.Stock = updated.Stock;
                    book.Stock = updated.Price;

                }
            }

        }
        public static void storeAllDatainFile(string Path)
        {
            StreamWriter file = new StreamWriter(Path);
            foreach(BooksBL book in booklist)
            {
                file.WriteLine(book.Bname1 + "," + book.Author + "," + book.Ctg + "," + book.Stock + "," + book.Price);
            }
            file.Flush();
            file.Close();
        }
        public static void swap(BooksBL b1, BooksBL b2)
        {
            BooksBL b3;
            b3 = b1;
            b1 = b2;
            b2 = b3;
        }
        // Bubble sort
        public static void bubbleSort(List<BooksBL> bk)
        {
            int n = bk.Count();
            for (int x = 0; x < n - 1; x++)
            {
                bool isSwapped = false;
                for (int y = 0; y < n - x - 1; y++)
                {
                    if (bk[y].Price > bk[y + 1].Price)
                    {
                        swap(bk[y], bk[y + 1]);
                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                {
                    break;
                }
            }
        }
        //find minimum
        public static int findMinimum(List<BooksBL> b, int start, int end)
        {
            int min =b[start].Price;
            int minIndex = start;
            for (int x = start; x < end; x++)
            {
                if (min > b[x].Price)
                {
                    min = b[x].Price;
                    minIndex = x;
                }
            }
            return minIndex;
        }
        // Selection Sort
        public static void selectionSort(List<BooksBL> b)
        {
            for (int y = 0; y < b.Count - 1; y++)
            {
                int minIndex = findMinimum(b, y, b.Count);
                BooksBL pt3;
                pt3 = b[y];
                b[y] = b[minIndex];
                b[minIndex] = pt3;
            }
        }
        //insertion sort
        public static void insertionsort(List<BooksBL> pt)
        {
            for (int x = 1; x < pt.Count; x++)
            {
                BooksBL key = pt[x];
                int y = x - 1;
                while (y >= 0 && pt[y].Price > key.Price)
                {
                    pt[y + 1] = pt[y];
                    y--;
                }
                pt[y + 1] = key;
            }
        }
        // ----------------Merge Sort---------
        //Merge Function
        static public void merge(List<BooksBL> pt, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            BooksBL[] L = new BooksBL[n1];
            BooksBL[] R = new BooksBL[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = pt[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = pt[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i].Price <= R[j].Price)
                {
                    pt[k] = L[i];
                    i++;
                }
                else
                {
                    pt[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                pt[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                pt[k] = R[j];
                j++;
                k++;
            }
        }
        static public void mergeSort(List<BooksBL> pt, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(pt, p, q);
                mergeSort(pt, q + 1, r);
                merge(pt, p, q, r);
            }
        }
        // Partition
        public static int partition(List<BooksBL> pt, int start, int end, int pivot)
        {
            int left = start;
            int right = end;
            while (left <= right)
            {
                while (left <= end && pt[left].Price < pt[pivot].Price)
                {
                    left++;
                }
                while (right >= start && pt[right].Price >= pt[pivot].Price)
                {
                    right--;
                }
                if (left < right)
                {
                    BooksBL pt3;
                    pt3 = pt[left];
                    pt[left] = pt[right];
                    pt[right] = pt3;
                }

            }
            BooksBL pt4; pt4 = pt[right];
            pt[right] = pt[pivot];
            pt[pivot] = pt4;
            return right;
        }
        //Quick Sort
        public static void quickSort(List<BooksBL> pt, int start, int end)
        {
            if (start < end)
            {
                int pivot = start;
                int mid = partition(pt, start + 1, end, pivot);
                quickSort(pt, start, mid - 1);
                quickSort(pt, mid + 1, end);
            }
        }
        // ________________Heap Sort________________
        //Heapify Function
        public static void heapify(List<BooksBL> pt, int size, int index)
        {
            int maxIndex;
            while (true)
            {
                int lIdx = leftChildIndex(index);
                int rIdx = rightChildIndex(index);
                if (rIdx >= size)
                {
                    if (lIdx >= size)
                        return;
                    else
                        maxIndex = lIdx;
                }
                else
                {
                    if (pt[lIdx].Price >= pt[rIdx].Price)
                        maxIndex = lIdx;
                    else
                        maxIndex = rIdx;
                }
                if (pt[index].Price < pt[maxIndex].Price)
                {
                    BooksBL pt4; pt4 = pt[index];
                    pt[index] = pt[maxIndex];
                    pt[maxIndex] = pt4;
                    index = maxIndex;
                }
                else
                    return;
            }
        }

        public static int leftChildIndex(int i)
        {
            return (2 * i) + 1;
        }
        public static int rightChildIndex(int i)
        {
            return (2 * i) + 2;
        }

        //HEAP SORT
        public static void heapSort(List<BooksBL> pt, int size)
        {
            for (int x = (size - 1) / 2; x >= 0; x--)
            {
                heapify(pt, size, x);
            }
            for (int x = size - 1; x > 0; x--)
            {
                BooksBL pt4; pt4 = pt[0];
                pt[0] = pt[x];
                pt[x] = pt4;
                heapify(pt, x, 0);
            }
        }
        // Maximum
        public static int max_element(List<BooksBL> pt, int start, int end)
        {
            int max = pt[start].Price;
            int minIndex = start;
            for (int x = start; x < end; x++)
            {
                if (max < pt[x].Price)
                {
                    max = pt[x].Price;
                    minIndex = x;
                }
            }
            return minIndex;
        }

        //COUNT SORT
        public static void countSort(List<BooksBL> pt)
        {
            int m = max_element(pt, 0, pt.Count);
            int max = pt[m].Price;
            List<int> count = new List<int>(max + 1);
            BooksBL[] output = new BooksBL[pt.Count];
            Console.WriteLine(count.Capacity);
            for (int i = 0; i < count.Capacity; i++)
            {
                count.Add(0);
            }
            for (int i = 0; i < pt.Count; i++)
            {
                count[pt[i].Price]++;
            }
            for (int i = 1; i < count.Count; i++)//comulative sum
            {  
                count[i] = count[i - 1] + count[i];
                Console.WriteLine(count[i]);
            }
            for (int x = pt.Count - 1; x >= 0; x--)
            {         
                int index = count[pt[x].Price] - 1;
                Console.WriteLine(index);
                count[pt[x].Price]--;
                output[index] = pt[x];
            }
            for (int x = 0; x < output.Length; x++)
            {     
                pt[x] = output[x];
            }
        }
        // _____________Radix Sort_____________
        //count
        public static void counting(List<BooksBL> pt, int place, int max)
        {
            List<int> count = new List<int>(max + 1);
            BooksBL[] output = new BooksBL[pt.Count];
            for (int i = 0; i < count.Capacity; i++)
            {
                count.Add(0);
            }
            for (int x = 0; x < pt.Count; x++)
            {
                count[(pt[x].Price / place) % 10]++;
            }
            for (int x = 1; x < count.Count; x++)
            {
                count[x] = count[x - 1] + count[x];
            }
            for (int x = pt.Count - 1; x >= 0; x--)
            {
                int index = count[(pt[x].Price / place) % 10] - 1;
                count[(pt[x].Price / place) % 10]--;
                output[index] = pt[x];
            }
            for (int x = 0; x < output.Length; x++)
            {
                pt[x] = output[x];
            }
        }
        // Radix Sort
        public static void radixSort(List<BooksBL> pt)
        {
            int m = max_element(pt, 0, pt.Count);
            int max = pt[m].Price;
            int place = 1;
            while ((max / place) > 0)
            {
                counting(pt, place, max);
                place = place * 10;
            }
        }
    }
}
