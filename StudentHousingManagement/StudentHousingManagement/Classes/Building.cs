namespace StudentHousingManagement
{
    public class Building
    {
        int ID;
        int noOfHouses;
        string buildingRules;


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
            NewHouse(6, "51-56");
            Residents = new List<User>();
            Complaints = new List<Message>();
            Announcements = new List<Message>();
        }

        public bool NewHouse(int noOfResidents, string houseNumber)
        {
            if (noOfHouses > IDFeeder)
            {
                Houses.Add(new House(this, noOfResidents, houseNumber));
                IDFeeder++;
                return true;
            }
            else return false;
        }

        public void AddResident(User resident)
        {
            Residents.Add(resident);
        }

        public void NewBuildingRules(string rules)
        {

        }

        public override string ToString()
        {
            return Address;
        }

        public void NewAnnouncement(string header, string body, User user, DateTime dateTime)
        {
            Announcements.Add(new Message(header, body, user, dateTime));
        }

        public void NewComplaint(string header, string body, User user, DateTime dateTime)
        {
            Complaints.Add(new Message(header, body, user, dateTime));
        }
    }
}