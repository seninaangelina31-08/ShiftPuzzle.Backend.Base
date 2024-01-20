string inputString = "казак";
bool isPalindrome = IsPalindrome(inputString.ToLower(), 0, inputString.Length - 1);

Console.WriteLine($"Строка '{inputString}' является палиндромом: {isPalindrome}");

static bool IsPalindrome(string str, int left, int right)
{
    if (left >= right)
    {
        return true;
        }
        if (str[left] != str[right])
        {
            return false;
            }
            else
            {
                return IsPalindrome(str, left + 1, right - 1);
                }
                }
