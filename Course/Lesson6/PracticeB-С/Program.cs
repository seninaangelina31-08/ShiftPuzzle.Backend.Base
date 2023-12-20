// Пратика B
static void Task1(int [] mass, int N){
    var maxIndex = 0;
    var max = 0;
    for (var i = 0; i < mass.Length - N; i++){
        var Sum = 0;
            for (var j = i; j < i + N; j++){
                Sum += mass[j];
                if (max < Sum){
                    max = Sum;
                    maxIndex = i;
                }
            }
        }
 
 
    for (var i = maxIndex; i < maxIndex + N; i++){
        Console.WriteLine(mass[i]);
    }
}

Task1([34, 1, 45, 1, 3, 5, 4, 2], 5);

//Пратика C is in process.....



