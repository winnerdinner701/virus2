namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            
        }
        private void OnApplicationExit(object? sender, EventArgs e)
        {
            MessageBox.Show("Don't think you can get away that easily!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (MessageBox.Show("Die!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
            {
                if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                {
                    if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                    {
                        if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                        {
                            if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                            {
                                if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                {
                                    if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                    {
                                        if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                        {
                                            if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                            {
                                                if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                                {
                                                    if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                                    {
                                                        if (MessageBox.Show("Fine you beat me...", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                                                        {
                                                            Application.Restart();
                                                            MessageBox.Show("Good bye!", "Virus");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Good","Virus",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
            {
                if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                {
                    if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                    {
                        if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                        {
                            if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                            {
                                if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                {
                                    if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                    {
                                        if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                        {
                                            if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                            {
                                                if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                                {
                                                    if (MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                                                    {
                                                        if (MessageBox.Show("Fine you beat me...", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
                                                        {
                                                            MessageBox.Show("Good bye!","Virus");
                                                            timer1.Enabled = true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("You are being hacked!", "Virus", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}