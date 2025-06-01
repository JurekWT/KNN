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

    public enum TypeOfClassification
    {
        KEachClass,
        KTotal,
    }

    public Classificator()
    {
    }

    public string Classify(RefSample sampleToClassify, SampleSet sampleSet, int k, Metric metric, TypeOfClassification typeOfClassification)
    {
        testSample = sampleToClassify;
        var distancesToSample = new List<KeyValuePair<double, string>>();
        

        for (int sampleIndex = 0; sampleIndex < sampleSet.samples.Count; sampleIndex++)
        {
            if (sampleToClassify == sampleSet.samples[sampleIndex]) continue;
            
            var distance = CalculateDistance(sampleSet.samples[sampleIndex], metric);
            distancesToSample.Add(new KeyValuePair<double, string>(distance, sampleSet.samples[sampleIndex].classLabel));
        }

        if (typeOfClassification == TypeOfClassification.KTotal)
        {
            distancesToSample.Sort((x,y) => x.Key.CompareTo(y.Key));
            var groupedSamples = distancesToSample.Take(k).GroupBy(x => x.Value);
            var mostCommonClass = groupedSamples.OrderByDescending(x => x.Count()).ToList();

            if (mostCommonClass.Count > 1 && mostCommonClass[0].Count() == mostCommonClass[1].Count())
            {
                return "Cant classify";
            }
            else
            {
                return mostCommonClass[0].Key;
            }
        }

        if (typeOfClassification == TypeOfClassification.KEachClass)
        {
            string[] classes = ["1","2","3"];
            var sumOfDistanceToSampleByClass = new List<KeyValuePair<double, string>>();
            distancesToSample.Sort((x,y) => x.Key.CompareTo(y.Key));
            foreach (var @class in classes)
            {
                var groupedSamples = distancesToSample.Where(x => x.Value == @class).Take(k).ToList();
                var sum = groupedSamples.Sum(x => x.Key);
                sumOfDistanceToSampleByClass.Add(new KeyValuePair<double, string>(sum, @class));
            }
            sumOfDistanceToSampleByClass.Sort((x,y) => x.Key.CompareTo(y.Key));
            if (sumOfDistanceToSampleByClass[0].Key == sumOfDistanceToSampleByClass[1].Key)
            {
                return "Cant classify";
            }
            else
            {
                return sumOfDistanceToSampleByClass[0].Value;
            }
        }

        return null;
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