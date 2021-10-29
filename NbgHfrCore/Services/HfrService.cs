using Microsoft.EntityFrameworkCore;
using NbgHfrCore.Data;
using NbgHfrCore.Model;
using NbgHfrCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NbgHfrCore.Services
{
    public class HfrService : IHfrService
        {
        private readonly HfrDbContext hfrDbContext;
        public HfrService(HfrDbContext hrDbContext)
        {
            this.hfrDbContext = hfrDbContext;

        }


        public async Task<Host> CreateHost(Host host)
        {
            hfrDbContext.Host.Add(host);
            await hfrDbContext.SaveChangesAsync();
            return host;
        }

        public async Task<Property> CreateProperty(Property property)
        {
            hfrDbContext.Property.Add(property);
            await hfrDbContext.SaveChangesAsync();
            return property;
        }

        public async Task<bool> DeleteHost(int id)
        {
            Host host = hfrDbContext.Host.Find(id);
            if (host == null) return false;
            hfrDbContext.Host.Remove(host);
            await hfrDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProperty(int id)
        {
            Property property = hfrDbContext.Property.Find(id);
            if (property == null) return false;
            hfrDbContext.Property.Remove(property);
            await hfrDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Host> EditHost(int id, Host host)
        {
            Host hostFromDb = hfrDbContext.Host.Find(id);
            if (hostFromDb == null) return null;
            hostFromDb.Address   = host.Address;
            hostFromDb.Email     = host.Email;
            hostFromDb.FirstName = host.FirstName;
            hostFromDb.LastName  = host.LastName;
            hostFromDb.LastName  = host.PhoneNumber;
            await hfrDbContext.SaveChangesAsync();
            return hostFromDb;
        }

        public async Task<Property> EditProperty(int id, Property property)
        {
            Property propertyFromDb = hfrDbContext.Property.Find(id);
            if (propertyFromDb == null) return null;
            propertyFromDb.Location = property.Location;
            propertyFromDb.Price = property.Price;
            propertyFromDb.Description = property.Description;
            propertyFromDb.Description = property.Description;
            await hfrDbContext.SaveChangesAsync();
            return propertyFromDb; 
        }

        public async Task<List<Host>> GetHost()
        {
            return await hfrDbContext.Host.ToListAsync();
        }

        public async Task<Host> GetHost(int id)
        {
            return await hfrDbContext.Host.FindAsync(id);
        }

        public  async Task<List<Property>> GetProperty()
        {
            var q = await hfrDbContext.Property.ToListAsync();
            if (q == null) return null;
            return q;
        }

        public async Task<Property> GetProperty(int id)
        {
            return await hfrDbContext.Property.FindAsync(id); 
        }

        public async Task<Host> GetPropertiesByHost (int hostId)
        {
            return await hfrDbContext.Host
               .Where(host => host.HostId == hostId)
               .Include(p => p.Properties).SingleOrDefaultAsync();
        }
    }
}
        