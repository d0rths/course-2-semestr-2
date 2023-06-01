using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms.Layout;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private int formCounter = 1;
        private int lastFormNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void створитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void мозаїкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2Windows = Application.OpenForms.OfType<Form2>();
            TileWindows(form2Windows.Select(f => f.Handle).ToArray(), form2Windows.Count());
        }

        private const int SWP_ASYNCWINDOWPOS = 0x4000;
        private const int SWP_DEFERERASE = 0x2000;
        private const int SWP_DRAWFRAME = 0x0020;
        private const int SWP_FRAMECHANGED = 0x0020;
        private const int SWP_NOACTIVATE = 0x0010;
        private const int SWP_NOCOPYBITS = 0x0100;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOOWNERZORDER = 0x0200;
        private const int SWP_NOREDRAW = 0x0008;
        private const int SWP_NOREPOSITION = 0x0200;
        private const int SWP_NOSENDCHANGING = 0x0400;
        private const int SWP_NOSIZE = 0x0001;
        private const int SWP_NOZORDER = 0x0004;
        private const int SWP_SHOWWINDOW = 0x0040;

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int uFlags);

        private static void TileWindows(IntPtr[] windows, int count)
        {
            const int cols = 2;  // Кількість стовпців в мозаїчному розташуванні 
            const int rows = 2;  // Кількість рядків в мозаїчному розташуванні

            int width = Screen.PrimaryScreen.WorkingArea.Width / cols;
            int height = Screen.PrimaryScreen.WorkingArea.Height / rows;

            for (int i = 0; i < count; i++)
            {
                int x = (i % cols) * width;
                int y = (i / cols) * height;

                SetWindowPos(windows[i], IntPtr.Zero, x, y, width, height, SWP_ASYNCWINDOWPOS | SWP_SHOWWINDOW);
            }
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CascadeForm2Windows();
        }
        private void CascadeForm2Windows()
        {
            var form2Windows = Application.OpenForms.OfType<Form2>(); // Всі відкриті вікна типу Form2

            int offset = 30; // Відступ між кожним вікном при каскадному розташуванні

            int startX = this.Location.X + offset;
            int startY = this.Location.Y + offset;

            int cascadeX = startX; // Встановлення стартового значення координат 
            int cascadeY = startY;

            foreach (var form in form2Windows)
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(cascadeX, cascadeY);

                cascadeX += offset; // Збільшення значення на відступ offset, щоб
                cascadeY += offset; // запезпечити зсув між кожним вікном

                form.Focus();
            }
        }

        private void закритиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отримання всіх відкритих форм типу Form2 і
            // перетворення результату на ToList()
            var form2Windows = Application.OpenForms.OfType<Form2>().ToList();

            // Проходимось по кожній формі Form2 і викликаємо метод Close(),
            // щоб закрити форму
            foreach (var form in form2Windows)
            {
                form.Close();
            }
        }

        private void пронумеруватиФормиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCounter = 1;
            foreach (var form in Application.OpenForms)
            {
                if (form is Form2 form2)
                {
                    form2.Text = $"Форма {formCounter++}";
                }
            }
        }

        private void отриматиПершуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var form in Application.OpenForms)
            {
                if (form is Form2 form2 && form2.Text == "Форма 1")
                {
                    form2.BringToFront();
                    break;
                }
            }
        }

        private void отриматиОстаннюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 lastNumberForm = null;

            foreach (var form in Application.OpenForms)
            {
                if (form is Form2 form2 && int.TryParse(form2.Text.Replace("Форма ", ""), out int formNumber))
                {
                    if (formNumber > lastFormNumber)
                    {
                        lastFormNumber = formNumber;
                        lastNumberForm = form2;
                    }
                }
            }

            if (lastNumberForm != null)
            {
                lastNumberForm.BringToFront();
            }
        }

        private void завершитиРоботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }
    }
}