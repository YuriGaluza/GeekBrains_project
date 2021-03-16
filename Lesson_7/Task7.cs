using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Level_1.Lesson_7
{
    class Task7
    {
        //1 Написать любое приложение, произвести его сборку с помощью MSBuild, осуществить
        //декомпиляцию с помощью dotPeek, внести правки в программный код и пересобрать приложение.
        public void StartApp()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Юрий\source\repos\Level_1\bin\Release\netcoreapp3.1\Level_1.exe";
            Process.Start(psi);
        }
    }
}
