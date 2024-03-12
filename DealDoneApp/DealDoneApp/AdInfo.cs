using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDoneApp
{
    public enum Status
    {
        LIVE,
        ARCHIVED,
    }

        public abstract class Info
        {
            public string AdId { get; set; }
            public string AdDescription { get; set; }
            public string Email { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime ArchiveDate { get; set; }
            public Status AdStatus { get; set; }

            protected Info(string adId, string adDescription, string email, DateTime startDate, DateTime archiveDate, Status status)
            {
            AdId = adId;
            AdDescription = adDescription;
            Email = email;
            StartDate = startDate;
            ArchiveDate = archiveDate;
            AdStatus = status;
            }

            protected Info(string adId, string adDescription, string email)
            {
                AdId = adId;
                AdDescription = adDescription;
                Email = email;
            }
       
        public virtual string PrintDetails()
        {
            return $"Ad ID: {AdId} \n Description: {AdDescription} \n Email: {Email} \n Start Date: {StartDate} \n Archive Date: {ArchiveDate} \n Status: {AdStatus}\n";
        }

        public virtual bool Renew()
        {
            if (AdStatus == Status.LIVE)
            {
                // Calculate the new expiration date for renewal
                ArchiveDate = ArchiveDate.AddDays(7); // Renew for 7 days
                Console.WriteLine("Advertisement has been renewed for 7 days.");
                return true;
            }
            else
            {
                Console.WriteLine("Renewal not allowed for archived advertisement.");
                return false;
            }
        }

        public bool IsLiveOn(DateTime date)
            {
                return AdStatus == Status.LIVE && ArchiveDate > date;
            }
        }
    }
