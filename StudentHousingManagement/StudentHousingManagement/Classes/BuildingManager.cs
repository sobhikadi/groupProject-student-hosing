using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class BuildingManager
    {

        List<string> buildingAddresses;

        public List<Building> Buildings 
        { get; private set; }

        public BuildingManager()
        {
            Buildings = new List<Building>();
            LoadBuildingAddresses();
        }

        public void SaveBuilding(Building building)
        {
            FileStream? fs = null;
            BinaryFormatter? bf = null;

            try
            {
                fs = new FileStream($"{building.Address}", FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, building);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { if (fs != null) fs.Close(); }
        }

        public Building LoadBuilding(string buildingAddress)
        {
            Building? building = null;
            FileStream? fs = null;
            BinaryFormatter? bf = null;

            try
            {
                fs = new FileStream($"{building.Address}", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                building = (Building)bf.Deserialize(fs);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { if (fs != null) fs.Close(); }

            if (building != null) { Buildings.Add(building); }
            return building;
        }

        public void LoadAllBuildings()
        {
            if (buildingAddresses == null)
            { return; }
            FileStream? fs = null;
            BinaryFormatter? bf = null;

            foreach (string buildingAddress in buildingAddresses)
            {
                try
                {
                    fs = new FileStream($"{buildingAddress}", FileMode.Open, FileAccess.Read);
                    bf = new BinaryFormatter();
                    Buildings.Add((Building)bf.Deserialize(fs));
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                finally
                { if (fs != null) fs.Close(); }
            }
        }

        public void SaveBuildingAddresses(List<string> addresses)
        {
            List<string> buildingAddresses = addresses;
            FileStream? fs = null;
            BinaryFormatter? bf = null;

            try
            {
                fs = new FileStream($"Building addresses", FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, buildingAddresses);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { if (fs != null) fs.Close(); }
        }

        public void LoadBuildingAddresses()
        {
            FileStream? fs = null;
            BinaryFormatter? bf = null;

            try
            {
                fs = new FileStream($"Building addresses", FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                buildingAddresses = (List<string>)bf.Deserialize(fs);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { if (fs != null) fs.Close(); }
        }
    }
}
