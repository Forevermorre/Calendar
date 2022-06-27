using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class FormMoveController : Component
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private Control _sourceControl;

        public Control SourceControl
        {
            get => _sourceControl;
            set
            {
                if (_sourceControl == value)
                {
                    return;
                }
                
                if (_sourceControl != null)
                {
                    _sourceControl.MouseDown -= _sourceControl_MouseDown;
                }

                _sourceControl = value;

                if (_sourceControl == null)
                {
                    return;
                }

                _sourceControl.MouseDown += _sourceControl_MouseDown;
            }
        }

        private void _sourceControl_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button != MouseButtons.Left ? 0 : (_sourceControl != null ? 1 : 0)) == 0)
            {
                return;
            }
            ReleaseCapture();
            SendMessage(_sourceControl.FindForm().Handle, 161, 2, 0);
        }

        public FormMoveController()
        {
            InitializeComponent();
        }

        public FormMoveController(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}
