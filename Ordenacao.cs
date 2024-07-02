using System;


//Classe para criar métodos de ordenação
public class Ordenacao

{   

    //Em cada método foi utilizada a função Stopwatch para controlar a contagem do tempo, multiplicando por 1000000 no final para converter milissegundos em nanossegundos

    //Método Bubble Sort
    public static double BubbleSortMethod<T>(T[] array) where T : IComparable<T>
    {   

        var watch = System.Diagnostics.Stopwatch.StartNew();

        bool exchange;
        do
        {
            exchange = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    Exchange(array, i, i + 1);
                    exchange = true;
                }
            }
        } while (exchange);

        watch.Stop();
        var elapsedMs = watch.Elapsed.TotalMilliseconds;


        Console.WriteLine("Tempo de execução em nanossegundos: " + elapsedMs* 1000000);

        return (double) elapsedMs * 1000000;
    }

    //Método Insertion Sort
    public static double InsertionSort<T>(T[] array) where T : IComparable<T>
    {
       var watch = System.Diagnostics.Stopwatch.StartNew();

        for (int i = 1; i < array.Length; i++)
        {
            for (int j = i; j > 0 && array[j - 1].CompareTo(array[j]) > 0; j--)
            {
                Exchange(array, j - 1, j);
            }
        }

         watch.Stop();
        var elapsedMs = watch.Elapsed.TotalMilliseconds;


        Console.WriteLine("Tempo de execução em nanossegundos: " + elapsedMs* 1000000);

        return (double) elapsedMs * 1000000;
    }

    //Método SelectSort
    public static double SelectSort<T>(T[] array) where T : IComparable<T>
    {

        var watch = System.Diagnostics.Stopwatch.StartNew();

        for (int min, i = 0; i < array.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].CompareTo(array[min]) < 0)
                {
                    min = j;
                }
            }
            Exchange(array, min, i);
        }

        watch.Stop();
        var elapsedMs = watch.Elapsed.TotalMilliseconds;


        Console.WriteLine("Tempo de execução em nanossegundos: " + elapsedMs* 1000000);

        return (double) elapsedMs * 1000000;
    }

    //Método HeapSort
    public static double HeapSort<T>(T[] array) where T : IComparable<T>
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();

        BuildMaxHeap(array);
        for (int i = array.Length - 1; i > 0; i--)
        {
            Exchange(array, 0, i);
            MaxHeapify(array, 0, i);
        }

        watch.Stop();

        var elapsedMs = watch.Elapsed.TotalMilliseconds;


        Console.WriteLine("Tempo de execução em nanossegundos: " + elapsedMs* 1000000);

        return (double) elapsedMs * 1000000;
    }

    //Método MaxHeap para auxiliar Heap Sort
    private static void BuildMaxHeap<T>(T[] array) where T : IComparable<T>
    {




        for (int i = array.Length / 2 - 1; i >= 0; i--)
        {
            MaxHeapify(array, i, array.Length);
        }
    }

    //Método MaxHeapify para auxiliar Heap Sort
    private static void MaxHeapify<T>(T[] array, int i, int n) where T : IComparable<T>
    {
        int max = 2 * i + 1;
        if (max + 1 < n && array[max].CompareTo(array[max + 1]) < 0)
            max++;
        if (max < n && array[max].CompareTo(array[i]) > 0)
        {
            Exchange(array, i, max);
            MaxHeapify(array, max, n);
        }
    }

    //Método Shell Sort
    public static double shellSort<T>(T[] array) where T : IComparable<T>
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();

        int h = 1;
        while (3 * h + 1 < array.Length) h = 3 * h + 1;
        while (h > 0)
        {
            for (int i = h; i < array.Length; i++)
            {
                for (int j = i; j >= h && array[j - h].CompareTo(array[j]) > 0; j -= h)
                {
                    Exchange(array, j - h, j);
                }
            }
            h /= 3;
        }
         watch.Stop();

        var elapsedMs = watch.Elapsed.TotalMilliseconds;


        Console.WriteLine("Tempo de execução em nanossegundos: " + elapsedMs* 1000000);

        return (double) elapsedMs * 1000000;
    }  

    //Método Merge Sort

    public static double MergeSort<T>(T[] array) where T : IComparable<T>
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();

        T[] aux = new T[array.Length];
        Divide(array, aux, 0, array.Length - 1);

        watch.Stop();

        var elapsedMs = watch.Elapsed.TotalMilliseconds;


        Console.WriteLine("Tempo de execução em nanossegundos: " + elapsedMs* 1000000);

        return (double) elapsedMs * 1000000;
    }

    //Método "Dividir" do Merge Sort
    private static void Divide<T>(T[] array, T[] aux, int low, int high) where T : IComparable<T>
    {
        if (low >= high) return;
        int middle = (low + high) / 2;
        Divide(array, aux, low, middle);
        Divide(array, aux, middle + 1, high);
        Conquer(array, aux, low, middle, high);
    }

    //Método "Conquistar" do Merge Sort

    private static void Conquer<T>(T[] array, T[] aux, int low, int middle, int high) where T : IComparable<T>
    {
        for (int k = low; k <= high; k++)
        {
            aux[k] = array[k];
        }

        int i = low, j = middle + 1;
        for (int k = low; k <= high; k++)
        {
            if (i > middle) array[k] = aux[j++];
            else if (j > high) array[k] = aux[i++];
            else if (aux[j].CompareTo(aux[i]) < 0) array[k] = aux[j++];
            else array[k] = aux[i++];
        }
    }

    //Método Quick Sort

    public static double QuickSort<T>(T[] array) where T : IComparable<T>
    {
         var watch = System.Diagnostics.Stopwatch.StartNew();

        Sort(array, 0, array.Length - 1);

        watch.Stop();

        var elapsedMs = watch.Elapsed.TotalMilliseconds;


        Console.WriteLine("Tempo de execução em nanossegundos: " + elapsedMs* 1000000);

        return (double) elapsedMs * 1000000;
    }

    //Método Sort que auxiliar Quick Sort

    private static void Sort<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        if (low >= high) return;
        int p = Partition(array, low, high);
        Sort(array, low, p - 1);
        Sort(array, p + 1, high);
    }

    //Método Partition para auxiliar método Sort

    private static int Partition<T>(T[] array, int low, int high) where T : IComparable<T>
    {
        T pivot = array[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (array[j].CompareTo(pivot) <= 0)
            {
                Exchange(array, ++i, j);
            }
        }
        Exchange(array, i + 1, high);
        return i + 1;
    }



    //Método que troca valores dos arrays de lugares quando condição é atingida nos métodos de ordenação.
    private static void Exchange<T>(T[] array, int i, int j)
    {
        T temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

}