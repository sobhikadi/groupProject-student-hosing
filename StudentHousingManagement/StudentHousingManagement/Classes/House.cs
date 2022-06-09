﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class House
    {
        private ChoreSchedule choreSchedule;
        private string houseRules;

        public Building Building
        { get; private set; }
        public List<User> Residents
        { get; private set; }
        public List<Message> Announcements
        { get; private set; }
        
        public string HouseNumber
        { get; private set; }
        public int NoOfResidents
        { get; private set; }

        public House(Building building, int noOfResidents, string houseNumber)
        {
            Building = building;
            NoOfResidents = noOfResidents;
            HouseNumber = houseNumber;

            Residents = new List<User>();
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

        public bool RoomAvailable()
        { return Residents.Count < NoOfResidents; }

        public void NewHouseRules(string rules)
        { }

        public override string ToString()
        {
            return $"House Number: {HouseNumber}";
        }
    }
}
