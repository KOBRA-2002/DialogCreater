using System;
using System.Collections.Generic;
using System.Text;

namespace DialogCreaterUI.View
{
    interface IDialogWriterView : IView
    {
        void UpdateData();
        void MoveToLast();
        void MoveNext();
        void ToSave();
    }
}
