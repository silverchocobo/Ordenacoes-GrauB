using System.Runtime.Intrinsics.Arm;

//Classe para criar e popular arrays
class ConjuntoArrays{

    
    //Criação de todos os tamanhos de arrays que serão utilizados
    private int [] array = new int [128];
    private int [] array1 = new int [256];

    private int [] array2 = new int [512];

    private int [] array3 = new int [1024];

    private int [] array4 = new int [2048];

    private int [] array5 = new int [4096];

    private int [] array6 = new int [8192];

    private int [] array7 = new int [16384];

    private int [] array8 = new int [32768];

    private int [] array9 = new int [65536];

    public int[] Array{
        get { return array; }
    }

    public int[] Array1{
        get { return array1; }
    }

    public int[] Array2{
        get { return array2; }
    }

    public int[] Array3{
        get { return array3; }
    }

    public int[] Array4{
        get { return array4; }
    }

    public int[] Array5{
        get { return array5; }
    }

    public int[] Array6{
        get { return array6; }
    }

    public int[] Array7{
        get { return array7; }
    }

    public int[] Array8{
        get { return array8; }
    }

    public int[] Array9{
        get { return array9; }
    }

    Random rnd = new Random();
    

    //Método de popular array com valores em ordem crescente e sem repetições
    public void popularCrescenteSemRepetido(int[] array){
        for (int i = 0; i < array.Length; i++){
            array[i] = i;
        }
    }

    //Método de popular array com valores em ordem decrescente e sem repetições
    public void popularDecrescenteSemRepetido(int [] array){
        for (int i = 0; i < array.Length;i++){
            array[i] = array.Length - i;
        }
    }

    //Método de popular array com valores aleatórios e sem repetições
    public void popularAleatoriaSemRepetido(int[] array){

        int numeroAleatorio;

        for(int i = 0; i < array.Length;i++){
            while (true){
                numeroAleatorio = rnd.Next(1, array.Length + 1);

                if (!array.Contains(numeroAleatorio)){

                    array[i] = numeroAleatorio;
                    break;
                }
            }

            

        }
    }

    //Método de popular array com valores aleatórios e com repetições
    public void popularAleatoriaComRepetido(int[] array){

        int numeroAleatorio;

        for (int i = 0; i <array.Length; i++){
            numeroAleatorio = rnd.Next(0, array.Length);
            array[i] = numeroAleatorio;
        }
    }



    }

    

