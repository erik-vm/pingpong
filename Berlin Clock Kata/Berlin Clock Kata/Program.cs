

using System.Linq;
using System.Reflection.Metadata.Ecma335;

class BerlinClock
{
    public static string SingleMinutes(int minutes)
    {
        if (minutes %5 == 0)
        {
            return "OOOO";
        }
        if (minutes % (10) == 6 || minutes % (10) == 1)
        {
            return "YOOO";
        }
        if (minutes % (10) == 7 || minutes % (10) == 2)
        {
            return "YYOO";
        }
        if (minutes % (10) == 8 || minutes % (10) == 3)
        {
            return "YYYO";
        }
        if (minutes % (10) == 9 || minutes % (10) == 4)
        {
            return "YYYY";
        }

        return "error";
    }
    public static string FiveMinutes(int minutes)
    {
        string[] minutesUp = new string[11] { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" };

        if (minutes >= 5)
        {
            minutesUp[0] = "Y";

            if (minutes >= 10)
            {
                minutesUp[1] = "Y";
            }
        }
        if (minutes >= 15)
        {
            minutesUp[2] = "R";

            if (minutes >= 20)
            {
                minutesUp[3] = "Y";

                if (minutes >= 25)
                {
                    minutesUp[4] = "Y";
                }
            }
            if (minutes >= 30)
            {
                minutesUp[5] = "R";

                if (minutes >= 35)
                {
                    minutesUp[6] = "Y";

                    if (minutes >= 40)
                    {
                        minutesUp[7] = "Y";
                    }
                }
                if (minutes >= 45)
                {
                    minutesUp[8] = "R";

                    if (minutes >= 50)
                    {
                        minutesUp[9] = "Y";

                        if (minutes >= 55)
                        {
                            minutesUp[10] = "Y";
                        }
                    }
                }
            }
        }

        string res = string.Join( "",minutesUp);
        if (minutes >= 60)
        {
            res = "error";
        }
        return res;
    }
    public static string SingleHours(int hours)
    {
        if (hours % 5 == 0)
        {
            return "OOOO";
        }
        if (hours % (10) == 6 || hours % (10) == 1)
        {
            return "ROOO";
        }
        if (hours % (10) == 7 || hours % (10) == 2)
        {
            return "RROO";
        }
        if (hours % (10) == 8 || hours % (10) == 3)
        {
            return "RRRO";
        }
        if (hours % (10) == 9 || hours % (10) == 4)
        {
            return "RRRR";
        }

        return "error";
    }
    public static string FiveHours(int hours)
    {
        if (hours < 5)
        {
            return "OOOO";
        }
        if (hours >= 5 && hours < 10)
        {
            return "ROOO";
        }
        if (hours >= 10 && hours < 15)
        {
            return "RROO";
        }
        if (hours >= 15 && hours < 20)
        {
            return "RRRO";
        }
        if (hours >= 20 && hours < 24)
        {
            return "RRRR";
        }

        return "error";
    }
    public static string SecondsLap(int seconds)
    {
        if (seconds % 2 == 0)
        {
            return "Y";
        }
        else
        {
            if (seconds >= 60)
            {
                return "error";
            }
            return "O";
        }
    }
    public static string BerlinClockToDigitalTime(string clock)
    {
        char[] clockArray = new char[clock.Length-1];
        int[] t = new int[clock.Length-1];
        int digitalTimeHours = 0;
        int digitalTimeMinutes = 0;
        string digitalTime = "";

        for (int i = 0; i < clockArray.Length; i++)
        {
            clockArray[i] = clock[i+1];
            if (clockArray[i] == 'O')
            {
                t[i] = 0;
            }
            else
            {
                t[i] = 1;
            }
        }

        digitalTimeHours = ((t[0]+ t[1]+ t[2] + t[3]) * 5) + t[4] + t[5] + t[6] + t[7];

        digitalTimeMinutes = ((t[8] + t[9] + t[10] + t[11] + t[12] + t[13] + t[14] + t[15] + t[16] + t[17] + t[18]) * 5) + t[19] + t[20] + t[21] + t[22];
        
        if (digitalTimeHours >= 10 && digitalTimeMinutes >=10)
        {
            digitalTime = digitalTimeHours + ":" + digitalTimeMinutes;
        }
        else if (digitalTimeHours < 10 && digitalTimeMinutes >= 10)
        {
            digitalTime = "0" + digitalTimeHours + ":" + digitalTimeMinutes;
        }
        else if (digitalTimeHours >= 10 && digitalTimeMinutes < 10)
        {
            digitalTime = digitalTimeHours + ":" + "0" + digitalTimeMinutes;
        }
        else if (digitalTimeHours < 10 && digitalTimeMinutes < 10)
        {
            digitalTime = "0" + digitalTimeHours + ":" + "0" + digitalTimeMinutes;
        }

        return digitalTime;
    }

    static void Main(string[] args)
    {
        int hours;
        int minutes;
        int seconds;
        string berlinClock;

        seconds = 2;
        minutes = 2;
        hours = 10;

        berlinClock = SecondsLap(seconds) + FiveHours(hours) + SingleHours(hours) + FiveMinutes(minutes) + SingleMinutes(minutes);

        Console.WriteLine(BerlinClockToDigitalTime(berlinClock));
        Console.WriteLine(berlinClock);
        Console.WriteLine(SecondsLap(seconds));
        Console.WriteLine(FiveHours(hours));
        Console.WriteLine(SingleHours(hours));
        Console.WriteLine(FiveMinutes(minutes));
        Console.WriteLine(SingleMinutes(minutes));
    }
}