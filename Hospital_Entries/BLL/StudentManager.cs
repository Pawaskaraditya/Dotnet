﻿namespace BLL;
using BOL;
using DLL;
using System.Collections.Generic;
public class HelpManager
{

    public List<Hospital> GetAllHospitals()
    {
       List<Hospital> allHospitals= DatabaseManager.GetAllHospitalsFromDatabse();
       return allHospitals;
    }

    public Hospital GetHospital(int id)
    {
       // Console.WriteLine("inside helmanager BOL");
        Hospital newHospital= DatabaseManager.GetHospitalFromDatabase(id);
       // Hospital hospital=allHospitals.Find((h)=>h.Id==id);
        return newHospital;
    }

    public bool DoValidate(string username,string password)
    {
         List<Admin> allAdmins= DatabaseManager.GetAllAdminsFromDatabase();
       foreach(Admin a in allAdmins)
       {
        if(a.UserName==username  && a.Password==password)
        {
            return true;
        }
       }
       return false;
    }



     public bool InsertHospital(string name,string email,string pin)
    {
        // Hospital newHospital=new Hospital(name,email,pin);
       // Console.WriteLine("inside helmanager BOL");
        // List<Hospital> allHospitals= DatabaseManager.GetAllHospitalsFromFile();
        // allHospitals.Add(newHospital);

       if( DatabaseManager.InsertIntoDatabase(name,email,pin))
       {
        return true;
       }
        
        return false;

    }







}
