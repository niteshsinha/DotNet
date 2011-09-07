using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace CarRentalDLL
{
    public class RentCar
    {

       static ArrayList ar = new ArrayList();
        // default constructor
        public RentCar()
        {}
        //parameterized constructor
        public RentCar(string bookingid,string name, string car,string location, DateTime fromdate,DateTime todate)
        {
            this.bookingid = bookingid;
            this.name = name;
            this.car = car;
            this.location = location;
            this.fromdate = fromdate;
            this.todate = todate;
        }
        //properties
        public string bookingid { get; set; }
        public string name { get; set; }
        public string car { get; set; }
        public string location { get; set; }
        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }

        //populate array
        public string addData()
        {
            ar.Add(this);
            return ar.Count.ToString();
        }
        public ArrayList populateData()
        {
           // foreach (RentCar item in ar)
           // {
             //   Console.WriteLine(item.ToString());
            //}
            return ar;
        }
        public void delete(int n)
        {

            try
            {
                RentCar rc = (RentCar)ar[n];
                ar.Remove(rc);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }


        }
        public ArrayList search(string ser)
        {
            ArrayList newar = new ArrayList(ar);
            foreach (RentCar item in ar)
            {
                
                if (item.bookingid.StartsWith(ser) ||
                    item.car.StartsWith(ser) ||
                    item.fromdate.Equals(ser) ||
                    item.todate.Equals(ser) ||
                    item.name.StartsWith(ser)
                    ) 
                {
                        newar.Add(item);
                
                }

            }
            return newar;
       }

        //to generate a unique id 
        public string getId()
        {
            return Guid.NewGuid().ToString();
        }
       
    }
}
