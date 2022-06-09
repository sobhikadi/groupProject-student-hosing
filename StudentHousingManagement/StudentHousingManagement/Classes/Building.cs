namespace StudentHousingManagement
{
    public class Building
    {
        int noOfHouses;
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

        public Building(string address, int noOfHouses)
        {
            Address = address;
            this.noOfHouses = noOfHouses;

            Houses = new List<House>();
            NewHouse(3, "51");
            Residents = new List<User>();
            Complaints = new List<Message>();
            Announcements = new List<Message>();
        }

        public bool NewHouse(int noOfResidents, string houseNumber)
        {
            foreach(House house in Houses)
            {
                if (houseNumber == house.HouseNumber)
                { return false; }
            }
            Houses.Add(new House(this, noOfResidents, houseNumber));
            return true;
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
        { return Houses.Count < noOfHouses; }

        public override string ToString()
        {
            return Address;
        }
    }
}