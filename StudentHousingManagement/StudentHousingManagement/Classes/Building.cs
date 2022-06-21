namespace StudentHousingManagement
{
    [Serializable]
    public class Building
    {
        string? buildingRules;

        int IDFeeder = 0;

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
        }
        public void RemoveResident(User resident)
        {
            Residents.Remove(resident);
        }
        public void NewBuildingRules(string rules)
        {

        }

        public bool HouseAvailable()
        { return Houses.Count < NoOfHouses; }

        public override string ToString()
        {
            return Address;
        }
    }
}