// See https://aka.ms/new-console-template for more information


double CalculateVolume(double length, double width, double height)
{
    return length * width * height;
}
double lengthOfBox = 5.0;
double widthOfBox = 3.0;
double heightOfBox = 4.0;

double volume = CalculateVolume(lengthOfBox, widthOfBox, heightOfBox);

Console.WriteLine($"\n\tThe volume of the box is:\n\t {volume}");
