namespace Data
{
    public partial class Form1 : Form
    {
        private Panel panel2;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 548);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 548);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}