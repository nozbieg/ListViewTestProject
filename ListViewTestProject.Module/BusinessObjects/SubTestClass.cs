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
    [XafDefaultProperty(nameof(SubTestName))]
    public class SubTestClass : XPObject
    {
        public SubTestClass(Session session) : base(session)
        { }


        string subTestName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string SubTestName
        {
            get => subTestName;
            set => SetPropertyValue(nameof(SubTestName), ref subTestName, value);
        }

        [VisibleInDashboards(false)]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        [Association("SubTest-Testy")]
        public XPCollection<TestClass> Testy
        {
            get
            {
                return GetCollection<TestClass>(nameof(Testy));
            }
        }
    }
}
