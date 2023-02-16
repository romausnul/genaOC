namespace WinFormsApp2

{
 
  public partial class Form1 : Form
  {
    private readonly object his;

    public Form1()
    {
      {
        InitializeComponent();
        timer1.Interval = 10000;
        timer1.Start();
      }

      

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Form2 newfrm = new Form2();
      newfrm.Show();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      {
        Form2 frm = new Form2();
        frm.Show();
        timer1.Stop();
      }
    }

    private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void timer1_Tick_1(object sender, EventArgs e)
    {
      Form2 frm = new Form2();
      frm.Show();
      timer1.Stop();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
