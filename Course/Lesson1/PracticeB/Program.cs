namespace PracticeB;
class Program
{
    static void Main(string[] args)
    {
        /*
        ввод в формате: "ЦЫФРА_1 ОПЕРАТОР ЦЫФРА_2"
        Ошибки при не правильном вводе я не пофиксил (было лень, да и задание про другое) 
        */
        string expression = Console.ReadLine();
        string[] elements = expression.Split();
        if(elements[1] == "+"){
            Console.WriteLine(Convert.ToInt32(elements[0]) + Convert.ToInt32(elements[2]));
        }
        else if(elements[1] == "-"){
            Console.WriteLine(Convert.ToInt32(elements[0]) - Convert.ToInt32(elements[2]));
        }
        else if(elements[1] == "*"){
            Console.WriteLine(Convert.ToInt32(elements[0]) * Convert.ToInt32(elements[2]));
        }
        else if(elements[1] == "/"){
            Console.WriteLine(Convert.ToInt32(elements[0]) + Convert.ToInt32(elements[2]));
        }
    }
}
