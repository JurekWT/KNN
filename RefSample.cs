namespace KNN;

public class RefSample(double valueA, double valueB, double valueC, double valueD, string classLabel)
{
    public double valueA = valueA;
    public double valueB = valueB;
    public double valueC = valueC;
    public double valueD = valueD;
    public string classLabel = classLabel;

    public void Normalize(double minValA, double maxValA, double minValB, double maxValB, double minValC, double maxValC, double minValD, double maxValD)
    {
        valueA = (valueA - minValA) / (maxValA - minValA);
        valueB = (valueB - minValB) / (maxValB - minValB);
        valueC = (valueC - minValC) / (maxValC - minValC);
        valueD = (valueD - minValD) / (maxValD - minValD);
    }
}