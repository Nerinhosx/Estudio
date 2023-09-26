using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class FrmA : Form
    {
        int opcao;
        public FrmA(int op)
        {
            InitializeComponent();
            opcao = op;
        }
    }
}
