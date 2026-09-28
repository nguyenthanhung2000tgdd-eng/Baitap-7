using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_7
{
    internal class bai1
    {
        public static int[] Songaunhien(int mang, int sonhonhat, int solonnhat)
        {
            Random rand = new Random();
            int[] arr = new int[mang];
            for (int i = 0; i < mang; i++)
            {
                arr[i] = rand.Next(sonhonhat, solonnhat + 1);
            }
            return arr;
        }
        // 1, Tính giá trị trung bình
        public static double Sotrungbinh(int[] arr)
        {
            if (arr.Length == 0) return 0;
            int tong = 0;
            foreach (int item in arr) tong += item;
            return (double)tong / arr.Length;
        }
        // 2.Kiểm tra giá trị trong mảng
        public static bool Chuagiatri(int[] arr, int muctieu)
        {
            foreach (int item in arr)
            {
                if (item == muctieu) return true;
            }
            return false; }
        // 3. Tìm vị trí giá trị
        public static int Timgiatri(int[] arr, int muctieu)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == muctieu || arr[i] == 0) return i;
            }
            return 0;
        }
        // 4. Xóa phàn tử
        public static int[] Xoaphantu(int[] arr, int muctieu)
        {
            List<int> list = new List<int>();
            foreach (int item in arr)
            {
                if (item != muctieu) list.Add(item);
            }
            return list.ToArray();
        }
        // 5. Giá trị lớn nhất và nhỏ nhất
        public static (int nhonhat, int lonnhat) nholon(int[] arr)
        {
            int nhonhat = arr[0];
            int lonnhat = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < nhonhat) nhonhat = arr[i];
                if (arr[i] > lonnhat) lonnhat = arr[i];
            }
            return (nhonhat, lonnhat);
        }
        // 6. Đảo ngược mảng
        public static int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            return reversed;
        }

        // 7. Tìm các giá trị bị trùng lặp
        public static int[] FindDuplicates(int[] arr)
        {
            List<int> duplicates = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && !duplicates.Contains(arr[i]))
                    {
                        duplicates.Add(arr[i]);
                    }
                }
            }
            return duplicates.ToArray();
        }

        // 8. Xóa các phần tử bị trùng lặp 
        public static int[] RemoveDuplicates(int[] arr)
        {
            List<int> uniqueList = new List<int>();
            foreach (int item in arr)
            {
                if (!uniqueList.Contains(item))
                {
                    uniqueList.Add(item);
                }
            }
            return uniqueList.ToArray();
        }

        public static void Main()
        {
            int[] arr = Songaunhien(10, 1, 15);
            Console.WriteLine("Mang ban dau: " + string.Join(", ", arr));

            Console.WriteLine("1. Trung binh: " + Sotrungbinh(arr));
            Console.WriteLine("2. Chua so 5?: " + Chuagiatri(arr, 5));
            Console.WriteLine("3. Vi tri cua so 5: " + Timgiatri(arr, 5));

            var (sonhonhat, solonnhat) = nholon(arr);
            Console.WriteLine($"5. Min = {sonhonhat}, Max = {solonnhat}");

            Console.WriteLine("6. Mang dao nguoc: " + string.Join(", ", ReverseArray(arr)));
            Console.WriteLine("7. Cac gia tri trung: " + string.Join(", ", FindDuplicates(arr)));
            Console.WriteLine("8. Mang sau khi xoa trung: " + string.Join(", ", RemoveDuplicates(arr)));
            Console.WriteLine("4. Mang sau khi xoa so 5: " + string.Join(", ", Xoaphantu(arr, 5)));
        }
    }
}
