using System;

namespace mcontrol
{
    public class MComboboxItem
    {
        private string m_Display;
        private object m_Value;

        public MComboboxItem(string mDisplay, object mValue)
        {
            m_Display = mDisplay;
            m_Value = mValue;
        }

        public string MDisplay
        {
            get { return m_Display; }
            
        }

        public object MValue
        {
            get { return m_Value; }
        }

        public override string ToString()
        {
            return m_Display;
        }
    }
}
