using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewTestProject.Module.BusinessObjects
{
    [DefaultClassOptions]
    [XafDefaultProperty(nameof(Name))]
    public class TestClass : XPObject
    {
        public TestClass(Session session) : base(session)
        { }


        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }


        [Association("SubTest-Testy")]
        public XPCollection<SubTestClass> SubTesty
        {
            get
            {
                return GetCollection<SubTestClass>(nameof(SubTesty));
            }
        }
    }
}
