using ComplexClass;

Complex complex1 = new Complex(4, 7);
Complex complex2 = new Complex(5, 8);
Complex complex3 = complex1+complex2;
Console.WriteLine(complex3.ToString());
Complex complex4 = complex1 - complex2;
Console.WriteLine(complex4.ToString());
Complex complex5 = complex1 * complex2;
Console.WriteLine(complex5.ToString());
Complex complex6 = complex1 / complex2;
Console.WriteLine(complex6.ToString());
Console.WriteLine(complex1==complex2);
Console.WriteLine(complex1!=complex2);