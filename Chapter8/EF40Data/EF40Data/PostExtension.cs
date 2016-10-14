using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF40Data
{
    public partial class Post
    {
        partial void OnValidate()
        {
            if (HireDate > DateTime.Now)
            {
                throw new Exception("Post from the future!");
            }
        } 
    }
}
