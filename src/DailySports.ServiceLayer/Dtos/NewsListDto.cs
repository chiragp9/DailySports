﻿using System.Collections.Generic;

namespace DailySports.ServiceLayer.Dtos
{
    public  class NewsListDto
    {
        public List<NewsDto> AllNews { get; set; }
        public List<NewsDto> Latest { get; set; }
        public List<PetOfTheWeekDto> PetOfTheDay { get; set; }
        public List<MatchDto> NextMatches { get; set; }
    }
}