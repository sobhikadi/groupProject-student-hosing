﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class BuildingController
    {
        BuildingManager buildingManager;
        public List<Building> Buildings
        { get; private set; }

        public BuildingController()
        {
            buildingManager = new BuildingManager();
            buildingManager.LoadAllBuildings();
            Buildings = buildingManager.Buildings;
        }

        public void NewBuilding(string address, int noOfHouses)
        {
            Building building = new Building(address, noOfHouses);
            Buildings.Add(building);
            SaveBuilding(building);            

            Buildings.Sort((a, b) => a.Address.CompareTo(b.Address));
        }

        public bool NewHouse(Building building, int noOfResidents, string houseNumber)
        {
            foreach (House house in building.Houses)
            {
                if (houseNumber == house.HouseNumber)
                { return false; }
            }
            building.Houses.Add(new House(building, noOfResidents, houseNumber));
            buildingManager.SaveBuilding(building);
            return true;
        }

        public bool ChangeHouse(House house, User user)
        {
            if (user.House != house)
            {
                user.House.RemoveResident(user);
                user.House.Building.RemoveResident(user);
                house.AddResident(user);
                house.Building.AddResident(user);
                return true;
            }
            else return false;
        }

        public void SaveBuilding(Building building)
        {
            List<string> addresses = new List<string>();

            foreach (Building b in Buildings)
            {
                addresses.Add(b.Address);
            }

            buildingManager.SaveBuildingAddresses(addresses);
            buildingManager.SaveBuilding(building);
        }
    }
}
