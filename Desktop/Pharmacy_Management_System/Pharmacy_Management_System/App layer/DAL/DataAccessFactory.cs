using DAL.Interface;
using DAL.Models.Entities;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IProfile<Pharmacist, int, bool> PharmacistData()
        {
            return new PharmacistRepo();
        }
    }
}
