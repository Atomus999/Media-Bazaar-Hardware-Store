using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_App
{
    public class CustomTextbox : UserControl
    {
        TextBox textBox;

        public CustomTextbox()
        {
            textBox = new TextBox()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(-1, -1),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right
            };
            Control container = new ContainerControl()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(-1)
            };
            container.Controls.Add(textBox);
            this.Controls.Add(container);

            DefaultBorderColor = SystemColors.ControlDark;
            FocusedBorderColor = Color.Red;
            BackColor = DefaultBorderColor;
            Padding = new Padding(3);
            Size = textBox.Size;
        }

        public Color DefaultBorderColor { get; set; }
        public Color FocusedBorderColor { get; set; }

        public override string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public void Clear()
        {
            textBox.Text = "";
        }

        public bool ReadOnly { 
            get 
            {
                return textBox.ReadOnly; 
            }
            set 
            {
                TextColor = Color.DarkGray;
                textBox.ReadOnly = value; 
            }
        }

        public Char PasswordChar
        {
            get
            {
                return textBox.PasswordChar;
            }
            set
            {
                textBox.PasswordChar = value;
            }
        }

        public Color TextColor
        {
            get
            {
                return textBox.ForeColor;
            }
            set
            {
                textBox.ForeColor = value;
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            BackColor = FocusedBorderColor;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            BackColor = DefaultBorderColor;
            base.OnLeave(e);
        }

        protected override void SetBoundsCore(int x, int y,
            int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, textBox.PreferredHeight, specified);
        }
    }
}
