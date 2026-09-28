using System;

class Algorithms
{
    // Sắp xếp nổi bọt 
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Tìm kiếm tuyến tính (Linear Search) cho từ trong câu
    public static int LinearSearchWord(string[] words, string targetWord)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Equals(targetWord, StringComparison.OrdinalIgnoreCase))
            {
                return i;
            }
        }
        return -1;
    }

    public static void Main11()
    {
        // 1. Nhập 10 số nguyên và sắp xếp 
        int[] numbers = new int[10];
        Console.WriteLine("SAP XEP 10 SO NGUYEN");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Nhap so thu {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        BubbleSort(numbers);
        Console.WriteLine("Mang sau khi sap xep tang dan: " + string.Join(" ", numbers));

        // 2. Tìm từ trong câu
        Console.WriteLine("TIM KIEM TU TRONG CAU ");
        Console.Write("Nhap mot cau: ");
        string sentence = Console.ReadLine();

        Console.Write("Nhap tu can tim: ");
        string wordToFind = Console.ReadLine();

        string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int foundIndex = LinearSearchWord(words, wordToFind);

        if (foundIndex != -1)
        {
            Console.WriteLine($"Tu '{wordToFind}' duoc tim thay tai vi tri tu thu {foundIndex + 1} trong cau.");
        }
        else
        {
            Console.WriteLine($"Tu '{wordToFind}' khong xuat hien trong cau.");
        }
    }
}