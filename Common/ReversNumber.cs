namespace Common;

public static class ReversNumber
{
    public static int GetNumberFromUser()
    {
        bool isParsed = int.TryParse(Console.ReadLine(),out int number);

        if(isParsed)
        {
            return number;
        }
        else{
            return -1;
        }
    }
    public static int GetNumberOfRevers(int num)
    {
        int resNum = 0;

        while (num > 0)
        {
            resNum = resNum * 10 + num % 10;
            num = num / 10;
        }
        return resNum;
    }
}