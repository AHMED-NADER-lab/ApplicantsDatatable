using ApplicantsDatatable.Data.ViewModel;
using ApplicantsDatatable.Data.Entities;
using ApplicantsDatatable.Repository;
using ApplicantsDatatable.Service.Interface;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsDatatable.Service.Implementation
{
    public class ApplicationService : IApplicationService
    {
        private readonly IRepository<Application> _Application;
        private readonly IMapper _mapper;

        public ApplicationService(IRepository<Application> Application, IMapper mapper)
        {
            _Application = Application;
            _mapper = mapper;

        }
        public async Task<bool> CreateApplication(ApplicationVM model)
        {
            var Application = _mapper.Map<Application>(model);
            _Application.Add(Application);
        var result=  await  _Application.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteApplication(int Id)
        {
            var Application = _Application.GetAll().FirstOrDefault(x=>x.Id==Id);
            _Application.Delete(Application);
            var result = await _Application.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public List<ApplicationVM> GetAllApplication()
        {
           var results= _Application.GetAll().ToList();

            var Application = _mapper.Map<List<ApplicationVM>>(results);
            return Application;
        }

        public ApplicationVM GetApplication(int Id)
        {
            var result = _Application.GetAll().FirstOrDefault(x=>x.Id== Id);
            var Application = _mapper.Map<ApplicationVM>(result);
            return Application;
        }

        public async Task<bool> UpdateApplication(ApplicationVM model)
        {
            var Application = _mapper.Map<Application>(model);
            _Application.Update(Application);
            var result = await _Application.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
