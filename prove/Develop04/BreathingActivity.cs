using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.")
    {
    }
    
    public void RunActivity()
    {
        Start();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);
        while(currentTime < futureTime)
        {
            Console.WriteLine("\nBreathe in...");
            CountDown(4);
            Console.WriteLine("Breathe out...");
            CountDown(4);
            currentTime = DateTime.Now;
        }

        End();

    }

}