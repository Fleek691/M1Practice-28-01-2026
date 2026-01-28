using Microsoft.VisualBasic;

namespace String
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the UserName: ");
            string UserName=Console.ReadLine()!;
            string result="";
            if (validateUserName(UserName))
            {
                result=PasswordGenerator(UserName);
            }
            else
            {
                System.Console.WriteLine($"{UserName} is an invalid Username");
            }
            System.Console.WriteLine(result);

        }
        public static string PasswordGenerator(string name)
        {
            string password="TECH_";
            int sum=0;
            name.ToLower();
            for(int i = 0; i < 4;i++)
            {
                sum+=(int)name[i];
            }
            password+=sum.ToString();
            password+=int.Parse(name.Substring(name.Length-2));
            return password;

        }
        public static bool validateUserName(string name)
        {
            if (name.Length != 8)
            {
                return false;
            }
            if (name[4] != '@')
            {
                return false;
            }
            int.TryParse(name.Substring(name.Length-3),out int courseId);
            if(courseId>115 || courseId < 110)
            {
                return false;
            }
            return true;
        }
    }
}