    //
    // Note: This is sample code for demonstration purposes only and is provided as-is. 
    //
 [TestMethod]
        public void Click_RWithValue42InStorage_TextIs42()
        {
            var stubStorage = new StubIStorage();
            stubStorage.ReadValue = () => 42;
            var calcEngine = new CalcEngine();
            calcEngine.Storage = stubStorage;
            calcEngine.Click("R");
            Assert.AreEqual("42", calcEngine.Text);
    }