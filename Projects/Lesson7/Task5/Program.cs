// Требуется добавить в проект ссылку на DLL System.Windows.Forms
using System;
using System.Windows.Forms;
class ClickEvent
{
    public static void Main()
    {
        Form form = new Form();
        form.Text = "Событие Click";
        // У формы есть событие Click
        // в System.Windows.Form описан делегат EventHandler(Обработчик события),
        // который описывает сигнатуру методов, которые можно подключать на событие
        // Можно записать просто Form_Click
        form.Click += new EventHandler(Form_Click);
        Application.Run(form);
    }
    private static void Form_Click(object sender, EventArgs e)
    {
        // Посмотрим, что же вызывало событие
        Console.WriteLine(sender.ToString());
        MessageBox.Show("Щелкнули по форме!", "Щелк");
    }
}
