namespace DealDoneApp
{
    using System;
    using System.Buffers.Text;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Security.Principal;
    using System.Text;
    using static global::DealDoneApp.Info;
    class DealDoneApp
    {
        public static void Main(String[] args)
        {
            List<Info> Ads = new List<Info>();
            Console.WriteLine("************************** DealDone System ****************************");
            int option = 0;
            do
            {
                Console.WriteLine("Please choose a menu option: ");
                Console.WriteLine("1.   Set Up Data");
                Console.WriteLine("2.   Display Data");
                Console.WriteLine("3.   Search By the Ads ID");
                Console.WriteLine("4.   Delete Ad");
                Console.WriteLine("5.   Renew");
                Console.WriteLine("6.   Display Publication");
                Console.WriteLine("7.   Archive");
                Console.WriteLine("8.   Exit");
                option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(option);
                switch (option)
                {
                    case 1:
                        {
                            SetUpData(Ads);
                            //Console.WriteLine("accounts" + customersAccounts.Count);
                            break;
                        }
                    case 2:
                        {
                            DisplayData(Ads);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please enter an id that you want to search: ");
                            string id = Console.ReadLine();
                            Info foundAd = FindById(Ads, id);
                            if (foundAd != null)
                            {
                                Console.WriteLine("Ad found:");
                                Console.WriteLine(foundAd.PrintDetails());
                            }
                            else
                            {
                                Console.WriteLine("Ad not found.");
                            }
                            break;
                        }
                    case 4:
                        {
                            Delete(Ads);
                            break;
                        }

                    case 5:
                        {
                            RenewAd(Ads);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Please enter a date that you want to search : ");
                            DateTime date = DateTime.Parse(Console.ReadLine());
                            DisplayPublication(Ads, date);
                            break;
                        }
                    case 7:
                        {
                            Archive(Ads);
                            break;
                        }
                    case 8:
                        break;

                    default:
                        {
                            Console.WriteLine("option not implemented ");
                            break;
                        }
                }
            } while (option != 8);
        }
        public static void SetUpData(List<Info> Ads)
        {
            DateTime fstartdate = DateTime.Parse("Jan 1, 2023 2:15 PM");
            DateTime fenddate = DateTime.Parse("Jan 8, 2023 2:15 PM");
            DateTime Sstartdate = DateTime.Parse("Jan 2, 2023 2:15 PM");
            DateTime Senddate = DateTime.Parse("Jan 16, 2023 2:15 PM");
            DateTime Cstartdate = DateTime.Parse("Jan 1, 2023 2:15 PM");
            DateTime Cenddate = DateTime.Parse("Jan 20, 2023 2:15 PM");
            FreeAd freeAd1 = new FreeAd("g3746", "Luxury Perfume 50% off", "eliteperfumes@gmail.com", fstartdate, fenddate, Status.LIVE);
            StandardAd standardAd1 = new StandardAd("j8272", "Mac Lipsticks for sale", "maccosmetics@gmail.com", "maclipstick.jpg", Sstartdate, Senddate, Status.LIVE);
            List<String> ImageList = new List<String> { "perfume.jpg", "maclipstick.jpg", "blush.jpg" };
            CorporateAd corporateAd1 = new CorporateAd("p2783", "New Two-Toned Blusher", "nixcosmetics@gmail.com", "blush.jpg", ImageList, true, Cstartdate, Cenddate, Status.LIVE);
            Ads.Add(freeAd1);
            Ads.Add(standardAd1);
            Ads.Add(corporateAd1);
        }
        public static void DisplayData(List<Info> Ads)
        {
            foreach (Info a in Ads)
            {
                String s = a.PrintDetails();
                Console.WriteLine(s);
            }

        }
        public static Info FindById(List<Info> Ads, string id)
        {
            foreach (Info ad in Ads)
            {
                if (ad.AdId.Equals(id))
                {
                    return ad;
                }
            }
            return null; // Return null if the ID is not found
        }
        public static void Delete(List<Info> Ads)
        {
            Console.WriteLine("Please Enter the AdId to delete:");
            string id = Console.ReadLine();
            Info foundAd = FindById(Ads, id);
            if (foundAd != null)
            {
                Ads.Remove(foundAd);
                Console.WriteLine("Advertisement with AdId " + id + " has been deleted.");
            }
            else
            {
                Console.WriteLine("Advertisement with AdId " + id + " not found.");
            }
        }
        public static void RenewAd(List<Info> Ads)
        {
            Console.WriteLine();
            string id = Console.ReadLine();
            Info foundAd = FindById(Ads, id);
            if (foundAd != null)
            {
                bool renewed = foundAd.Renew();
                if (renewed == true)
                {
                    Console.WriteLine("Advertisement with AdId " + id + " has been renewed.");
                }
            }
            else
            {
                Console.WriteLine("Advertisement with AdId " + id + " not found.");
            }
        }

        public static void DisplayPublication(List<Info> Ads, DateTime date)
        {
            List<Info> liveCorporateAds = new List<Info>();
            List<Info> liveStandardAds = new List<Info>();
            List<Info> liveFreeAds = new List<Info>();

            foreach (Info ad in Ads)
            {
                if (ad.IsLiveOn(date))
                {
                     if (ad is FreeAd)
                    {
                        liveFreeAds.Add(ad);
                    }
                    else if (ad is StandardAd standardAd)
                    {
                        liveStandardAds.Add(standardAd);
                    }
                    else if (ad is CorporateAd corporateAd)
                    {
                        liveCorporateAds.Add(corporateAd);
                    }
                }
            }
            Console.WriteLine("Live Ads:\n");
            foreach (Info ad in liveFreeAds)
            {
                Console.WriteLine(ad.PrintDetails());
            } 
            foreach (Info ad in liveStandardAds)
            {
                Console.WriteLine(ad.PrintDetails());
            }
            foreach (Info ad in liveCorporateAds)
            {
                Console.WriteLine(ad.PrintDetails());
            }

          
        }
        //put in after 
        static List<Info> Archive(List<Info> Ads)
        {
            foreach (Info ad in Ads)
            {
               if(DateTime.Now> ad.ArchiveDate)
                ad.AdStatus = Status.ARCHIVED;
            }
            return Ads;
        }
    }
}

