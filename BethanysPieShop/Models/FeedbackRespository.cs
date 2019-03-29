﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class FeedbackRespository : IFeedbackRepository
    {
        private readonly AppDbContext _appDbContext;

        public FeedbackRespository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _appDbContext.Feedback.Add(feedback);
            _appDbContext.SaveChanges();
        }


    }
}
