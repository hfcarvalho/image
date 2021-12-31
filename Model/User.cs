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

        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

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
