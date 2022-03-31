using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_3.Model
{
    internal class User
    {
      //  static Random rnd = new Random();
     //   public static int nextAvaribaleID = rnd.Next(1, 9999);
    //    public readonly int ID = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        /*   public User(string fName, int iage)
           {

               ID = User.nextAvaribaleID++;
               Name = fName;
               age = iage;

           }
        */
        public override string ToString()
        {
            return "User is" + Id + "   " + Name + "   " + age;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is User))
            {
                return false;
            }
            return (this.Name == ((User)obj).Name)
                && (this.age == ((User)obj).age);
        }

    }
  
}
