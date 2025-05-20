using System.Globalization;

namespace KNN;

public class SampleSet
{
    public List<RefSample> samples;
    private double maxValA;
    private double minValA;
    private double maxValB;
    private double minValB;
    private double maxValC;
    private double minValC;
    private double maxValD;
    private double minValD;

    public SampleSet()
    {
        this.samples = new List<RefSample>();
    }

    public void AddSample(double valueA, double valueB, double valueC, double valueD, string classLabel)
    {
        this.samples.Add(new RefSample(valueA, valueB, valueC, valueD, classLabel));
    }

    private (double[] valuesA, double[] valuesB, double[] valuesC, double[] valuesD, string[] classLabel) LoadFile(string filename) { 
        string[] lines = File.ReadAllLines(filename);
        double[] valuesA = new double[lines.Length];
        double[] valuesB = new double[lines.Length];
        double[] valuesC = new double[lines.Length];
        double[] valuesD = new double[lines.Length];
        string[] classLabels = new string[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            string[] values = lines[i].Trim().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            valuesA[i] = double.Parse(values[0], NumberStyles.Float, CultureInfo.InvariantCulture);
            valuesB[i] = double.Parse(values[1], NumberStyles.Float, CultureInfo.InvariantCulture);
            valuesC[i] = double.Parse(values[2], NumberStyles.Float, CultureInfo.InvariantCulture);
            valuesD[i] = double.Parse(values[3], NumberStyles.Float, CultureInfo.InvariantCulture);
            classLabels[i] = values[4];
        }
        return (valuesA, valuesB, valuesC, valuesD, classLabels);
    }

    public void LoadSamplesFromFile(string filename)
    {
        (double[] valuesA, double[] valuesB, double[] valuesC, double[] valuesD, string[] classLabel) = LoadFile(filename);
        minValA = valuesA.Min();
        maxValA = valuesA.Max();
        minValB = valuesB.Min();
        maxValB = valuesB.Max();
        minValC = valuesC.Min();
        maxValC = valuesC.Max();
        minValD = valuesD.Min();
        maxValD = valuesD.Max();
        for (int i = 0; i < valuesA.Length; i++)
        {
            AddSample(valuesA[i], valuesB[i], valuesC[i], valuesD[i], classLabel[i]);
        }
    }

    public void NormalizeSamples()
    {
        
        foreach (var sample in samples)
        {
            sample.Normalize(minValA, maxValA, minValB, maxValB, minValC, maxValC, minValD, maxValD);
        }
    }

}