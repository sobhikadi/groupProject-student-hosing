namespace StudentHousingManagement
{
    [Serializable]
    public class Building
    {
        public List<User> Residents
        { get; private set; }
        public List<House> Houses
        { get; private set; }
        public List<Message> Complaints
        { get; private set; }
        public List<Message> Announcements
        { get; private set; }

        public string Address
        { get; private set; }
        public int NoOfHouses
        { get; private set; }
        public string? BuildingRules
        { get; private set; }

        public Building(string address, int noOfHouses)
        {
            Address = address;
            this.NoOfHouses = noOfHouses;

            Houses = new List<House>();
            Residents = new List<User>();
            Complaints = new List<Message>();
            Announcements = new List<Message>();
        }

        public void AddResident(User resident)
        {
            Residents.Add(resident);
            SaveMe();
        }
        public void RemoveResident(User resident)
        {
            Residents.Remove(resident);
            SaveMe();
        }
        public void NewBuildingRules(string rules)
        {
            BuildingRules = rules;
            SaveMe();
        }

        public bool HouseAvailable()
        { return Houses.Count < NoOfHouses; }

        public void SaveMe()
        {
            BuildingController buildingController = new BuildingController();
            buildingController.SaveBuilding(this);
        }

        public override string ToString()
        {
            return Address;
        }
    }
}