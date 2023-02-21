using First_API.Data;
using First_API.Interface;
using First_API.Models;
using Microsoft.AspNetCore.Mvc;


namespace First_API.Services
{
    public class Electronicsdata : IElectronicscs
    {
        private readonly StoreDB _dbContext;
        public Electronicsdata(StoreDB dbContext)
        {
            _dbContext = dbContext;
        }

        Electronics IElectronicscs.Add(Electronics elecs)
        {

            _dbContext.electronics.Add(elecs);
            _dbContext.SaveChanges();
            return elecs;
        }
    }
}
