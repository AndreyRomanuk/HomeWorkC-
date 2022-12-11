namespace Common;

public static class Distance3D
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
    public static double GetCoordinates(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        return distance;
    }
}