namespace GenericProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Generic Method");
            Console.WriteLine("------------------------Interger Maximum check-----------------------");
            int maximum = Generic.CheckMaximum(15, 30, 45);
            Console.WriteLine("-----------------------Float Maximum check-----------------------");
            float checkMax = Generic.CheckMaximumFloat(2.3f,4.5f,9.8f);
        }
    }
}