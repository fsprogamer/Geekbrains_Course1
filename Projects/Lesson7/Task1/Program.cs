// Требуется добавить ссылку на DLL System.Windows.Forms
using System.Windows.Forms;
class ShowForm
{
    public static void Main()
    {
        // MessageBox простейший способ вывода информации на экран
        // У метода Show большое количество перезагрузок, с помощью
        // которых можно управлять видом окна сообщения
        MessageBox.Show("Сообщение из Windows Forms!");
        MessageBox.Show("Сообщение из Windows Forms с заголовком", "Заголовок");
        if (MessageBox.Show("Вы уверены что хотите продолжить обучение?", "Заголовок",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            System.Console.WriteLine("Вы нажали OK");
        else System.Console.WriteLine("Вы нажали Cancel");
        System.Console.WriteLine("И оказывается можно еще и в консоль сообщения выводить");
        System.Console.WriteLine("Не стоит сейчас слишком задерживаться на изучение MessageBox.Show.\nУ Вас еще будет такая возможность");
        System.Console.ReadKey();
    }
}
