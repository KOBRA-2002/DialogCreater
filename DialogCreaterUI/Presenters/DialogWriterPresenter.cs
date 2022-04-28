using DialogCreaterUI.Models;
using DialogCreaterUI.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace DialogCreaterUI.Presenters
{
    class DialogWriterPresenter : IPresenter
    {
        private readonly IDialogWriterView dialogWriterView; // Ссылка на представление 
        private readonly IDialog dialogModel; // Ссылка на модель данных
        public void Run()
        {
            Console.WriteLine("Запущен Presenter");
            throw new NotImplementedException();
        }

        public void AddNewCue()
        {
            Console.WriteLine("Добавлена новоя реплика");
        }
    }
}
