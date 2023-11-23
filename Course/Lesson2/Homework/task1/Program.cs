namespace task1;
class Program
{
    static void Main(string[] args)
    {
        //ввод в формате: "ЦЫФРА_1 ОПЕРАТОР ЦЫФРА_2"
        string[] expressionSplit = Console.ReadLine().Split();
        Console.WriteLine(ExpressionExecution(expressionSplit));
    }

    static int ExpressionExecution(string[] expression)
    {
        int result = 0;
        if(expression[1] == "+"){
            result = Convert.ToInt32(expression[0]) + Convert.ToInt32(expression[2]);
        }
        else if(expression[1] == "-"){
            result = Convert.ToInt32(expression[0]) - Convert.ToInt32(expression[2]);
        }
        else if(expression[1] == "*"){
            result = Convert.ToInt32(expression[0]) * Convert.ToInt32(expression[2]);
        }
        else if(expression[1] == "/"){
            result = Convert.ToInt32(expression[0]) / Convert.ToInt32(expression[2]);
        }
        return result;
    }
}
