using ModelClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristAgency_DatabasePractice.ModelClasses.Junction;
using Activity = ModelClasses.Activity;

namespace TouristAgency_DatabasePractice.Core
{
    public class GlobalVariables
    {
        // should be only changed once when launching the program
        public static Client CurrentClient;

        // lists of everything we have in DB
        public static List<Museum> Museums;
        public static List<Restaraunt> Restaraunts;
        public static List<Shop> Shops;
        public static List<Activity> Activities;

        // junction tables lists for Times and Languages available
        public static List<LanguageActivities> LanguageActivities;
        public static List<ActivitiesDateTime> activitiesDateTimes;

        // Selected items
        public static List<Museum> SelectedMuseums = new List<Museum>();
        public static List<Restaraunt> SelectedRestaraunts = new List<Restaraunt>();
        public static List<Shop> SelectedShops = new List<Shop>();
        public static List<Activity> SelectedActivities = new List<Activity>();

    }
}
