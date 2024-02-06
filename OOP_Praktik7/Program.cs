using Vector = OOP_Praktik7.Vector;

Vector vector1 = new Vector(1, 2, 3);
Vector vector2 = new Vector(4, 5, 6);
vector1.Print();
vector2.Print();
Vector sum = vector1.Add(vector2);
sum.Print();
Vector difference = vector1.Subtract(vector2);
difference.Print();
Console.WriteLine("Length of vector1: " + vector1.Length);
Console.WriteLine("Length of sum: " + sum.Length);
Console.WriteLine("Length of difference: " + difference.Length);
