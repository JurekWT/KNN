namespace KNN;

public partial class Form1 : Form
{
    private SampleSet sampleSet = new SampleSet();
    private Classificator classificator = new Classificator();
    private Classificator.Metric metric = Classificator.Metric.Manhattan;
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

    private void buttonStart_Click(object sender, EventArgs e)
    {
        classificator.Classify(sampleSet.samples[0], sampleSet, 3, metric);
    }
}