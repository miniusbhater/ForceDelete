namespace ForceDelete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Launch.launch();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Opening file browser");
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "All Files (*.*)|*.*";
            Console.WriteLine("File browser opened");

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
                Console.WriteLine($"File to delete: {textBox1.Text}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Filepath = textBox1.Text;
            Console.WriteLine($"Beggining");
            try
            {              
                File.SetAttributes(Filepath, FileAttributes.Normal);
                Console.WriteLine($"Unlocking");
                File.Delete(Filepath);
                Console.WriteLine($"Deleting");
                Console.WriteLine($"{Filepath} deleted.");                
            }
            catch (Exception exeption)
            {
                Console.WriteLine("Could not delete: " + exeption.Message);
            }
        }
    }
}
