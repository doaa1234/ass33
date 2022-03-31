using assigment_3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_3.View
{
    public class UserModelView
    {

        private List<User> user1 = new List<User>();
        private List<StaffUser> staff1 = new List<StaffUser>();
        private List<AdminUser> admin1 = new List<AdminUser>();
        public UserModelView()
        {
            user1 = new List<User>();
            staff1 = new List<StaffUser>();
            admin1 = new List<AdminUser>();
        }

        internal void Add(User user)
        {
            user1.Add(user);


        }
        internal void Add(StaffUser staff)
        {
            staff1.Add(staff);


        }
        internal void Add(AdminUser admin)
        {
            admin1.Add(admin);


        }


        internal void edit(User user)
        {


        }
        internal void edit(StaffUser staff)
        {



        }
        internal void edit(AdminUser admin)
        {



        }
        //3
        public void Delete(int indexUser)
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
        public void RemoveAT(double indexAdmain)
        {
            if (user1.Count == 0)
            {
                throw new Exception("the list is empty");
            }
            else if (indexAdmain >= user1.Count)
            {
                throw new Exception($"index[{indexAdmain}] out of bound exception");
            }
            user1.RemoveAt((int)indexAdmain);
        }

        public void RemoveAT(float indexStaff)
        {
            if (user1.Count == 0)
            {
                throw new Exception("the list is empty");
            }
            else if (indexStaff >= user1.Count)
            {
                throw new Exception($"index[{indexStaff}] out of bound exception");
            }
            user1.RemoveAt((int)indexStaff);
        }


        /*    internal void Delete(int indexuser)
            {
                if (user1.Count == 0)
                {
                    throw new Exception("the list is empty");

                }
                else if (indexuser >= user1.Count)
                {
                    throw new Exception($"index[{indexuser}] out of bound exception");
                }
                user1.RemoveAt(indexuser);

            }
            public void RemoveAT(float indexStaff)
            {
                if (users.Count == 0)
                {
                    throw new Exception("the list is empty");
                }
                else if (indexStaff >= users.Count)
                {
                    throw new Exception($"index[{indexStaff}] out of bound exception");
                }
                users.RemoveAt((int)indexStaff);
            }
            internal void Delete(int indexstaff)
            {
                if (staff1.Count == 0)
                {
                    throw new Exception("the list is empty");

                }
                else if (indexstaff >= staff1.Count)
                {
                    throw new Exception($"index[{indexstaff}] out of bound exception");
                }
                staff1.RemoveAt(indexstaff);

            }
            internal void Delete(int indexadmin)
            {
                if (admin1.Count == 0)
                {
                    throw new Exception("the list is empty");

                }
                else if (indexadmin >= admin1.Count)
                {
                    throw new Exception($"index[{indexadmin}] out of bound exception");
                }
                admin1.RemoveAt(indexadmin);

            }
        */

    }
}
        //3




    

