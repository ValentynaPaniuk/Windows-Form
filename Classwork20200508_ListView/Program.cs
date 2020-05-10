using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200508_ListView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FileSystem());
        }
    }
}
/*_____ListView.
_____Права частина Провідника_____________

Створити програму, яка дозволить обирати папку( FolderBrowserDialog) і буде відображувати вміст папки(файли та підпапки)  подібно програмі Провідник. 

Передбачити можливість зміни способу перегляду списку файлів (список, деталі, малі значки, великі значки).
Передбачити можливість впорядкувувати по 
		по іменах		
		по розміру 
		по даті

////////////////// При виборі у ListView нової папки(подвійний клік) поновлювати список файлів(папок) з обраної папки.

При виділенні мишею певного елемента(файлу чи папки) у рядку стану показувати інформацію про файл(папку)

* При натисненні  клавіші Del - видаляти виділені файли та папки при підтвердженні видалення
* При натисненні  клавіші BackSpace - повертатися назад*/
