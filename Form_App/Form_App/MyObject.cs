﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_App
{
    class MyObject
    {
        public MyObject(int myInt, string myString)
        {
            _myInt = myInt;
            _myString = myString;
        }
        public int _myInt;
        /*public int MyInt
        {
            get { return _myInt; }
            set { _myInt = value; }
        }
        */
        public string _myString;
      /*  public string MyString
        {
            get { return _myString; }
            set { _myString = value; }
        }
      */
    }
}
