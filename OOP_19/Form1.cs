namespace OOP_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)//�� ��� ��������� �� ������
        {
            try
            {
                char num_1 = char.Parse(txtBoxNum1.Text);//����� ����������� ����
                char num_2 = char.Parse(txtBoxNum2.Text);//����� ����������� ����
                char num_3 = char.Parse(txtBoxNum3.Text);//����� ����������� ����
                string str = num_1.ToString() + num_2.ToString() + num_3.ToString();//����������� � string
                int strNum = int.Parse(str);//����������� � int 
                lbl_1.Text = "����� �������� � ����� ����: " + strNum;
            }
            catch (FormatException)//����������
            {
                lbl_1.Text = "�� ������� �������� �����!";
            }
            
        }
    }
}
