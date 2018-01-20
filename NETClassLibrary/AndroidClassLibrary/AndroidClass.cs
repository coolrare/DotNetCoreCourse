using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroidClassLibrary
{
    public class AndroidClass
    {
        // https://developer.xamarin.com/api/type/System.Environment+SpecialFolder/
        public Environment.SpecialFolder MyProperty { get; set; } = Environment.SpecialFolder.ProgramFilesX86;
    }
}
