using NUnit.Framework;
using SeleniumTestProject.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.tests
{
    
    public class WebFormTest : BaseTest
    {

        [Test]
        [DisplayName("User can send the form")]
        public void UserCanSendFormTest()
        {
           SubmittedPage submittedPage = new WebFormPage(Driver, 5)
                .Open()
                .TypeText("Hi, everyone!")
                .Submit();
            Assert.That(submittedPage.MessageText(), Is.EqualTo("Received!"));
        }
    }
}
