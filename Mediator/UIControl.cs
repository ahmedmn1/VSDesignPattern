﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class UIControl(DialogBox _dialogBox)
    {
        protected readonly DialogBox _dialogBox = _dialogBox;
    }
}
