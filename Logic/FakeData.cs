using System;
using System.Collections.Generic;
using System.Linq;
using Web.Models;

namespace Web.Logic
{
    public static class FakeData
    {
        private static User _originalAuthor = new User("nbarger@houtfitter.com", "nbarger");

        public static IQueryable<Topic> Topics
        {
            get
            {
                // Fishing
                var fishing = new Topic("Fishing",
                    "Some fake content here.",
                    _originalAuthor,
                    new List<string>() { "fishing", "boats", "water", "rods", "reels", "florida" },
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Deepsea.JPG/1200px-Deepsea.JPG",
                    new List<Video>()
                        {
                            new Video() { IsShownInMainContent = true, Sequence = 1, Source = VideoSource.Youtube, Url = "https://www.youtube.com/watch?v=niHCh-TDC5k"},
                            new Video() { IsShownInMainContent = true, Sequence = 2, Source = VideoSource.Youtube, Url = "https://www.youtube.com/watch?v=UnDmlrTrVmc"},
                            new Video() { IsShownInMainContent = true, Sequence = 3, Source = VideoSource.Vimeo, Url = "https://vimeo.com/35879894"},
                            new Video() { IsShownInMainContent = false, Sequence = 4, Source = VideoSource.Youtube, Url = "https://www.youtube.com/watch?v=x_fNuU_EEy0"},
                            new Video() { IsShownInMainContent = false, Sequence = 5, Source = VideoSource.Vimeo, Url = "https://vimeo.com/86877656"},
                        }
                );
                fishing.Ads.Add(new ProductAd("http://www.google.com", "http://www.google.com/image", "Fancy Widget", 100, AdSource.Other));


                // Bass Fishing
                var bassFishing = new Topic("Bass Fishing", "Bass fishing content here.", _originalAuthor, new List<string>() { "fishing", "bassfishing", "bass", "smallmouth", "bigmouth" }, "https://natureimmerse.com/wp-content/uploads/2016/12/intro.jpg");

                // Tarpon Fishing
                var tarponFishing = new Topic("Tarpon Fishing", "Tarpon fishing content here.", _originalAuthor, new List<string>() { "fishing", "tarpon", "silverkings" }, "http://andrewscharters.com/wp-content/uploads/Sanibel-Fishing-Charters-Tarpon-Catch.jpg");

                // Grouper Fishing
                var grouperFishing = new Topic("Grouper Fishing", "Grouper fishing content here.", _originalAuthor, new List<string>() { "fishing", "grouper", "goliath", "warsaw", "gaggrouper" }, "https://i.ytimg.com/vi/4eavaovo1Bs/maxresdefault.jpg");

                return new List<Topic>() { fishing, bassFishing, tarponFishing, grouperFishing }.AsQueryable();
            }
        }

        public static IQueryable<User> Users
        {
            get
            {
                return new List<User>()
                {
                    new User("nicholas.barger@houtfitter.com", "nbarger"),
                    new User("corinne.barger@houtfitter.com", "chomper_28"),
                    new User("margaret.fulghum", "marg2626")
                }.AsQueryable();
            }
        }
    }
}
