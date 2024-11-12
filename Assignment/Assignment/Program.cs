namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new NotificationRepository();
            var service = new NotificationService(repository);
            Console.WriteLine("Enter the notification title:");
            string input = Console.ReadLine()!;
            service.DisplayChannels(input);
        }
    }
}
//In this case I am using Repository Design Pattern to solve this problem.

//Input "[BE][FE][Urgent] there is error"
//Output: "Receive channels: BE, FE, Urgent"

//Input: "[BE][QA][HAHA][Urgent] there is error"
//Output: "Receive channels: BE, QA, Urgent"
