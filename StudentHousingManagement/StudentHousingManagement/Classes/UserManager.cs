using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class UserManager
    {
        public List<User> Users
        { get; private set; }
        public List<Admin> Admins
        { get; private set; }

        public UserManager()
        {

            Users = new List<User>();
            Admins = new List<Admin>();
            LoadUsers();
            LoadAdmins();
        }
        public void SaveUsers(List<User> users)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("Users", FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();

                bf.Serialize(fs, users);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { if (fs != null) fs.Close(); }
        }
        public void SaveAdmins(List<Admin> admins)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("Admins", FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();

                bf.Serialize(fs, admins);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { if (fs != null) fs.Close(); }
        }

        public void LoadUsers()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("Users", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();

                Users = (List<User>)bf.Deserialize(fs);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { if (fs != null) fs.Close(); }
        }

        public void LoadAdmins()
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream("Admins", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();

                Admins = (List<Admin>)bf.Deserialize(fs);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { if (fs != null) fs.Close(); }
        }
    }
}
