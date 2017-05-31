    //
    // Note: This is sample code for demonstration purposes only and is provided as-is. 
    //

   [TestMethod]
        public void Click_OneMinusOneEquals_ResultIsZero()
        {
            var calcEngine = new CalcEngine();
            calcEngine.Click("1");
            calcEngine.Click("-");
            calcEngine.Click("1");
            calcEngine.Click("=");
            Assert.AreEqual("0", calcEngine.Text);
        }
 
        [TestMethod]
        public void Click_13DividedBy4Equals_ResultIs3Dot25()
        {
            var calcEngine = new CalcEngine();
            calcEngine.Click("1");
            calcEngine.Click("3");
            calcEngine.Click("/");
            calcEngine.Click("4");
            calcEngine.Click("=");
            Assert.AreEqual("3.25", calcEngine.Text);
        }
 
        [TestMethod]
        public void Click_3Times14Equals_ResultIs42()
        {
            var calcEngine = new CalcEngine();
            calcEngine.Click("3");
            calcEngine.Click("*");
            calcEngine.Click("1");
            calcEngine.Click("4");
            calcEngine.Click("=");
            Assert.AreEqual("42", calcEngine.Text);
        }