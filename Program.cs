public class program
{
    // Matrix de leitura
    // Marcelo Carreta
    static public double[,] Matrix_Read()
    {
     
    
    double[,] r;

    //Pedir dim do vetor
    Console.WriteLine("Indique o número de linhas: ");
    int line = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Indique o número de colunas: ");
    int column = Convert.ToInt32(Console.ReadLine());

    r = new double[line, column];
    
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
            {
            Console.WriteLine($"Insira o valor do elemento da linha {i+1} coluna {j+1} : "); 
              r[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        
    }
    
    return r;




    }

    //Multiplicação por um escalar
    // Marcelo Carreta
    static public double[,] Matrix_Scalar_Mult(int a , double[,] m)
    {
       double[,] r;
       r = new double[m.GetLength(0), m.GetLength(1)];
        for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
            {
                r[i, j] = a * m[i, j];
            }
        
    }
    return r;
    }
  
    //Soma de matrizes
    // Jaime Domingos
    static public void Matrix_Add()
    {
        
    }

    //Multiplicação de matrizes
    // Eltino Domingos
    static public void Matrix_Mult()
    {
        
    }
    //Inversa de uma matriz 2×2
    //  Uveli Afonso
    static public void Matrix_Inverse_2x2()
    {
        
    }

    //Determinante de uma matriz 3×3 por Laplace
    // Uveli Afonso
    static public void Matrix_Determinant_3x3()
    {
        
    }
    //Transposta de uma matriz
    // Jaime Domingos
    static public void Matrix_Transpose()
    {
        
    }

    //Verificar se uma matriz é diagonal
    // Marcelo Carreta
    static public void Matrix_IsDiagonal()
    {
        
    }

    //Verificar se uma matriz é triangular superior
    // Jaime Domingos
    static public void Matrix_IsUpperTriangular()
    {
        
    }

    //Imprime uma matriz de forma legível; usada para testar todas as outras funções. 
    // Eltino Domingos
    static public void Matrix_Print(double[,] m)
    {
        // Console.WriteLine(text);
        for (int i = 0; i < m.GetLength(0); i++)
        {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write($"{m[i,j]},");
        }
       }
    }

    //Determinante de uma matriz 2x2; é a base do Matrix_Inverse_2x2 e do Matrix_Determinant_3x3.
    //Uveli Afonso
    static public void Matrix_Determinant_2x2()
    {
        
    }

    static void Main(string[] args)
    {
        // Matrix_Print(Matrix_Read());
        Matrix_Print(Matrix_Scalar_Mult(2, Matrix_Read()));
    }
}