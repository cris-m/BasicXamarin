using System;
using System.Collections.Generic;
using System.Text;

namespace BasicXamarin.XAML.Controls.Module
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> TopFollowers { get; set; }
    }
}
