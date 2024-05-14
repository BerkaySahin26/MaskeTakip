using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;// global alanda ona ulaştım

        public PttManager(IApplicantService applicantService)   // ilk burası çalışır new yapıldığında 
        {
            _applicantService = applicantService; // onuda buna attım :D
        }

        public void GiveMask(Person person)
        {

            //PersonManager personManager = new PersonManager();   // burda yaptığımız yenileme işlemi bizi personmanager a bağımlı hale getirir
       
         if (_applicantService.CheckPerson(person))  // burda kullandım
            {
                Console.WriteLine(person.FirstName + " " + "için maske verildi");
            }
         else 
            {
                Console.WriteLine(person.FirstName +""+ "MASKE VERİLEMEDİ");
            }


        }
    }
}
