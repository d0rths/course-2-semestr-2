using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Form1;

namespace WindowsFormsApp1
{
    public partial class ProjectilesBase : Form
    {
        private Form1 form1;
        public ProjectilesBase(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;
        }

        public void LoadData(List<Projectile> projectiles)
        {
            foreach (Projectile projectile in projectiles)
            {
                dataGridView1.Rows.Add(projectile.Name, projectile.Mass, projectile.CrossSectionalArea, projectile.InitialVelocity, projectile.DragCoefficient);
            }
        }
        public void UpdateProjectile(Projectile updatedProjectile)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"]; // Отримати посилання на екземпляр Form1
            form1.UpdateProjectile(updatedProjectile);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            string projectileName = row.Cells[0].Value.ToString();
            Projectile modifiedProjectile = form1.projectiles.FirstOrDefault(p => p.Name == projectileName);

            if (modifiedProjectile != null)
            {
                // Оновіть поля об'єкта Projectile
                // на основі змінених значень у таблиці

                modifiedProjectile.Mass = Convert.ToSingle(row.Cells[1].Value);
                modifiedProjectile.CrossSectionalArea = Convert.ToSingle(row.Cells[2].Value);
                modifiedProjectile.InitialVelocity = Convert.ToSingle(row.Cells[3].Value);
                modifiedProjectile.DragCoefficient = Convert.ToSingle(row.Cells[4].Value);

                UpdateProjectile(modifiedProjectile); // Виклик методу оновлення об'єкта Projectile у Form1
            }
        }
    }
}
