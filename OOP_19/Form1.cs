namespace OOP_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)//дія при натисканні на кнопку
        {
            try
            {
                char num_1 = char.Parse(txtBoxNum1.Text);//змінна символьного типу
                char num_2 = char.Parse(txtBoxNum2.Text);//змінна символьного типу
                char num_3 = char.Parse(txtBoxNum3.Text);//змінна символьного типу
                string str = num_1.ToString() + num_2.ToString() + num_3.ToString();//конвертація в string
                int strNum = int.Parse(str);//конвертація в int 
                lbl_1.Text = "Число утворене з трьох цифр: " + strNum;
            }
            catch (FormatException)//виключення
            {
                lbl_1.Text = "Не вдається створити число!";
            }
            
        }
    }
}
