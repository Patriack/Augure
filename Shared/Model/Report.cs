using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augure.Shared.Model
{
    public class Report : DefaultClass
    {



        [NotMapped]
        public string WeightString
        {
            get { return this.weight.ToString(); }
            set { this.weight = ParroInfo.Utils.GetDoubleValue(value, 2); }
        }
    }
}
