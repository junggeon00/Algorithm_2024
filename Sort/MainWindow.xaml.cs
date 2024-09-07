using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int MAX = 1000000;
        int[] a = new int[MAX];
        int N = 0;
        Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Randomize()
        {
            for (int i = 0; i < N; i++)
                a[i] = r.Next(5 * N); 
        }

        private void printData(string s)
        {
            txtResult.Text += "\n" + s + "\n";
            for (int i = 0; i < N; i++)
            {
                txtResult.Text += a[i] + " ";
            }
            txtResult.Text += "\n";
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "";
            N = int.Parse(txtData.Text);
            txtBubble.Text = "버블 정렬 : ";
            txtQuick.Text = "퀵 정렬 : ";
            txtMerge.Text = "합병 정렬 : ";
            Randomize();
            printData("랜덤 숫자");
        }

        private void btnTime_Click(object sender, RoutedEventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Bubblesort();
            watch.Stop();
            printData("버블 정렬");
            long tickbubble = watch.ElapsedTicks;
            long msbubble = watch.ElapsedMilliseconds;
            txtBubble.Text = "버블 정렬 : " + tickbubble + "Ticks," + msbubble + "ms";

            Randomize();
            watch = System.Diagnostics.Stopwatch.StartNew();
            Quicksort(a, 0, N - 1);
            watch.Stop();
            printData("퀵 정렬");
            long tickquick = watch.ElapsedTicks;
            long msquick = watch.ElapsedMilliseconds;
            txtBubble.Text = "퀵 정렬 : " + tickquick + "Ticks," + msquick + "ms";

            Randomize();
            watch = System.Diagnostics.Stopwatch.StartNew();
            Mergesort(a, 0, N - 1);
            watch.Stop();
            printData("합병 정렬");
            long tickmerge = watch.ElapsedTicks;
            long msmerge = watch.ElapsedMilliseconds;
            txtBubble.Text = "합병 정렬 : " + tickmerge + "Ticks," + msmerge + "ms";
        }

        private void Bubblesort()
        {
            for(int i=N-1; i>0; i--)
                for(int j=0; j<i; j++)
                    if (a[j] > a[j+1])
                    {
                        int t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
        }

        private void Quicksort(int[] a, int left, int right)
        {
            if(left < right)
            {
                int q = Partition(a, left, right);
                Quicksort(a, left, q - 1);
                Quicksort(a, q + 1, right);
            }
        }

        private void Mergesort(int[] a, int left, int right)
        {
            if(left < right)
            {
                int mid = (left + right) / 2;
                Mergesort(a, left, mid);
                Mergesort(a, mid + 1, right);
                Merge(a, left, mid, right);
            }
        }

        private int Partition(int[] a, int left, int right)
        {
            int i = left;
            int j = right;

            int pivot = a[left];

            while (i < j)
            {
                while ((i <= right) && (a[i] < pivot))
                    i++;
                while ((j >= left) && (a[j] > pivot))
                    j--;

                if (i < j)
                {
                    int t = a[i];
                    a[i] = a[j];
                    a[j] = t;

                    if (a[i] == a[j])
                        j--;
                }
            }
            return j;
        }

        int[] sorted = new int[MAX];
        private void Merge(int[] a, int left, int mid, int right)
        {
            int i, j, k = left;
            for (i = left, j = mid + 1; i <= mid && j <= right;)
                sorted[k++] = (a[i] <= a[j]) ? a[i++] : a[j++];
            if (i > mid)
                for (int l = j; l <= right; l++)
                    sorted[k++] = a[l];
            else
                for (int l = i; l <= mid; l++)
                    sorted[k++] = a[l];

            for (int l = left; l <= right; l++)
                a[l] = sorted[l];
        }
    }
}