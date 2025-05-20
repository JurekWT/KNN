namespace KNN;

public partial class Form1 : Form
{
    private SampleSet sampleSet = new SampleSet();
    private Classificator classificator = new Classificator();
    private Classificator.Metric metric = Classificator.Metric.Manhattan;
    private int k;
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
            buttonLoadSamples.Enabled = false;
            buttonStart.Enabled = true;
        }
        else
        {
            labelSamplesLoaded.Text = "Nie wybrano pliku";
        }
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
        k = (int)numericUpDown1.Value;
        var results = new List<int>();
        for (int i = 0; i < sampleSet.samples.Count; i++)
        {
            var result = classificator.Classify(sampleSet.samples[i], sampleSet, k, metric);
            results.Add(result == sampleSet.samples[i].classLabel ? 1 : 0);
        }
        double accuracy = (results.Count(x => x == 1) / (double)results.Count) * 100;
        textBoxOutput.Text +=
            $"Metryka: {metric.ToString()}, k-nn: {k}, Poprawnych: {results.Count(x => x == 1)}, Dokładność: {accuracy:F2}%" +
            Environment.NewLine;

    }

    private void radioButtonManhattan_CheckedChanged(object sender, EventArgs e)
    {
        metric = Classificator.Metric.Manhattan;
    }

    private void radioButtonEuclid_CheckedChanged(object sender, EventArgs e)
    {
        metric = Classificator.Metric.Euclidean;
    }

    private void radioButtonCzebyszew_CheckedChanged(object sender, EventArgs e)
    {
        metric = Classificator.Metric.Chebyshev;
    }

    private void radioButtonLog_CheckedChanged(object sender, EventArgs e)
    {
        metric = Classificator.Metric.Logarithmic;
    }
}