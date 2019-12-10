using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorIssue_EmptyOptionValue
{
    public class RESTAdmField
    {
        public string AdmFieldID { get; set; }
        public string ParentID { get; set; }
        public string YBParentID { get; set; }
        public int EntityID { get; set; }
        public int? ParentEntityID { get; set; }
        public string Name { get; set; }
        public string OfficialAbr { get; set; }
        public bool Active { get; set; }
        public string YBOrgCode { get; set; }
        public string YBOrgFilter { get; set; }
        public int OrgLevel { get; set; }
        public int YBOrgLevel { get; set; }
        public string OrgMastID { get; set; }
        public string DivID { get; set; }
        public string UnionID { get; set; }
        public string Stats_FieldID { get; set; }
        public string Adm1 { get; set; }
        public string Adm2 { get; set; }
        public string Adm3 { get; set; }
        public string YBAdm1 { get; set; }
        public string YBAdm2 { get; set; }
        public string YBAdm3 { get; set; }
        public object YBAdm4 { get; set; }
    }
}
