# ass33



created inside the model three classes: Admin, User, and Staff

I built a function for adding, modifying and deleting for three users
     internal void Add(User user)
        {
            user1.Add(user);


        }
            internal void edit(int id,string name,int age,User user2)
        {
            try
            {
                if (id == user2.Id)
                {
                    user2.age = age;
                    user2.Name = name;
                }
            }
            catch(editException e)
            {
                Console.WriteLine("the id incorrect", e.Message);
            }

        }
                public void RemoveAt(int indexUser)
        {
       
            
                if (user1.Count == 0)
                {
                    throw new Exception("the list is empty");
                }
        
         
            else if (indexUser >= user1.Count)
            {
                throw new Exception($"index[{indexUser}] out of bound exception");
            }
            user1.RemoveAt(indexUser);
        }
i built a class Exception I used it in the edit  function
  public class editException: Exception
        {
            public editException(string message) : base(message)
            {

            }
        }
