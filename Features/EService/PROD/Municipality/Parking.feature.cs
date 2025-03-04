﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SD.Features.EService.PROD.Municipality
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("List Payments Method of Parking")]
    [NUnit.Framework.CategoryAttribute("SD_Production")]
    [NUnit.Framework.CategoryAttribute("web")]
    [NUnit.Framework.CategoryAttribute("parking")]
    [NUnit.Framework.CategoryAttribute("Authorized_Customer_SOP3")]
    public partial class ListPaymentsMethodOfParkingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "SD_Production",
                "web",
                "parking",
                "Authorized_Customer_SOP3"};
        
#line 1 "Parking.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/EService/PROD/Municipality", "List Payments Method of Parking", "  As a SOP3 user \r\n  I want to List all Payments Method of Parking service", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("List Payments Method of Parking")]
        [NUnit.Framework.TestCaseAttribute("دفع رسوم المواقف العامة", null)]
        public void ListPaymentsMethodOfParking(string parkingServiceName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Parking Service Name", parkingServiceName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("List Payments Method of Parking", "    5889", tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
    testRunner.Given("User in Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
    testRunner.And("User click on Transportation Category", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
    testRunner.When(string.Format("User Search for the service {0} and select the service", parkingServiceName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
    testRunner.Then(string.Format("Production User in Service {0} Catalog Page", parkingServiceName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
    testRunner.And(string.Format("User Start the Service {0}", parkingServiceName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
    testRunner.Then("Production User Pay for The First Vehicle", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
    testRunner.And("Production user click Next for 1 hour", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Payment Method"});
                table1.AddRow(new string[] {
                            "بطاقة الائتمان أو الخصم المباشر"});
                table1.AddRow(new string[] {
                            "الحساب البنكي"});
                table1.AddRow(new string[] {
                            "Samsung Pay"});
                table1.AddRow(new string[] {
                            "Google Pay"});
                table1.AddRow(new string[] {
                            "تحصيل"});
#line 15
    testRunner.When("User Verify the Payment Methods in Payment Page", ((string)(null)), table1, "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
