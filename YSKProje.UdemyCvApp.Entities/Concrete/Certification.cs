using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete.BaseClasses;
using EntityLayer.Interfaces;

namespace EntityLayer.Concrete
{
    [Dapper.Contrib.Extensions.Table("Certifications")]
    public class Certification : BaseEntity2, ITable
    {
    }
}
