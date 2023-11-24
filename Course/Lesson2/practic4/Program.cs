// See https://aka.ms/new-console-template for more information
int cnt = 0;
string a;
        
    while (true){
        a = Console.ReadLine();
        if (a == "") {
            cnt++;
        } else {
            break;
        }
    }
Console.Write(cnt);

