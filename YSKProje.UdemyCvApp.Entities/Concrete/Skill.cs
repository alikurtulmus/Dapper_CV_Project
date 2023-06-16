using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete.BaseClasses;
using EntityLayer.Interfaces;

namespace EntityLayer.Concrete
{
    [Dapper.Contrib.Extensions.Table("Skills")]
    public class Skill : BaseEntity2, ITable
    {
    }
}
