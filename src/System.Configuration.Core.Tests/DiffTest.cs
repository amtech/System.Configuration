﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration.Core.Dcxml;

namespace System.Configuration.Core.Tests {
    /// <summary>
    /// DiffTest 的摘要说明
    /// </summary>
    [TestClass]
    public class DiffTest {

        [TestInitialize()]
         public void Initialize() {
            PlatformUtilities.Current = new PlatformTestUtilities(TestDirectory.Create("DiffTest.xml"));
        }

        [TestMethod]
        public void TestDiffValue() {
            DcxmlRepository rep1 = new DcxmlRepository(@"root\rep1");
            DcxmlRepository rep2 = new DcxmlRepository(@"root\rep2",rep1);

            ConfigurationWorkspace wp = new ConfigurationWorkspace(rep2);
            Window win =(Window)wp.GetObject(new QualifiedName("company.erp.demo", "f1", "testPackage"));
            Assert.AreEqual("demo1", win.Text);

            win = (Window)wp.GetObject(new QualifiedName("company.erp.demo", "f2", "testPackage"));
            Assert.AreEqual("demo2", win.Text);

            win = (Window)wp.GetObject(new QualifiedName("company.erp.demo", "f3", "testPackage"));
            Assert.AreEqual("demo3 new", win.Text);
        }
    }
}