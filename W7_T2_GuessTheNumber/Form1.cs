using System.Windows.Forms;

namespace W7_T2_GuessTheNumber
{
    
    public partial class Form1 : Form, IView
    {
        public string Result { set => lblResult.Text = value; }
        public string TryCount { set => lblTryCount.Text = value; }

        public Form1()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(new Model(), this);
            FormLoad();
            btnEnter.Click += delegate { presenter.EnteredClick(tbEnteredNumberField.Text); };
        }

        private void FormLoad()
        {
            MessageBox.Show($"Компьютер загадал число. Отгадайте его!");
            label1.Text = "Введите число";
            lblResult.Text = "";
            lblTryCount.Text = "Количество попыток: 0";
        }
    }
}
