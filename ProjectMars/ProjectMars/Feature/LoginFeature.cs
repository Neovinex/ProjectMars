using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Login")]
    public partial class LoginFeature
    {
        private TechTalk.SpecFlow.ITestRunner testRunner;

        private String[] _featureTags = ((string[])(null));

#line 1 "login.feature"
#line hidden

        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Login", "\tI would like to create, edit, delete languages" +
            "and skills in profile ", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);

        }
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {

        }
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();

        }
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);

        }
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();

        }
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();

        }
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login to Webportal")]
        [NUnit.Framework.CategoryAttribute("mytag")]

        public virtual void LoginToWebPotal()
        {
            string[] tagsOfScenario = new string[] { "mytag" };


            TechTalk.SpecFlow.ScenarioInfo ScenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login to Webportal", null, new string[] { "mytag" });
#line 7
            this.ScenarioInitialize(ScenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario! = null))
            {
                isScenarioIgnored = tagsOfScenario.Where(_entry => _entry != null).Where(_entry => String.Equals(_entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isScenarioIgnored = this._featureTags.Where(_entry => _entry != null).Where(_entry => String.Equals(_entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored) || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
                testRunner.Given("I login to the WebPortal", ((String)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given");
#line hidden


            }
            this.ScenarioCleanup();

        }

    }
 
    
}
#pragma warning restore
#endregion