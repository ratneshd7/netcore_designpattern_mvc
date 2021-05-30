using System.Drawing;
using System.Windows.Forms;
using System;
namespace ConsoleWinFormApp
{
    class WelcomeForm: Form
    {
        public WelcomeForm()
        {
            this.Text = "Ratnesh";
            this.Width = 400;
            this.Height = 400;
            this.BackColor = Color.Azure;

            Label label = new Label();
            label.Text = "Welcome To windows Form";
            this.Controls.Add(label);

            Button button = new Button();
            button.Text = "Hello";
            button.Location = new Point(200, 200);
            button.Click += Button_Click;
            button.Click += (sender, eventargs) => Console.WriteLine("Button clicked");
            this.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine(e);
        }
    }
}
