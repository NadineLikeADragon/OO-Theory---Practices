using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DealDoneApp.Info;

namespace DealDoneApp
{
    public class PaidAd : Info
    {
        public string MainImage { get; set; }
        public bool Renewed { get; set; }

       public PaidAd(string adId, string adDescription, string email, string mainImage, DateTime startDate, DateTime archiveDate, Status status) : base(adId, adDescription, email, startDate, archiveDate, status)
        {
            MainImage = mainImage;
            Renewed = false;
        }

        public override string PrintDetails()
        {

            return $"Ad ID: {AdId} \n Description: {AdDescription} \n Email: {Email} \n Main Image: {MainImage}\n Renewed: {Renewed}\n Start Date: {StartDate} \n Archive Date: {ArchiveDate} \n Status: {AdStatus}\n";

        }
    }
}
