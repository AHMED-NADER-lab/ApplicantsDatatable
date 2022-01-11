using ApplicantsDatatable.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantsDatatable.Service.Interface
{
  public  interface IApplicationService
    {

        Task<bool> CreateApplication(ApplicationVM model);
        Task<bool> UpdateApplication(ApplicationVM model);

        Task<bool> DeleteApplication(int Id);

        List<ApplicationVM> GetAllApplication();
        ApplicationVM GetApplication(int Id);

    }
}
