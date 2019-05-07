using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop4 {
    public partial class AgentButton : UserControl {
        public AgentButton() {
            InitializeComponent();
        }

        // Bind child controls inside the user control to respond to Click event
        public new event EventHandler Click {
            add {
                base.Click += value;
                foreach (Control control in Controls) {
                    control.Click += value;
                }
            }
            remove {
                base.Click -= value;
                foreach (Control control in Controls) {
                    control.Click -= value;
                }
            }
        }

        public new event EventHandler MouseEnter {
            add {
                base.MouseEnter += value;
                foreach (Control control in Controls) {
                    control.MouseEnter += value;
                }
            }
            remove {
                base.MouseEnter -= value;
                foreach (Control control in Controls) {
                    control.MouseEnter -= value;
                }
            }
        }

        public new event EventHandler MouseLeave {
            add {
                base.MouseLeave += value;
                foreach (Control control in Controls) {
                    control.MouseLeave += value;
                }
            }
            remove {
                base.MouseLeave -= value;
                foreach (Control control in Controls) {
                    control.MouseLeave -= value;
                }
            }
        }
    }
}
