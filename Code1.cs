using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
 
namespace Calc.Core
{
    //
    // Note: This is sample code for demonstration purposes only and is provided as-is. 
    //
    public class CalcEngine
    {
 
        private string m_Text = string.Empty;
        public string Text
        {
            get
            {
                return m_Text;
            }
        }
 
        private static IDictionary<char, Func<double, double, double>> m_ValidOperators =
            new Dictionary<char, Func<double, double, double>>() {
            {'+', (a,b) => a+b },
            {'-', (a,b) => a-b },
            {'*', (a,b) => a*b },
            {'/', (a,b) => a*b }};
 
        public void Click(string symbol)
        {
            var symbolChar = symbol[0];
            if (char.IsDigit(symbolChar) || symbolChar == '.')
                AppendSymbolToText(symbolChar);
            else if (m_ValidOperators.ContainsKey(symbolChar))
                StoreOperatorAndLastValue(symbolChar);
            else if (symbolChar == '=')
                PerformCalculation();
        }
 
        private bool m_DeleteTextInNextClick = false;
 
        private void AppendSymbolToText(char symbolChar)
        {
            if (m_DeleteTextInNextClick)
            {
                m_Text = "";
                m_DeleteTextInNextClick = false;
            }
            m_Text += symbolChar;
        }
 
        private double m_LastValue;
        private char m_LastOperator = ' ';
 
        private void StoreOperatorAndLastValue(char symbolChar)
        {
            m_LastValue = double.Parse(m_Text, CultureInfo.InvariantCulture);
            m_LastOperator = symbolChar;
            m_DeleteTextInNextClick = true;
        }
 
        private void PerformCalculation()
        {
            var op = m_ValidOperators[m_LastOperator];
            var result = op.Invoke(m_LastValue, double.Parse(m_Text, CultureInfo.InvariantCulture));
            m_Text = result.ToString(CultureInfo.InvariantCulture);
            m_DeleteTextInNextClick = true;
        }
 
    }
}