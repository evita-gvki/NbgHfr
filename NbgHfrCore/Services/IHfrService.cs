using NbgHfrCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgHfrCore.Services
{
    public interface IHfrService
    {
        public Task<List<Host>> GetHost();
        public Task<Host> GetHost(int id);

        public Task<List<Property>> GetProperty();
        public Task<Property> GetProperty(int id);

        public Task<Host> CreateHost(Host host);
        public Task<Property> CreateProperty(Property property);


        public Task<Host> EditHost(int id, Host host);
        public Task<Property> EditProperty(int id, Property property);

        public Task<bool> DeleteHost(int id);
        public Task<bool> DeleteProperty(int id);

        public Task<Host> GetPropertiesByHost(int hostId);

    }
}
