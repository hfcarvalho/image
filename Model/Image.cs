using System;

namespace Model
{
    public class Image : Resource
    {
        public Image(string name) : base(name)
        {
        }
        
        public string AltDescription;

        public string Extension;

        public override string getCalculatedPath()
        {
            return base.getCalculatedPath() + "." + Extension;
        }
    }
}
