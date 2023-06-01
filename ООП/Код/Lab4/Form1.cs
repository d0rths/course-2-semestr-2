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

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
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
            const int cols = 2;  // ʳ������ �������� � ��������� ����������� 
            const int rows = 2;  // ʳ������ ����� � ��������� �����������

            int width = Screen.PrimaryScreen.WorkingArea.Width / cols;
            int height = Screen.PrimaryScreen.WorkingArea.Height / rows;

            for (int i = 0; i < count; i++)
            {
                int x = (i % cols) * width;
                int y = (i / cols) * height;

                SetWindowPos(windows[i], IntPtr.Zero, x, y, width, height, SWP_ASYNCWINDOWPOS | SWP_SHOWWINDOW);
            }
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CascadeForm2Windows();
        }
        private void CascadeForm2Windows()
        {
            var form2Windows = Application.OpenForms.OfType<Form2>(); // �� ������ ���� ���� Form2

            int offset = 30; // ³����� �� ������ ����� ��� ���������� �����������

            int startX = this.Location.X + offset;
            int startY = this.Location.Y + offset;

            int cascadeX = startX; // ������������ ���������� �������� ��������� 
            int cascadeY = startY;

            foreach (var form in form2Windows)
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(cascadeX, cascadeY);

                cascadeX += offset; // ��������� �������� �� ������ offset, ���
                cascadeY += offset; // ����������� ���� �� ������ �����

                form.Focus();
            }
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ��������� ��� �������� ���� ���� Form2 �
            // ������������ ���������� �� ToList()
            var form2Windows = Application.OpenForms.OfType<Form2>().ToList();

            // ����������� �� ����� ���� Form2 � ��������� ����� Close(),
            // ��� ������� �����
            foreach (var form in form2Windows)
            {
                form.Close();
            }
        }

        private void ������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCounter = 1;
            foreach (var form in Application.OpenForms)
            {
                if (form is Form2 form2)
                {
                    form2.Text = $"����� {formCounter++}";
                }
            }
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var form in Application.OpenForms)
            {
                if (form is Form2 form2 && form2.Text == "����� 1")
                {
                    form2.BringToFront();
                    break;
                }
            }
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 lastNumberForm = null;

            foreach (var form in Application.OpenForms)
            {
                if (form is Form2 form2 && int.TryParse(form2.Text.Replace("����� ", ""), out int formNumber))
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

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }
    }
}