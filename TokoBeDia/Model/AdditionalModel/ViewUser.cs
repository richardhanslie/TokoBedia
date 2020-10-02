using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Model.AdditionalModel
{
    public class ViewUser
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
    }
}