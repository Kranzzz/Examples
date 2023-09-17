Console.Write("Enter user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "Va")
{
    Console.WriteLine("Hooray, it's Va!");
} 
else
{
    Console.WriteLine("Hello, ");
    Console.WriteLine(username);
}