using System;
internal class Program
{



    private static void Main(string[] args)

    {

        List<double> tempos = new List<double>();

        List<double> temposIntervalos = new List<double>();

        //Cria diferentes modaliades de Array
        ConjuntoArrays arrays = new ConjuntoArrays();



        Program program = new Program();

        /* foreach(int numero in arrays.Array93.Array9){
            Console.WriteLine(numero);
        } */


    double media = 0;
    double variancia = 0;
    double desvio = 0;
    double novaMedia = 0;


        //BubbleSort

        Console.WriteLine("BubbleSort");

        for (int i = 0; i < 10; i++)
        {

            arrays.popularAleatoriaComRepetido(arrays.Array9);

            tempos.Add(Ordenacao.BubbleSortMethod(arrays.Array9));
            Array.Clear(arrays.Array9, 0, arrays.Array9.Length);

        }

        media = program.calcularMedia(tempos);

        Console.WriteLine("Média do Bubble Sort: " + media);

        variancia = program.variancia(tempos, media);
        Console.WriteLine("Variância do Bubble Sort: " + variancia);

        desvio = program.desvioPadrao(variancia);

        Console.WriteLine(desvio);

        novaMedia = program.novaMedia(tempos, desvio, media, temposIntervalos);

        Console.WriteLine("Nova média: " + novaMedia);


        tempos.Clear();
        temposIntervalos.Clear();





        //InsertionSort
        Console.WriteLine("Insertion Sort");

        for (int i = 0; i < 10; i++)
        {

            arrays.popularAleatoriaComRepetido(arrays.Array9);

            tempos.Add(Ordenacao.InsertionSort(arrays.Array9));
            Array.Clear(arrays.Array9, 0, arrays.Array9.Length);

        }

        media = program.calcularMedia(tempos);

        Console.WriteLine("Média do Insert Sort: " + media);

        variancia = program.variancia(tempos, media);
        Console.WriteLine("Variância do Insert Sort: " + variancia);

        desvio = program.desvioPadrao(variancia);

        Console.WriteLine(desvio);

        novaMedia = program.novaMedia(tempos, desvio, media, temposIntervalos);

        Console.WriteLine("Nova média: " + novaMedia);


        tempos.Clear();
        temposIntervalos.Clear();



        //SelectSort
        Console.WriteLine("SelectSort");

        for (int i = 0; i < 10; i++)
        {

            arrays.popularAleatoriaComRepetido(arrays.Array9);

            tempos.Add(Ordenacao.SelectSort(arrays.Array9));
            Array.Clear(arrays.Array9, 0, arrays.Array9.Length);

        }

        media = program.calcularMedia(tempos);

        Console.WriteLine("Média do Select Sort: " + media);

        variancia = program.variancia(tempos, media);
        Console.WriteLine("Variância do Select Sort: " + variancia);

        desvio = program.desvioPadrao(variancia);

        Console.WriteLine(desvio);

        novaMedia = program.novaMedia(tempos, desvio, media, temposIntervalos);

        Console.WriteLine("Nova média: " + novaMedia);


        tempos.Clear();
        temposIntervalos.Clear();



        //HeapSort
        Console.WriteLine("Heap Sort");
        for (int i = 0; i < 10; i++)
        {

            arrays.popularAleatoriaComRepetido(arrays.Array9);

            tempos.Add(Ordenacao.HeapSort(arrays.Array9));
            Array.Clear(arrays.Array9, 0, arrays.Array9.Length);

        }

        media = program.calcularMedia(tempos);

        Console.WriteLine("Média do Heap Sort: " + media);

        variancia = program.variancia(tempos, media);
        Console.WriteLine("Variância do Heap Sort: " + variancia);

        desvio = program.desvioPadrao(variancia);

        Console.WriteLine(desvio);

        novaMedia = program.novaMedia(tempos, desvio, media, temposIntervalos);

        Console.WriteLine("Nova média: " + novaMedia);


        tempos.Clear();
        temposIntervalos.Clear();

        //Shell Sort
        Console.WriteLine("Shell Sort");

        for (int i = 0; i < 10; i++)
        {

            arrays.popularAleatoriaComRepetido(arrays.Array9);

            tempos.Add(Ordenacao.shellSort(arrays.Array9));
            Array.Clear(arrays.Array9, 0, arrays.Array9.Length);

        }

        media = program.calcularMedia(tempos);

        Console.WriteLine("Média do Shell Sort: " + media);

        variancia = program.variancia(tempos, media);
        Console.WriteLine("Variância do Shell Sort: " + variancia);

        desvio = program.desvioPadrao(variancia);

        Console.WriteLine(desvio);

        novaMedia = program.novaMedia(tempos, desvio, media, temposIntervalos);

        Console.WriteLine("Nova média: " + novaMedia);


        tempos.Clear();
        temposIntervalos.Clear();


        //Merge Sort
        Console.WriteLine("Merge Sort");

        for (int i = 0; i < 10; i++)
        {

            arrays.popularAleatoriaComRepetido(arrays.Array9);

            tempos.Add(Ordenacao.MergeSort(arrays.Array9));
            Array.Clear(arrays.Array9, 0, arrays.Array9.Length);

        }

        media = program.calcularMedia(tempos);

        Console.WriteLine("Média do Merge Sort: " + media);

        variancia = program.variancia(tempos, media);
        Console.WriteLine("Variância do Merge Sort: " + variancia);

        desvio = program.desvioPadrao(variancia);

        Console.WriteLine(desvio);

        novaMedia = program.novaMedia(tempos, desvio, media, temposIntervalos);

        Console.WriteLine("Nova média: " + novaMedia);


        tempos.Clear();
        temposIntervalos.Clear();

        //Quick Sort
        Console.WriteLine("Quick Sort");

        for (int i = 0; i < 10; i++)
        {

            arrays.popularAleatoriaComRepetido(arrays.Array9);

            tempos.Add(Ordenacao.QuickSort(arrays.Array9));
            Array.Clear(arrays.Array9, 0, arrays.Array9.Length);

        }

        media = program.calcularMedia(tempos);

        Console.WriteLine("Média do Quick Sort: " + media);

        variancia = program.variancia(tempos, media);
        Console.WriteLine("Variância do Quick Sort: " + variancia);

        desvio = program.desvioPadrao(variancia);

        Console.WriteLine(desvio);

        novaMedia = program.novaMedia(tempos, desvio, media, temposIntervalos);

        Console.WriteLine("Nova média: " + novaMedia);


        tempos.Clear();
        temposIntervalos.Clear();





































    }

    public double calcularMedia(List<double> tempos)
    {
        double media = tempos.Sum(x => Convert.ToInt64(x)) / 10;
        return media;
    }

    public double variancia(List<double> tempos,double media)
    {
        double somaVariancia = tempos.Select(num => (double) Math.Pow(num - media, 2)).Sum();
    double variancia = somaVariancia / tempos.Count;
        return variancia;
    }

    public double desvioPadrao (double variancia)
    {
        return (double) Math.Sqrt(variancia);
    }

    public double novaMedia(List<double> tempos,double desvioPadrao,double media, List<double> temposIntervalos)
    {

    double desvioPositivo = media + desvioPadrao;
    double desvioNegativo = media - desvioPadrao;
        for (int i = 0; i < tempos.Count; i++)
        {
            if (tempos[i] >= desvioNegativo && tempos[i] <= desvioPositivo)
            {
                temposIntervalos.Add(tempos[i]);
            }
        }

        return temposIntervalos.Sum(x => (double) x) / temposIntervalos.Count;
    }
}