namespace Common;

public static class GetNumber
{
    public static int GetNumberFromUser()
    {
        bool isParsed = int.TryParse(Console.ReadLine(), out int number);

        if (isParsed)
        {
            return number;
        }
        else
        {
            return -1;
        }
    }
}