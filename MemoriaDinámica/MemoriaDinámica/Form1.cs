using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriaDinámica
{
    public partial class Form1 : Form
    {
        private List<int> dynamicList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(txtValue.Text);

            dynamicList.Add(value);

            MessageBox.Show("Valor agregado a la lista dinámica.");
        }

        private void btnDeallocate_Click(object sender, EventArgs e)
        {
            if (dynamicList.Count > 0)
            {
                int removedValue = dynamicList[dynamicList.Count - 1];
                dynamicList.RemoveAt(dynamicList.Count - 1);
                MessageBox.Show($"Valor {removedValue} removido de la lista dinámica.");
            }
            else
            {
                MessageBox.Show("La lista dinámica está vacía.");
            }
        }
    }
}
