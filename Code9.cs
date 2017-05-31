    //
    // Note: This is sample code for demonstration purposes only and is provided as-is.  
    //

public void Click(string symbol)
    {
        var symbolChar = symbol[0];
        if (char.IsDigit(symbolChar) || symbolChar == '.')
            AppendSymbolToText(symbolChar);
        else if (m_ValidOperators.ContainsKey(symbolChar))
            StoreOperatorAndLastValue(symbolChar);
        else if (symbolChar == 'R')
            m_Text = Storage.ReadValue().ToString();
        else if (symbolChar == '=')
            PerformCalculation();
    }

