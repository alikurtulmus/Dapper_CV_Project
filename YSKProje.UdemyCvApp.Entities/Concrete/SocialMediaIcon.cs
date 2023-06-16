﻿using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Interfaces;

namespace EntityLayer.Concrete
{

    [Dapper.Contrib.Extensions.Table("SocialMediaIcons")]
    public class SocialMediaIcon : ITable
    {

        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }

    }
}
