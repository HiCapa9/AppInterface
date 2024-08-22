namespace AppInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");

            PasswordManager pm = new PasswordManager("iluvpie", true);
            tdl.Display();
            pm.Display();

            pm.Reset();
            tdl.Reset();

            pm.Display();
            tdl.Display();


        }
    }
}
