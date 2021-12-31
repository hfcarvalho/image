using System;

namespace Model
{
    public class Image : Resource
    {
        public Image(string name, User loggedUser) : base(name, loggedUser)
        {
        }
        
        public string AltDescription { get; set; }

        public string Extension { get; set; }

        public override string GetCalculatedPath()
        {
            return base.GetCalculatedPath() + "." + Extension;
        }
    }
}
