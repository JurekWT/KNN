using System.Net.Http.Metrics;

namespace KNN;

public class Classificator
{
    public RefSample testSample;

    public enum Metric
    {
        Manhattan,
        Euclidean,
        Chebyshev,
        Logarithmic,
    }

    public Classificator()
    {
    }

    public string Classify(RefSample sampleToClassify, SampleSet sampleSet, int k, Metric metric)
    {
        testSample = sampleToClassify;
        Dictionary<double, string> distancesToSample = new Dictionary<double, string>();

        for (int sampleIndex = 0; sampleIndex < sampleSet.samples.Count; sampleIndex++)
        {
            if (sampleToClassify == sampleSet.samples[sampleIndex]) continue;
            
            var distance = CalculateDistance(sampleSet.samples[sampleIndex], metric);
            distancesToSample.Add(distance, sampleSet.samples[sampleIndex].classLabel);
        }
        
        distancesToSample = distancesToSample.OrderBy(x => x.Key).Take(k).ToDictionary(x => x.Key, x => x.Value);
        var groupedClasses = distancesToSample.GroupBy(x => x.Value).OrderByDescending(x => x.Count()).ToList();

        if (groupedClasses.Count > 1 && groupedClasses[0].Count() == groupedClasses[1].Count())
        {
            return "Nie można sklasyfikować";
        }
        else
        {
            return groupedClasses[0].Key;
        }

    }

    public double CalculateDistance(RefSample sample, Metric metric)
    {
        var diffA = sample.valueA - testSample.valueA;
        var diffB = sample.valueB - testSample.valueB;
        var diffC = sample.valueC - testSample.valueC;
        var diffD = sample.valueD - testSample.valueD;
        double result = metric switch
        {
            Metric.Manhattan => Math.Abs(diffA) + Math.Abs(diffB) + Math.Abs(diffC) + Math.Abs(diffD),
            Metric.Euclidean => Math.Sqrt(Math.Pow(diffA, 2) + Math.Pow(diffB, 2) + Math.Pow(diffC, 2) +
                                          Math.Pow(diffD, 2)),
            Metric.Chebyshev => Math.Max(Math.Max(Math.Abs(diffA), Math.Abs(diffB)),
                 Math.Max(Math.Abs(diffC), Math.Abs(diffD))),
            Metric.Logarithmic => Math.Abs(Math.Log(sample.valueA) - Math.Log(testSample.valueA)) +
                                  Math.Abs(Math.Log(sample.valueB) - Math.Log(testSample.valueB)) +
                                  Math.Abs(Math.Log(sample.valueC) - Math.Log(testSample.valueC)) +
                                  Math.Abs(Math.Log(sample.valueD) - Math.Log(testSample.valueD)),
        };
            return result;
    }
}