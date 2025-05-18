namespace KNN;

public partial class Form1 : Form
{
    private SampleSet sampleSet = new SampleSet();
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonLoadSamples_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog1.FileName;
            sampleSet.LoadSamplesFromFile(filePath);
            sampleSet.NormalizeSamples();
            labelSamplesLoaded.Text = $"Wczytano próbki";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
        else
        {
            labelSamplesLoaded.Text = "Nie wybrano pliku";
        }
    }
}