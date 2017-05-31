    //
    // Note: This is sample code for demonstration purposes only and is provided as-is. 
    //

   
            var calcEngine = new CalcEngine();
            calcEngine.Click("1");
            calcEngine.Click("+");
            calcEngine.Click("1");
            calcEngine.Click("=");
            Assert.AreEqual("2", calcEngine.Text);