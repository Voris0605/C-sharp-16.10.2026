using System.Diagnostics.Contracts;

class Calculator
{
    private double FirstNumber {get; set;}

    private double SecondNumber {get; set;}

    public Calculator(double n1, double n2)
    {
        FirstNumber = n1;
        SecondNumber = n2;
    }
    public double Sum()
    {
        return FirstNumber + SecondNumber;
    }
    public double Subtract()
    {
        return FirstNumber - SecondNumber;
    }
    public double Multiply()
    {
        return FirstNumber * SecondNumber;
    }
    public double Division()
    {
        return FirstNumber / SecondNumber;
    }

}