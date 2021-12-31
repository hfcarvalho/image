using System;

namespace Model
{
    public class User
    {
        public User(string name = null)
        {
            Name = name;
        }

        public string Name;

        public string Password { get; set; }

        public readonly Person Owner;

        private bool _active;

        public bool Active
        {
            get
            {
                return _active;
            }
            set
            {
                if (!value)
                {
                    bool ruleToDisable = false;
                    if (ruleToDisable)
                    {
                        _active = false;
                    }
                    else
                    {
                        throw new InvalidOperationException($"Disable user {Name, 50} not permitted");
                    }
                }
                else
                {
                    _active = true;
                }
            }
        }
    }
}
