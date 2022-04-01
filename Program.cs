


using assigment_3.View;


namespace ass3
{
 


    class program
    {
        static int gitchoice()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Enter your choice: 1, 2, 3,4,5,6,7,8,9 or -1 (Exit)");
            Console.WriteLine("1: add user");
            Console.WriteLine("2: edit user");
            Console.WriteLine("3: delete staffuser");
            Console.WriteLine("4: add staffuser");
            Console.WriteLine("5: edit staffuser");
            Console.WriteLine("6: delete staffuser");
            Console.WriteLine("7: add adminuser");
            Console.WriteLine("8: edit adminuser");
            Console.WriteLine("9: delete adminuser");
            int Choice= Convert.ToInt32(Console.ReadLine());
            return Choice;
        }


        static void Main(string[] args)
        {
            int choice = gitchoice();
            //  Observable<string> 

            UserModelView users = new UserModelView();
            //     users.Add(new.User( "doaa", 20));
            
            while(choice !=-1)
            {
                if(choice == 1)
                {
                    Console.WriteLine("add user");
                    users = new UserModelView();
                }
                else if(choice == 2)
                {
                    Console.WriteLine("edit user");
                }
                else if(choice == 3)
                {
                    Console.WriteLine("delete user");
                }

                choice = gitchoice();
            }
            




        }
    }
}
