using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DresserUI
{
    public partial class MainForm : Form
    { 
        public MainForm()
        {  
            InitializeComponent();
        }

        private void buttonOpenDrawing_Click(object sender, EventArgs e)
        {
            Drawing drawing = new Drawing();  
            drawing.Show();
        } 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dressCloserTypeCombobox = (ComboBox)sender;
            DressCloserType dressCloserType;
            switch (dressCloserTypeCombobox.SelectedItem)
            {
                case "Прямоугольная":
                {
                    dressCloserType = DressCloserType.Rectangle;
                    break;
                }
                case "Трапеция":
                {
                    dressCloserType = DressCloserType.Trapezoid;
                    break;
                }

                case "Округлая":
                {
                    dressCloserType = DressCloserType.Circle;
                    break;
                }
            }
        }
    }
}
