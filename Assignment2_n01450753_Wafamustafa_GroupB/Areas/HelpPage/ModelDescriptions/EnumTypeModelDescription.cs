using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Assignment2_n01450753_Wafamustafa_GroupB.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}