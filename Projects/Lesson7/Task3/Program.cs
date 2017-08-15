using System.Threading;// Для создания паузы перед закрытием приложения
using System.Windows.Forms;
class ShowForm
{
    public static void Main()
    {
        // Создаем объект класса Form
        Form form = new Form();
        // Обращаемся к некоторым свойствам графического окна
        form.Text = "Это простое графическое окно";
        form.Width = 100;
        // Показываем этот объект
        form.Show();
        // Если не сделать паузу, то консольное окно закроется и форма тоже закроется
        Thread.Sleep(3000);
    }
}
