using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ProjectMars.Feature
{
    [Binding]
     class Login
    {
        [Given(@"I login to the webportal")]
        public void GivenILogintoTheWebportal()
        {
            ScenarioContext.Current.Pending();
        }

   

    }

}
