class Program
{
    public static void Main(string[] args)
    {
       ILogger logger = new ConsoleLogger();
       UserService userService = new UserService(logger);
       userService.CreateUser("Alice"); 
    }
}
