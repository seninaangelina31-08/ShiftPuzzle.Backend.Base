namespace Homw2;

class Program
{
    static void Main(){
        Console.WriteLine("Угадайте число от 1 до 100, у вас 10 попыток)"); 
        Random rnd = new Random();
        int num = rnd.Next(1, 100);
        
        for (int i = 0; i < 10; i++){
            int numvod = Convert.ToInt32(Console.ReadLine());
            if(i == 9){
                Console.WriteLine("Вы не угадали, попробуйте снова!");   
            }
            else if (numvod < num){
                Console.WriteLine("Загаданное число больше");
            }

            else if (numvod > num){
                Console.WriteLine("Загаданное число меньше");
            }

            else if (numvod == num){
                Console.WriteLine("Ура, вы угадали!");
            }   
        }                
    }
}
