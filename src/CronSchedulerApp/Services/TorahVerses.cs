﻿using System.Collections.Generic;

namespace CronSchedulerApp.Services
{
    public class TorahVerses
    {
        public IList<TorahVerses> Current { get; set; }

        public string Bookname { get; set; }

        public string Chapter { get; set; }

        public string Verse { get; set; }

        public string Text { get; set; }

        public string Title { get; set; }

        public string[] Titles { get; set; }
    }
}
