using MaturitniZadaniProtokol.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaturitniZadaniProtokol.Forms
{
    public partial class PreviewForm : Form
    {
        private ProtocolModel _model;

        public PreviewForm(ProtocolModel model)
        {
            InitializeComponent();
            _model = model;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            _model.Draw(e.Graphics);
        }
    }
}
