namespace Task4;

class Program
{ 
    public static int Summa(int a) 
    { 
        int s=0; 
        while (a>0) 
        { 
            s=s+ (a % 10); 
            a=a/10; 
        } 
        return s; 
    }
}