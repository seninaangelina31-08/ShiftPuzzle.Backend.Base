


string[] messages = {"My", "Name", "Is", "Eva", "My", "Home", "Is", "Vorkuta", "Miyagi", "Andy Panda"};
string[] rotatedMessages = new string[messages.Length];
int k = 0;
while (k < messages.Length)
{
    rotatedMessages[k] = messages[messages.Length - k - 1];
    k++;
}
foreach (string rotMessage in rotatedMessages)
{
    Console.WriteLine(rotMessage);
}