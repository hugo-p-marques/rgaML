using System.Diagnostics;

namespace rgaML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;

                pictureBox1.ImageLocation = openFileDialog1.FileName;

                //Load sample data
                var imageBytes = File.ReadAllBytes(openFileDialog1.FileName);
                RgaML.MLModel1.ModelInput sampleData = new RgaML.MLModel1.ModelInput()
                {
                    ImageSource = imageBytes,
                };

                //Load model and predict output
                var result = RgaML.MLModel1.Predict(sampleData);
                Debug.WriteLine($"\n\nPredicted Label value: {result.PredictedLabel} \nPredicted Label scores: [{String.Join(",", result.Score)}]\n\n");
                label2.Text = result.PredictedLabel;
                label3.Text = String.Join(",", result.Score);
                progressBar1.Value = (int)(result.Score[0] * 100);
                progressBar2.Value = (int)(result.Score[1] * 100);
                progressBar3.Value = (int)(result.Score[2] * 100);

            }
        }
    }
}