public class Program
{
    private static void Main(string[] args)
    {
        static int findAngle(int hour, int minute)
        {
            hour = hour % 12;
            int h = hour * 360 / 12 + minute * 360 / (12 * 60);
            int m = minute * 360 / 60;
            int angle = Math.Abs(h - m);

            if (angle > 180)
            {
                angle = 360 - angle;
            }

            return angle;
        }
        Console.Write("Enter the hours: ");
        int hh = int.Parse(Console.ReadLine());
        Console.Write("Enter the minutes: ");
        int mm = int.Parse(Console.ReadLine());


        Console.WriteLine($"Angle between {hh} hours and {mm} minutes is {findAngle(hh, mm)} degrees.");
    }
}