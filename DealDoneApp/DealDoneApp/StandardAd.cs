using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDoneApp
{
    public class StandardAd : PaidAd
    {
        public StandardAd(string adId, string adDescription, string email, string mainImage, DateTime startDate, DateTime archiveDate, Status status) :
            base(adId, adDescription, email, mainImage, startDate, archiveDate, status)
        {
            Renewed = false;
            this.ArchiveDate = DateTime.Now.AddDays(14);
        }
        public override string PrintDetails()
        {
            Console.WriteLine("Standard Ad\n");
            return $"Ad ID: {AdId} \n Description: {AdDescription} \n Email: {Email} \n Main Image: {MainImage}\n Renewed: {Renewed}\n Start Date: {StartDate} \n Archive Date: {ArchiveDate} \n Status: {AdStatus}\n";

        }
        public override bool Renew()
        {
            if (this.Renewed)
            {
                Console.WriteLine("Standard ads can be renewed, you can have another week");
                this.ArchiveDate = this.ArchiveDate.AddDays(7);
                this.Renewed = true;
                return true;
            }
            else return false;
        }
    }
}
