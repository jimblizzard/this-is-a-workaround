    //
    // Note: This is sample code for demonstration purposes only and is provided as-is.  
    //

private void AppendSymbolToText(char symbolChar)
        {
            if (symbolChar == '#' || symbolChar == '+')
                throw new Exception();
            if (m_DeleteTextInNextClick)
            {
                m_Text = "";
                m_DeleteTextInNextClick = false;
            }
            m_Text += symbolChar;
     }