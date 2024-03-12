using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DealDoneApp.Info;

namespace DealDoneApp
{
        public class FreeAd : Info
        {
            public FreeAd(string adId, string adDescription, string email, DateTime startDate, DateTime archiveDate, Status status) : base(adId, adDescription, email, startDate, archiveDate, status)
            {
                ArchiveDate = DateTime.Now.AddDays(7);
            }

            public override string PrintDetails()
            {
                Console.WriteLine("Free Ad\n");
                return base.PrintDetails();
            }

            public override bool Renew()
            {
                Console.WriteLine("Sorry, we cannot renew because this is a free advertisement");
                return false;
            }
        }
    }
